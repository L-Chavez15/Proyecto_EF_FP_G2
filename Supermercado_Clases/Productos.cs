using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado_Clases
{
    public class Productos
    {
        public double Codigo { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }

        //Metodo Constructor
        public Productos()
        {
        }

        public Productos(double G2_codigo, string G2_nombre, string G2_categoria, double G2_precio, int stock)
        {
            Codigo = G2_codigo;
            Nombre = G2_nombre;
            Categoria = G2_categoria;
            Precio = G2_precio;
            Stock = stock;
        }
    }
}
