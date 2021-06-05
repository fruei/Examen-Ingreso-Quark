
namespace CotizadorExpress_Examen_Ingreso_Quark
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbAppNombre = new System.Windows.Forms.Label();
            this.lbTiendaNombre = new System.Windows.Forms.Label();
            this.lbTiendaDireccion = new System.Windows.Forms.Label();
            this.lbUsuarioNyA = new System.Windows.Forms.Label();
            this.lbUsuarioID = new System.Windows.Forms.Label();
            this.btnVerHistorialCotizaciones = new System.Windows.Forms.Button();
            this.lbPrendas = new System.Windows.Forms.Label();
            this.lstPrendasNombres = new System.Windows.Forms.ListBox();
            this.lbTipos = new System.Windows.Forms.Label();
            this.lstPrendasTipos = new System.Windows.Forms.ListBox();
            this.lbPrendaStock = new System.Windows.Forms.Label();
            this.txtPrendaStock = new System.Windows.Forms.TextBox();
            this.lbPrendaCalidad = new System.Windows.Forms.Label();
            this.rbPrenda_Calidad_Standard = new System.Windows.Forms.RadioButton();
            this.rb_Prenda_Calidad_Premium = new System.Windows.Forms.RadioButton();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.txtPrendaCantidad = new System.Windows.Forms.TextBox();
            this.lbPrendaPrecioUnidad = new System.Windows.Forms.Label();
            this.txtPrendaPrecioUnidad = new System.Windows.Forms.TextBox();
            this.btnCotizarPrenda = new System.Windows.Forms.Button();
            this.txtPrendaCotizacion = new System.Windows.Forms.TextBox();
            this.btnActualizarPrendas = new System.Windows.Forms.Button();
            this.btnVenderPrenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAppNombre
            // 
            this.lbAppNombre.AutoSize = true;
            this.lbAppNombre.BackColor = System.Drawing.Color.SkyBlue;
            this.lbAppNombre.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAppNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAppNombre.Location = new System.Drawing.Point(13, 13);
            this.lbAppNombre.Name = "lbAppNombre";
            this.lbAppNombre.Size = new System.Drawing.Size(166, 25);
            this.lbAppNombre.TabIndex = 0;
            this.lbAppNombre.Text = "CotizadorExpress";
            // 
            // lbTiendaNombre
            // 
            this.lbTiendaNombre.AutoSize = true;
            this.lbTiendaNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTiendaNombre.Location = new System.Drawing.Point(13, 46);
            this.lbTiendaNombre.Name = "lbTiendaNombre";
            this.lbTiendaNombre.Size = new System.Drawing.Size(155, 21);
            this.lbTiendaNombre.TabIndex = 1;
            this.lbTiendaNombre.Text = "Nombre de la Tienda";
            // 
            // lbTiendaDireccion
            // 
            this.lbTiendaDireccion.AutoSize = true;
            this.lbTiendaDireccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTiendaDireccion.Location = new System.Drawing.Point(400, 46);
            this.lbTiendaDireccion.Name = "lbTiendaDireccion";
            this.lbTiendaDireccion.Size = new System.Drawing.Size(162, 21);
            this.lbTiendaDireccion.TabIndex = 2;
            this.lbTiendaDireccion.Text = "Direccion de la Tienda";
            // 
            // lbUsuarioNyA
            // 
            this.lbUsuarioNyA.AutoSize = true;
            this.lbUsuarioNyA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUsuarioNyA.Location = new System.Drawing.Point(13, 90);
            this.lbUsuarioNyA.Name = "lbUsuarioNyA";
            this.lbUsuarioNyA.Size = new System.Drawing.Size(212, 21);
            this.lbUsuarioNyA.TabIndex = 3;
            this.lbUsuarioNyA.Text = "Nombre y Apellido Vendedor";
            // 
            // lbUsuarioID
            // 
            this.lbUsuarioID.AutoSize = true;
            this.lbUsuarioID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUsuarioID.Location = new System.Drawing.Point(400, 90);
            this.lbUsuarioID.Name = "lbUsuarioID";
            this.lbUsuarioID.Size = new System.Drawing.Size(156, 21);
            this.lbUsuarioID.TabIndex = 4;
            this.lbUsuarioID.Text = "Codigo del Vendedor";
            // 
            // btnVerHistorialCotizaciones
            // 
            this.btnVerHistorialCotizaciones.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVerHistorialCotizaciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerHistorialCotizaciones.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVerHistorialCotizaciones.Location = new System.Drawing.Point(400, 124);
            this.btnVerHistorialCotizaciones.Name = "btnVerHistorialCotizaciones";
            this.btnVerHistorialCotizaciones.Size = new System.Drawing.Size(178, 37);
            this.btnVerHistorialCotizaciones.TabIndex = 5;
            this.btnVerHistorialCotizaciones.Text = "Historial Cotizaciones";
            this.btnVerHistorialCotizaciones.UseVisualStyleBackColor = false;
            this.btnVerHistorialCotizaciones.Click += new System.EventHandler(this.btnVerHistorialCotizaciones_Click);
            // 
            // lbPrendas
            // 
            this.lbPrendas.AutoSize = true;
            this.lbPrendas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPrendas.Location = new System.Drawing.Point(13, 140);
            this.lbPrendas.Name = "lbPrendas";
            this.lbPrendas.Size = new System.Drawing.Size(66, 21);
            this.lbPrendas.TabIndex = 6;
            this.lbPrendas.Text = "Prendas";
            // 
            // lstPrendasNombres
            // 
            this.lstPrendasNombres.FormattingEnabled = true;
            this.lstPrendasNombres.ItemHeight = 15;
            this.lstPrendasNombres.Location = new System.Drawing.Point(13, 176);
            this.lstPrendasNombres.Name = "lstPrendasNombres";
            this.lstPrendasNombres.Size = new System.Drawing.Size(120, 214);
            this.lstPrendasNombres.TabIndex = 7;
            this.lstPrendasNombres.SelectedValueChanged += new System.EventHandler(this.PrendasNombreSelectedValueChanged);
            // 
            // lbTipos
            // 
            this.lbTipos.AutoSize = true;
            this.lbTipos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTipos.Location = new System.Drawing.Point(209, 140);
            this.lbTipos.Name = "lbTipos";
            this.lbTipos.Size = new System.Drawing.Size(47, 21);
            this.lbTipos.TabIndex = 8;
            this.lbTipos.Text = "Tipos";
            // 
            // lstPrendasTipos
            // 
            this.lstPrendasTipos.FormattingEnabled = true;
            this.lstPrendasTipos.ItemHeight = 15;
            this.lstPrendasTipos.Location = new System.Drawing.Point(209, 176);
            this.lstPrendasTipos.Name = "lstPrendasTipos";
            this.lstPrendasTipos.Size = new System.Drawing.Size(120, 214);
            this.lstPrendasTipos.TabIndex = 9;
            this.lstPrendasTipos.SelectedValueChanged += new System.EventHandler(this.PrendasTiposSelectedValueChanged);
            // 
            // lbPrendaStock
            // 
            this.lbPrendaStock.AutoSize = true;
            this.lbPrendaStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPrendaStock.Location = new System.Drawing.Point(401, 192);
            this.lbPrendaStock.Name = "lbPrendaStock";
            this.lbPrendaStock.Size = new System.Drawing.Size(47, 21);
            this.lbPrendaStock.TabIndex = 10;
            this.lbPrendaStock.Text = "Stock";
            // 
            // txtPrendaStock
            // 
            this.txtPrendaStock.BackColor = System.Drawing.Color.White;
            this.txtPrendaStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrendaStock.Location = new System.Drawing.Point(551, 189);
            this.txtPrendaStock.Name = "txtPrendaStock";
            this.txtPrendaStock.ReadOnly = true;
            this.txtPrendaStock.Size = new System.Drawing.Size(100, 29);
            this.txtPrendaStock.TabIndex = 11;
            this.txtPrendaStock.Text = "0";
            // 
            // lbPrendaCalidad
            // 
            this.lbPrendaCalidad.AutoSize = true;
            this.lbPrendaCalidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPrendaCalidad.Location = new System.Drawing.Point(401, 250);
            this.lbPrendaCalidad.Name = "lbPrendaCalidad";
            this.lbPrendaCalidad.Size = new System.Drawing.Size(62, 21);
            this.lbPrendaCalidad.TabIndex = 12;
            this.lbPrendaCalidad.Text = "Calidad";
            // 
            // rbPrenda_Calidad_Standard
            // 
            this.rbPrenda_Calidad_Standard.AutoSize = true;
            this.rbPrenda_Calidad_Standard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbPrenda_Calidad_Standard.Location = new System.Drawing.Point(551, 248);
            this.rbPrenda_Calidad_Standard.Name = "rbPrenda_Calidad_Standard";
            this.rbPrenda_Calidad_Standard.Size = new System.Drawing.Size(90, 25);
            this.rbPrenda_Calidad_Standard.TabIndex = 13;
            this.rbPrenda_Calidad_Standard.Text = "Standard";
            this.rbPrenda_Calidad_Standard.UseVisualStyleBackColor = true;
            this.rbPrenda_Calidad_Standard.CheckedChanged += new System.EventHandler(this.PrendaCalidadStandardChanged);
            // 
            // rb_Prenda_Calidad_Premium
            // 
            this.rb_Prenda_Calidad_Premium.AutoSize = true;
            this.rb_Prenda_Calidad_Premium.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_Prenda_Calidad_Premium.Location = new System.Drawing.Point(656, 248);
            this.rb_Prenda_Calidad_Premium.Name = "rb_Prenda_Calidad_Premium";
            this.rb_Prenda_Calidad_Premium.Size = new System.Drawing.Size(92, 25);
            this.rb_Prenda_Calidad_Premium.TabIndex = 14;
            this.rb_Prenda_Calidad_Premium.Text = "Premium";
            this.rb_Prenda_Calidad_Premium.UseVisualStyleBackColor = true;
            this.rb_Prenda_Calidad_Premium.CheckedChanged += new System.EventHandler(this.PrendaCalidadStandardChanged);
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCantidad.Location = new System.Drawing.Point(401, 301);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(72, 21);
            this.lbCantidad.TabIndex = 15;
            this.lbCantidad.Text = "Cantidad";
            // 
            // txtPrendaCantidad
            // 
            this.txtPrendaCantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrendaCantidad.Location = new System.Drawing.Point(551, 298);
            this.txtPrendaCantidad.Name = "txtPrendaCantidad";
            this.txtPrendaCantidad.Size = new System.Drawing.Size(100, 29);
            this.txtPrendaCantidad.TabIndex = 16;
            this.txtPrendaCantidad.Text = "1";
            // 
            // lbPrendaPrecioUnidad
            // 
            this.lbPrendaPrecioUnidad.AutoSize = true;
            this.lbPrendaPrecioUnidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPrendaPrecioUnidad.Location = new System.Drawing.Point(401, 355);
            this.lbPrendaPrecioUnidad.Name = "lbPrendaPrecioUnidad";
            this.lbPrendaPrecioUnidad.Size = new System.Drawing.Size(117, 21);
            this.lbPrendaPrecioUnidad.TabIndex = 17;
            this.lbPrendaPrecioUnidad.Text = "Precio / Unidad";
            // 
            // txtPrendaPrecioUnidad
            // 
            this.txtPrendaPrecioUnidad.BackColor = System.Drawing.Color.White;
            this.txtPrendaPrecioUnidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrendaPrecioUnidad.Location = new System.Drawing.Point(551, 353);
            this.txtPrendaPrecioUnidad.Name = "txtPrendaPrecioUnidad";
            this.txtPrendaPrecioUnidad.ReadOnly = true;
            this.txtPrendaPrecioUnidad.Size = new System.Drawing.Size(100, 29);
            this.txtPrendaPrecioUnidad.TabIndex = 18;
            this.txtPrendaPrecioUnidad.Text = "0";
            // 
            // btnCotizarPrenda
            // 
            this.btnCotizarPrenda.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCotizarPrenda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCotizarPrenda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCotizarPrenda.Location = new System.Drawing.Point(401, 395);
            this.btnCotizarPrenda.Name = "btnCotizarPrenda";
            this.btnCotizarPrenda.Size = new System.Drawing.Size(117, 39);
            this.btnCotizarPrenda.TabIndex = 19;
            this.btnCotizarPrenda.Text = "Cotizar";
            this.btnCotizarPrenda.UseVisualStyleBackColor = false;
            this.btnCotizarPrenda.Click += new System.EventHandler(this.btnCotizarPrenda_Click);
            // 
            // txtPrendaCotizacion
            // 
            this.txtPrendaCotizacion.BackColor = System.Drawing.Color.White;
            this.txtPrendaCotizacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrendaCotizacion.Location = new System.Drawing.Point(551, 401);
            this.txtPrendaCotizacion.Name = "txtPrendaCotizacion";
            this.txtPrendaCotizacion.ReadOnly = true;
            this.txtPrendaCotizacion.Size = new System.Drawing.Size(100, 29);
            this.txtPrendaCotizacion.TabIndex = 20;
            this.txtPrendaCotizacion.Text = "0";
            // 
            // btnActualizarPrendas
            // 
            this.btnActualizarPrendas.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnActualizarPrendas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnActualizarPrendas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActualizarPrendas.Location = new System.Drawing.Point(13, 401);
            this.btnActualizarPrendas.Name = "btnActualizarPrendas";
            this.btnActualizarPrendas.Size = new System.Drawing.Size(120, 38);
            this.btnActualizarPrendas.TabIndex = 22;
            this.btnActualizarPrendas.Text = "Actualizar";
            this.btnActualizarPrendas.UseVisualStyleBackColor = false;
            this.btnActualizarPrendas.Click += new System.EventHandler(this.btnActualizarPrendas_Click);
            // 
            // btnVenderPrenda
            // 
            this.btnVenderPrenda.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVenderPrenda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVenderPrenda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVenderPrenda.Location = new System.Drawing.Point(401, 440);
            this.btnVenderPrenda.Name = "btnVenderPrenda";
            this.btnVenderPrenda.Size = new System.Drawing.Size(250, 45);
            this.btnVenderPrenda.TabIndex = 23;
            this.btnVenderPrenda.Text = "Vender";
            this.btnVenderPrenda.UseVisualStyleBackColor = false;
            this.btnVenderPrenda.Click += new System.EventHandler(this.btnVenderPrenda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(801, 497);
            this.Controls.Add(this.btnVenderPrenda);
            this.Controls.Add(this.btnActualizarPrendas);
            this.Controls.Add(this.txtPrendaCotizacion);
            this.Controls.Add(this.btnCotizarPrenda);
            this.Controls.Add(this.txtPrendaPrecioUnidad);
            this.Controls.Add(this.lbPrendaPrecioUnidad);
            this.Controls.Add(this.txtPrendaCantidad);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.rb_Prenda_Calidad_Premium);
            this.Controls.Add(this.rbPrenda_Calidad_Standard);
            this.Controls.Add(this.lbPrendaCalidad);
            this.Controls.Add(this.txtPrendaStock);
            this.Controls.Add(this.lbPrendaStock);
            this.Controls.Add(this.lstPrendasTipos);
            this.Controls.Add(this.lbTipos);
            this.Controls.Add(this.lstPrendasNombres);
            this.Controls.Add(this.lbPrendas);
            this.Controls.Add(this.btnVerHistorialCotizaciones);
            this.Controls.Add(this.lbUsuarioID);
            this.Controls.Add(this.lbUsuarioNyA);
            this.Controls.Add(this.lbTiendaDireccion);
            this.Controls.Add(this.lbTiendaNombre);
            this.Controls.Add(this.lbAppNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAppNombre;
        private System.Windows.Forms.Label lbTiendaNombre;
        private System.Windows.Forms.Label lbTiendaDireccion;
        private System.Windows.Forms.Label lbUsuarioNyA;
        private System.Windows.Forms.Label lbUsuarioID;
        private System.Windows.Forms.Button btnVerHistorialCotizaciones;
        private System.Windows.Forms.Label lbPrendas;
        private System.Windows.Forms.ListBox lstPrendasNombres;
        private System.Windows.Forms.Label lbTipos;
        private System.Windows.Forms.ListBox lstPrendasTipos;
        private System.Windows.Forms.Label lbPrendaStock;
        private System.Windows.Forms.TextBox txtPrendaStock;
        private System.Windows.Forms.Label lbPrendaCalidad;
        private System.Windows.Forms.RadioButton rbPrenda_Calidad_Standard;
        private System.Windows.Forms.RadioButton rb_Prenda_Calidad_Premium;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.TextBox txtPrendaCantidad;
        private System.Windows.Forms.Label lbPrendaPrecioUnidad;
        private System.Windows.Forms.TextBox txtPrendaPrecioUnidad;
        private System.Windows.Forms.Button btnCotizarPrenda;
        private System.Windows.Forms.TextBox txtPrendaCotizacion;
        private System.Windows.Forms.Button btnActualizarPrendas;
        private System.Windows.Forms.Button btnVenderPrenda;
    }
}

