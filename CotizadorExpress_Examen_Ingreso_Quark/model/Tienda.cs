using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress_Examen_Ingreso_Quark.model
{
    class Tienda
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        internal Vendedor Vendedor { get; set; }
        internal List<Prenda> Prendas { get; set; }
    }
}
