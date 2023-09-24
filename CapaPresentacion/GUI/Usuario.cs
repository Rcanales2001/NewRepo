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
    public partial class Usuario : Form
    {

        BindingSource _DATOS1 = new BindingSource();
        private void CargarDatos()
        {
            try
            {
                _DATOS1.DataSource = DataManager.DBConsultas.USERS();
                dtgvUsuario.AutoGenerateColumns = false;
                dtgvUsuario.DataSource = _DATOS1;
                lblRegistros.Text = dtgvUsuario.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }
        public Usuario()
        {
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            dtgvUsuario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            CargarDatos();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AgregarUsuario f = new AgregarUsuario();
            f.ShowDialog();
            CargarDatos();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente dese Editar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
           

                AgregarUsuario f = new AgregarUsuario();
                f.txbIDS.Text = dtgvUsuario.CurrentRow.Cells["IDUsuarios"].Value.ToString();
                f.txbUser.Text = dtgvUsuario.CurrentRow.Cells["nombreUsuario"].Value.ToString();
                f.txbClave.Text = dtgvUsuario.CurrentRow.Cells["Clave"].Value.ToString();
                string valorCelda = dtgvUsuario.CurrentRow.Cells["IdEstado"].Value?.ToString();

                if (!string.IsNullOrEmpty(valorCelda))
                {
                    DataRowView selectedItem = null;

                    foreach (DataRowView item in f.ccbEstado.Items)
                    {
                        if (item.Row["IdEstado"].ToString() == valorCelda)
                        {
                            selectedItem = item;
                            break;
                        }
                    }

                    if (selectedItem != null)
                    {
                        f.ccbEstado.SelectedItem = selectedItem;
                    }
                    else
                    {
                        // El valor de la celda no existe en la lista de elementos del ComboBox
                        // Puedes agregar una lógica adicional aquí si es necesario
                    }
                }
                string valorCelda1 = dtgvUsuario.CurrentRow.Cells["IDRoles"].Value?.ToString();

                if (!string.IsNullOrEmpty(valorCelda1))
                {
                    DataRowView selectedItem = null;

                    foreach (DataRowView item in f.ccbRoles.Items)
                    {
                        if (item.Row["IDRoles"].ToString() == valorCelda1)
                        {
                            selectedItem = item;
                            break;
                        }
                    }

                    if (selectedItem != null)
                    {
                        f.ccbRoles.SelectedItem = selectedItem;
                    }
                    else
                    {
                        // El valor de la celda no existe en la lista de elementos del ComboBox
                        // Puedes agregar una lógica adicional aquí si es necesario
                    }
                }

                f.ShowDialog();
                CargarDatos();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente dese eliminar el registor seleccionado?", "Preguntar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)


            {
                CLS.Usuario oclas = new CLS.Usuario();
                oclas.IDUsuarios = dtgvUsuario.CurrentRow.Cells["IDUsuarios"].Value.ToString().ToLower();
                if (oclas.Eliminar())
                {
                    //mostrar mensaje
                    MessageBox.Show("Registro Eliminado con exito", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("Registro no fue Eliminado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
