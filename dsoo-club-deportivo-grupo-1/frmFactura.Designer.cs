namespace ClubDeportivo
{
    partial class frmFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactura));
            panel1 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            lblDfecha = new Label();
            label4 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            lblCurso = new Label();
            lblValor = new Label();
            label11 = new Label();
            lblFPago = new Label();
            lblDia = new Label();
            label9 = new Label();
            label7 = new Label();
            label5 = new Label();
            lblSocio = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            btnImprimir = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(497, 52);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 19);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 0;
            label1.Text = "COMPROBANTE DE PAGO";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblDfecha);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(261, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(248, 118);
            panel3.TabIndex = 1;
            // 
            // lblDfecha
            // 
            lblDfecha.AutoSize = true;
            lblDfecha.Location = new Point(76, 17);
            lblDfecha.Name = "lblDfecha";
            lblDfecha.Size = new Size(73, 15);
            lblDfecha.TabIndex = 0;
            lblDfecha.Text = "[99/99/9999]";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 50);
            label4.Name = "label4";
            label4.Size = new Size(138, 15);
            label4.TabIndex = 0;
            label4.Text = "Datos Generales del Club";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 17);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 0;
            label3.Text = "Fecha:";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblCurso);
            panel4.Controls.Add(lblValor);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(lblFPago);
            panel4.Controls.Add(lblDia);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(lblSocio);
            panel4.Location = new Point(12, 194);
            panel4.Name = "panel4";
            panel4.Size = new Size(497, 178);
            panel4.TabIndex = 0;
            // 
            // lblCurso
            // 
            lblCurso.AutoSize = true;
            lblCurso.Location = new Point(176, 61);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(35, 15);
            lblCurso.TabIndex = 0;
            lblCurso.Text = "[DNI]";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(387, 132);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(69, 15);
            lblValor.TabIndex = 0;
            lblValor.Text = "[$ 99999.99]";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(325, 132);
            label11.Name = "label11";
            label11.Size = new Size(46, 15);
            label11.TabIndex = 0;
            label11.Text = "Monto:";
            // 
            // lblFPago
            // 
            lblFPago.AutoSize = true;
            lblFPago.Location = new Point(176, 132);
            lblFPago.Name = "lblFPago";
            lblFPago.Size = new Size(106, 15);
            lblFPago.TabIndex = 0;
            lblFPago.Text = "[Nombre Apellido]";
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(176, 95);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(106, 15);
            lblDia.TabIndex = 0;
            lblDia.Text = "[Nombre Apellido]";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 132);
            label9.Name = "label9";
            label9.Size = new Size(90, 15);
            label9.TabIndex = 0;
            label9.Text = "Forma de Pago:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 95);
            label7.Name = "label7";
            label7.Size = new Size(118, 15);
            label7.TabIndex = 0;
            label7.Text = "Fecha de Inscripción:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 61);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 0;
            label5.Text = "DNI:";
            // 
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.Location = new Point(23, 24);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(106, 15);
            lblSocio.TabIndex = 0;
            lblSocio.Text = "[Nombre Apellido]";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(245, 118);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 27);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 0;
            label2.Text = "CLUB DEPORTIVO";
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(209, 396);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(96, 33);
            btnImprimir.TabIndex = 2;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // frmFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 453);
            Controls.Add(btnImprimir);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "frmFactura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comprobante de Pago";
            Load += frmFactura_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Label lblDfecha;
        private Label label3;
        private Label lblCurso;
        private Label lblDia;
        private Label label7;
        private Label label5;
        private Label lblSocio;
        private Label lblValor;
        private Label label11;
        private Label lblFPago;
        private Label label9;
        private Label label4;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label2;
        private Button btnImprimir;
    }
}