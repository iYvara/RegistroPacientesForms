using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroPacientes
{
    public partial class RegistroDePacientes : Form
    {
        public RegistroDePacientes()
        {
            InitializeComponent();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string clave = txtContraseña.Text.Trim();
            if (clave == "")
            {
                MessageBox.Show("Escribe la contraseña.");
                return;
            }
            if (clave == "Admin123")
            {
                MessageBox.Show("Contraseña correcta, bienvenido/a.");
                using (SistemaDePacientes sistema = new SistemaDePacientes())
                {
                    this.Hide();
                    sistema.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta, intentelo de nuevo.");
                txtContraseña.Clear();
                txtContraseña.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
