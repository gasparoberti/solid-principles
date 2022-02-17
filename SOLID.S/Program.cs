using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.S
{
    class Program
    {
        static void Main(string[] args)
        {
            Item i1 = new Item(new Producto("Arroz", 10), 5);
            Item i2 = new Item(new Producto("Queso", 90), 1);
            Item i3 = new Item(new Producto("Gaseosa", 70), 2);

            List<Item> l = new List<Item>();

            l.Add(i1);
            l.Add(i2);
            l.Add(i3);

            Factura f = new Factura(21332, DateTime.Now, "Lopez", "Diego", l);

            Console.WriteLine(f.Total());

            Console.ReadKey();
        }
    }
}
