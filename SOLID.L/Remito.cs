using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L
{
    public class Remito : Documento
    {
        public Remito(DateTime fecha, int numero, int bultos) : base(fecha, numero)
        {
            CantBultos = bultos;
        }

        public int CantBultos { get; set; }

        public override string Descripcion()
        {
            return $"Remito nro {Numero} de fecha {Fecha.ToShortDateString()} con {CantBultos} bultos";
        }
    }
}
