using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L
{
    public class NotaDebito : DocumentoContable
    {
        public NotaDebito(DateTime fecha, int numero) : base(fecha, numero)
        {
            _sigla = "ND";
        }
    }
}
