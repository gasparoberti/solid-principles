using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.I
{
    public class FacturaElectronica : Documento, IEmaileable
    {
        public FacturaElectronica(DateTime fecha, int numero) : base(fecha, numero)
        {
        }

        public string CAE { get; set; }

        public void EnviarPorEmail()
        {
            Console.WriteLine($"Enviando por email la factura electrónica {Numero} de la fecha {Fecha.ToShortDateString()}");
        }

        //public override void EnviarPorEmail()
        //{
        //    Console.WriteLine($"Enviando por email la factura electrónica {Numero} de la fecha {Fecha.ToShortDateString()}");
        //}

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo la factura electrónica {Numero} de la fecha {Fecha.ToShortDateString()}");
        }
    }
}
