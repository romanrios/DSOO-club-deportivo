using ClubDeportivo.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class frmCarnet : Form
    {
        public frmCarnet()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                MessageBox.Show("Debe ingresar un número", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    sqlCon.Open();

                    // Validación para verificar si el carnet ya fue entregado
                    string consultaValidacion = @"SELECT carnetEmitido FROM socio WHERE NSocio = @NSocio";
                    using (MySqlCommand cmdValidacion = new MySqlCommand(consultaValidacion, sqlCon))
                    {
                        cmdValidacion.Parameters.AddWithValue("@NSocio", Convert.ToInt32(txtNumero.Text));

                        // Ejecuta la consulta y valida el resultado
                        object resultado = cmdValidacion.ExecuteScalar();
                        if (resultado == null)
                        {
                            MessageBox.Show("El número de socio no existe.", "AVISO DEL SISTEMA",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        int carnetEntregado = Convert.ToInt32(resultado);
                        if (carnetEntregado == 1)
                        {
                            MessageBox.Show("El Socio ya posee Carnet", "AVISO DEL SISTEMA",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    // Actualización de carnetEmitido a 1
                    string query = "UPDATE socio SET carnetEmitido = 1, nroCarnet = @NSocio WHERE NSocio = @NSocio";
                    using (MySqlCommand comando = new MySqlCommand(query, sqlCon))
                    {
                        comando.Parameters.AddWithValue("@NSocio", Convert.ToInt32(txtNumero.Text));
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Carnet entregado con éxito", "AVISO DEL SISTEMA",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el registro. Verifique los datos.", "AVISO DEL SISTEMA",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "MENSAJE DEL CATCH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
