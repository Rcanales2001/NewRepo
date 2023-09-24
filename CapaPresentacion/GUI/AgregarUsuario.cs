using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.GUI
{
    public partial class AgregarUsuario : Form
    {

        private void CargarEstado()
        {
            DataTable estados = DataManager.DBConsultas.Estado1();
            DataRow fila = estados.NewRow();
            fila["Estado"] = "Seleccionar un Estado";
            estados.Rows.InsertAt(fila, 0);
            ccbEstado.DataSource = estados;
            ccbEstado.ValueMember = "IdEstado";
            ccbEstado.DisplayMember = "Estado";

        }
        private void CargarRoles()
        {
            DataTable roles = DataManager.DBConsultas.ROLES();
            DataRow fila = roles.NewRow();
            fila["Rol"] = "Seleccionar un Rol";
            roles.Rows.InsertAt(fila, 0);
            ccbRoles.DataSource = roles;
            ccbRoles.ValueMember = "IDRoles";
            ccbRoles.DisplayMember = "Rol";


        }
        public AgregarUsuario()
        {
            InitializeComponent();
            CargarEstado();
            CargarRoles();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbClave.Text = "";
            txbIDS.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idEstado = Convert.ToInt32(ccbEstado.SelectedValue);
            int idRoles = Convert.ToInt32(ccbRoles.SelectedValue);
            CLS.Usuario oclas = new CLS.Usuario();
            // Datos para la dirección
            oclas.IDUsuarios = txbIDS.Text;
            oclas.Usuario1 = txbUser.Text;
            oclas.Clave = txbClave.Text;
            oclas.IDEstado = idEstado.ToString();
            oclas.IDRoles = idRoles.ToString();



            if (txbIDS.TextLength > 0)
            {
                if (oclas.Actualizar())
                {
                    //mostrar mensaje
                    MessageBox.Show("Registro fue actualizado con exito", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Registro no fue actualizado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            //Realizar la operacion de insertar
            else
            {
                if (oclas.Insertar())
                {

                    //mostrar mensaje
                    MessageBox.Show("Registro insertado con exito", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();


                }
                else
                {
                    MessageBox.Show("Registro no fue insertado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void txR_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void ccbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
