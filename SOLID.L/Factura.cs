using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L
{
    public class Factura : Documento
    {
        public Factura(DateTime fecha, int numero) : base(fecha, numero)
        {
            _sigla = "FC";
        }
    }
}
