using ClubDeportivo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ClubDeportivo
{
    public partial class frmInscripcionNS : Form
    {
        public frmInscripcionNS()
        {
            InitializeComponent();
        }
        /* -------------------------------
        * permite retornar al formulario PRINCIPAL
        * ------------------------------------------------------ */
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }


        /* ===================================================
        * Limpiamos los objetos para un nuevo ingreso
        * ================================================ */
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDNI.Text = "";
            txtNombre.Focus();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDNI.Text == "")
            {
                MessageBox.Show("Debe completar datos requeridos (*)", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string respuesta;
                E_NoSocio noSocio = new E_NoSocio();
                noSocio.Nombre = txtNombre.Text;
                noSocio.Apellido = txtApellido.Text;
                noSocio.DNI = Convert.ToInt32(txtDNI.Text);
                noSocio.FechaNac = dtpFechaDeNacimiento.Value;
                noSocio.FechaInsc = dtpFechaDeInscripcion.Value;
                noSocio.EntregoAptoFisico = chkEntregoAptoFisico.Checked;



                Datos.Clientes datosNoSocios = new Datos.Clientes();
                respuesta = datosNoSocios.Registrar(noSocio);
                bool esnumero = int.TryParse(respuesta, out int codigo);
                if (esnumero)
                {
                    if (codigo == 1)
                    {
                        MessageBox.Show("NO SOCIO YA EXISTE", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Se almacenó con éxito con el código Nro " + respuesta, "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es un número o una tecla de control (como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Si no es un número, cancela la entrada
            }
        }

        // Esto es para fijar la fecha de inscripción al día actual 
        private void frmInscripcionNS_Load(object sender, EventArgs e)
        {
            dtpFechaDeInscripcion.Value = DateTime.Now;
            dtpFechaDeInscripcion.Enabled = false;

        }
    }
}
