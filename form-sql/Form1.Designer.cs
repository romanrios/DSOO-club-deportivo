﻿namespace DiseñoLogin
{
    partial class Form1
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
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            btnIngresar = new Button();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(149, 35);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(163, 23);
            txtUsuario.TabIndex = 0;
            txtUsuario.Text = "USUARIO";
            // Asociar eventos Enter y Leave al TextBox txtUsuario
            txtUsuario.Enter += new EventHandler(this.txtUsuario_Enter);
            txtUsuario.Leave += new EventHandler(this.txtUsuario_Leave);
            // 
            // txtPass
            // 
            txtPass.Location = new Point(149, 95);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(163, 23);
            txtPass.TabIndex = 0;
            txtPass.Text = "CONTRASEÑA";
            // Asociar eventos Enter y Leave al TextBox txtPass
            txtPass.Enter += new EventHandler(this.txtPass_Enter);
            txtPass.Leave += new EventHandler(this.txtPass_Leave);
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(175, 162);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(122, 35);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            // Asociar evento Click al Button btnIngresar
            btnIngresar.Click += new EventHandler(this.btnIngresar_Click);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 236);
            Controls.Add(btnIngresar);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtPass;
        private Button btnIngresar;
    }
}