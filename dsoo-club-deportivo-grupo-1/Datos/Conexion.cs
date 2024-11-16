using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;

namespace ClubDeportivo.Datos
{
    public class Conexion
    {
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;

        private Conexion()
        {
            this.baseDatos = "dsoo-club-deportivo-grupo-1";
            bool correcto = false;

            while (!correcto)
            {
                servidor = Interaction.InputBox("Ingrese servidor", "Datos de instalación MySQL", "localhost");
                puerto = Interaction.InputBox("Ingrese puerto", "Datos de instalación MySQL", "3306");
                usuario = Interaction.InputBox("Ingrese usuario", "Datos de instalación MySQL", "root");
                clave = Interaction.InputBox("Ingrese clave", "Datos de instalación MySQL", "");

                if (string.IsNullOrEmpty(servidor) || string.IsNullOrEmpty(puerto) ||
                    string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave))
                {
                    MessageBox.Show("No se ingresaron todos los datos necesarios. El programa se cerrará.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Environment.Exit(0);
                }

                var mensaje = MessageBox.Show($"Servidor: {servidor}\nPuerto: {puerto}\nUsuario: {usuario}\nClave: {clave}",
                    "¿Son correctos estos datos?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (mensaje == DialogResult.Yes)
                {
                    correcto = true;
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese nuevamente los datos.");
                }
            }
        }

        public MySqlConnection CrearConexion()
        {
            MySqlConnection? cadena = new MySqlConnection();
            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                                          ";port=" + this.puerto +
                                          ";username=" + this.usuario +
                                          ";password=" + this.clave +
                                          ";Database=" + this.baseDatos;

                // Intentamos abrir la conexión para verificar que los datos son correctos
                cadena.Open();
            }
            catch (MySqlException ex)
            {
                // Especificar el error que ocurrió en la conexión
                string mensajeError = "Hubo un error al intentar conectarse a la Base de Datos. Detalle del error: ";
                switch (ex.Number)
                {
                    case 1042: // Error de host desconocido
                        mensajeError += "No se pudo encontrar el servidor especificado.";
                        break;
                    case 1045: // Error de autenticación
                        mensajeError += "Credenciales incorrectas (usuario o contraseña).";
                        break;
                    case 0: // Error de conexión (servidor no disponible)
                        mensajeError += "El servidor no está disponible o no puede ser alcanzado.";
                        break;
                    default:
                        mensajeError += ex.Message;
                        break;
                }

                MessageBox.Show(mensajeError, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cadena = null; // En caso de error, la conexión no se establece
            }
            catch (Exception ex)
            {
                // Manejar cualquier otro tipo de error que no sea específico de MySQL
                MessageBox.Show($"Hubo un error inesperado: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cadena = null;
            }

            return cadena;
        }

        public static Conexion getInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }
    }
}
