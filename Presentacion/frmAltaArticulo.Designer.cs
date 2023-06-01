namespace Presentacion
{
    partial class frmAltaArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtbxCodigo = new System.Windows.Forms.TextBox();
            this.txtbxDescripcion = new System.Windows.Forms.TextBox();
            this.txtbxNombre = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtbxPrecio = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbobxMarca = new System.Windows.Forms.ComboBox();
            this.cbobxCategoria = new System.Windows.Forms.ComboBox();
            this.pbxArticulos = new System.Windows.Forms.PictureBox();
            this.txtbxImagenUrl = new System.Windows.Forms.TextBox();
            this.lblImagenUrl = new System.Windows.Forms.Label();
            this.btnAgregarImagen = new FontAwesome.Sharp.IconButton();
            this.lblCodigoIncorrecto = new System.Windows.Forms.Label();
            this.lblPrecioIncorrecto = new System.Windows.Forms.Label();
            this.lblDescripcionIncorrecto = new System.Windows.Forms.Label();
            this.lblNombreIncorrecto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(82, 15);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(78, 49);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(59, 85);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // txtbxCodigo
            // 
            this.txtbxCodigo.Location = new System.Drawing.Point(131, 12);
            this.txtbxCodigo.Name = "txtbxCodigo";
            this.txtbxCodigo.Size = new System.Drawing.Size(121, 20);
            this.txtbxCodigo.TabIndex = 0;
            // 
            // txtbxDescripcion
            // 
            this.txtbxDescripcion.Location = new System.Drawing.Point(131, 82);
            this.txtbxDescripcion.Name = "txtbxDescripcion";
            this.txtbxDescripcion.Size = new System.Drawing.Size(121, 20);
            this.txtbxDescripcion.TabIndex = 2;
            // 
            // txtbxNombre
            // 
            this.txtbxNombre.Location = new System.Drawing.Point(131, 46);
            this.txtbxNombre.Name = "txtbxNombre";
            this.txtbxNombre.Size = new System.Drawing.Size(121, 20);
            this.txtbxNombre.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(62, 277);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(189, 277);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(85, 122);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtbxPrecio
            // 
            this.txtbxPrecio.Location = new System.Drawing.Point(131, 119);
            this.txtbxPrecio.Name = "txtbxPrecio";
            this.txtbxPrecio.Size = new System.Drawing.Size(121, 20);
            this.txtbxPrecio.TabIndex = 3;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(85, 197);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 10;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(68, 228);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(57, 13);
            this.lblCategoria.TabIndex = 11;
            this.lblCategoria.Text = "Categoría:";
            // 
            // cbobxMarca
            // 
            this.cbobxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobxMarca.FormattingEnabled = true;
            this.cbobxMarca.Location = new System.Drawing.Point(131, 189);
            this.cbobxMarca.Name = "cbobxMarca";
            this.cbobxMarca.Size = new System.Drawing.Size(121, 21);
            this.cbobxMarca.TabIndex = 5;
            // 
            // cbobxCategoria
            // 
            this.cbobxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobxCategoria.FormattingEnabled = true;
            this.cbobxCategoria.Location = new System.Drawing.Point(131, 225);
            this.cbobxCategoria.Name = "cbobxCategoria";
            this.cbobxCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbobxCategoria.TabIndex = 6;
            // 
            // pbxArticulos
            // 
            this.pbxArticulos.Location = new System.Drawing.Point(304, 29);
            this.pbxArticulos.Name = "pbxArticulos";
            this.pbxArticulos.Size = new System.Drawing.Size(242, 197);
            this.pbxArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulos.TabIndex = 14;
            this.pbxArticulos.TabStop = false;
            // 
            // txtbxImagenUrl
            // 
            this.txtbxImagenUrl.Location = new System.Drawing.Point(131, 154);
            this.txtbxImagenUrl.Name = "txtbxImagenUrl";
            this.txtbxImagenUrl.Size = new System.Drawing.Size(121, 20);
            this.txtbxImagenUrl.TabIndex = 4;
            this.txtbxImagenUrl.Leave += new System.EventHandler(this.txtbxImagenUrl_Leave);
            // 
            // lblImagenUrl
            // 
            this.lblImagenUrl.AutoSize = true;
            this.lblImagenUrl.Location = new System.Drawing.Point(55, 157);
            this.lblImagenUrl.Name = "lblImagenUrl";
            this.lblImagenUrl.Size = new System.Drawing.Size(70, 13);
            this.lblImagenUrl.TabIndex = 15;
            this.lblImagenUrl.Text = "URL Imagen:";
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btnAgregarImagen.IconColor = System.Drawing.Color.Black;
            this.btnAgregarImagen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarImagen.IconSize = 18;
            this.btnAgregarImagen.Location = new System.Drawing.Point(258, 154);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(29, 22);
            this.btnAgregarImagen.TabIndex = 17;
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // lblCodigoIncorrecto
            // 
            this.lblCodigoIncorrecto.AutoSize = true;
            this.lblCodigoIncorrecto.ForeColor = System.Drawing.Color.Red;
            this.lblCodigoIncorrecto.Location = new System.Drawing.Point(259, 19);
            this.lblCodigoIncorrecto.Name = "lblCodigoIncorrecto";
            this.lblCodigoIncorrecto.Size = new System.Drawing.Size(11, 13);
            this.lblCodigoIncorrecto.TabIndex = 18;
            this.lblCodigoIncorrecto.Text = "*";
            this.lblCodigoIncorrecto.Visible = false;
            // 
            // lblPrecioIncorrecto
            // 
            this.lblPrecioIncorrecto.AutoSize = true;
            this.lblPrecioIncorrecto.ForeColor = System.Drawing.Color.Red;
            this.lblPrecioIncorrecto.Location = new System.Drawing.Point(259, 126);
            this.lblPrecioIncorrecto.Name = "lblPrecioIncorrecto";
            this.lblPrecioIncorrecto.Size = new System.Drawing.Size(11, 13);
            this.lblPrecioIncorrecto.TabIndex = 19;
            this.lblPrecioIncorrecto.Text = "*";
            this.lblPrecioIncorrecto.Visible = false;
            // 
            // lblDescripcionIncorrecto
            // 
            this.lblDescripcionIncorrecto.AutoSize = true;
            this.lblDescripcionIncorrecto.ForeColor = System.Drawing.Color.Red;
            this.lblDescripcionIncorrecto.Location = new System.Drawing.Point(259, 89);
            this.lblDescripcionIncorrecto.Name = "lblDescripcionIncorrecto";
            this.lblDescripcionIncorrecto.Size = new System.Drawing.Size(11, 13);
            this.lblDescripcionIncorrecto.TabIndex = 20;
            this.lblDescripcionIncorrecto.Text = "*";
            this.lblDescripcionIncorrecto.Visible = false;
            // 
            // lblNombreIncorrecto
            // 
            this.lblNombreIncorrecto.AutoSize = true;
            this.lblNombreIncorrecto.ForeColor = System.Drawing.Color.Red;
            this.lblNombreIncorrecto.Location = new System.Drawing.Point(259, 53);
            this.lblNombreIncorrecto.Name = "lblNombreIncorrecto";
            this.lblNombreIncorrecto.Size = new System.Drawing.Size(11, 13);
            this.lblNombreIncorrecto.TabIndex = 21;
            this.lblNombreIncorrecto.Text = "*";
            this.lblNombreIncorrecto.Visible = false;
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 319);
            this.Controls.Add(this.lblNombreIncorrecto);
            this.Controls.Add(this.lblDescripcionIncorrecto);
            this.Controls.Add(this.lblPrecioIncorrecto);
            this.Controls.Add(this.lblCodigoIncorrecto);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.txtbxImagenUrl);
            this.Controls.Add(this.lblImagenUrl);
            this.Controls.Add(this.pbxArticulos);
            this.Controls.Add(this.cbobxCategoria);
            this.Controls.Add(this.cbobxMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtbxPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtbxNombre);
            this.Controls.Add(this.txtbxDescripcion);
            this.Controls.Add(this.txtbxCodigo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Articulo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtbxCodigo;
        private System.Windows.Forms.TextBox txtbxDescripcion;
        private System.Windows.Forms.TextBox txtbxNombre;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtbxPrecio;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbobxMarca;
        private System.Windows.Forms.ComboBox cbobxCategoria;
        private System.Windows.Forms.PictureBox pbxArticulos;
        private System.Windows.Forms.TextBox txtbxImagenUrl;
        private System.Windows.Forms.Label lblImagenUrl;
        private FontAwesome.Sharp.IconButton btnAgregarImagen;
        private System.Windows.Forms.Label lblCodigoIncorrecto;
        private System.Windows.Forms.Label lblPrecioIncorrecto;
        private System.Windows.Forms.Label lblDescripcionIncorrecto;
        private System.Windows.Forms.Label lblNombreIncorrecto;
    }
}