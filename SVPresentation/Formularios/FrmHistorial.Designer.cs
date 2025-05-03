namespace SVPresentation.Formularios
{
    partial class FrmHistorial
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
            BtnBuscar = new Button();
            txbEncontrar = new TextBox();
            label8 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpFechaInicio = new DateTimePicker();
            dtpFechaFin = new DateTimePicker();
            dgvVenta = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).BeginInit();
            SuspendLayout();
            // 
            // BtnBuscar
            // 
            BtnBuscar.BackColor = Color.White;
            BtnBuscar.Cursor = Cursors.Hand;
            BtnBuscar.FlatStyle = FlatStyle.Flat;
            BtnBuscar.Location = new Point(662, 80);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(75, 23);
            BtnBuscar.TabIndex = 36;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = false;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // txbEncontrar
            // 
            txbEncontrar.Location = new Point(448, 80);
            txbEncontrar.Name = "txbEncontrar";
            txbEncontrar.Size = new Size(198, 23);
            txbEncontrar.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(448, 62);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 32;
            label8.Text = "Encontrar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 18);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 21;
            label2.Text = "Historial Venta";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(740, 340);
            label1.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(29, 62);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 37;
            label3.Text = "Fecha Inicio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(242, 62);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 38;
            label4.Text = "Fecha Fin:";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(29, 80);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(177, 23);
            dtpFechaInicio.TabIndex = 39;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(233, 80);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(177, 23);
            dtpFechaFin.TabIndex = 40;
            // 
            // dgvVenta
            // 
            dgvVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVenta.Location = new Point(29, 122);
            dgvVenta.Name = "dgvVenta";
            dgvVenta.Size = new Size(708, 255);
            dgvVenta.TabIndex = 41;
            dgvVenta.CellContentClick += dgvVenta_CellContentClick;
            // 
            // FrmHistorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 407);
            Controls.Add(dgvVenta);
            Controls.Add(dtpFechaFin);
            Controls.Add(dtpFechaInicio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(BtnBuscar);
            Controls.Add(txbEncontrar);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHistorial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmHistorial";
            Load += FrmHistorial_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnBuscar;
        private TextBox txbEncontrar;
        private Label label8;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaFin;
        private DataGridView dgvVenta;
    }
}