using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L
{
    public class Documento
    {
        protected string _sigla;

        public Documento(DateTime fecha, int numero)
        {
            Fecha = fecha;
            Numero = numero;
        }

        public DateTime Fecha { get; set; }
        public int Numero { get; set; }

        public string Imprimir()
        {
            return $"Imprimiendo {Descripcion()}";
        }

        public virtual string Descripcion()
        {
            return $"{_sigla} nro {Numero} de fecha {Fecha.ToShortDateString()}";
        }
    }
}
