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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        /* ___________ VARIABLES tipo INTERNAL __________________________________
        * Serán accesibles desde el ensamblado en el cual están declarados
        * y tampoco se pueden utilizar en el interior de una función.
        ____________________________________________________________________ */
        internal string? rol;
        internal string? usuario;
        public void frmPrincipal_Load()
        {
            lblIngreso.Text = "USUARIO: " + usuario + " " + "(" + rol + ")";
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            /* Notifica a todos los surtidores de mensajes que deben terminar
            * y, a continuación, cierra todas las ventanas de la aplicación
            * ________________________________________________________________ */
            Application.Exit();
        }
        private void btnRegistrarSocio_Click(object sender, EventArgs e)
        {
            frmInscripcion inscripcion = new frmInscripcion();
            inscripcion.Show();
            this.Hide();
        }

        private void btnRegistrarNoSocio_Click(object sender, EventArgs e)
        {
            frmInscripcionNS inscripcion = new frmInscripcionNS();
            inscripcion.Show();
            this.Hide();
        }

        private void btnPagoCuota_Click(object sender, EventArgs e)
        {
            frmPagar frmPagar = new frmPagar();
            frmPagar.Show();
            this.Hide();
        }

        private void btnListarVencimientosHoy_Click(object sender, EventArgs e)
        {
            frmVencimientos vencimientos = new frmVencimientos();
            vencimientos.Show();
            this.Hide();
        }

        private void btnEntregarCarnet_Click(object sender, EventArgs e)
        {
            frmCarnet carnet = new frmCarnet();
            carnet.Show();
            this.Hide();
        }
    }
}
