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





                // Validación para verificar si el pago ya fue realizado este mes
                string consultaValidacion = @"SELECT COUNT(*) FROM cuota 
                                      WHERE idSocio = @idSocio 
                                      AND MONTH(fechaPago) = @mes 
                                      AND YEAR(fechaPago) = @anio";

                MySqlCommand cmdValidacion = new MySqlCommand(consultaValidacion, sqlCon);
                cmdValidacion.Parameters.AddWithValue("@idSocio", Convert.ToInt32(txtNro.Text));
                cmdValidacion.Parameters.AddWithValue("@mes", DateTime.Now.Month);
                cmdValidacion.Parameters.AddWithValue("@anio", DateTime.Now.Year);

                int pagosEsteMes = Convert.ToInt32(cmdValidacion.ExecuteScalar());

                if (pagosEsteMes > 0)
                {
                    MessageBox.Show("Cuota ya abonada este mes", "AVISO DEL SISTEMA",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }










                /*
                --------------------------------------------------------
                Consulta simple que proyecta los datos necesarios
                para rellenar el documento.
                En este caso se trata del comprobante de pago del curso.
                --------------------------------------------------------
                */

                //query = ("select idinscri, nombre, concat(nombrep, ' ', apellidop), precio, e.fecha " +
                //        "from inscripcion i " +
                //        "inner join edicion e on i.idEdicion = e.idEdicion " +
                //        "inner join curso c on c.ncurso = e.ncurso " +
                //        "inner join alumno a on a.legajo = i.legajo " +
                //        "inner join socio p on p.NSocio = a.NSocio " +
                //        "where idinscri = " + txtNro.Text);



                string query = ("select NSocio, concat(NombreS, ' ', ApellidoS), DocS, FechaInsc " +
                        "from socio " +
                        "where NSocio = " + txtNro.Text);


                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;

                MySqlDataReader reader = comando.ExecuteReader();

                 if (reader.HasRows)
                {
                    reader.Read(); // Sabemos que es solo una fila

                    //doc.numero_f = Convert.ToInt32(reader.GetString(0));
                    //doc.curso_f = reader.GetString(1);
                    //doc.socio_f = reader.GetString(2);
                    //doc.monto_f = (float)Convert.ToDouble(reader.GetString(3));
                    //doc.fecha_f = (DateTime)Convert.ToDateTime(reader.GetString(4));

                    doc.numero_f = reader.GetInt32(0);
                    doc.socio_f = Convert.ToString(reader.GetString(1));
                    doc.curso_f = Convert.ToString(reader.GetInt32(2));
                    doc.fecha_f = reader.GetDateTime(3);
                    doc.monto_f = 25000;


                    if (rbtEfectivo.Checked == true) // Evaluamos la opción seleccionada
                    {
                        doc.forma_f = "Efectivo";
                        // Pago en efectivo se descuenta 10%
                        doc.monto_f = (float)(doc.monto_f * 0.90);
                    }
                    else
                    {
                        doc.forma_f = "Tarjeta";
                    }

                    btnComprobante.Enabled = true;

                    // Crear el objeto Cuota y registrar el pago
                    Cuota cuota = new Cuota();
                    string resultado = cuota.RegistrarPago(doc.numero_f, doc.monto_f, DateTime.Now);


                    MessageBox.Show("Pago exitoso", "AVISO DEL SISTEMA",
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
