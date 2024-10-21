using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPersistencia
{
    public class VerificarConexionBD
    {
        private Database database = new Database();

        public bool ProbarConexion()
        {
            try
            {
                MySqlConnection conexion = database.getConexion();

                if(conexion.State == System.Data.ConnectionState.Open)
                {
                    return true; // Tenemos conexion
                }
                else
                {
                    return false; // No hay conexion
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error al intentar Conectarse:" + ex.Message);
                return false;
            }
        }

         
    }
}
