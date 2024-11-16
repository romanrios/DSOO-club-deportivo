using ClubDeportivo;
using ClubDeportivo.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class frmPagar : Form
    {
        public frmFactura doc = new frmFactura();

        public frmPagar()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            doc.Show();
            this.Hide();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNro.Text))
            {
                MessageBox.Show("Debe seleccionar un N° de Socio", "AVISO DEL SISTEMA",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!rbtEfectivo.Checked && !rbtTarjeta.Checked)
            {
                MessageBox.Show("Debe seleccionar una forma de pago", "AVISO DEL SISTEMA",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();

                // Consulta para obtener la fecha de vencimiento más reciente de las cuotas del socio
                string consultaFechaVencimiento = @"SELECT MAX(c.fechaVencimiento) 
                                                    FROM cuota c 
                                                    WHERE c.idSocio = @idSocio";

                MySqlCommand cmdFechaVencimiento = new MySqlCommand(consultaFechaVencimiento, sqlCon);
                cmdFechaVencimiento.Parameters.AddWithValue("@idSocio", Convert.ToInt32(txtNro.Text));

                object? resultFechaVencimiento = cmdFechaVencimiento.ExecuteScalar();

                if (resultFechaVencimiento != DBNull.Value && resultFechaVencimiento != null)
                {
                    DateTime fechaVencimientoUltimaCuota = Convert.ToDateTime(resultFechaVencimiento);

                    // Comprobamos si la fecha de vencimiento más reciente es posterior a la fecha actual
                    if (fechaVencimientoUltimaCuota > DateTime.Now)
                    {
                        MessageBox.Show("Cuota ya abonada este mes", "AVISO DEL SISTEMA",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                // Consulta para obtener los datos del socio
                string query = @"SELECT NSocio, CONCAT(NombreS, ' ', ApellidoS), DocS, FechaInsc 
                                 FROM socio 
                                 WHERE NSocio = @idSocio";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.Parameters.AddWithValue("@idSocio", Convert.ToInt32(txtNro.Text));
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    doc.numero_f = reader.GetInt32(0);
                    doc.socio_f = reader.GetString(1);
                    doc.curso_f = reader.GetInt32(2).ToString();
                    doc.fecha_f = reader.GetDateTime(3);
                    doc.monto_f = 25000;

                    if (rbtEfectivo.Checked)
                    {
                        doc.forma_f = "Efectivo";
                        doc.monto_f *= 0.90f; // Descuento del 10% para efectivo
                    }
                    else
                    {
                        doc.forma_f = "Tarjeta";
                    }

                    btnComprobante.Enabled = true;

                    // Crear el objeto Cuota y registrar el pago
                    Cuota cuota = new Cuota();
                    string resultado = cuota.RegistrarPago(doc.numero_f, doc.monto_f, DateTime.Now, doc.forma_f);

                    MessageBox.Show(resultado, "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Número de inscripción inexistente", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE DEL CATCH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
    }
}
