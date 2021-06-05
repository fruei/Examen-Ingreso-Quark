using CotizadorExpress_Examen_Ingreso_Quark.controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress_Examen_Ingreso_Quark.model
{
    public enum Manga
    {
        Larga,
        Corta
    };

    public enum Cuello
    {
        Normal,
        Mao
    };

    class Camisa : Prenda , ICotizable
    {
        private Manga manga;

        private Cuello cuello;

        public Manga Manga { get => manga; set => manga = value; }
        public Cuello Cuello { get => cuello; set => cuello = value; }

        public float Cotizar(int vendedorId, int cantidad)
        {
            float precio = this.Precio * cantidad;

            precio -= Manga == Manga.Larga ? ((precio * 10)/100 ) : 0;
            precio += Cuello == Cuello.Mao ? ((precio * 3) / 100) : 0;

            precio += Calidad == Calidad.Premium ? ((precio * 30) / 100) : 0;

            PrendasController.AgregarCotizacion(
                "Camisa", $"{Manga}, {Cuello}", 
                vendedorId, cantidad, precio);

            return precio;
        }
    }
}
