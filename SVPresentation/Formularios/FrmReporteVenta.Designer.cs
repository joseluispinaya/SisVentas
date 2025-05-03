namespace SVPresentation.Formularios
{
    partial class FrmReporteVenta
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
            dgvReporte = new DataGridView();
            dtpFechaFin = new DateTimePicker();
            dtpFechaInicio = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            BtnBuscar = new Button();
            label2 = new Label();
            label1 = new Label();
            BtnExcel = new Button();
            BtnReporteCaja = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            // 
            // dgvReporte
            // 
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Location = new Point(29, 122);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.Size = new Size(708, 255);
            dgvReporte.TabIndex = 51;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(233, 80);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(177, 23);
            dtpFechaFin.TabIndex = 50;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(29, 80);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(177, 23);
            dtpFechaInicio.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(242, 62);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 48;
            label4.Text = "Fecha Fin:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(29, 62);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 47;
            label3.Text = "Fecha Inicio:";
            // 
            // BtnBuscar
            // 
            BtnBuscar.BackColor = Color.White;
            BtnBuscar.Cursor = Cursors.Hand;
            BtnBuscar.FlatStyle = FlatStyle.Flat;
            BtnBuscar.Location = new Point(429, 80);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(75, 23);
            BtnBuscar.TabIndex = 46;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = false;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 18);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 43;
            label2.Text = "Reporte Venta";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(740, 340);
            label1.TabIndex = 42;
            // 
            // BtnExcel
            // 
            BtnExcel.BackColor = Color.White;
            BtnExcel.Cursor = Cursors.Hand;
            BtnExcel.FlatStyle = FlatStyle.Flat;
            BtnExcel.Location = new Point(662, 80);
            BtnExcel.Name = "BtnExcel";
            BtnExcel.Size = new Size(75, 23);
            BtnExcel.TabIndex = 52;
            BtnExcel.Text = "Excel";
            BtnExcel.UseVisualStyleBackColor = false;
            BtnExcel.Click += BtnExcel_Click;
            // 
            // BtnReporteCaja
            // 
            BtnReporteCaja.BackColor = Color.White;
            BtnReporteCaja.Cursor = Cursors.Hand;
            BtnReporteCaja.FlatStyle = FlatStyle.Flat;
            BtnReporteCaja.Location = new Point(520, 80);
            BtnReporteCaja.Name = "BtnReporteCaja";
            BtnReporteCaja.Size = new Size(96, 23);
            BtnReporteCaja.TabIndex = 53;
            BtnReporteCaja.Text = "Reporte Caja";
            BtnReporteCaja.UseVisualStyleBackColor = false;
            BtnReporteCaja.Click += BtnReporteCaja_Click;
            // 
            // FrmReporteVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 407);
            Controls.Add(BtnReporteCaja);
            Controls.Add(BtnExcel);
            Controls.Add(dgvReporte);
            Controls.Add(dtpFechaFin);
            Controls.Add(dtpFechaInicio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(BtnBuscar);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmReporteVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmReporteVenta";
            Load += FrmReporteVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvReporte;
        private DateTimePicker dtpFechaFin;
        private DateTimePicker dtpFechaInicio;
        private Label label4;
        private Label label3;
        private Button BtnBuscar;
        private Label label2;
        private Label label1;
        private Button BtnExcel;
        private Button BtnReporteCaja;
    }
}