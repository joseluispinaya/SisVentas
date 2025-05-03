namespace SVPresentation.Formularios
{
    partial class FrmVenta
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
            BtnRegistrar = new Button();
            BtnBuscar = new Button();
            txbCantidadTotal = new TextBox();
            label7 = new Label();
            txbNombreCliente = new TextBox();
            label4 = new Label();
            txbCodigoProducto = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label8 = new Label();
            lblTotal = new Label();
            cbbProductoVenta = new ComboBox();
            dgvDetalleVenta = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).BeginInit();
            SuspendLayout();
            // 
            // BtnRegistrar
            // 
            BtnRegistrar.BackColor = Color.White;
            BtnRegistrar.Cursor = Cursors.Hand;
            BtnRegistrar.FlatStyle = FlatStyle.Flat;
            BtnRegistrar.ForeColor = Color.FromArgb(30, 90, 195);
            BtnRegistrar.Location = new Point(662, 355);
            BtnRegistrar.Name = "BtnRegistrar";
            BtnRegistrar.Size = new Size(75, 23);
            BtnRegistrar.TabIndex = 38;
            BtnRegistrar.Text = "Registrar";
            BtnRegistrar.UseVisualStyleBackColor = false;
            BtnRegistrar.Click += BtnRegistrar_Click;
            // 
            // BtnBuscar
            // 
            BtnBuscar.BackColor = Color.White;
            BtnBuscar.Cursor = Cursors.Hand;
            BtnBuscar.FlatStyle = FlatStyle.Flat;
            BtnBuscar.Location = new Point(498, 79);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(75, 23);
            BtnBuscar.TabIndex = 36;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = false;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // txbCantidadTotal
            // 
            txbCantidadTotal.Location = new Point(511, 356);
            txbCantidadTotal.Name = "txbCantidadTotal";
            txbCantidadTotal.ReadOnly = true;
            txbCantidadTotal.Size = new Size(101, 23);
            txbCantidadTotal.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(449, 359);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 30;
            label7.Text = "Cantidad:";
            // 
            // txbNombreCliente
            // 
            txbNombreCliente.Location = new Point(31, 135);
            txbNombreCliente.Name = "txbNombreCliente";
            txbNombreCliente.Size = new Size(542, 23);
            txbNombreCliente.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(31, 117);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 24;
            label4.Text = "Nombre Cliente:";
            // 
            // txbCodigoProducto
            // 
            txbCodigoProducto.Location = new Point(31, 80);
            txbCodigoProducto.Name = "txbCodigoProducto";
            txbCodigoProducto.Size = new Size(169, 23);
            txbCodigoProducto.TabIndex = 23;
            txbCodigoProducto.KeyDown += txbCodigoProducto_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(31, 62);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 22;
            label3.Text = "Codigo Producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 18);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 21;
            label2.Text = "Nueva Venta";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(740, 340);
            label1.TabIndex = 20;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(58, 49, 69);
            label5.Location = new Point(592, 65);
            label5.Name = "label5";
            label5.Size = new Size(145, 97);
            label5.TabIndex = 39;
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(58, 49, 69);
            label8.Font = new Font("Segoe UI", 18F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(629, 80);
            label8.Name = "label8";
            label8.Size = new Size(70, 32);
            label8.TabIndex = 40;
            label8.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.FromArgb(58, 49, 69);
            lblTotal.Font = new Font("Segoe UI", 18F);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(592, 117);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(145, 32);
            lblTotal.TabIndex = 41;
            lblTotal.Text = "0";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbbProductoVenta
            // 
            cbbProductoVenta.Cursor = Cursors.Hand;
            cbbProductoVenta.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbProductoVenta.FormattingEnabled = true;
            cbbProductoVenta.Location = new Point(226, 80);
            cbbProductoVenta.Name = "cbbProductoVenta";
            cbbProductoVenta.Size = new Size(226, 23);
            cbbProductoVenta.TabIndex = 42;
            // 
            // dgvDetalleVenta
            // 
            dgvDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleVenta.Location = new Point(31, 172);
            dgvDetalleVenta.Name = "dgvDetalleVenta";
            dgvDetalleVenta.Size = new Size(706, 171);
            dgvDetalleVenta.TabIndex = 43;
            dgvDetalleVenta.CellContentClick += dgvDetalleVenta_CellContentClick;
            // 
            // FrmVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 407);
            Controls.Add(dgvDetalleVenta);
            Controls.Add(cbbProductoVenta);
            Controls.Add(lblTotal);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(BtnRegistrar);
            Controls.Add(BtnBuscar);
            Controls.Add(txbCantidadTotal);
            Controls.Add(label7);
            Controls.Add(txbNombreCliente);
            Controls.Add(label4);
            Controls.Add(txbCodigoProducto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmVenta";
            Load += FrmVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnRegistrar;
        private Button BtnBuscar;
        private TextBox txbCantidadTotal;
        private Label label7;
        private TextBox txbNombreCliente;
        private Label label4;
        private TextBox txbCodigoProducto;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label8;
        private Label lblTotal;
        private ComboBox cbbProductoVenta;
        private DataGridView dgvDetalleVenta;
    }
}