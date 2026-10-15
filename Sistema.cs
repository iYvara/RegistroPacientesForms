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
    public partial class SistemaDePacientes : Form
    {
        public SistemaDePacientes()
        {
            InitializeComponent();
        }

        private void btnBorrarPacientes_Click(object sender, EventArgs e)
        {
            using(RegistroDePacientes borrar = new RegistroDePacientes())
            {
                this.Hide();
                borrar.ShowDialog();
                this.Show();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            using(RegistroDePacientes registro = new RegistroDePacientes())
            {
                this.Hide();
                registro.ShowDialog();
                this.Show();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarPacientes_Click(object sender, EventArgs e)
        {
            using(RegistroDePacientes buscar = new RegistroDePacientes())
            {
                this.Hide();
                buscar.ShowDialog();
                this.Show();
            }
        }
    }
}
