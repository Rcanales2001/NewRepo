using CapaPresentacion.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.GUI
{
    public partial class Login : Form
    {
        SessionManager.Session oSesion = SessionManager.Session.Instancia;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = oSesion.Usuario;
            lblRol.Text = oSesion.Rol;

            if (lblRol.Text == "ADMINISTRADOR")
            {
                // Habilitar todos los botones
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;

            }
            else if (lblRol.Text == "USUARIO")
            {
                // Inhabilitar algunos botones específicos
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = false;
                button5.Enabled = true;
                button6.Enabled = false;
            }
            else if (lblRol.Text == "CONSULTOR")
            {
                // Inhabilitar algunos botones específicos
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = true;
                button6.Enabled = false;
            }
            else
            {
                // Inhabilitar todos los botones
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Pasajeros f = new Pasajeros();
                f.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Reserva f = new Reserva();
                f.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Aviones f = new Aviones();
                f.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario f = new Usuario();
                f.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Reporte f = new Reporte();
                f.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Informacion f = new Informacion();
                f.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
