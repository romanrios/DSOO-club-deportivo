using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ClubDeportivo.Datos
{
    internal class Clientes
    {
        // Método para agregar un nuevo socio
        public string Registrar(E_Socio socio)
        {
            return AgregarCliente("NuevoSocio", socio.Nombre, socio.Apellido, socio.Estado,
                                  socio.DNI, socio.FechaNac, socio.FechaInsc, socio.EntregoAptoFisico);
        }

        // Sobrecarga de método: el método "Registrar" puede recibir como parámetro un 
        // objeto E_Socio o E_NoSocio. El sistema elige cuál ejecutar en tiempo de 
        // compilación según el tipo de objeto pasado, permitiendo manejar ambos tipos de cliente.
        public string Registrar(E_NoSocio noSocio)
        {
            return AgregarCliente("NuevoNoSocio", noSocio.Nombre, noSocio.Apellido, null,
                                  noSocio.DNI, noSocio.FechaNac, noSocio.FechaInsc, noSocio.EntregoAptoFisico);
        }

        // Método privado común para manejar la lógica de inserción
        private string AgregarCliente(string procedimiento, string nombre, string apellido,
                                      string? estado, int dni, DateTime fechaNac,
                                      DateTime fechaInsc, bool entregoAptoFisico)
        {
            string? salida;
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand(procedimiento, sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Añadir los parámetros comunes
                comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value = nombre;
                comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value = apellido;
                comando.Parameters.Add("Doc", MySqlDbType.Int32).Value = dni;
                comando.Parameters.Add("Fec", MySqlDbType.DateTime).Value = fechaNac;
                comando.Parameters.Add("FecI", MySqlDbType.DateTime).Value = fechaInsc;
                comando.Parameters.Add("EAF", MySqlDbType.Bit).Value = entregoAptoFisico;

                // Añadir el parámetro "Tip" solo si el estado es válido (para los socios)
                if (estado != null)
                {
                    comando.Parameters.Add("Tip", MySqlDbType.VarChar).Value = estado;
                }

                // Parámetro de salida
                MySqlParameter ParCodigo = new MySqlParameter
                {
                    ParameterName = "rta",
                    MySqlDbType = MySqlDbType.Int32,
                    Direction = ParameterDirection.Output
                };
                comando.Parameters.Add(ParCodigo);

                // Ejecutar el procedimiento
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }

            return salida;
        }
    }
}
