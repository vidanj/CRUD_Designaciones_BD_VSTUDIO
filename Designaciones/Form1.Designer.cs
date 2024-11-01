namespace Designaciones
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artefactosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeAsignacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeArtefactosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeAsignacionesPorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeAsignacionesPorArtefactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeAsignacionesPorUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acerdaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.preferenciasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.TabStop = true;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignacionesToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.artefactosToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // asignacionesToolStripMenuItem
            // 
            this.asignacionesToolStripMenuItem.Name = "asignacionesToolStripMenuItem";
            this.asignacionesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.asignacionesToolStripMenuItem.Text = "Asignaciones";
            this.asignacionesToolStripMenuItem.Click += new System.EventHandler(this.asignacionesToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // artefactosToolStripMenuItem
            // 
            this.artefactosToolStripMenuItem.Name = "artefactosToolStripMenuItem";
            this.artefactosToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.artefactosToolStripMenuItem.Text = "Artefactos";
            this.artefactosToolStripMenuItem.Click += new System.EventHandler(this.artefactosToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesDeAsignacionesToolStripMenuItem,
            this.reporteDeClientesToolStripMenuItem,
            this.reporteDeArtefactosToolStripMenuItem,
            this.reporteDeUsuariosToolStripMenuItem,
            this.reporteDeAsignacionesPorClienteToolStripMenuItem,
            this.reporteDeAsignacionesPorArtefactoToolStripMenuItem,
            this.reporteDeAsignacionesPorUsuarioToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reportesDeAsignacionesToolStripMenuItem
            // 
            this.reportesDeAsignacionesToolStripMenuItem.Name = "reportesDeAsignacionesToolStripMenuItem";
            this.reportesDeAsignacionesToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.reportesDeAsignacionesToolStripMenuItem.Text = "Reporte de Asignaciones";
            this.reportesDeAsignacionesToolStripMenuItem.Click += new System.EventHandler(this.reportesDeAsignacionesToolStripMenuItem_Click);
            // 
            // reporteDeClientesToolStripMenuItem
            // 
            this.reporteDeClientesToolStripMenuItem.Name = "reporteDeClientesToolStripMenuItem";
            this.reporteDeClientesToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.reporteDeClientesToolStripMenuItem.Text = "Reporte de Clientes";
            this.reporteDeClientesToolStripMenuItem.Click += new System.EventHandler(this.reporteDeClientesToolStripMenuItem_Click);
            // 
            // reporteDeArtefactosToolStripMenuItem
            // 
            this.reporteDeArtefactosToolStripMenuItem.Name = "reporteDeArtefactosToolStripMenuItem";
            this.reporteDeArtefactosToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.reporteDeArtefactosToolStripMenuItem.Text = "Reporte de Artefactos";
            this.reporteDeArtefactosToolStripMenuItem.Click += new System.EventHandler(this.reporteDeArtefactosToolStripMenuItem_Click);
            // 
            // reporteDeUsuariosToolStripMenuItem
            // 
            this.reporteDeUsuariosToolStripMenuItem.Name = "reporteDeUsuariosToolStripMenuItem";
            this.reporteDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.reporteDeUsuariosToolStripMenuItem.Text = "Reporte de Usuarios";
            this.reporteDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.reporteDeUsuariosToolStripMenuItem_Click);
            // 
            // reporteDeAsignacionesPorClienteToolStripMenuItem
            // 
            this.reporteDeAsignacionesPorClienteToolStripMenuItem.Name = "reporteDeAsignacionesPorClienteToolStripMenuItem";
            this.reporteDeAsignacionesPorClienteToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.reporteDeAsignacionesPorClienteToolStripMenuItem.Text = "Reporte de Asignaciones por Cliente";
            this.reporteDeAsignacionesPorClienteToolStripMenuItem.Click += new System.EventHandler(this.reporteDeAsignacionesPorClienteToolStripMenuItem_Click);
            // 
            // reporteDeAsignacionesPorArtefactoToolStripMenuItem
            // 
            this.reporteDeAsignacionesPorArtefactoToolStripMenuItem.Name = "reporteDeAsignacionesPorArtefactoToolStripMenuItem";
            this.reporteDeAsignacionesPorArtefactoToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.reporteDeAsignacionesPorArtefactoToolStripMenuItem.Text = "Reporte de Asignaciones por Artefacto";
            this.reporteDeAsignacionesPorArtefactoToolStripMenuItem.Click += new System.EventHandler(this.reporteDeAsignacionesPorArtefactoToolStripMenuItem_Click);
            // 
            // reporteDeAsignacionesPorUsuarioToolStripMenuItem
            // 
            this.reporteDeAsignacionesPorUsuarioToolStripMenuItem.Name = "reporteDeAsignacionesPorUsuarioToolStripMenuItem";
            this.reporteDeAsignacionesPorUsuarioToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.reporteDeAsignacionesPorUsuarioToolStripMenuItem.Text = "Reporte de Asignaciones por Usuario";
            this.reporteDeAsignacionesPorUsuarioToolStripMenuItem.Click += new System.EventHandler(this.reporteDeAsignacionesPorUsuarioToolStripMenuItem_Click);
            // 
            // preferenciasToolStripMenuItem
            // 
            this.preferenciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarContraseñaToolStripMenuItem,
            this.cambiarDeToolStripMenuItem,
            this.acerdaDeToolStripMenuItem});
            this.preferenciasToolStripMenuItem.Name = "preferenciasToolStripMenuItem";
            this.preferenciasToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.preferenciasToolStripMenuItem.Text = "Preferencias";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // cambiarDeToolStripMenuItem
            // 
            this.cambiarDeToolStripMenuItem.Name = "cambiarDeToolStripMenuItem";
            this.cambiarDeToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cambiarDeToolStripMenuItem.Text = "Cambiar de Idioma";
            this.cambiarDeToolStripMenuItem.Click += new System.EventHandler(this.cambiarDeToolStripMenuItem_Click);
            // 
            // acerdaDeToolStripMenuItem
            // 
            this.acerdaDeToolStripMenuItem.Name = "acerdaDeToolStripMenuItem";
            this.acerdaDeToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.acerdaDeToolStripMenuItem.Text = "Acerda de...";
            this.acerdaDeToolStripMenuItem.Click += new System.EventHandler(this.acerdaDeToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(154, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.Text = "Sistema de Designaciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artefactosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesDeAsignacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeArtefactosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeAsignacionesPorClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeAsignacionesPorArtefactoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem preferenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeAsignacionesPorUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acerdaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeUsuariosToolStripMenuItem;
    }
}

