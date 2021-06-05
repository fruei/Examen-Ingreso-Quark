using CotizadorExpress_Examen_Ingreso_Quark.model;
using CotizadorExpress_Examen_Ingreso_Quark.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CotizadorExpress_Examen_Ingreso_Quark
{
    public partial class Form1 : Form
    {
        List<string> prendasNombres;
        List<string> prendasTipos;
        Prenda prendaSeleccionada;
        Vendedor vendedor;
        Tienda tienda;

        string prendaSeleccionadaNombre;
        string prendaSeleccionadaTipo;

        public Form1()
        {
            InitializeComponent();           

            vendedor = new Vendedor
            {
                Id = 444,
                Nombre = "Emanuel",
                Apellido = "Jara"
            };

            List<Prenda> prendas = new List<Prenda>();

            prendas = PrendasController.TraerListadoPrendas();

            tienda = new Tienda
            {
                Nombre = "'Tienda Emanuel Examen'",
                Direccion = "San Salvador Jujuy s/n",
                Vendedor = vendedor,
                Prendas = prendas
            };

            lbTiendaNombre.Text = $"Tienda: {tienda.Nombre}";
            lbTiendaDireccion.Text = $"Direccion: {tienda.Direccion}";
            lbUsuarioNyA.Text = $"Vendedor: {vendedor.Nombre}  {vendedor.Apellido}";
            lbUsuarioID.Text = $"ID: {vendedor.Id}";

            ActualizarNombrePrendas();
        }

        private void btnCotizarPrenda_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(prendaSeleccionadaNombre))
            {
                MessageBox.Show("Para poder cotizar seleccione la prenda");
                return;
            }

            if (string.IsNullOrEmpty(prendaSeleccionadaTipo))
            {
                MessageBox.Show("Para poder cotizar seleccione el tipo de prenda");
                return;
            }

            if (rbPrenda_Calidad_Standard.Checked ||
                rb_Prenda_Calidad_Premium.Checked)
            {
                int cantidad;
                bool esNumero = int.TryParse(txtPrendaCantidad.Text, out cantidad);

                if (!esNumero)
                {
                    MessageBox.Show("La cantidad debe ser un valor numerico");
                    return;
                }

                bool puedoCotizar = Prenda.ControlStock(
                    prendaSeleccionada.Stock,
                    cantidad,
                    (x, y) => x > y && y > 0);

                if (!puedoCotizar)
                {
                    MessageBox.Show("Para poder cotizar la cantidad debe ser mayor a 0 y menor al Stock");
                    return;
                }

                ICotizable cotizable = (ICotizable)prendaSeleccionada;
                float precio = cotizable.Cotizar(vendedor.Id, cantidad);
                txtPrendaCotizacion.Text = $"$ {precio}";
            }
            else
            {
                MessageBox.Show("Para poder cotizar seleccione calidad: Standard o Premium");
            }
        }

        private void btnActualizarPrendas_Click(object sender, EventArgs e)
        {
            txtPrendaCotizacion.Text = $"$ 0";
            rbPrenda_Calidad_Standard.Checked = false;
            rb_Prenda_Calidad_Premium.Checked = false;
            ActualizarNombrePrendas();
        }        

        private void ActualizarNombrePrendas()
        {
            prendaSeleccionadaNombre = "";
            prendasNombres = new List<string>();
            lstPrendasNombres.Items.Clear();
            prendasNombres = PrendasController.TraerPrendas();
            prendasNombres.ForEach(arma =>
            {
                lstPrendasNombres.Items.Add(arma);
            });
        }

        private void ActualizarTipoPrendas()
        {
            prendaSeleccionadaNombre = lstPrendasNombres.SelectedItem.ToString();
            prendaSeleccionadaTipo = "";
            prendasTipos = new List<string>();
            lstPrendasTipos.Items.Clear();
            switch (prendaSeleccionadaNombre)
            {
                case "Camisa":
                    prendasTipos = PrendasController.TraerTiposCamisa();
                    break;
                case "Pantalon":
                    prendasTipos = PrendasController.TraerTiposPantalon();
                    break;
                default: break;
            }

            prendasTipos.ForEach(arma =>
            {
                lstPrendasTipos.Items.Add(arma);
            });
        }

        private void PrendasNombreSelectedValueChanged(object sender, EventArgs e)
        {
            txtPrendaCotizacion.Text = "$ 0";
            txtPrendaStock.Text = "0";
            txtPrendaPrecioUnidad.Text = "$ 0";
            rbPrenda_Calidad_Standard.Checked = false;
            rb_Prenda_Calidad_Premium.Checked = false;
            ActualizarTipoPrendas();
        }

        private void PrendasTiposSelectedValueChanged(object sender, EventArgs e)
        {
            txtPrendaCotizacion.Text = "$ 0";
            rbPrenda_Calidad_Standard.Checked = false;
            rb_Prenda_Calidad_Premium.Checked = false;
            prendaSeleccionadaTipo = lstPrendasTipos.SelectedItem.ToString();

            switch (prendaSeleccionadaNombre)
            {
                case "Camisa":
                    TraerDatosCamisa();
                    break;
                case "Pantalon":
                    TraerDatosPantalon();
                    break;
                default: break;
            }            
        }

        private void TraerDatosCamisa()
        {
            string[] prendaData = prendaSeleccionadaTipo.Split(',');
            if (prendaData.Length != 2)
                return;
            Manga manga = prendaData[0] == "Corta" ? Manga.Corta : Manga.Larga;
            Cuello cuello = (Cuello)Enum.Parse(typeof(Cuello), prendaData[1]);
            Camisa camisa = PrendasController.TraerDatosCamisa(manga, cuello);
            txtPrendaStock.Text = camisa.Stock.ToString();
            txtPrendaPrecioUnidad.Text = $"$ {camisa.Precio}";
            prendaSeleccionada = camisa;
        }

        private void TraerDatosPantalon()
        {
            TipoPantalon tipo = (TipoPantalon)Enum.Parse(typeof(TipoPantalon), prendaSeleccionadaTipo); 
            Pantalon pantalon = PrendasController.TraerDatosPantalon(tipo);
            txtPrendaStock.Text = pantalon.Stock.ToString();
            txtPrendaPrecioUnidad.Text = $"$ {pantalon.Precio}";
            prendaSeleccionada = pantalon;
        }

        private void PrendaCalidadStandardChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(prendaSeleccionadaNombre) ||
                string.IsNullOrEmpty(prendaSeleccionadaTipo)) return;

            prendaSeleccionada.Calidad = 
                rbPrenda_Calidad_Standard.Checked ? Calidad.Standard : Calidad.Premium;
        }

        private void btnVerHistorialCotizaciones_Click(object sender, EventArgs e)
        {
            HistorialCotizacionesForm historialForm =
                new HistorialCotizacionesForm(vendedor.Id, vendedor.Nombre+" "+vendedor.Apellido);
            historialForm.ShowDialog();
        }

        private void btnVenderPrenda_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(prendaSeleccionadaNombre))
            {
                MessageBox.Show("Para poder vender seleccione la prenda");
                return;
            }

            if (string.IsNullOrEmpty(prendaSeleccionadaTipo))
            {
                MessageBox.Show("Para poder vender seleccione el tipo de prenda");
                return;
            }

            if (rbPrenda_Calidad_Standard.Checked ||
                rb_Prenda_Calidad_Premium.Checked)
            {

                bool puedoVender = Prenda.ControlStock(
                    prendaSeleccionada.Stock,
                    int.Parse(txtPrendaCantidad.Text),
                    (x, y) => x > y && y > 0);

                if (!puedoVender)
                {
                    MessageBox.Show("Para poder vender la cantidad debe ser mayor a 0 y menor al Stock");
                    return;
                }

                int stock = int.Parse(txtPrendaStock.Text);
                int cantidad = int.Parse(txtPrendaCantidad.Text);

                switch (prendaSeleccionadaNombre)
                {
                    case "Camisa":
                        string[] prendaData = prendaSeleccionadaTipo.Split(',');
                        if (prendaData.Length != 2)
                            return;
                        Manga manga = prendaData[0] == "Corta" ? Manga.Corta : Manga.Larga;
                        Cuello cuello = (Cuello)Enum.Parse(typeof(Cuello), prendaData[1]);

                        Camisa camisa = new Camisa
                        {
                            Manga = manga,
                            Cuello = cuello
                        };
                        txtPrendaStock.Text = (stock - cantidad).ToString();
                        PrendasController.VenderCamisa(camisa,cantidad);
                        MessageBox.Show("La venta se efectuo correctamente");
                        break;

                    case "Pantalon":
                        TipoPantalon tipo = (TipoPantalon)Enum.Parse(typeof(TipoPantalon), prendaSeleccionadaTipo);
                        Pantalon pantalon = PrendasController.TraerDatosPantalon(tipo);

                        txtPrendaStock.Text = (stock - cantidad).ToString();
                        PrendasController.VenderPantalon(pantalon,cantidad);
                        MessageBox.Show("La venta se efectuo correctamente");
                        break;
                    default: break;
                }
            }
            else
            {
                MessageBox.Show("Para poder vender seleccione calidad: Standard o Premium");
            }            
        }
    }
}
