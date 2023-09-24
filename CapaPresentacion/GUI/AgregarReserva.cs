using DataManager;
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
    public partial class AgregarReserva : Form
    {
        public int IdAviones { get; set; }
        public int IdPasajero { get; set; }
        private void FrmSeleccionado(int idAviones)
        {
            // Asignar los valores a las propiedades del formulario GenerarPedido
            IdAviones = idAviones;


            // Asignar los valores a los TextBox del formulario GenerarPedido
            txAvion.Text = IdAviones.ToString();

        }
        private void FrmSeleccionado1(int idPasajero)
        {
            // Asignar los valores a las propiedades del formulario GenerarPedido
            IdPasajero = idPasajero;


            // Asignar los valores a los TextBox del formulario GenerarPedido
            txPasaj.Text = IdPasajero.ToString();

        }
        public AgregarReserva()
        {
            InitializeComponent();
            fechatxt.ValueChanged += fechatxt_ValueChanged;


        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbnumeroR.Text = "";
            txbdestino.Text = "";
            txborigen.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Aviones frmAviones = new Aviones();

            // Suscribir al evento ClienteSeleccionado para recibir los datos del cliente
            frmAviones.Seleccionado += FrmSeleccionado;

            // Mostrar el formulario FrmClientes
            frmAviones.ShowDialog();
        }
        // Suponiendo que este es el método donde se realiza la consulta y se obtiene el resultado
       
        private void button1_Click(object sender, EventArgs e)
        {
            Pasajeros frmPasajeros = new Pasajeros();

            // Suscribir al evento ClienteSeleccionado para recibir los datos del cliente
            frmPasajeros.Seleccionado1 += FrmSeleccionado1;

            // Mostrar el formulario FrmClientes
            frmPasajeros.ShowDialog();
        }

        private void AgregarReserva_Load(object sender, EventArgs e)
        {
            
        }

        private void fechatxt_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = fechatxt.Value;
            int idAvion = IdAviones; // Usa la propiedad IdAviones
            MostrarDisponibilidad(idAvion);
            CalcularDisponibilidad(idAvion, fechaSeleccionada);
        }
        private void CalcularDisponibilidad(int idAvion, DateTime fechaSeleccionada)
        {
            DataTable disponibilidadTable1 = DBConsultas.ObtenerDisponibilidadAsientos(idAvion, fechaSeleccionada);

            // Agrega un punto de depuración aquí para verificar el contenido de disponibilidadTable1

            if (disponibilidadTable1.Rows.Count > 0)
            {
                int disponibilidad1 = Convert.ToInt32(disponibilidadTable1.Rows[0]["Disponibilidad"]);

                // Agrega un punto de depuración aquí para verificar disponibilidad1

                txbAsientos.Text = disponibilidad1.ToString();
            }
            else
            {
                txbAsientos.Text = "0";
            }
        }


        private void MostrarDisponibilidad(int idAvion)
        {
            DataTable disponibilidadTable = DBConsultas.CapacidadMaximaAvion(idAvion);

            if (disponibilidadTable.Rows.Count > 0)
            {
                int disponibilidad = Convert.ToInt32(disponibilidadTable.Rows[0]["CapacidadMaxima"]);
                txbAsi.Text = disponibilidad.ToString();
            }
            else
            {
                txbAsi.Text = "0";
            }
        }

    }
}
