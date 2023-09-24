using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.CLS
{
    internal class Pasajeros
    {
        String _IdDirecciones;
        String _numeroCasa;
        String _pasajePoligono;
        String _calle;
        String _pais;
        String _departamento;
        String _municipio;
        String _IdPasajero;
        String _NumeroPasaporte;
        String _NombreApellido;
        String _FechaNac;
        String _Correo;
        String _IDEstado;

        public string IdDirecciones { get => _IdDirecciones; set => _IdDirecciones = value; }
        public string NumeroCasa { get => _numeroCasa; set => _numeroCasa = value; }
        public string PasajePoligono { get => _pasajePoligono; set => _pasajePoligono = value; }
        public string Calle { get => _calle; set => _calle = value; }
        public string Pais { get => _pais; set => _pais = value; }
        public string Departamento { get => _departamento; set => _departamento = value; }
        public string Municipio { get => _municipio; set => _municipio = value; }
        public string IdPasajero { get => _IdPasajero; set => _IdPasajero = value; }
        public string NombreApellido { get => _NombreApellido; set => _NombreApellido = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public string IDEstado { get => _IDEstado; set => _IDEstado = value; }
        public string NumeroPasaporte { get => _NumeroPasaporte; set => _NumeroPasaporte = value; }
        public string FechaNac { get => _FechaNac; set => _FechaNac = value; }

        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {


                Sentencia = @" INSERT INTO direcciones( NumeroCasa, PasajePoligono, Calle, Pais, Departamento, Municipio) " +
                              "VALUES ('" + _numeroCasa + "','" + _pasajePoligono + "','" + _calle + "','" + _pais + "','" + _departamento + "','" + _municipio + "');";

                Sentencia = Sentencia + @" SET @idDireccion = LAST_INSERT_ID();";



                Sentencia = Sentencia + @" INSERT INTO pasajero (NumeroPasaporte, NombresyApellido, FechaNac, Correo, IdEstado, IdDirecciones)" +
                             "VALUES ('" + _NumeroPasaporte + "','" + _NombreApellido + "','" + FechaNac + "','" + _Correo + "','" + _IDEstado + "', @idDireccion); ";

                DataManager.DBOperacion Operacion = new DataManager.DBOperacion();
                FilasInsertadas = Operacion.EjecutarSentencia(Sentencia);
                if (FilasInsertadas >= 2)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }

        public Boolean Actualizar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                 Sentencia = "UPDATE pasajero AS p " +
                   "JOIN direcciones AS d ON p.IdDirecciones = d.IdDirecciones " +
                   "SET p.NumeroPasaporte = '" + _NumeroPasaporte + "', " +
                   "p.NombresyApellido = '" + _NombreApellido + "', " +
                   "p.FechaNac = '" + FechaNac + "', " +
                   "p.Correo = '" + _Correo + "', " +
                   "p.IdEstado = '" + _IDEstado + "', " +
                   "d.NumeroCasa = '" + _numeroCasa + "', " +
                   "d.PasajePoligono = '" + _pasajePoligono + "', " +
                   "d.Calle = '" + _calle + "', " +
                   "d.Pais = '" + _pais + "', " +
                   "d.Departamento = '" + _departamento + "', " +
                   "d.Municipio = '" + _municipio + "' " +
                   "WHERE p.IdPasajero = '" + _IdPasajero + "';";


                DataManager.DBOperacion Operacion = new DataManager.DBOperacion();
                FilasInsertadas = Operacion.EjecutarSentencia(Sentencia);
                if (FilasInsertadas > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }
        public Boolean Eliminar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasEliminadas = 0;
            try
            {
                Sentencia = "DELETE p, d FROM pasajero AS p " +
                   "JOIN direcciones AS d ON p.IdDirecciones = d.IdDirecciones " +
                   "WHERE p.IdPasajero = '" + _IdPasajero + "';";

                DataManager.DBOperacion Operacion = new DataManager.DBOperacion();
                FilasEliminadas = Operacion.EjecutarSentencia(Sentencia);
                if (FilasEliminadas > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }


    }
}
