using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class ProductosPedidos
    {
        public int id_pedido;
        public int id_producto;
        public int cantidad;

        public ProductosPedidos()
        {

        }
        public ProductosPedidos (int id_pedido, int id_producto,int cantidad)
        {
            this.id_pedido = id_pedido;
            this.id_producto = id_producto;
            this.cantidad = cantidad;
        }



    }
}
