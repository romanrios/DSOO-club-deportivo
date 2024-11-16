using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;

namespace ClubDeportivo.Datos
{
    public class Conexion // La clase debe ser pública
    {
        // Declaración de variables
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;

        private Conexion() // Asignamos valores a las variables de la conexión
        {
            // Asigna el nombre de la base de datos
            this.baseDatos = "dsoo-club-deportivo-grupo-1";
            bool correcto = false;

            while (!correcto)
            {
                // Solicitar al usuario los datos de conexión, con valores predeterminados
                servidor = Interaction.InputBox("Ingrese servidor", "Datos de instalación MySQL", "localhost");
                puerto = Interaction.InputBox("Ingrese puerto", "Datos de instalación MySQL", "3306");
                usuario = Interaction.InputBox("Ingrese usuario", "Datos de instalación MySQL", "root");
                clave = Interaction.InputBox("Ingrese clave", "Datos de instalación MySQL", "");

                // Si el usuario cancela alguno de los cuadros de diálogo, salir del ciclo
                if (string.IsNullOrEmpty(servidor) || string.IsNullOrEmpty(puerto) ||
                    string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave))
                {
                    MessageBox.Show("No se ingresaron todos los datos necesarios. El programa se cerrará.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Environment.Exit(0); // Cierra el programa
                }

                // Confirmar los datos ingresados
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

        // Proceso de conexión
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la conexión: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cadena = null;
            }
            return cadena;
        }

        // Método para evaluar la instancia de la conexión
        public static Conexion getInstancia()
        {
            if (con == null) // Verifica si la conexión está cerrada
            {
                con = new Conexion(); // Crea una nueva instancia
            }
            return con;
        }
    }
}
