using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress_Examen_Ingreso_Quark.model
{
    public interface ICotizable
    {
        public float Cotizar(int vendedorId, int cantidad);
    }
}
