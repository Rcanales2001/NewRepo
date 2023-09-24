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
    public partial class Aviones : Form
    {
        BindingSource _DATOS1 = new BindingSource();
        public event Action<int> Seleccionado;
        private void CargarDatos()
        {
            try
            {
                _DATOS1.DataSource = DataManager.DBConsultas.AVIONESS();
                dtgvAviones.AutoGenerateColumns = false;
                dtgvAviones.DataSource = _DATOS1;
                lblRegistros.Text = dtgvAviones.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }
        public Aviones()
        {
            InitializeComponent();
        }

        private void Aviones_Load(object sender, EventArgs e)
        {
            dtgvAviones.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            CargarDatos();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente dese eliminar el registor seleccionado?", "Preguntar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)


            {
                CLS.Aviones oclas = new CLS.Aviones();
                oclas.IdAviones = dtgvAviones.CurrentRow.Cells["IdAviones"].Value.ToString().ToLower();
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AgregarAviones f = new AgregarAviones();
            f.ShowDialog();
            CargarDatos();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente dese Editar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                AgregarAviones f = new AgregarAviones();
                f.txbIDAvion.Text = dtgvAviones.CurrentRow.Cells["IdAviones"].Value.ToString();
                f.txbMatricula.Text = dtgvAviones.CurrentRow.Cells["Matricula"].Value.ToString();
                f.txbMarca.Text = dtgvAviones.CurrentRow.Cells["Marca"].Value.ToString();
                f.txbModelo.Text = dtgvAviones.CurrentRow.Cells["Modelo"].Value.ToString();
                f.txbCapacidad.Text = dtgvAviones.CurrentRow.Cells["CapacidadMaxima"].Value.ToString();
                string valorCelda = dtgvAviones.CurrentRow.Cells["IdEstado"].Value?.ToString();

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
               
                f.ShowDialog();
                CargarDatos();
            }
        }

        private void dtgvAviones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idAviones = Convert.ToInt32(dtgvAviones.Rows[e.RowIndex].Cells["IdAviones"].Value);
            Seleccionado?.Invoke(idAviones);
            Close();
        }
    }
}
