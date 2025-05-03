namespace SVPresentation.Formularios
{
    partial class FrmProducto
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
            btnGuardarEditar = new Button();
            btnVolverEditar = new Button();
            btnGuardarNuevo = new Button();
            btnVolverNuevo = new Button();
            cbbCategoriaNuevo = new ComboBox();
            label3 = new Label();
            tabEditar = new TabPage();
            cbbHabilitado = new ComboBox();
            label16 = new Label();
            txbPrecioVentaEditar = new TextBox();
            label4 = new Label();
            txbPrecioComEditar = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txbCantidadEditar = new NumericUpDown();
            txbDescripcionEditar = new TextBox();
            label12 = new Label();
            txbNombreEditar = new TextBox();
            label13 = new Label();
            cbbCategoriaEditar = new ComboBox();
            label14 = new Label();
            txbCodigoEditar = new TextBox();
            label15 = new Label();
            txbCodigoNuevo = new TextBox();
            tabNuevo = new TabPage();
            txbPrecioVentaNuevo = new TextBox();
            label11 = new Label();
            txbPrecioCompNuevo = new TextBox();
            label10 = new Label();
            label9 = new Label();
            txbCantidadNuevo = new NumericUpDown();
            txbDescripcionNuevo = new TextBox();
            label8 = new Label();
            txbNombreNuevop = new TextBox();
            label7 = new Label();
            label2 = new Label();
            dgvProductos = new DataGridView();
            btnBuscar = new Button();
            txbBuscar = new TextBox();
            btnNuevoLista = new Button();
            tabLista = new TabPage();
            tabControlMain = new TabControl();
            BtnExportarRe = new Button();
            tabEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txbCantidadEditar).BeginInit();
            tabNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txbCantidadNuevo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            tabLista.SuspendLayout();
            tabControlMain.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 15);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 3;
            label1.Text = "Inventario / Producto";
            // 
            // btnGuardarEditar
            // 
            btnGuardarEditar.Cursor = Cursors.Hand;
            btnGuardarEditar.FlatStyle = FlatStyle.Flat;
            btnGuardarEditar.ForeColor = Color.FromArgb(30, 90, 195);
            btnGuardarEditar.Location = new Point(638, 273);
            btnGuardarEditar.Name = "btnGuardarEditar";
            btnGuardarEditar.Size = new Size(75, 23);
            btnGuardarEditar.TabIndex = 11;
            btnGuardarEditar.Text = "Guardar";
            btnGuardarEditar.UseVisualStyleBackColor = true;
            btnGuardarEditar.Click += btnGuardarEditar_Click;
            // 
            // btnVolverEditar
            // 
            btnVolverEditar.Cursor = Cursors.Hand;
            btnVolverEditar.FlatStyle = FlatStyle.Flat;
            btnVolverEditar.Location = new Point(20, 273);
            btnVolverEditar.Name = "btnVolverEditar";
            btnVolverEditar.Size = new Size(75, 23);
            btnVolverEditar.TabIndex = 10;
            btnVolverEditar.Text = "Volver";
            btnVolverEditar.UseVisualStyleBackColor = true;
            btnVolverEditar.Click += btnVolverEditar_Click;
            // 
            // btnGuardarNuevo
            // 
            btnGuardarNuevo.Cursor = Cursors.Hand;
            btnGuardarNuevo.FlatStyle = FlatStyle.Flat;
            btnGuardarNuevo.ForeColor = Color.FromArgb(30, 90, 195);
            btnGuardarNuevo.Location = new Point(633, 276);
            btnGuardarNuevo.Name = "btnGuardarNuevo";
            btnGuardarNuevo.Size = new Size(75, 23);
            btnGuardarNuevo.TabIndex = 5;
            btnGuardarNuevo.Text = "Guardar";
            btnGuardarNuevo.UseVisualStyleBackColor = true;
            btnGuardarNuevo.Click += btnGuardarNuevo_Click;
            // 
            // btnVolverNuevo
            // 
            btnVolverNuevo.Cursor = Cursors.Hand;
            btnVolverNuevo.FlatStyle = FlatStyle.Flat;
            btnVolverNuevo.Location = new Point(24, 276);
            btnVolverNuevo.Name = "btnVolverNuevo";
            btnVolverNuevo.Size = new Size(75, 23);
            btnVolverNuevo.TabIndex = 4;
            btnVolverNuevo.Text = "Volver";
            btnVolverNuevo.UseVisualStyleBackColor = true;
            btnVolverNuevo.Click += btnVolverNuevo_Click;
            // 
            // cbbCategoriaNuevo
            // 
            cbbCategoriaNuevo.Cursor = Cursors.Hand;
            cbbCategoriaNuevo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCategoriaNuevo.FormattingEnabled = true;
            cbbCategoriaNuevo.Location = new Point(24, 33);
            cbbCategoriaNuevo.Name = "cbbCategoriaNuevo";
            cbbCategoriaNuevo.Size = new Size(290, 23);
            cbbCategoriaNuevo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 16);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Categoria:";
            // 
            // tabEditar
            // 
            tabEditar.Controls.Add(cbbHabilitado);
            tabEditar.Controls.Add(label16);
            tabEditar.Controls.Add(txbPrecioVentaEditar);
            tabEditar.Controls.Add(label4);
            tabEditar.Controls.Add(txbPrecioComEditar);
            tabEditar.Controls.Add(label5);
            tabEditar.Controls.Add(label6);
            tabEditar.Controls.Add(txbCantidadEditar);
            tabEditar.Controls.Add(txbDescripcionEditar);
            tabEditar.Controls.Add(label12);
            tabEditar.Controls.Add(txbNombreEditar);
            tabEditar.Controls.Add(label13);
            tabEditar.Controls.Add(cbbCategoriaEditar);
            tabEditar.Controls.Add(label14);
            tabEditar.Controls.Add(txbCodigoEditar);
            tabEditar.Controls.Add(label15);
            tabEditar.Controls.Add(btnGuardarEditar);
            tabEditar.Controls.Add(btnVolverEditar);
            tabEditar.Location = new Point(4, 24);
            tabEditar.Name = "tabEditar";
            tabEditar.Padding = new Padding(3);
            tabEditar.Size = new Size(732, 316);
            tabEditar.TabIndex = 2;
            tabEditar.Text = "Editar";
            tabEditar.UseVisualStyleBackColor = true;
            // 
            // cbbHabilitado
            // 
            cbbHabilitado.Cursor = Cursors.Hand;
            cbbHabilitado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbHabilitado.FormattingEnabled = true;
            cbbHabilitado.Location = new Point(218, 255);
            cbbHabilitado.Name = "cbbHabilitado";
            cbbHabilitado.Size = new Size(290, 23);
            cbbHabilitado.TabIndex = 31;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(221, 238);
            label16.Name = "label16";
            label16.Size = new Size(65, 15);
            label16.TabIndex = 30;
            label16.Text = "Habilitado:";
            // 
            // txbPrecioVentaEditar
            // 
            txbPrecioVentaEditar.Location = new Point(431, 149);
            txbPrecioVentaEditar.Name = "txbPrecioVentaEditar";
            txbPrecioVentaEditar.Size = new Size(273, 23);
            txbPrecioVentaEditar.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(433, 132);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 28;
            label4.Text = "Precio Venta:";
            // 
            // txbPrecioComEditar
            // 
            txbPrecioComEditar.Location = new Point(431, 94);
            txbPrecioComEditar.Name = "txbPrecioComEditar";
            txbPrecioComEditar.Size = new Size(273, 23);
            txbPrecioComEditar.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(433, 77);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 26;
            label5.Text = "Precio Compra:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(433, 22);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 25;
            label6.Text = "Cantidad:";
            // 
            // txbCantidadEditar
            // 
            txbCantidadEditar.Location = new Point(431, 40);
            txbCantidadEditar.Name = "txbCantidadEditar";
            txbCantidadEditar.Size = new Size(273, 23);
            txbCantidadEditar.TabIndex = 24;
            // 
            // txbDescripcionEditar
            // 
            txbDescripcionEditar.Location = new Point(20, 201);
            txbDescripcionEditar.Name = "txbDescripcionEditar";
            txbDescripcionEditar.Size = new Size(684, 23);
            txbDescripcionEditar.TabIndex = 23;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(23, 184);
            label12.Name = "label12";
            label12.Size = new Size(72, 15);
            label12.TabIndex = 22;
            label12.Text = "Descripcion:";
            // 
            // txbNombreEditar
            // 
            txbNombreEditar.Location = new Point(20, 149);
            txbNombreEditar.Name = "txbNombreEditar";
            txbNombreEditar.Size = new Size(290, 23);
            txbNombreEditar.TabIndex = 21;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(23, 132);
            label13.Name = "label13";
            label13.Size = new Size(54, 15);
            label13.TabIndex = 20;
            label13.Text = "Nombre:";
            // 
            // cbbCategoriaEditar
            // 
            cbbCategoriaEditar.Cursor = Cursors.Hand;
            cbbCategoriaEditar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCategoriaEditar.FormattingEnabled = true;
            cbbCategoriaEditar.Location = new Point(20, 39);
            cbbCategoriaEditar.Name = "cbbCategoriaEditar";
            cbbCategoriaEditar.Size = new Size(290, 23);
            cbbCategoriaEditar.TabIndex = 19;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(23, 22);
            label14.Name = "label14";
            label14.Size = new Size(61, 15);
            label14.TabIndex = 18;
            label14.Text = "Categoria:";
            // 
            // txbCodigoEditar
            // 
            txbCodigoEditar.Location = new Point(20, 94);
            txbCodigoEditar.Name = "txbCodigoEditar";
            txbCodigoEditar.Size = new Size(290, 23);
            txbCodigoEditar.TabIndex = 17;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(23, 77);
            label15.Name = "label15";
            label15.Size = new Size(49, 15);
            label15.TabIndex = 16;
            label15.Text = "Codigo:";
            // 
            // txbCodigoNuevo
            // 
            txbCodigoNuevo.Location = new Point(24, 88);
            txbCodigoNuevo.Name = "txbCodigoNuevo";
            txbCodigoNuevo.Size = new Size(290, 23);
            txbCodigoNuevo.TabIndex = 1;
            // 
            // tabNuevo
            // 
            tabNuevo.Controls.Add(txbPrecioVentaNuevo);
            tabNuevo.Controls.Add(label11);
            tabNuevo.Controls.Add(txbPrecioCompNuevo);
            tabNuevo.Controls.Add(label10);
            tabNuevo.Controls.Add(label9);
            tabNuevo.Controls.Add(txbCantidadNuevo);
            tabNuevo.Controls.Add(txbDescripcionNuevo);
            tabNuevo.Controls.Add(label8);
            tabNuevo.Controls.Add(txbNombreNuevop);
            tabNuevo.Controls.Add(label7);
            tabNuevo.Controls.Add(btnGuardarNuevo);
            tabNuevo.Controls.Add(btnVolverNuevo);
            tabNuevo.Controls.Add(cbbCategoriaNuevo);
            tabNuevo.Controls.Add(label3);
            tabNuevo.Controls.Add(txbCodigoNuevo);
            tabNuevo.Controls.Add(label2);
            tabNuevo.Location = new Point(4, 24);
            tabNuevo.Name = "tabNuevo";
            tabNuevo.Padding = new Padding(3);
            tabNuevo.Size = new Size(732, 316);
            tabNuevo.TabIndex = 1;
            tabNuevo.Text = "Nuevo";
            tabNuevo.UseVisualStyleBackColor = true;
            // 
            // txbPrecioVentaNuevo
            // 
            txbPrecioVentaNuevo.Location = new Point(435, 143);
            txbPrecioVentaNuevo.Name = "txbPrecioVentaNuevo";
            txbPrecioVentaNuevo.Size = new Size(273, 23);
            txbPrecioVentaNuevo.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(437, 126);
            label11.Name = "label11";
            label11.Size = new Size(75, 15);
            label11.TabIndex = 14;
            label11.Text = "Precio Venta:";
            // 
            // txbPrecioCompNuevo
            // 
            txbPrecioCompNuevo.Location = new Point(435, 88);
            txbPrecioCompNuevo.Name = "txbPrecioCompNuevo";
            txbPrecioCompNuevo.Size = new Size(273, 23);
            txbPrecioCompNuevo.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(437, 71);
            label10.Name = "label10";
            label10.Size = new Size(89, 15);
            label10.TabIndex = 12;
            label10.Text = "Precio Compra:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(437, 16);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 11;
            label9.Text = "Cantidad:";
            // 
            // txbCantidadNuevo
            // 
            txbCantidadNuevo.Location = new Point(435, 34);
            txbCantidadNuevo.Name = "txbCantidadNuevo";
            txbCantidadNuevo.Size = new Size(273, 23);
            txbCantidadNuevo.TabIndex = 10;
            // 
            // txbDescripcionNuevo
            // 
            txbDescripcionNuevo.Location = new Point(24, 195);
            txbDescripcionNuevo.Name = "txbDescripcionNuevo";
            txbDescripcionNuevo.Size = new Size(684, 23);
            txbDescripcionNuevo.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 178);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 8;
            label8.Text = "Descripcion:";
            // 
            // txbNombreNuevop
            // 
            txbNombreNuevop.Location = new Point(24, 143);
            txbNombreNuevop.Name = "txbNombreNuevop";
            txbNombreNuevop.Size = new Size(290, 23);
            txbNombreNuevop.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 126);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 6;
            label7.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 71);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 0;
            label2.Text = "Codigo:";
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(19, 50);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(698, 253);
            dgvProductos.TabIndex = 3;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // btnBuscar
            // 
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(535, 18);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txbBuscar
            // 
            txbBuscar.Location = new Point(316, 18);
            txbBuscar.Name = "txbBuscar";
            txbBuscar.Size = new Size(203, 23);
            txbBuscar.TabIndex = 1;
            // 
            // btnNuevoLista
            // 
            btnNuevoLista.Cursor = Cursors.Hand;
            btnNuevoLista.FlatStyle = FlatStyle.Flat;
            btnNuevoLista.Location = new Point(19, 18);
            btnNuevoLista.Name = "btnNuevoLista";
            btnNuevoLista.Size = new Size(75, 23);
            btnNuevoLista.TabIndex = 0;
            btnNuevoLista.Text = "Nuevo";
            btnNuevoLista.UseVisualStyleBackColor = true;
            btnNuevoLista.Click += btnNuevoLista_Click;
            // 
            // tabLista
            // 
            tabLista.Controls.Add(BtnExportarRe);
            tabLista.Controls.Add(dgvProductos);
            tabLista.Controls.Add(btnBuscar);
            tabLista.Controls.Add(txbBuscar);
            tabLista.Controls.Add(btnNuevoLista);
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
            // BtnExportarRe
            // 
            BtnExportarRe.Cursor = Cursors.Hand;
            BtnExportarRe.FlatStyle = FlatStyle.Flat;
            BtnExportarRe.Location = new Point(642, 18);
            BtnExportarRe.Name = "BtnExportarRe";
            BtnExportarRe.Size = new Size(75, 23);
            BtnExportarRe.TabIndex = 4;
            BtnExportarRe.Text = "Excel";
            BtnExportarRe.UseVisualStyleBackColor = true;
            BtnExportarRe.Click += BtnExportarRe_Click;
            // 
            // FrmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 407);
            Controls.Add(label1);
            Controls.Add(tabControlMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmProducto";
            Load += FrmProducto_Load;
            tabEditar.ResumeLayout(false);
            tabEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txbCantidadEditar).EndInit();
            tabNuevo.ResumeLayout(false);
            tabNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txbCantidadNuevo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            tabLista.ResumeLayout(false);
            tabLista.PerformLayout();
            tabControlMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGuardarEditar;
        private Button btnVolverEditar;
        private Button btnGuardarNuevo;
        private Button btnVolverNuevo;
        private ComboBox cbbCategoriaNuevo;
        private Label label3;
        private TabPage tabEditar;
        private TextBox txbCodigoNuevo;
        private TabPage tabNuevo;
        private Label label2;
        private DataGridView dgvProductos;
        private Button btnBuscar;
        private TextBox txbBuscar;
        private Button btnNuevoLista;
        private TabPage tabLista;
        private TabControl tabControlMain;
        private TextBox txbDescripcionNuevo;
        private Label label8;
        private TextBox txbNombreNuevop;
        private Label label7;
        private Label label9;
        private NumericUpDown txbCantidadNuevo;
        private TextBox txbPrecioVentaNuevo;
        private Label label11;
        private TextBox txbPrecioCompNuevo;
        private Label label10;
        private ComboBox cbbHabilitado;
        private Label label16;
        private TextBox txbPrecioVentaEditar;
        private Label label4;
        private TextBox txbPrecioComEditar;
        private Label label5;
        private Label label6;
        private NumericUpDown txbCantidadEditar;
        private TextBox txbDescripcionEditar;
        private Label label12;
        private TextBox txbNombreEditar;
        private Label label13;
        private ComboBox cbbCategoriaEditar;
        private Label label14;
        private TextBox txbCodigoEditar;
        private Label label15;
        private Button BtnExportarRe;
    }
}