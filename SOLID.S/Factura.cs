using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.S
{
    public class Factura
    {
        public Factura(int numero, DateTime fecha, Cliente cliente, List<Item> items)
        {
            Numero = numero;
            Fecha = fecha;
            Cliente = cliente;
            Items = items;
        }

        //public Factura(int numero, DateTime fecha, string apellido, string nombre, List<Item> items)
        //{
        //    Numero = numero;
        //    Fecha = fecha;
        //    Apellido = apellido;
        //    Nombre = nombre;
        //    Items = items;
        //}

        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        //public string Apellido { get; set; }
        //public string Nombre { get; set; }

        public Cliente Cliente { get; set; }
        public List<Item> Items { get; set; }

        public double Total()
        {
            double total = 0;
            foreach (var item in Items)
            {
                //total += item.Cantidad * item.Producto.Precio;
                total += item.Subtotal();
            }

            return total;
        }
    }

}
