
namespace CotizadorExpress_Examen_Ingreso_Quark
{
    partial class HistorialCotizacionesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstHistorialCotizaciones = new System.Windows.Forms.ListBox();
            this.txtVendedorNyA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historial Completo de las Cotizaciones ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vendedor que efectuo estas cotizaciones : ";
            // 
            // lstHistorialCotizaciones
            // 
            this.lstHistorialCotizaciones.FormattingEnabled = true;
            this.lstHistorialCotizaciones.ItemHeight = 15;
            this.lstHistorialCotizaciones.Location = new System.Drawing.Point(12, 89);
            this.lstHistorialCotizaciones.Name = "lstHistorialCotizaciones";
            this.lstHistorialCotizaciones.Size = new System.Drawing.Size(927, 394);
            this.lstHistorialCotizaciones.TabIndex = 2;
            // 
            // txtVendedorNyA
            // 
            this.txtVendedorNyA.BackColor = System.Drawing.Color.White;
            this.txtVendedorNyA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVendedorNyA.Location = new System.Drawing.Point(318, 47);
            this.txtVendedorNyA.Name = "txtVendedorNyA";
            this.txtVendedorNyA.ReadOnly = true;
            this.txtVendedorNyA.Size = new System.Drawing.Size(258, 29);
            this.txtVendedorNyA.TabIndex = 3;
            // 
            // HistorialCotizacionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(952, 495);
            this.Controls.Add(this.txtVendedorNyA);
            this.Controls.Add(this.lstHistorialCotizaciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HistorialCotizacionesForm";
            this.Text = "HistorialCotizacionesForm";
            this.Load += new System.EventHandler(this.HistorialCotizacionesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstHistorialCotizaciones;
        private System.Windows.Forms.TextBox txtVendedorNyA;
    }
}