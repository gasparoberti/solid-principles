using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D
{
    public class Cobranza : IImprimible
    {
        public Cobranza(int numero, int importe)
        {
            Numero = numero;
            Importe = importe;
        }

        public int Numero { get; set; }
        public int Importe { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"Imprimiendo cobranza {Numero} por un importe de $ {Importe}"); 
        }
    }
}
