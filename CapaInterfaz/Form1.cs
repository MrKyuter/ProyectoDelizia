using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
namespace CapaInterfaz
{
    public partial class Form1 : Form
    {
        private ProbarConexion logica = new ProbarConexion();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBD_Click(object sender, EventArgs e)
        {
            bool hayConexion = logica.VerificarConexionBD();

            if (hayConexion)
            {
                MessageBox.Show("Conexión exitosa con la base de datos.", "Estado de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo conectar a la base de datos.", "Estado de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void LabelUsuario_Click(object sender, EventArgs e)
        {

        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {

        }
    }
}