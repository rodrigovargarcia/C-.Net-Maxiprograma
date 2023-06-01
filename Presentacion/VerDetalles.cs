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
    public partial class frmVerDetalles : Form
    {
        public frmVerDetalles()
        {
            InitializeComponent();
        }
        public frmVerDetalles(Articulos verDetalles)
        {
            InitializeComponent();
            this.verDetalles = verDetalles;
            Text = "Ver Detalles";
        }
        private Articulos verDetalles = null;

        private void frmVerDetalles_Load(object sender, EventArgs e)
        {
            
            if (verDetalles != null)
            {
                txtbxCodigo.Text = verDetalles.Codigo;
                txtbxNombre.Text = verDetalles.Nombre;
                txtbxDescripcion.Multiline = true;
                txtbxDescripcion.Height = 50;
                txtbxDescripcion.Text = verDetalles.Descripcion;
                txtbxPrecio.Text = verDetalles.Precio.ToString();                
                txtbxMarca.Text = verDetalles.Marca.ToString();
                txtbxCategoria.Text = verDetalles.Categorias.ToString();
                cargarImagen(verDetalles.ImagenUrl.ToString());                
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxVerDetalles.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxVerDetalles.Load("https://upload.wikimedia.org/wikipedia/commons/1/14/No_Image_Available.jpg?20200913095930");
            }
        }
    }
}
