using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L
{
    public class Remito
    {
        public Remito(DateTime fecha, int numero, int bultos)
        {
            Fecha = fecha;
            Numero = numero;
            CantBultos = bultos;
        }

        public DateTime Fecha { get; set; }
        public int Numero { get; set; }
        public int CantBultos { get; set; }

        public string Imprimir()
        {
            return $"Imprimiendo {Descripcion()}";
        }

        public string Descripcion()
        {
            return $"Remito nro {Numero} de fecha {Fecha.ToShortDateString()} con {CantBultos} bultos";
        }
    }
}
