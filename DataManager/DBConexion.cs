using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataManager
{
    public class DBConexion
    {
        String _CadenaConexion = "Server=localhost;Port=3306;Database=sistemavuelo;Uid=root;Pwd=roberto1;AllowUserVariables=True;";
        protected MySqlConnection _CONEXION = new MySqlConnection();


        public Boolean Conectar()
        {
            Boolean result = false;
            try
            {
                _CONEXION.ConnectionString = _CadenaConexion;
                _CONEXION.Open();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public void Desconectar()
        {
            try
            {
                if (_CONEXION.State == System.Data.ConnectionState.Open)
                {
                    _CONEXION.Close();
                }
            }
            catch (Exception)
            {

            }
        }

    }
}