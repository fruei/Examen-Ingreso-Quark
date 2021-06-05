using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress_Examen_Ingreso_Quark.model
{
    class Cotizacion
    {
        private int id;
        private DateTime fechayhora;
        private int vendedorId;
        private int cantidad;
        private float resultado;
        private string prendatipo;
        private string prendaconf;

        public int Id { get => id; set => id = value; }
        public DateTime Fechayhora { get => fechayhora; set => fechayhora = value; }
        public int VendedorId { get => vendedorId; set => vendedorId = value; }
        public float Resultado { get => resultado; set => resultado = value; }
        public string Prendatipo { get => prendatipo; set => prendatipo = value; }
        public string Prendaconf { get => prendaconf; set => prendaconf = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
