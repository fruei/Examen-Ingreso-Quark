using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress_Examen_Ingreso_Quark.model
{
    public delegate bool ControlStock(int stockAmount, int currentStockAmount);

    public enum Calidad
    {
        Standard,
        Premium

    };
    abstract class Prenda
    {
        private Calidad calidad;
        private int stock;
        private float precio;
        private string id;
        private string tipo;
        private string prendaconfid;

        public Calidad Calidad { get => calidad; set => calidad = value; }
        public int Stock { get => stock; set => stock = value; }
        public float Precio { get => precio; set => precio = value; }
        public string Id { get => id; set => id = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Prendaconfid { get => prendaconfid; set => prendaconfid = value; }

        public static bool ControlStock(int stockAmount, int currentStockAmount, ControlStock cs)
        {
            return cs(stockAmount, currentStockAmount);
        }

    }
}
