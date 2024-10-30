using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Pedido
    {
        public string estado;
        public int id;
        public DateTime fecha;
        public int id_cliente;
        public int preciototal;

        public Pedido(string estado, int id, DateTime fecha, int id_cliente, int preciototal) {
        
        this.estado = estado;
            this.id = id;
            this.fecha = fecha;     
            this.id_cliente = id_cliente;
            this.preciototal = preciototal;

        
        }



    }
}
