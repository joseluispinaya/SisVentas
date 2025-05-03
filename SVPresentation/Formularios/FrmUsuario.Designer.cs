namespace SVPresentation.Formularios
{
    partial class FrmUsuario
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
            label6 = new Label();
            BtnGuardarEditar = new Button();
            BtnVolverEditar = new Button();
            BtnGuardarNuevo = new Button();
            BtnVolverNuevo = new Button();
            cbbRolNuevo = new ComboBox();
            label3 = new Label();
            cbbHabilitado = new ComboBox();
            tabEditar = new TabPage();
            txbClaveEditar = new TextBox();
            label4 = new Label();
            txbNombreUserEditar = new TextBox();
            label5 = new Label();
            txbCorreoEditar = new TextBox();
            label10 = new Label();
            cbbRolEditar = new ComboBox();
            label11 = new Label();
            txbNombreComEditar = new TextBox();
            label12 = new Label();
            txbNombreCompNuevo = new TextBox();
            tabNuevo = new TabPage();
            txbClaveNuevo = new TextBox();
            label9 = new Label();
            txbNombreUseNuevo = new TextBox();
            label8 = new Label();
            txbCorreoNuevo = new TextBox();
            label7 = new Label();
            label2 = new Label();
            dgvUsuarios = new DataGridView();
            BtnBuscar = new Button();
            txbBuscar = new TextBox();
            BtnNuevoLista = new Button();
            tabLista = new TabPage();
            tabControlMain = new TabControl();
            tabEditar.SuspendLayout();
            tabNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            tabLista.SuspendLayout();
            tabControlMain.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 15);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 236);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 12;
            label6.Text = "Habilitado:";
            // 
            // BtnGuardarEditar
            // 
            BtnGuardarEditar.Cursor = Cursors.Hand;
            BtnGuardarEditar.FlatStyle = FlatStyle.Flat;
            BtnGuardarEditar.ForeColor = Color.FromArgb(30, 90, 195);
            BtnGuardarEditar.Location = new Point(638, 283);
            BtnGuardarEditar.Name = "BtnGuardarEditar";
            BtnGuardarEditar.Size = new Size(75, 23);
            BtnGuardarEditar.TabIndex = 11;
            BtnGuardarEditar.Text = "Guardar";
            BtnGuardarEditar.UseVisualStyleBackColor = true;
            BtnGuardarEditar.Click += BtnGuardarEditar_Click;
            // 
            // BtnVolverEditar
            // 
            BtnVolverEditar.Cursor = Cursors.Hand;
            BtnVolverEditar.FlatStyle = FlatStyle.Flat;
            BtnVolverEditar.Location = new Point(20, 283);
            BtnVolverEditar.Name = "BtnVolverEditar";
            BtnVolverEditar.Size = new Size(75, 23);
            BtnVolverEditar.TabIndex = 10;
            BtnVolverEditar.Text = "Volver";
            BtnVolverEditar.UseVisualStyleBackColor = true;
            BtnVolverEditar.Click += BtnVolverEditar_Click;
            // 
            // BtnGuardarNuevo
            // 
            BtnGuardarNuevo.Cursor = Cursors.Hand;
            BtnGuardarNuevo.FlatStyle = FlatStyle.Flat;
            BtnGuardarNuevo.ForeColor = Color.FromArgb(30, 90, 195);
            BtnGuardarNuevo.Location = new Point(633, 276);
            BtnGuardarNuevo.Name = "BtnGuardarNuevo";
            BtnGuardarNuevo.Size = new Size(75, 23);
            BtnGuardarNuevo.TabIndex = 5;
            BtnGuardarNuevo.Text = "Guardar";
            BtnGuardarNuevo.UseVisualStyleBackColor = true;
            BtnGuardarNuevo.Click += BtnGuardarNuevo_Click;
            // 
            // BtnVolverNuevo
            // 
            BtnVolverNuevo.Cursor = Cursors.Hand;
            BtnVolverNuevo.FlatStyle = FlatStyle.Flat;
            BtnVolverNuevo.Location = new Point(15, 276);
            BtnVolverNuevo.Name = "BtnVolverNuevo";
            BtnVolverNuevo.Size = new Size(75, 23);
            BtnVolverNuevo.TabIndex = 4;
            BtnVolverNuevo.Text = "Volver";
            BtnVolverNuevo.UseVisualStyleBackColor = true;
            BtnVolverNuevo.Click += BtnVolverNuevo_Click;
            // 
            // cbbRolNuevo
            // 
            cbbRolNuevo.Cursor = Cursors.Hand;
            cbbRolNuevo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbRolNuevo.FormattingEnabled = true;
            cbbRolNuevo.Location = new Point(15, 23);
            cbbRolNuevo.Name = "cbbRolNuevo";
            cbbRolNuevo.Size = new Size(693, 23);
            cbbRolNuevo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 8);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 2;
            label3.Text = "Rol:";
            // 
            // cbbHabilitado
            // 
            cbbHabilitado.Cursor = Cursors.Hand;
            cbbHabilitado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbHabilitado.FormattingEnabled = true;
            cbbHabilitado.Location = new Point(20, 251);
            cbbHabilitado.Name = "cbbHabilitado";
            cbbHabilitado.Size = new Size(693, 23);
            cbbHabilitado.TabIndex = 13;
            // 
            // tabEditar
            // 
            tabEditar.Controls.Add(txbClaveEditar);
            tabEditar.Controls.Add(label4);
            tabEditar.Controls.Add(txbNombreUserEditar);
            tabEditar.Controls.Add(label5);
            tabEditar.Controls.Add(txbCorreoEditar);
            tabEditar.Controls.Add(label10);
            tabEditar.Controls.Add(cbbRolEditar);
            tabEditar.Controls.Add(label11);
            tabEditar.Controls.Add(txbNombreComEditar);
            tabEditar.Controls.Add(label12);
            tabEditar.Controls.Add(cbbHabilitado);
            tabEditar.Controls.Add(label6);
            tabEditar.Controls.Add(BtnGuardarEditar);
            tabEditar.Controls.Add(BtnVolverEditar);
            tabEditar.Location = new Point(4, 24);
            tabEditar.Name = "tabEditar";
            tabEditar.Padding = new Padding(3);
            tabEditar.Size = new Size(732, 316);
            tabEditar.TabIndex = 2;
            tabEditar.Text = "Editar";
            tabEditar.UseVisualStyleBackColor = true;
            // 
            // txbClaveEditar
            // 
            txbClaveEditar.Location = new Point(20, 210);
            txbClaveEditar.Name = "txbClaveEditar";
            txbClaveEditar.Size = new Size(693, 23);
            txbClaveEditar.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 195);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 22;
            label4.Text = "Clave";
            // 
            // txbNombreUserEditar
            // 
            txbNombreUserEditar.Location = new Point(20, 165);
            txbNombreUserEditar.Name = "txbNombreUserEditar";
            txbNombreUserEditar.Size = new Size(693, 23);
            txbNombreUserEditar.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 150);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 20;
            label5.Text = "Nombre Usuario";
            // 
            // txbCorreoEditar
            // 
            txbCorreoEditar.Location = new Point(20, 117);
            txbCorreoEditar.Name = "txbCorreoEditar";
            txbCorreoEditar.Size = new Size(693, 23);
            txbCorreoEditar.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(23, 102);
            label10.Name = "label10";
            label10.Size = new Size(43, 15);
            label10.TabIndex = 18;
            label10.Text = "Correo";
            // 
            // cbbRolEditar
            // 
            cbbRolEditar.Cursor = Cursors.Hand;
            cbbRolEditar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbRolEditar.FormattingEnabled = true;
            cbbRolEditar.Location = new Point(20, 22);
            cbbRolEditar.Name = "cbbRolEditar";
            cbbRolEditar.Size = new Size(693, 23);
            cbbRolEditar.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 7);
            label11.Name = "label11";
            label11.Size = new Size(27, 15);
            label11.TabIndex = 16;
            label11.Text = "Rol:";
            // 
            // txbNombreComEditar
            // 
            txbNombreComEditar.Location = new Point(20, 71);
            txbNombreComEditar.Name = "txbNombreComEditar";
            txbNombreComEditar.Size = new Size(693, 23);
            txbNombreComEditar.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(23, 56);
            label12.Name = "label12";
            label12.Size = new Size(107, 15);
            label12.TabIndex = 14;
            label12.Text = "Nombre Completo";
            // 
            // txbNombreCompNuevo
            // 
            txbNombreCompNuevo.Location = new Point(15, 72);
            txbNombreCompNuevo.Name = "txbNombreCompNuevo";
            txbNombreCompNuevo.Size = new Size(693, 23);
            txbNombreCompNuevo.TabIndex = 1;
            // 
            // tabNuevo
            // 
            tabNuevo.Controls.Add(txbClaveNuevo);
            tabNuevo.Controls.Add(label9);
            tabNuevo.Controls.Add(txbNombreUseNuevo);
            tabNuevo.Controls.Add(label8);
            tabNuevo.Controls.Add(txbCorreoNuevo);
            tabNuevo.Controls.Add(label7);
            tabNuevo.Controls.Add(BtnGuardarNuevo);
            tabNuevo.Controls.Add(BtnVolverNuevo);
            tabNuevo.Controls.Add(cbbRolNuevo);
            tabNuevo.Controls.Add(label3);
            tabNuevo.Controls.Add(txbNombreCompNuevo);
            tabNuevo.Controls.Add(label2);
            tabNuevo.Location = new Point(4, 24);
            tabNuevo.Name = "tabNuevo";
            tabNuevo.Padding = new Padding(3);
            tabNuevo.Size = new Size(732, 316);
            tabNuevo.TabIndex = 1;
            tabNuevo.Text = "Nuevo";
            tabNuevo.UseVisualStyleBackColor = true;
            // 
            // txbClaveNuevo
            // 
            txbClaveNuevo.Location = new Point(15, 218);
            txbClaveNuevo.Name = "txbClaveNuevo";
            txbClaveNuevo.Size = new Size(693, 23);
            txbClaveNuevo.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 203);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 10;
            label9.Text = "Clave";
            // 
            // txbNombreUseNuevo
            // 
            txbNombreUseNuevo.Location = new Point(15, 170);
            txbNombreUseNuevo.Name = "txbNombreUseNuevo";
            txbNombreUseNuevo.Size = new Size(693, 23);
            txbNombreUseNuevo.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 155);
            label8.Name = "label8";
            label8.Size = new Size(94, 15);
            label8.TabIndex = 8;
            label8.Text = "Nombre Usuario";
            // 
            // txbCorreoNuevo
            // 
            txbCorreoNuevo.Location = new Point(15, 120);
            txbCorreoNuevo.Name = "txbCorreoNuevo";
            txbCorreoNuevo.Size = new Size(693, 23);
            txbCorreoNuevo.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 105);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 6;
            label7.Text = "Correo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 57);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre Completo";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(19, 50);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(698, 253);
            dgvUsuarios.TabIndex = 3;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Cursor = Cursors.Hand;
            BtnBuscar.FlatStyle = FlatStyle.Flat;
            BtnBuscar.Location = new Point(642, 18);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(75, 23);
            BtnBuscar.TabIndex = 2;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // txbBuscar
            // 
            txbBuscar.Location = new Point(423, 18);
            txbBuscar.Name = "txbBuscar";
            txbBuscar.Size = new Size(203, 23);
            txbBuscar.TabIndex = 1;
            // 
            // BtnNuevoLista
            // 
            BtnNuevoLista.Cursor = Cursors.Hand;
            BtnNuevoLista.FlatStyle = FlatStyle.Flat;
            BtnNuevoLista.Location = new Point(19, 18);
            BtnNuevoLista.Name = "BtnNuevoLista";
            BtnNuevoLista.Size = new Size(75, 23);
            BtnNuevoLista.TabIndex = 0;
            BtnNuevoLista.Text = "Nuevo";
            BtnNuevoLista.UseVisualStyleBackColor = true;
            BtnNuevoLista.Click += BtnNuevoLista_Click;
            // 
            // tabLista
            // 
            tabLista.Controls.Add(dgvUsuarios);
            tabLista.Controls.Add(BtnBuscar);
            tabLista.Controls.Add(txbBuscar);
            tabLista.Controls.Add(BtnNuevoLista);
            tabLista.Location = new Point(4, 24);
            tabLista.Name = "tabLista";
            tabLista.Padding = new Padding(3);
            tabLista.Size = new Size(732, 316);
            tabLista.TabIndex = 0;
            tabLista.Text = "Lista";
            tabLista.UseVisualStyleBackColor = true;
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabLista);
            tabControlMain.Controls.Add(tabNuevo);
            tabControlMain.Controls.Add(tabEditar);
            tabControlMain.ItemSize = new Size(80, 20);
            tabControlMain.Location = new Point(12, 47);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(740, 344);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlMain.TabIndex = 2;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 407);
            Controls.Add(label1);
            Controls.Add(tabControlMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUsuario";
            Load += FrmUsuario_Load;
            tabEditar.ResumeLayout(false);
            tabEditar.PerformLayout();
            tabNuevo.ResumeLayout(false);
            tabNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            tabLista.ResumeLayout(false);
            tabLista.PerformLayout();
            tabControlMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label6;
        private Button BtnGuardarEditar;
        private Button BtnVolverEditar;
        private Button BtnGuardarNuevo;
        private Button BtnVolverNuevo;
        private ComboBox cbbRolNuevo;
        private Label label3;
        private ComboBox cbbHabilitado;
        private TabPage tabEditar;
        private TextBox txbNombreCompNuevo;
        private TabPage tabNuevo;
        private Label label2;
        private DataGridView dgvUsuarios;
        private Button BtnBuscar;
        private TextBox txbBuscar;
        private Button BtnNuevoLista;
        private TabPage tabLista;
        private TabControl tabControlMain;
        private TextBox txbClaveNuevo;
        private Label label9;
        private TextBox txbNombreUseNuevo;
        private Label label8;
        private TextBox txbCorreoNuevo;
        private Label label7;
        private TextBox txbClaveEditar;
        private Label label4;
        private TextBox txbNombreUserEditar;
        private Label label5;
        private TextBox txbCorreoEditar;
        private Label label10;
        private ComboBox cbbRolEditar;
        private Label label11;
        private TextBox txbNombreComEditar;
        private Label label12;
    }
}