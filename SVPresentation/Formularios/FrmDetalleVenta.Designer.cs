namespace SVPresentation.Formularios
{
    partial class FrmDetalleVenta
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
            dgvDetalle = new DataGridView();
            BtnVerPdf = new Button();
            label1 = new Label();
            lblNroVenta = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // dgvDetalle
            // 
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(22, 50);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.Size = new Size(698, 253);
            dgvDetalle.TabIndex = 8;
            // 
            // BtnVerPdf
            // 
            BtnVerPdf.Cursor = Cursors.Hand;
            BtnVerPdf.FlatStyle = FlatStyle.Flat;
            BtnVerPdf.Location = new Point(645, 18);
            BtnVerPdf.Name = "BtnVerPdf";
            BtnVerPdf.Size = new Size(75, 23);
            BtnVerPdf.TabIndex = 7;
            BtnVerPdf.Text = "Ver PDF";
            BtnVerPdf.UseVisualStyleBackColor = true;
            BtnVerPdf.Click += BtnVerPdf_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 18);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 9;
            label1.Text = "Nro Venta:";
            // 
            // lblNroVenta
            // 
            lblNroVenta.AutoSize = true;
            lblNroVenta.Location = new Point(90, 18);
            lblNroVenta.Name = "lblNroVenta";
            lblNroVenta.Size = new Size(13, 15);
            lblNroVenta.TabIndex = 10;
            lblNroVenta.Text = "0";
            // 
            // FrmDetalleVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(743, 321);
            Controls.Add(lblNroVenta);
            Controls.Add(label1);
            Controls.Add(dgvDetalle);
            Controls.Add(BtnVerPdf);
            MaximizeBox = false;
            MaximumSize = new Size(759, 360);
            MinimizeBox = false;
            MinimumSize = new Size(759, 360);
            Name = "FrmDetalleVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle Venta";
            Load += FrmDetalleVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDetalle;
        private Button BtnVerPdf;
        private Label label1;
        private Label lblNroVenta;
    }
}