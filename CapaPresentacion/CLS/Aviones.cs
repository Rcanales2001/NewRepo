using CapaPresentacion.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.CLS
{
    internal class Aviones
    {
        string _IdAviones;
        string _Matricula;
        string _Marca;
        string _Modelo;
        string _CapacidadMaxima;
        string _IDEstado;

        public string IdAviones { get => _IdAviones; set => _IdAviones = value; }
        public string Matricula { get => _Matricula; set => _Matricula = value; }
        public string Marca { get => _Marca; set => _Marca = value; }
        public string Modelo { get => _Modelo; set => _Modelo = value; }
        public string CapacidadMaxima { get => _CapacidadMaxima; set => _CapacidadMaxima = value; }
        public string IDEstado { get => _IDEstado; set => _IDEstado = value; }

        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                 Sentencia = $@"INSERT INTO aviones (Matricula, Marca, Modelo, CapacidadMaxima, IdEstado) 
                     VALUES('{_Matricula}', '{_Marca}', '{_Modelo}', '{_CapacidadMaxima}', {_IDEstado});";

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
                Sentencia = $@"UPDATE aviones 
                     SET Matricula = '{_Matricula}', 
                         Marca = '{_Marca}', 
                         Modelo = '{_Modelo}', 
                         CapacidadMaxima = '{_CapacidadMaxima}', 
                         IdEstado = {_IDEstado}
                     WHERE IdAviones = {_IdAviones};";


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
                Sentencia = $@"DELETE FROM aviones WHERE IdAviones = {_IdAviones};";

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
