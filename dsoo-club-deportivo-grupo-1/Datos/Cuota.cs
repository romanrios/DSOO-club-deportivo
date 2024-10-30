using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    internal class Cuota
    {
        public string RegistrarPago(int idSocio, float monto, DateTime fechaPago)
        {
            string? resultado;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string query = "INSERT INTO cuota (idSocio, monto, fechaPago) VALUES (@idSocio, @monto, @fechaPago)";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.Parameters.AddWithValue("@idSocio", idSocio);
                comando.Parameters.AddWithValue("@monto", monto);
                comando.Parameters.AddWithValue("@fechaPago", fechaPago);

                sqlCon.Open();
                int filasAfectadas = comando.ExecuteNonQuery();

                resultado = filasAfectadas > 0 ? "Pago registrado correctamente" : "No se pudo registrar el pago";
            }
            catch (Exception ex)
            {
                resultado = "Error: " + ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return resultado;
        }
    }
}
