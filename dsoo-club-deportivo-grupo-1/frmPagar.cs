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
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
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



                query = ("select NSocio, concat(NombreP, ' ', ApellidoP), DocP, FechaInsc " +
                        "from socio " +
                        "where NSocio = " + txtNro.Text);


                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

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
