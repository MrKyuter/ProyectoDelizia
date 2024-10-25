using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Cliente
    {
        public string nombre;
        public string apellido;
        public int id;
        public string direccion;
        public int telefono;

        public Cliente (string nombre, string apellido, int id, string direccion, int telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.id = id;
            this.direccion = direccion;
            this.telefono = telefono;
        }
    }
}
