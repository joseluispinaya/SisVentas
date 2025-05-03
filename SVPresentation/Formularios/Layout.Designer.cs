namespace SVPresentation.Formularios
{
    partial class Layout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Layout));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            linkCerrarSesion = new LinkLabel();
            lblRol = new Label();
            lblUsuario = new Label();
            panel2 = new Panel();
            msMenu = new MenuStrip();
            mnVentas = new ToolStripMenuItem();
            smNuevo = new ToolStripMenuItem();
            smHistorial = new ToolStripMenuItem();
            mnInventario = new ToolStripMenuItem();
            smProductos = new ToolStripMenuItem();
            smCategorias = new ToolStripMenuItem();
            mnReportes = new ToolStripMenuItem();
            smRVentas = new ToolStripMenuItem();
            mnUsuarios = new ToolStripMenuItem();
            mnConfiguracion = new ToolStripMenuItem();
            panelMain = new Panel();
            lblMain = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            msMenu.SuspendLayout();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 49, 69);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(linkCerrarSesion);
            panel1.Controls.Add(lblRol);
            panel1.Controls.Add(lblUsuario);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(919, 91);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(155, 22);
            label1.Name = "label1";
            label1.Size = new Size(279, 45);
            label1.TabIndex = 3;
            label1.Text = "Sistema de Ventas";
            // 
            // linkCerrarSesion
            // 
            linkCerrarSesion.AutoSize = true;
            linkCerrarSesion.LinkColor = Color.White;
            linkCerrarSesion.Location = new Point(824, 64);
            linkCerrarSesion.Name = "linkCerrarSesion";
            linkCerrarSesion.Size = new Size(76, 15);
            linkCerrarSesion.TabIndex = 2;
            linkCerrarSesion.TabStop = true;
            linkCerrarSesion.Text = "Cerrar Sesion";
            linkCerrarSesion.LinkClicked += linkCerrarSesion_LinkClicked;
            // 
            // lblRol
            // 
            lblRol.ForeColor = Color.White;
            lblRol.Location = new Point(688, 35);
            lblRol.Name = "lblRol";
            lblRol.RightToLeft = RightToLeft.Yes;
            lblRol.Size = new Size(212, 15);
            lblRol.TabIndex = 1;
            lblRol.Text = "rol";
            // 
            // lblUsuario
            // 
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(688, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.RightToLeft = RightToLeft.Yes;
            lblUsuario.Size = new Size(212, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "usuario";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(58, 49, 69);
            panel2.Controls.Add(msMenu);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(155, 407);
            panel2.TabIndex = 1;
            // 
            // msMenu
            // 
            msMenu.BackColor = Color.FromArgb(58, 49, 69);
            msMenu.Items.AddRange(new ToolStripItem[] { mnVentas, mnInventario, mnReportes, mnUsuarios, mnConfiguracion });
            msMenu.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            msMenu.Location = new Point(0, 0);
            msMenu.Name = "msMenu";
            msMenu.Size = new Size(155, 256);
            msMenu.TabIndex = 0;
            msMenu.Text = "menuStrip1";
            // 
            // mnVentas
            // 
            mnVentas.AutoSize = false;
            mnVentas.DropDownItems.AddRange(new ToolStripItem[] { smNuevo, smHistorial });
            mnVentas.Name = "mnVentas";
            mnVentas.Size = new Size(148, 50);
            mnVentas.Tag = "ventas";
            mnVentas.Text = "Ventas >";
            // 
            // smNuevo
            // 
            smNuevo.AutoSize = false;
            smNuevo.Name = "smNuevo";
            smNuevo.Padding = new Padding(0, 2, 0, 2);
            smNuevo.Size = new Size(180, 30);
            smNuevo.Tag = "nuevo";
            smNuevo.Text = "Nuevo";
            smNuevo.Click += smNuevo_Click;
            // 
            // smHistorial
            // 
            smHistorial.AutoSize = false;
            smHistorial.Name = "smHistorial";
            smHistorial.Padding = new Padding(0, 2, 0, 2);
            smHistorial.Size = new Size(180, 30);
            smHistorial.Tag = "historial";
            smHistorial.Text = "Historial";
            smHistorial.Click += smHistorial_Click;
            // 
            // mnInventario
            // 
            mnInventario.AutoSize = false;
            mnInventario.DropDownItems.AddRange(new ToolStripItem[] { smProductos, smCategorias });
            mnInventario.Name = "mnInventario";
            mnInventario.Size = new Size(148, 50);
            mnInventario.Tag = "inventario";
            mnInventario.Text = "Inventario >";
            // 
            // smProductos
            // 
            smProductos.AutoSize = false;
            smProductos.Name = "smProductos";
            smProductos.Padding = new Padding(0, 2, 0, 2);
            smProductos.Size = new Size(180, 30);
            smProductos.Tag = "productos";
            smProductos.Text = "Productos";
            smProductos.Click += smProductos_Click;
            // 
            // smCategorias
            // 
            smCategorias.AutoSize = false;
            smCategorias.Name = "smCategorias";
            smCategorias.Padding = new Padding(0, 2, 0, 2);
            smCategorias.Size = new Size(180, 30);
            smCategorias.Tag = "categorias";
            smCategorias.Text = "Categorias";
            smCategorias.Click += smCategorias_Click;
            // 
            // mnReportes
            // 
            mnReportes.AutoSize = false;
            mnReportes.DropDownItems.AddRange(new ToolStripItem[] { smRVentas });
            mnReportes.Name = "mnReportes";
            mnReportes.Size = new Size(148, 50);
            mnReportes.Tag = "reportes";
            mnReportes.Text = "Reporte >";
            // 
            // smRVentas
            // 
            smRVentas.AutoSize = false;
            smRVentas.Name = "smRVentas";
            smRVentas.Padding = new Padding(0, 2, 0, 2);
            smRVentas.Size = new Size(180, 30);
            smRVentas.Tag = "ventas";
            smRVentas.Text = "Ventas";
            smRVentas.Click += smRVentas_Click;
            // 
            // mnUsuarios
            // 
            mnUsuarios.AutoSize = false;
            mnUsuarios.Name = "mnUsuarios";
            mnUsuarios.Size = new Size(148, 50);
            mnUsuarios.Tag = "usuarios";
            mnUsuarios.Text = "Usuarios";
            mnUsuarios.Click += mnUsuarios_Click;
            // 
            // mnConfiguracion
            // 
            mnConfiguracion.AutoSize = false;
            mnConfiguracion.Name = "mnConfiguracion";
            mnConfiguracion.Size = new Size(148, 50);
            mnConfiguracion.Tag = "configuracion";
            mnConfiguracion.Text = "Configuracion";
            mnConfiguracion.Click += mnConfiguracion_Click;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(lblMain);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(155, 91);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(764, 407);
            panelMain.TabIndex = 2;
            // 
            // lblMain
            // 
            lblMain.Dock = DockStyle.Fill;
            lblMain.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMain.Location = new Point(0, 0);
            lblMain.Name = "lblMain";
            lblMain.Size = new Size(764, 407);
            lblMain.TabIndex = 0;
            lblMain.Text = "Bienvenido";
            lblMain.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Layout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 498);
            Controls.Add(panelMain);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MainMenuStrip = msMenu;
            MaximizeBox = false;
            MaximumSize = new Size(935, 537);
            MinimizeBox = false;
            MinimumSize = new Size(935, 537);
            Name = "Layout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Layout";
            Load += Layout_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            msMenu.ResumeLayout(false);
            msMenu.PerformLayout();
            panelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panelMain;
        private MenuStrip msMenu;
        private ToolStripMenuItem mnVentas;
        private ToolStripMenuItem mnInventario;
        private ToolStripMenuItem mnReportes;
        private ToolStripMenuItem mnUsuarios;
        private ToolStripMenuItem mnConfiguracion;
        private ToolStripMenuItem smNuevo;
        private ToolStripMenuItem smHistorial;
        private ToolStripMenuItem smProductos;
        private ToolStripMenuItem smCategorias;
        private ToolStripMenuItem smRVentas;
        private Label lblRol;
        private Label lblUsuario;
        private LinkLabel linkCerrarSesion;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lblMain;
    }
}