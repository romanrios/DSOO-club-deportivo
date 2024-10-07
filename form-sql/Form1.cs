using DiseñoLogin.Datos;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using static System.Runtime.InteropServices.JavaScript.JSType;

using System.Data;
namespace DiseñoLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            /* este evento se ejecuta cuando llega el foco */
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
            }
        }
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            /* este evento se ejecuta cuando se va el foco */
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
            }
        }
        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
            }
        }
        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.UseSystemPasswordChar = false;
            }
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable(); // es la que recibe los datos desde el formulario
            Datos.Usuarios dato = new Datos.Usuarios(); // variable que contiene todas las caracteristicas de la clase
            tablaLogin = dato.Log_Usu(txtUsuario.Text, txtPass.Text);
            if (tablaLogin.Rows.Count > 0)
            {
                MessageBox.Show("Ingreso exitoso", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmPrincipal Principal = new frmPrincipal();
                Principal.rol = Convert.ToString(tablaLogin.Rows[0][0]);
                Principal.usuario = Convert.ToString(txtUsuario.Text);

                // Llama al método para actualizar el Label
                Principal.frmPrincipal_Load();

                Principal.Show(); // se llama al formulario principal
                this.Hide(); // se oculta el formulario del login
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto");
            }
        }


        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
