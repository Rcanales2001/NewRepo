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
    public partial class Pasajeros : Form
    {
        BindingSource _DATOS1 = new BindingSource();

        
       

        public event Action<int> Seleccionado1;
        private void CargarDatos()
        {
            try
            {
                _DATOS1.DataSource = DataManager.DBConsultas.PASAJEROS();
                dtgvPasajeros.AutoGenerateColumns = false;
                dtgvPasajeros.DataSource = _DATOS1;
                lblRegistros.Text = dtgvPasajeros.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }
        public Pasajeros()
        {
            InitializeComponent();
        }

        private void Pasajeros_Load(object sender, EventArgs e)
        {
            dtgvPasajeros.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            CargarDatos();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AgregarPasajero f = new AgregarPasajero();
            f.ShowDialog();
            CargarDatos();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente dese Editar el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                AgregarPasajero f = new AgregarPasajero();
                f.txbIdPasajero.Text = dtgvPasajeros.CurrentRow.Cells["IdPasajero"].Value.ToString();
                f.txtNomApe.Text = dtgvPasajeros.CurrentRow.Cells["NombresyApellido"].Value.ToString();
                f.txbnump.Text = dtgvPasajeros.CurrentRow.Cells["NumeroPasaporte"].Value.ToString();
                f.txtCorreo.Text = dtgvPasajeros.CurrentRow.Cells["Correo"].Value.ToString();
                f.fechatxt.Text = dtgvPasajeros.CurrentRow.Cells["FechaNac"].Value.ToString();
                
                f.txbIdDi.Text = dtgvPasajeros.CurrentRow.Cells["IdDirecciones"].Value.ToString();
                f.txbnumeroc.Text = dtgvPasajeros.CurrentRow.Cells["NumeroCasa"].Value.ToString();
                f.txbpasaje.Text = dtgvPasajeros.CurrentRow.Cells["PasajePoligono"].Value.ToString();
                f.txbCalle.Text = dtgvPasajeros.CurrentRow.Cells["Calle"].Value.ToString();
                f.txbPais.Text = dtgvPasajeros.CurrentRow.Cells["Pais"].Value.ToString();

                string valorCelda = dtgvPasajeros.CurrentRow.Cells["IdEstado"].Value?.ToString();
                if (!string.IsNullOrEmpty(valorCelda))
                {
                    DataRowView selectedItem = null;

                    foreach (DataRowView item in f.cbbEstado.Items)
                    {
                        if (item.Row["IdEstado"].ToString() == valorCelda)
                        {
                            selectedItem = item;
                            break;
                        }
                    }

                    if (selectedItem != null)
                    {
                        f.cbbEstado.SelectedItem = selectedItem;
                    }
                    else
                    {
                        // El valor de la celda no existe en la lista de elementos del ComboBox
                        // Puedes agregar una lógica adicional aquí si es necesario
                    }
                }

               
                

                string valorCelda1 = dtgvPasajeros.CurrentRow.Cells["Departamento"].Value?.ToString();

                if (!string.IsNullOrEmpty(valorCelda1))
                {
                    DataRowView selectedItem = f.cbbDepartamento.Items
                        .OfType<DataRowView>()
                        .FirstOrDefault(item => item.Row["IDDepartamento"].ToString() == valorCelda1);

                    if (selectedItem != null)
                    {
                        f.cbbDepartamento.SelectedItem = selectedItem;
                    }
                    else
                    {
                        // El valor de la celda no existe en la lista de elementos del ComboBox
                        // Puedes agregar una lógica adicional aquí si es necesario
                    }
                }
                string valorCelda2 = dtgvPasajeros.CurrentRow.Cells["Municipio"].Value?.ToString();

                if (!string.IsNullOrEmpty(valorCelda2))
                {
                    DataRowView selectedItem = f.ccbbMunicipio.Items
                        .OfType<DataRowView>()
                        .FirstOrDefault(item => item.Row["IDMunicipio"].ToString() == valorCelda2);

                    if (selectedItem != null)
                    {
                        f.ccbbMunicipio.SelectedItem = selectedItem;
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
                CLS.Pasajeros oclas = new CLS.Pasajeros();
                oclas.IdPasajero = dtgvPasajeros.CurrentRow.Cells["IdPasajero"].Value.ToString().ToLower();
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

        private void dtgvPasajeros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idPasajero = Convert.ToInt32(dtgvPasajeros.Rows[e.RowIndex].Cells["IdPasajero"].Value);
            Seleccionado1?.Invoke(idPasajero);
            Close();
        }
    }
}
