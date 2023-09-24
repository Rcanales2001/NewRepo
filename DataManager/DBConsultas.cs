using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    public static class DBConsultas
    {
        public static DataTable VALIDAR_USUARIO(String pUsuario, String pClave)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT 
            a.IDUsuarios, a.Usuario, a.IdEstado, a.IDRoles, c.Rol, e.IdEstado 
            FROM usuarios a, roles c, estado e
            WHERE a.Usuario='" + pUsuario + @"' 
            AND a.Clave=SHA1(MD5('" + pClave + @"')) 
            AND a.IdEstado = e.IdEstado
            AND a.IDRoles = c.IDRoles
            AND e.IdEstado = 1;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }

            return Resultado;
        }
        public static DataTable DISPONIBLE(DateTime fechaSeleccionada, int idAvion)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT COUNT(*) FROM ticker WHERE FechaVuelo ='" + fechaSeleccionada + @"' AND IdAviones = " + idAvion + @" ;";

            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }

            return Resultado;
        }

        public static DataTable CapacidadAvion(int idAvion)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT CapacidadMaxima FROM aviones WHERE IdAviones = " + idAvion + @" ;";

            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }

            return Resultado;
        }
        public static DataTable ObtenerDisponibilidadAsientos(int idAvion, DateTime fechaSeleccionada)
        {
            DataTable Resultado = new DataTable();

            String Sentencia = @"
            SELECT (SELECT CapacidadMaxima FROM aviones WHERE IdAviones = " + idAvion + @") - COUNT(*) AS Disponibilidad
            FROM ticker 
            WHERE IdAviones = " + idAvion + @"
            AND FechaVuelo = '" + fechaSeleccionada + @"' ;";


            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }

            return Resultado;
        
         }


        public static DataTable ObtenerDisponibilidadAvion(DateTime fechaSeleccionada, int idAvion)
        {
            DataTable Resultado = new DataTable();

            String SentenciaDisponibilidad = @"
        SELECT COUNT(*) AS Disponibilidad
        FROM ticker 
        WHERE FechaVuelo = '" + fechaSeleccionada + @"'
        AND IdAviones = " + idAvion + @" ;";

            String SentenciaCapacidad = @"
        SELECT CapacidadMaxima
        FROM aviones 
        WHERE IdAviones = " + idAvion + @" ;";

            DBOperacion Consultor = new DBOperacion();
            try
            {
                DataTable Disponibilidad = Consultor.Consultar(SentenciaDisponibilidad);
                DataTable Capacidad = Consultor.Consultar(SentenciaCapacidad);

                // Combinar los resultados en una sola tabla
                Resultado.Columns.Add("Disponibilidad", typeof(int));
                Resultado.Columns.Add("CapacidadMaxima", typeof(int));

                int disponibilidad = Convert.ToInt32(Disponibilidad.Rows[0]["Disponibilidad"]);
                int capacidad = Convert.ToInt32(Capacidad.Rows[0]["CapacidadMaxima"]);

                Resultado.Rows.Add(disponibilidad, capacidad);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }

            return Resultado;
        }

        public static DataTable CapacidadMaximaAvion(int idAvion)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT CapacidadMaxima FROM aviones WHERE IdAviones = " + idAvion + @" ;";

            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }

            return Resultado;
        }

        public static DataTable Departamento1()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT IDDepartamento, NombreDepartamento FROM departamento;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }
        public static DataTable Municipio1(String pIDDepartamento)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT IDMunicipio, NombreMunicipio FROM municipio Where IDDepartamento='" + pIDDepartamento + @"';";

            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }
        public static DataTable Estado1()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT IdEstado, Estado FROM estado;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable ROLES()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT IDRoles, Rol FROM roles;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }
        public static DataTable CLASIFIACIONES()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT IDClasificaciones, Clasificaciones FROM clasificaciones;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable PERMISO(string pIDRol)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT a.IDOpciones,a.Opcion,a.IDClasificaciones, b.Clasificaciones,
            IFNULL((SELECT IDPermisos FROM permisos z 
            where z.IDRoles=" + pIDRol + @" AND z.IDOpciones=a.IDOpciones),0)IDPermisos,
            if(IFNULL((SELECT IDPermisos FROM permisos z where z.IDRoles=" + pIDRol + @" AND 
            z.IDOpciones=a.IDOpciones),0)>0,1,0)Asignado
            FROM opciones a, clasificaciones b
            Where a.IDClasificaciones =b.IDClasificaciones;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }
        public static DataTable USERS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT roles.IDRoles,roles.Rol,usuarios.* FROM usuarios
            JOIN roles ON usuarios.IDRoles = roles.IDRoles;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }
        public static DataTable AVIONESS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT IdAviones, Matricula, Marca, Modelo, CapacidadMaxima, IdEstado FROM sistemavuelo.aviones;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }
        public static DataTable PASAJEROS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT p.IdPasajero, p.NumeroPasaporte, p.NombresyApellido, p.Correo, p.FechaNac, p.IdEstado, d.*,
            CONCAT(d.NumeroCasa, ' ', d.PasajePoligono, ' ', d.Calle, ', ', d.Municipio, ', ', d.Departamento, ', ', d.Pais) as DireccionCompleta
            FROM sistemavuelo.pasajero p
            JOIN sistemavuelo.direcciones d ON p.IdDirecciones = d.IdDirecciones;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }
        public static DataTable RESERVA()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT IdTicker, NumeroTicker, Origen, Destino, FechaVuelo, IdPasajero, IdAviones
            FROM sistemavuelo.ticker;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

    }
}
