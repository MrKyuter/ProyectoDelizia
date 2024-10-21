using System;
using CapaPersistencia;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class ProbarConexion
    {
        private VerificarConexionBD Vconexion = new VerificarConexionBD();

        public bool VerificarConexionBD()
        {
            bool conexionExitosa = Vconexion.ProbarConexion();
            return conexionExitosa;
        }
    }
}
