using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.CLS
{
    internal class Usuario
    {
        string _IDUsuarios;
        string _Usuario1;
        string _Clave;
        string _IDRoles;
        string _IDEstado;
       

        public string IDUsuarios { get => _IDUsuarios; set => _IDUsuarios = value; }
        public string Clave { get => _Clave; set => _Clave = value; }
        public string IDRoles { get => _IDRoles; set => _IDRoles = value; }
        public string Usuario1 { get => _Usuario1; set => _Usuario1 = value; }
        public string IDEstado { get => _IDEstado; set => _IDEstado = value; }


        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = $@"INSERT INTO usuarios (Usuario, Clave, IDRoles, IdEstado) 
            VALUES('{_Usuario1}', SHA1(MD5('{_Clave}')), {_IDRoles}, {_IDEstado});";

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

        public Boolean Actualizar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = "UPDATE usuarios " +
                   "SET Usuario = '" + _Usuario1 + "', " +
                   "    Clave = SHA1(MD5('" + _Clave + "')), " +
                   "    IDRoles = " + _IDRoles + ", " +
                   "    IDEstado = " + _IDEstado + " " +
                   "WHERE IDUsuarios = '" + _IDUsuarios + "';";


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
                Sentencia = @"DELETE FROM usuarios WHERE IDUsuarios = 1;";
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