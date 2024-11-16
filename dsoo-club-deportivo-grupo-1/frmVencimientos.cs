using ClubDeportivo.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class frmVencimientos : Form
    {
        public frmVencimientos()
        {
            InitializeComponent(); // Inicializa los componentes del formulario
        }

        private void frmVencimientos_Load(object sender, EventArgs e)
        {
            lblFecha.Text += DateTime.Now.ToString("dd/MM/yyyy"); // Muestra la fecha actual
            CargaGrilla(); // Llama al método para cargar los vencimientos en la grilla
        }

        public void CargaGrilla()
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                // Consulta SQL para obtener socios con cuotas que vencen hoy
                string query = @"
                    SELECT s.NSocio, s.NombreS, s.ApellidoS, s.DocS
                    FROM socio s
                    JOIN cuota c ON s.NSocio = c.idSocio
                    WHERE c.fechaVencimiento = 
                        (SELECT MAX(fechaVencimiento) 
                         FROM cuota 
                         WHERE idSocio = s.NSocio) 
                         AND c.fechaVencimiento = @fechaActual";

                // Obtiene la conexión a la base de datos
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                // Parámetro de fecha actual
                comando.Parameters.AddWithValue("@fechaActual", DateTime.Now.Date);
                sqlCon.Open(); // Abre la conexión

                // Ejecuta la consulta y obtiene los resultados
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    dtgvVencimientos.Rows.Clear(); // Limpia la grilla antes de cargar datos nuevos
                    while (reader.Read())
                    {
                        int renglon = dtgvVencimientos.Rows.Add();
                        dtgvVencimientos.Rows[renglon].Cells[0].Value = reader.GetInt32(0); // NSocio
                        dtgvVencimientos.Rows[renglon].Cells[1].Value = reader.GetString(1); // NombreS
                        dtgvVencimientos.Rows[renglon].Cells[2].Value = reader.GetString(2); // ApellidoS
                        dtgvVencimientos.Rows[renglon].Cells[3].Value = reader.GetInt32(3); // DocS
                    }
                }
                else
                {
                    // Muestra mensaje si no hay datos
                    MessageBox.Show("No hay vencimientos para el día de hoy.", "AVISO DEL SISTEMA",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la carga de datos", MessageBoxButtons.OK, MessageBoxIcon.Error); // Manejo de errores
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close(); // Cierra la conexión
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show(); // Muestra el formulario principal
            this.Hide(); // Oculta el formulario actual
        }
    }
}
