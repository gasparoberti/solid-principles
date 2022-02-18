using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D
{
    public class ReciboSueldo
    {
        public ReciboSueldo(double legajo, int total)
        {
            Legajo = legajo;
            Total = total;
        }

        public double Legajo { get; set; }
        public int Total { get; set; }
    }
}
