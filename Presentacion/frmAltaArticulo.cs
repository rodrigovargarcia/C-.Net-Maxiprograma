using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using negocio;
using System.IO;
using System.Configuration;

namespace Presentacion
{
    public partial class frmAltaArticulo : Form
    {
        private Articulos articulo = null;
        private OpenFileDialog archivo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }
        public frmAltaArticulo(Articulos articulo)
        {
            InitializeComponent();     
            this.articulo = articulo;
            Text = "Modificar artículo";
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {            
            ArticulosNegocio negocio = new ArticulosNegocio();  
            try
            {
                if(articulo == null)
                    articulo = new Articulos();
                
                if (!(validarArticulo()))
                {
                    MessageBox.Show("Por favor rellene los campos requeridos");                    
                    return;
                }
                if ((!soloNumeros(txtbxPrecio.Text.ToString())))
                {
                    MessageBox.Show("Solo numeros en el campo de precio por favor");
                    return;
                }
                articulo.Codigo = txtbxCodigo.Text;
                articulo.Nombre = txtbxNombre.Text;
                articulo.Descripcion = txtbxDescripcion.Text;                
                articulo.Precio = decimal.Parse(txtbxPrecio.Text);
                articulo.ImagenUrl = txtbxImagenUrl.Text;
                articulo.Marca = (Marcas)cbobxMarca.SelectedItem;
                articulo.Categorias = (Categoria)cbobxCategoria.SelectedItem;
                
                if(articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado Exitosamente!");
                }
                else
                {                                                            
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado Exitosamente!");                    
                }
                if (archivo != null && !(txtbxImagenUrl.Text.ToUpper().Contains("HTTP")))
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private bool validarArticulo()
        {               
            if(txtbxCodigo.Text == "")
            {
                lblCodigoIncorrecto.Visible = true;
                return false;
            }
            if (txtbxNombre.Text == "")
            {
                lblNombreIncorrecto.Visible = true;
                return false;
            }
            if (txtbxDescripcion.Text == "")
            {
                lblDescripcionIncorrecto.Visible = true;
                return false;
            }
            if (txtbxPrecio.Text.ToString() == "")
            {
                lblPrecioIncorrecto.Visible = true;
                return false;
            }
            else
            {
                return true;
            }
        }
        
        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if(!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }
        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcasNegocio marcaNegocio = new MarcasNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cbobxMarca.DataSource = marcaNegocio.listar();
                cbobxMarca.ValueMember = "Id";
                cbobxMarca.DisplayMember = "Descripcion";
                cbobxCategoria.DataSource = categoriaNegocio.listar();
                cbobxCategoria.ValueMember = "Id";
                cbobxCategoria.DisplayMember = "Descripcion";

                if(articulo != null)
                {
                    txtbxCodigo.Text = articulo.Codigo;
                    txtbxNombre.Text = articulo.Nombre;
                    txtbxDescripcion.Text = articulo.Descripcion;
                    txtbxPrecio.Text = articulo.Precio.ToString();                    
                    txtbxImagenUrl.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
                    cbobxMarca.SelectedValue = articulo.Marca.Id;
                    cbobxCategoria.SelectedValue = articulo.Categorias.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtbxImagenUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtbxImagenUrl.Text);       
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

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                txtbxImagenUrl.Text = archivo.FileName;
                cargarImagen(archivo.FileName);                
            }            
        }
    }
}
