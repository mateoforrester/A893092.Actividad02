using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A893092.Actividad02
{
    class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Stock { get; set; }

        public Producto()
        {
            
        }


        public Producto (int id, string nombre, int stock)
        {
            Id =id;
            Nombre = nombre;
            Stock = stock;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", Id, Nombre, Stock);
        }


    }


}
