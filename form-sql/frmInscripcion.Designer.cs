namespace DiseñoLogin
{
    partial class frmInscripcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInscripcion));
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            cboEstado = new ComboBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDNI = new Label();
            pictureBox1 = new PictureBox();
            lblEstado = new Label();
            chkEntregoAptoFisico = new CheckBox();
            btnAceptar = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            lblFechaDeInscripcion = new Label();
            dtpFechaDeInscripcion = new DateTimePicker();
            lblFechaDeNacimiento = new Label();
            dtpFechaDeNacimiento = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(351, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(220, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(351, 81);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(220, 23);
            txtApellido.TabIndex = 0;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(351, 125);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(220, 23);
            txtDNI.TabIndex = 0;
            // 
            // cboEstado
            // 
            cboEstado.AutoCompleteCustomSource.AddRange(new string[] { "Activo", "Inactivo" });
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cboEstado.Location = new Point(351, 171);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(220, 23);
            cboEstado.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(228, 35);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(228, 81);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(228, 128);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(27, 15);
            lblDNI.TabIndex = 2;
            lblDNI.Text = "DNI";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(228, 174);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 2;
            lblEstado.Text = "Estado";
            // 
            // chkEntregoAptoFisico
            // 
            chkEntregoAptoFisico.AutoSize = true;
            chkEntregoAptoFisico.Location = new Point(228, 327);
            chkEntregoAptoFisico.Name = "chkEntregoAptoFisico";
            chkEntregoAptoFisico.Size = new Size(129, 19);
            chkEntregoAptoFisico.TabIndex = 4;
            chkEntregoAptoFisico.Text = "Entregó Apto Físico";
            chkEntregoAptoFisico.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(23, 376);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(167, 47);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(215, 376);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(167, 47);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(404, 376);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(167, 47);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;

            // 
            // lblFechaDeInscripcion
            // 
            lblFechaDeInscripcion.AutoSize = true;
            lblFechaDeInscripcion.Location = new Point(228, 276);
            lblFechaDeInscripcion.Name = "lblFechaDeInscripcion";
            lblFechaDeInscripcion.Size = new Size(115, 15);
            lblFechaDeInscripcion.TabIndex = 2;
            lblFechaDeInscripcion.Text = "Fecha de Inscripción";
            // 
            // dtpFechaDeInscripcion
            // 
            dtpFechaDeInscripcion.Location = new Point(351, 270);
            dtpFechaDeInscripcion.Name = "dtpFechaDeInscripcion";
            dtpFechaDeInscripcion.Size = new Size(220, 23);
            dtpFechaDeInscripcion.TabIndex = 6;
            // 
            // lblFechaDeNacimiento
            // 
            lblFechaDeNacimiento.AutoSize = true;
            lblFechaDeNacimiento.Location = new Point(228, 229);
            lblFechaDeNacimiento.Name = "lblFechaDeNacimiento";
            lblFechaDeNacimiento.Size = new Size(119, 15);
            lblFechaDeNacimiento.TabIndex = 2;
            lblFechaDeNacimiento.Text = "Fecha de Nacimiento";
            // 
            // dtpFechaDeNacimiento
            // 
            dtpFechaDeNacimiento.Location = new Point(351, 223);
            dtpFechaDeNacimiento.Name = "dtpFechaDeNacimiento";
            dtpFechaDeNacimiento.Size = new Size(220, 23);
            dtpFechaDeNacimiento.TabIndex = 6;
            // 
            // frmInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 449);
            Controls.Add(dtpFechaDeNacimiento);
            Controls.Add(dtpFechaDeInscripcion);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAceptar);
            Controls.Add(chkEntregoAptoFisico);
            Controls.Add(pictureBox1);
            Controls.Add(lblFechaDeNacimiento);
            Controls.Add(lblFechaDeInscripcion);
            Controls.Add(lblEstado);
            Controls.Add(lblDNI);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(cboEstado);
            Controls.Add(txtDNI);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "frmInscripcion";
            Text = "frmInscripcion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDocumento;
        private ComboBox cboTipo;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDNI;
        private PictureBox pictureBox1;
        private Label label2;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Button btnAceptar;
        private Button btnLimpiar;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private TextBox txtDNI;
        private ComboBox cboEstado;
        private Label lblEstado;
        private Button btnVolver;
        private Label lblFechaDeInscripcion;
        private DateTimePicker dtpFechaDeInscripcion;
        private Label lblFechaDeNacimiento;
        private DateTimePicker dtpFechaDeNacimiento;
        private CheckBox chkEntregoAptoFisico;
    }
}