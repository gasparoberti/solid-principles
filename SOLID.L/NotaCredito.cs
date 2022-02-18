using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L
{
    public class NotaCredito : DocumentoContable
    {
        public NotaCredito(DateTime fecha, int numero) : base(fecha, numero)
        {
            _sigla = "NC";
        }
    }
}
