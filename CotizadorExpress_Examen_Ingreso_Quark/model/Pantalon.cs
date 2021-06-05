using CotizadorExpress_Examen_Ingreso_Quark.controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress_Examen_Ingreso_Quark.model
{
    public enum TipoPantalon
    {
        Normal,
        Chupin,
    };

    class Pantalon : Prenda, ICotizable
    {
        private TipoPantalon tipo;

        public TipoPantalon Tipo { get => tipo; set => tipo = value; }

        public Pantalon(
            Calidad calidad,
            int stock,
            float precio,
            string id,
            TipoPantalon tipo = TipoPantalon.Normal)
        {
            Calidad = calidad;
            Stock = Stock;
            Precio = precio;
            Id = id;
            this.tipo = tipo;
        }

        public Pantalon() { }


        public float Cotizar(int vendedorId, int cantidad)
        {
            float precio = this.Precio * cantidad;

            precio -= Tipo == TipoPantalon.Chupin ? ((precio * 12) / 100) : 0;

            precio += Calidad == Calidad.Premium ? ((precio * 30) / 100) : 0;

            PrendasController.AgregarCotizacion(
               "Pantalon", $"{Tipo}",
               vendedorId, cantidad, precio);

            return precio;
        }
    }
}
