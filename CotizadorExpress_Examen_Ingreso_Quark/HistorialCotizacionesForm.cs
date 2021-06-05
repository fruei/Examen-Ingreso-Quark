using CotizadorExpress_Examen_Ingreso_Quark.controller;
using CotizadorExpress_Examen_Ingreso_Quark.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotizadorExpress_Examen_Ingreso_Quark
{
    public partial class HistorialCotizacionesForm : Form
    {
        private int vendedorID;
        private string vendedorNyA;

        List<Cotizacion> cotizaciones = new List<Cotizacion>();

        public HistorialCotizacionesForm(int vendedorID, string vendedorNyA)
        {
            this.vendedorID = vendedorID;
            this.vendedorNyA = vendedorNyA;
            InitializeComponent();
        }

        private void HistorialCotizacionesForm_Load(object sender, EventArgs e)
        {
            txtVendedorNyA.Text = $"{vendedorNyA}";
            lstHistorialCotizaciones.Items.Clear();
            cotizaciones = PrendasController.TraerHistorialCotizaciones(vendedorID);
            cotizaciones.ForEach(cot =>
            {
                string cotizacion = @$"ID:   {cot.Id},
                FECHA Y HORA:    {cot.Fechayhora: mm-dd-yyy H:m},
                CANTIDAD:    {cot.Cantidad},
                COTIZADO A:    ${cot.Resultado},
                PRENDA:    {cot.Prendatipo}, {cot.Prendaconf}";
                lstHistorialCotizaciones.Items.Add(cotizacion);
            });
        }
    }
}
