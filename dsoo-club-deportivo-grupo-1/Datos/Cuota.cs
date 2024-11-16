using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ClubDeportivo.Datos
{
    internal class Cuota
    {
        public string RegistrarPago(int idSocio, float monto, DateTime fechaPago, string formaDePago)
        {
            string? resultado;
            DateTime fechaVencimiento = fechaPago.AddDays(30);
            int nroCuota = 1;
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                // Consulta para obtener el último número de cuota
                string queryCuota = "SELECT MAX(nroCuota) FROM cuota WHERE idSocio = @idSocio";
                MySqlCommand cmdCuota = new MySqlCommand(queryCuota, sqlCon);
                cmdCuota.Parameters.AddWithValue("@idSocio", idSocio);

                sqlCon.Open();
                object? result = cmdCuota.ExecuteScalar();

                // Si existe un número de cuota, lo incrementamos; de lo contrario, nroCuota sigue siendo 1
                if (result != DBNull.Value && result != null)
                {
                    nroCuota = Convert.ToInt32(result) + 1;
                }

                // Insertar el nuevo pago con el número de cuota actualizado
                string queryInsert = "INSERT INTO cuota (idSocio, nroCuota, monto, fechaPago, formaDePago, fechaVencimiento) " +
                                     "VALUES (@idSocio, @nroCuota, @monto, @fechaPago, @formaDePago, @fechaVencimiento)";

                MySqlCommand comando = new MySqlCommand(queryInsert, sqlCon);
                comando.Parameters.AddWithValue("@idSocio", idSocio);
                comando.Parameters.AddWithValue("@nroCuota", nroCuota);
                comando.Parameters.AddWithValue("@monto", monto);
                comando.Parameters.AddWithValue("@fechaPago", fechaPago);
                comando.Parameters.AddWithValue("@formaDePago", formaDePago);
                comando.Parameters.AddWithValue("@fechaVencimiento", fechaVencimiento);

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
