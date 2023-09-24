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
    public partial class Reserva : Form
    {
        BindingSource _DATOS1 = new BindingSource();
        private void CargarDatos()
        {
            try
            {
                _DATOS1.DataSource = DataManager.DBConsultas.RESERVA();
                dtgvReserva.AutoGenerateColumns = false;
                dtgvReserva.DataSource = _DATOS1;
                lblRegistros.Text = dtgvReserva.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }
        public Reserva()
        {
            InitializeComponent();
        }

        private void Reserva_Load(object sender, EventArgs e)
        {
            dtgvReserva.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            CargarDatos();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AgregarReserva f = new AgregarReserva();
            f.ShowDialog();
            CargarDatos();
        }
    }
}
