using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using negocio;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        private List<Articulos> listaArticulos;
        public Form1()
        {
            InitializeComponent();
        }        

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
            cbobxCampo.Items.Add("Precio");
            cbobxCampo.Items.Add("Nombre");
            cbobxCampo.Items.Add("Descripcion");            
        }
        private void cargar()
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            listaArticulos = negocio.listar();
            dgvArticulos.DataSource = listaArticulos;
            ocultarColumnas();
            cargarImagen(listaArticulos[0].ImagenUrl);
        }
        private void ocultarColumnas()
        {
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
        }
        private void dgvArticulosNegocio_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulos seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
        }

        private void cargarImagen(string imagen)
        {            
            try
            {
                pbxArticulos.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulos.Load("https://upload.wikimedia.org/wikipedia/commons/1/14/No_Image_Available.jpg?20200913095930");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulos seleccionado;
            seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;

            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            Articulos seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar el artículo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes) 
                { 
                    seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.ToString());
            }
        }
        private bool validarBusqueda()
        {
            if(cbobxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true;
            }
            if(cbobxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                return true;
            }
            if(cbobxCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtbxFiltroAvanzado.Text))
                {
                    MessageBox.Show("Debe cargar el filtro para numéricos.");
                    return true;
                }
                if (!(soloNumeros(txtbxFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Solo numeros por favor");
                    return true;
                }
            }
            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach(char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                if (validarBusqueda())
                    return;
                string campo = cbobxCampo.SelectedItem.ToString();
                string criterio = cbobxCriterio.SelectedItem.ToString();
                string filtro = txtbxFiltroAvanzado.Text;

                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtbxBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulos> listaFiltrada;
            string filtro = txtbxBuscar.Text;

            if(filtro.Length >= 2)
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Codigo.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cbobxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbobxCampo.SelectedItem.ToString();
            if(opcion == "Precio")
            {
                cbobxCriterio.Items.Clear();
                cbobxCriterio.Items.Add("Mayor a");
                cbobxCriterio.Items.Add("Menor a");
                cbobxCriterio.Items.Add("Igual a");
            }
            else if(opcion == "Nombre")
            {
                cbobxCriterio.Items.Clear();
                cbobxCriterio.Items.Add("Comienza con");
                cbobxCriterio.Items.Add("Termina con");
                cbobxCriterio.Items.Add("Contiene");
            }
            else if(opcion == "Descripcion")
            {
                cbobxCriterio.Items.Clear();
                cbobxCriterio.Items.Add("Comienza con");
                cbobxCriterio.Items.Add("Termina con");
                cbobxCriterio.Items.Add("Contiene");
            }
            //else
            //{
            //    cbobxCriterio.Items.Clear();
            //    cbobxCriterio.Items.Add("Televisores");
            //    cbobxCriterio.Items.Add("Celulares");
            //    cbobxCriterio.Items.Add("Media");
            //    cbobxCriterio.Items.Add("Sonido");
            //}
        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            Articulos seleccionado;
            seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;

            frmVerDetalles verDetalles = new frmVerDetalles(seleccionado);
            verDetalles.ShowDialog();
            cargar();
        }
    }
}
