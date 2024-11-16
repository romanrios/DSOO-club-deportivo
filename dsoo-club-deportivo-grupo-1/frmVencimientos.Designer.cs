namespace ClubDeportivo
{
    partial class frmVencimientos
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
            dtgvVencimientos = new DataGridView();
            lblFecha = new Label();
            NSocio = new DataGridViewTextBoxColumn();
            NombreS = new DataGridViewTextBoxColumn();
            ApellidoS = new DataGridViewTextBoxColumn();
            DocS = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvVencimientos).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(259, 352);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(99, 38);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // dtgvVencimientos
            // 
            dtgvVencimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvVencimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvVencimientos.Columns.AddRange(new DataGridViewColumn[] { NSocio, NombreS, ApellidoS, DocS });
            dtgvVencimientos.Location = new Point(37, 73);
            dtgvVencimientos.Name = "dtgvVencimientos";
            dtgvVencimientos.Size = new Size(564, 251);
            dtgvVencimientos.TabIndex = 1;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(37, 36);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(154, 15);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Vencimientos al día de hoy: ";
            // 
            // NSocio
            // 
            NSocio.HeaderText = "N° Socio";
            NSocio.Name = "NSocio";
            // 
            // NombreS
            // 
            NombreS.HeaderText = "Nombre";
            NombreS.Name = "NombreS";
            // 
            // ApellidoS
            // 
            ApellidoS.HeaderText = "Apellido";
            ApellidoS.Name = "ApellidoS";
            // 
            // DocS
            // 
            DocS.HeaderText = "Documento";
            DocS.Name = "DocS";
            // 
            // frmVencimientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 417);
            Controls.Add(lblFecha);
            Controls.Add(dtgvVencimientos);
            Controls.Add(btnVolver);
            Name = "frmVencimientos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listar Vencimientos Hoy";
            Load += frmVencimientos_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvVencimientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private DataGridView dtgvVencimientos;
        private Label lblFecha;
        private DataGridViewTextBoxColumn NSocio;
        private DataGridViewTextBoxColumn NombreS;
        private DataGridViewTextBoxColumn ApellidoS;
        private DataGridViewTextBoxColumn DocS;
    }
}