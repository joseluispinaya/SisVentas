namespace SVPresentation.Formularios
{
    partial class FrmLogin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txbUsuario = new TextBox();
            txbContrasena = new TextBox();
            BtnSalir = new Button();
            BtnEntrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(58, 49, 69);
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(270, 307);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Ventas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(305, 24);
            label2.Name = "label2";
            label2.Size = new Size(172, 37);
            label2.TabIndex = 1;
            label2.Text = "Iniciar Sesion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(281, 91);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Usuario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(281, 164);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 3;
            label4.Text = "Contraseña:";
            // 
            // txbUsuario
            // 
            txbUsuario.Location = new Point(281, 109);
            txbUsuario.Name = "txbUsuario";
            txbUsuario.Size = new Size(239, 23);
            txbUsuario.TabIndex = 4;
            // 
            // txbContrasena
            // 
            txbContrasena.Location = new Point(281, 182);
            txbContrasena.Name = "txbContrasena";
            txbContrasena.Size = new Size(239, 23);
            txbContrasena.TabIndex = 5;
            // 
            // BtnSalir
            // 
            BtnSalir.BackColor = Color.White;
            BtnSalir.Cursor = Cursors.Hand;
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.ForeColor = Color.Red;
            BtnSalir.Location = new Point(281, 267);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(75, 23);
            BtnSalir.TabIndex = 6;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // BtnEntrar
            // 
            BtnEntrar.BackColor = Color.White;
            BtnEntrar.Cursor = Cursors.Hand;
            BtnEntrar.FlatStyle = FlatStyle.Flat;
            BtnEntrar.Location = new Point(445, 267);
            BtnEntrar.Name = "BtnEntrar";
            BtnEntrar.Size = new Size(75, 23);
            BtnEntrar.TabIndex = 7;
            BtnEntrar.Text = "Entrar";
            BtnEntrar.UseVisualStyleBackColor = false;
            BtnEntrar.Click += BtnEntrar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(543, 307);
            Controls.Add(BtnEntrar);
            Controls.Add(BtnSalir);
            Controls.Add(txbContrasena);
            Controls.Add(txbUsuario);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txbUsuario;
        private TextBox txbContrasena;
        private Button BtnSalir;
        private Button BtnEntrar;
    }
}