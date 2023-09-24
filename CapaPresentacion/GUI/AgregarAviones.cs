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
    public partial class AgregarAviones : Form
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
        public AgregarAviones()
        {
            InitializeComponent();
            CargarEstado();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbCapacidad.Text = "";
            txbMarca.Text = "";
            txbMatricula.Text = "";
            txbModelo.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idEstado = Convert.ToInt32(ccbEstado.SelectedValue);
            CLS.Aviones oclas = new CLS.Aviones();
            // Datos para la dirección
            oclas.IdAviones = txbIDAvion.Text;
            oclas.Matricula = txbMatricula.Text;
            oclas.Marca = txbMarca.Text;
            oclas.Modelo = txbModelo.Text;
            oclas.CapacidadMaxima = txbCapacidad.Text;
            oclas.IDEstado = idEstado.ToString();

            if (txbIDAvion.TextLength > 0)
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

        private void txbCapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Por favor, ingrese solo números.");
            }
        }

        private void txbCapacidad_Leave(object sender, EventArgs e)
        {
            string input = txbCapacidad.Text;

            if (!string.IsNullOrEmpty(input) && !int.TryParse(input, out _))
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
                txbCapacidad.Focus();
            }
        }
    }
}
