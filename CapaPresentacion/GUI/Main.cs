using SessionManager;
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
    
    public partial class Main : Form
    {
        SessionManager.Session oSesion = SessionManager.Session.Instancia;
        Boolean _Autorizado = false;
        public bool Autorizado { get => _Autorizado; }
        public Main()
        {
            InitializeComponent();
            txtusuario.Text = "Dlla";
            txtclave.Text = "Dlla123";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (oSesion.IniciarSesion(txtusuario.Text, txtclave.Text))
            {
                _Autorizado = true;
                Close();
            }
            else
            {
                _Autorizado = false;
                lblMensaje.Text = "USUARIO O CLAVE INCORRECTOS";
                txtclave.Focus();
                txtclave.SelectAll();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
