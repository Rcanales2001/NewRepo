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
    public partial class AgregarPasajero : Form
    {
        private void CargarDepartamento()
        {

            DataTable departamento = new DataTable();
            try
            {
                departamento = DataManager.DBConsultas.Departamento1();
                DataRow fila = departamento.NewRow();
                fila["NombreDepartamento"] = "Seleccionar un Departamento";
                departamento.Rows.InsertAt(fila, 0);
                cbbDepartamento.DataSource = departamento;
                cbbDepartamento.ValueMember = "IDDepartamento";
                cbbDepartamento.DisplayMember = "NombreDepartamento";

            }
            catch (Exception e)
            {
                Debug.WriteLine("Error: " + e);
            }
        }
       
        private void CargarEstado()
        {
            DataTable estados = DataManager.DBConsultas.Estado1();
            DataRow fila = estados.NewRow();
            fila["Estado"] = "Seleccionar un Estado";
            estados.Rows.InsertAt(fila, 0);
            cbbEstado.DataSource = estados;
            cbbEstado.ValueMember = "IdEstado";
            cbbEstado.DisplayMember = "Estado";

        }

        public AgregarPasajero()
        {
            InitializeComponent();
            CargarDepartamento();
            CargarEstado();
        }
        private void CargarMunicipio(String pIDDepartamento)
        {

            DataTable municipio = new DataTable();
            try
            {
                municipio = DataManager.DBConsultas.Municipio1(pIDDepartamento);
                DataRow dr = municipio.NewRow();
                dr["NombreMunicipio"] = "Seleccionar un Municipio";
                municipio.Rows.InsertAt(dr, 0);

                ccbbMunicipio.DataSource = municipio;
                ccbbMunicipio.ValueMember = "IDMunicipio";
                ccbbMunicipio.DisplayMember = "NombreMunicipio";

            }
            catch (Exception e)
            {
                Debug.WriteLine("Error: " + e);
            }
        }
        private string ObtenerNombreDepartamento(int idDepartamento)
        {
            DataTable departamentoTable = DataManager.DBConsultas.Departamento1();
            DataRow[] rows = departamentoTable.Select("IDDepartamento = " + idDepartamento);

            if (rows.Length > 0)
            {
                return rows[0]["NombreDepartamento"].ToString();
            }

            return string.Empty;
        }

        private string ObtenerNombreMunicipio(int idMunicipio, string pIDDepartamento)
        {
            DataTable municipioTable = DataManager.DBConsultas.Municipio1(pIDDepartamento);
            DataRow[] rows = municipioTable.Select("IDMunicipio = " + idMunicipio);

            if (rows.Length > 0)
            {
                return rows[0]["NombreMunicipio"].ToString();
            }

            return string.Empty;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbnumeroc.Text = "";
            txbpasaje.Text = "";
            txbCalle.Text = "";
            txbPais.Text = "";
            txtNomApe.Text = "";
            txtCorreo.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DateTime fechaCliente = DateTime.Parse(fechatxt.Text);
            string fechaTexto = fechaCliente.ToString("yyyy-MM-dd");

            int idEstado = Convert.ToInt32(cbbEstado.SelectedValue);
            CLS.Pasajeros oclas = new CLS.Pasajeros();
            // Datos para la dirección
            oclas.NumeroCasa = txbnumeroc.Text;
            oclas.PasajePoligono = txbpasaje.Text;
            oclas.Calle = txbCalle.Text;
            oclas.Pais = txbPais.Text;
            DataRowView dataCbbDepartamento = (DataRowView)cbbDepartamento.SelectedItem;
            int idDepartamento = Convert.ToInt32(dataCbbDepartamento.Row.ItemArray[0]);
            string pIDDepartamento = dataCbbDepartamento.Row.ItemArray[0].ToString();

            DataRowView dataCcbbMunicipio = (DataRowView)ccbbMunicipio.SelectedItem;
            int idMunicipio = Convert.ToInt32(dataCcbbMunicipio.Row.ItemArray[0]);

            string nombreDepartamento = ObtenerNombreDepartamento(idDepartamento);
            string nombreMunicipio = ObtenerNombreMunicipio(idMunicipio, pIDDepartamento);

            oclas.Departamento = nombreDepartamento;
            oclas.Municipio = nombreMunicipio;

            oclas.IdDirecciones = txbIdDi.Text;

            // Datos para el pasajero
            oclas.IdPasajero = txbIdPasajero.Text;
            oclas.NombreApellido = txtNomApe.Text;
            oclas.NumeroPasaporte = txbnump.Text;
            oclas.Correo = txtCorreo.Text;
            oclas.FechaNac = fechaTexto;
            oclas.IDEstado = idEstado.ToString();

            //oclas.IdDirecciones = (int)command.LastInsertedId;
            if (txbIdPasajero.TextLength > 0)
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

        private void cbbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDepartamento.SelectedValue.ToString() != null)
            {
                String pIDDepartamento = cbbDepartamento.SelectedValue.ToString();
                CargarMunicipio(pIDDepartamento);
            }
        }
    }
}
