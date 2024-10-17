namespace ClubDeportivo
{
    partial class frmPagar
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
            lblIngreseNumero = new Label();
            btnComprobante = new Button();
            btnVolver = new Button();
            btnPagar = new Button();
            txtNro = new TextBox();
            groupBox1 = new GroupBox();
            rbtTarjeta = new RadioButton();
            rbtEfectivo = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblIngreseNumero
            // 
            lblIngreseNumero.AutoSize = true;
            lblIngreseNumero.Location = new Point(24, 24);
            lblIngreseNumero.Name = "lblIngreseNumero";
            lblIngreseNumero.Size = new Size(197, 15);
            lblIngreseNumero.TabIndex = 0;
            lblIngreseNumero.Text = "INGRESE NÚMERO DE INSCRIPCIÓN";
            // 
            // btnComprobante
            // 
            btnComprobante.Enabled = false;
            btnComprobante.Location = new Point(48, 190);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(116, 35);
            btnComprobante.TabIndex = 1;
            btnComprobante.Text = "COMPROBANTE";
            btnComprobante.UseVisualStyleBackColor = true;
            btnComprobante.Click += btnComprobante_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(258, 190);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(116, 35);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(48, 100);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(116, 35);
            btnPagar.TabIndex = 1;
            btnPagar.Text = "PAGAR";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // txtNro
            // 
            txtNro.Location = new Point(48, 52);
            txtNro.Name = "txtNro";
            txtNro.Size = new Size(137, 23);
            txtNro.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtTarjeta);
            groupBox1.Controls.Add(rbtEfectivo);
            groupBox1.Location = new Point(242, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(154, 125);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Forma de Pago";
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(30, 77);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(59, 19);
            rbtTarjeta.TabIndex = 0;
            rbtTarjeta.TabStop = true;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(30, 43);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(67, 19);
            rbtEfectivo.TabIndex = 0;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // frmPagar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 262);
            Controls.Add(groupBox1);
            Controls.Add(txtNro);
            Controls.Add(btnVolver);
            Controls.Add(btnPagar);
            Controls.Add(btnComprobante);
            Controls.Add(lblIngreseNumero);
            Name = "frmPagar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagar";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIngreseNumero;
        private Button btnComprobante;
        private Button btnVolver;
        private Button btnPagar;
        private TextBox txtNro;
        private GroupBox groupBox1;
        private RadioButton rbtEfectivo;
        private RadioButton rbtTarjeta;
    }
}