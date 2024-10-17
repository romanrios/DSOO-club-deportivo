﻿using ClubDeportivo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ClubDeportivo
{
    public partial class frmFactura : Form
    {
        public frmFactura()
        {
            InitializeComponent();
        }
        /*________________________________________________________
        * Variables para traer LOS DATOS del formulario
        * donde se ejecuta la lógica
        * ------------------------------------------------------
        */
        public string? socio_f;
        public string? curso_f;
        public string? pago_f;
        public float monto_f;
        public int numero_f;
        public DateTime fecha_f;
        public string? forma_f;
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            /* -----------------------------------------------------
            * Ocultamos los botones que no pertenecen al diseño
            * pero si para la funcionalidad
            * Usamos la propiedad VISIBLE y los posibles
            * valores son True o False
            * ----------------------------------------------------
            */
            btnImprimir.Visible = false;
            /* ---------------------------------------
            * creamos los objetos para la impresion
            * ------------------------------------------
            */
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);

            //pd.Print();
            // Usar PrintDialog para seleccionar la impresora
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
                MessageBox.Show("Solicitud de impresión exitosa", "AVISO DEL SISTEMA",
           MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Impresión cancelada", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            btnImprimir.Visible = true; // visualizamos nuevamente el objeto
            /* _________________________________
            * regreso al formulario principal
            * después del dar aviso
            * ----------------------------------
            */

            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Close();
        }
        /* -------------------------------------------------------
        * Conjunto de sentencias necesarias para
        * el objeto Print
        * ------------------------------------------------------- */
        private void ImprimirForm1(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }
        private void frmFactura_Load(object sender, EventArgs e)
        {
            /* ----------------------------------------
            * asignación de los valores a los datos
            * que muestra cada etiqueta del diseño
            * del comprobante de pago
            * --------------------------------------------- */
            lblSocio.Text = socio_f;
            lblCurso.Text = curso_f;
            lblDia.Text = Convert.ToString(fecha_f);
            lblValor.Text = Convert.ToString(monto_f);
            lblFPago.Text = forma_f;
            // se obtiene la fecha actual
            lblDfecha.Text = DateTime.UtcNow.ToShortDateString();
        }
    }
}