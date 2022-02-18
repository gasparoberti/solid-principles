using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.I
{
    public class Factura : Documento
    {
        public Factura(DateTime fecha, int numero) : base(fecha, numero)
        {
        }

        public string CAI { get; set; }

        //public override void EnviarPorEmail()
        //{
        //    //no se puede enviar por email porque es impresa
        //}

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo la factura {Numero} de la fecha {Fecha.ToShortDateString()}");
        }
    }
}
