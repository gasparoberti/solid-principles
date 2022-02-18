using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D
{
    public class Impresora
    {
        public void Imprimir(Factura factura)
        {
            Console.WriteLine($"Imprimiendo factura {factura.Numero} del {factura.Fecha.ToShortDateString()} por un importe de $ {factura.Importe}");
        }
        
        public void Imprimir(NotaCredito notaCredito)
        {
            Console.WriteLine($"Imprimiendo nota de crédito {notaCredito.Numero} del {notaCredito.Fecha.ToShortDateString()} por un importe de $ {notaCredito.Importe}");
        }
        
        public void Imprimir(FacturaLuz facturaLuz)
        {
            Console.WriteLine($"Imprimiendo factura de luz {facturaLuz.CodigoPago} por un importe de $ {facturaLuz.Importe}");
        }
        
        public void Imprimir(Municipal municipal)
        {
            Console.WriteLine($"Imprimiendo impuesto municipal {municipal.Partida} por un importe de $ {municipal.Importe}");
        }
        
        public void Imprimir(ReciboSueldo reciboSueldo)
        {
            Console.WriteLine($"Imprimiendo recibo de sueldo {reciboSueldo.Legajo} por un importe de $ {reciboSueldo.Total}");
        }
        
        public void Imprimir(Remito remito)
        {
            Console.WriteLine($"Imprimiendo remito {remito.Numero} del {remito.Fecha.ToShortDateString()} con {remito.CantBultos} bultos");
        }
    }
}
