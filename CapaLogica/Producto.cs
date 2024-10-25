using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Producto
    {
        public string nombre;
        public int codigo;
        public int precio;
        public string tipo;

        public Producto() { 
        
        }
        public Producto(string nombre,int codigo, int precio,string tipo) {
            this.nombre = nombre;
            this.codigo = codigo;
            this.precio = precio;
            this.tipo = tipo;
    }
}
