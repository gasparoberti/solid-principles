﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D
{
    public abstract class DocumentoContable : IImprimible
    {
        protected string _sigla;

        protected DocumentoContable(DateTime fecha, double importe, int numero)
        {
            Fecha = fecha;
            Importe = importe;
            Numero = numero;
        }

        public DateTime Fecha { get; set; }
        public double Importe { get; set; }
        public int Numero { get; set; }

        public abstract void Imprimir();

        public abstract double Total();
    }
}
