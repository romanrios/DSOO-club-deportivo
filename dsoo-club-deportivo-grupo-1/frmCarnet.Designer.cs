namespace ClubDeportivo
{
    partial class frmCarnet
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
            btnVolver = new Button();
            lblIngrese = new Label();
            txtNumero = new TextBox();
            btnEntregar = new Button();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(89, 223);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(101, 41);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblIngrese
            // 
            lblIngrese.AutoSize = true;
            lblIngrese.Location = new Point(43, 42);
            lblIngrese.Name = "lblIngrese";
            lblIngrese.Size = new Size(197, 15);
            lblIngrese.TabIndex = 1;
            lblIngrese.Text = "INGRESE NÚMERO DE INSCRIPCIÓN";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(71, 88);
            txtNumero.MaxLength = 5;
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(142, 23);
            txtNumero.TabIndex = 2;
            // 
            // btnEntregar
            // 
            btnEntregar.Location = new Point(71, 138);
            btnEntregar.Name = "btnEntregar";
            btnEntregar.Size = new Size(142, 41);
            btnEntregar.TabIndex = 0;
            btnEntregar.Text = "ENTREGAR CARNET";
            btnEntregar.UseVisualStyleBackColor = true;
            btnEntregar.Click += btnEntregar_Click;
            // 
            // frmCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 302);
            Controls.Add(txtNumero);
            Controls.Add(lblIngrese);
            Controls.Add(btnEntregar);
            Controls.Add(btnVolver);
            Name = "frmCarnet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entregar Carnet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label lblIngrese;
        private TextBox txtNumero;
        private Button btnEntregar;
    }
}