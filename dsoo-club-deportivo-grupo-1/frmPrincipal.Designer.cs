namespace DiseñoLogin
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblIngreso = new Label();
            btnSalir = new Button();
            btnRegistrarSocio = new Button();
            btnRegistrarNoSocio = new Button();
            btnPagoCuota = new Button();
            btnListarVencimientosHoy = new Button();
            btnEntregarCarnet = new Button();
            SuspendLayout();
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(85, 33);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(283, 15);
            lblIngreso.TabIndex = 0;
            lblIngreso.Text = "Bienvenido al Sistema de Gestión del Club Deportivo";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.LightCoral;
            btnSalir.Location = new Point(234, 255);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(178, 67);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnRegistrarSocio
            // 
            btnRegistrarSocio.Location = new Point(36, 78);
            btnRegistrarSocio.Name = "btnRegistrarSocio";
            btnRegistrarSocio.Size = new Size(178, 67);
            btnRegistrarSocio.TabIndex = 0;
            btnRegistrarSocio.Text = "REGISTRAR SOCIO";
            btnRegistrarSocio.UseVisualStyleBackColor = true;
            btnRegistrarSocio.Click += btnRegistrarSocio_Click;
            // 
            // btnRegistrarNoSocio
            // 
            btnRegistrarNoSocio.BackColor = SystemColors.ControlDark;
            btnRegistrarNoSocio.Location = new Point(234, 78);
            btnRegistrarNoSocio.Name = "btnRegistrarNoSocio";
            btnRegistrarNoSocio.Size = new Size(178, 67);
            btnRegistrarNoSocio.TabIndex = 1;
            btnRegistrarNoSocio.Text = "REGISTRAR NO SOCIO";
            btnRegistrarNoSocio.UseVisualStyleBackColor = false;
            btnRegistrarNoSocio.Click += button1_Click;
            // 
            // btnPagoCuota
            // 
            btnPagoCuota.BackColor = SystemColors.ControlDark;
            btnPagoCuota.Location = new Point(36, 166);
            btnPagoCuota.Name = "btnPagoCuota";
            btnPagoCuota.Size = new Size(178, 67);
            btnPagoCuota.TabIndex = 2;
            btnPagoCuota.Text = "PAGO CUOTA";
            btnPagoCuota.UseVisualStyleBackColor = false;
            btnPagoCuota.Click += button1_Click;
            // 
            // btnListarVencimientosHoy
            // 
            btnListarVencimientosHoy.BackColor = SystemColors.ControlDark;
            btnListarVencimientosHoy.Location = new Point(234, 166);
            btnListarVencimientosHoy.Name = "btnListarVencimientosHoy";
            btnListarVencimientosHoy.Size = new Size(178, 67);
            btnListarVencimientosHoy.TabIndex = 3;
            btnListarVencimientosHoy.Text = "LISTAR VENCIMIENTOS HOY";
            btnListarVencimientosHoy.UseVisualStyleBackColor = false;
            btnListarVencimientosHoy.Click += button1_Click;
            // 
            // btnEntregarCarnet
            // 
            btnEntregarCarnet.BackColor = SystemColors.ControlDark;
            btnEntregarCarnet.Location = new Point(36, 255);
            btnEntregarCarnet.Name = "btnEntregarCarnet";
            btnEntregarCarnet.Size = new Size(178, 67);
            btnEntregarCarnet.TabIndex = 4;
            btnEntregarCarnet.Text = "ENTREGAR CARNET";
            btnEntregarCarnet.UseVisualStyleBackColor = false;
            btnEntregarCarnet.Click += button1_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 359);
            Controls.Add(btnListarVencimientosHoy);
            Controls.Add(btnEntregarCarnet);
            Controls.Add(btnPagoCuota);
            Controls.Add(btnRegistrarNoSocio);
            Controls.Add(btnRegistrarSocio);
            Controls.Add(btnSalir);
            Controls.Add(lblIngreso);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIngreso;
        private Button btnSalir;
        private Button btnRegistrarSocio;
        private Button btnRegistrarNoSocio;
        private Button btnPagoCuota;
        private Button btnListarVencimientosHoy;
        private Button btnEntregarCarnet;
    }
}