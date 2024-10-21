using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
namespace CapaPersistencia
{
    public class Database
    {
        private MySqlConnection connection;
        private string server = "localhost";
        private string database = "delizia";
        private string user = "root";
        private string password = "";
        private string cadenaConexion;

        public Database()
        {
            cadenaConexion = $"Server={server};Database={database};User Id={user};Password={password};";
            
        }

        public MySqlConnection getConexion() 
        {
            if (connection==null)
            {
                connection = new MySqlConnection(cadenaConexion);
                connection.Open();

            }
            return connection;

        }
    }
}
