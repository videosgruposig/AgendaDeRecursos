namespace AgendaDeRecursos
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorDeInstanciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorAgrupacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorPlanesDeEstudioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorDeCargosPorEstablecimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdministradorAmbientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(657, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradorDeInstanciaToolStripMenuItem,
            this.administradorAgrupacionesToolStripMenuItem,
            this.administradorPlanesDeEstudioToolStripMenuItem,
            this.administradorDeCargosPorEstablecimientoToolStripMenuItem,
            this.AdministradorAmbientes});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.nuevoToolStripMenuItem.Text = "Administrador";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // administradorDeInstanciaToolStripMenuItem
            // 
            this.administradorDeInstanciaToolStripMenuItem.Name = "administradorDeInstanciaToolStripMenuItem";
            this.administradorDeInstanciaToolStripMenuItem.Size = new System.Drawing.Size(314, 22);
            this.administradorDeInstanciaToolStripMenuItem.Text = "Administrador de Curso/Sección";
            this.administradorDeInstanciaToolStripMenuItem.Click += new System.EventHandler(this.administradorDeInstanciaToolStripMenuItem_Click);
            // 
            // administradorAgrupacionesToolStripMenuItem
            // 
            this.administradorAgrupacionesToolStripMenuItem.Name = "administradorAgrupacionesToolStripMenuItem";
            this.administradorAgrupacionesToolStripMenuItem.Size = new System.Drawing.Size(314, 22);
            this.administradorAgrupacionesToolStripMenuItem.Text = "Administrador Agrupaciones";
            this.administradorAgrupacionesToolStripMenuItem.Click += new System.EventHandler(this.administradorAgrupacionesToolStripMenuItem_Click);
            // 
            // administradorPlanesDeEstudioToolStripMenuItem
            // 
            this.administradorPlanesDeEstudioToolStripMenuItem.Name = "administradorPlanesDeEstudioToolStripMenuItem";
            this.administradorPlanesDeEstudioToolStripMenuItem.Size = new System.Drawing.Size(314, 22);
            this.administradorPlanesDeEstudioToolStripMenuItem.Text = "Administrador Planes de Estudio";
            this.administradorPlanesDeEstudioToolStripMenuItem.Click += new System.EventHandler(this.administradorPlanesDeEstudioToolStripMenuItem_Click);
            // 
            // administradorDeCargosPorEstablecimientoToolStripMenuItem
            // 
            this.administradorDeCargosPorEstablecimientoToolStripMenuItem.Name = "administradorDeCargosPorEstablecimientoToolStripMenuItem";
            this.administradorDeCargosPorEstablecimientoToolStripMenuItem.Size = new System.Drawing.Size(314, 22);
            this.administradorDeCargosPorEstablecimientoToolStripMenuItem.Text = "Administrador de Cargos por Establecimiento";
            this.administradorDeCargosPorEstablecimientoToolStripMenuItem.Click += new System.EventHandler(this.administradorDeCargosPorEstablecimientoToolStripMenuItem_Click);
            // 
            // AdministradorAmbientes
            // 
            this.AdministradorAmbientes.Name = "AdministradorAmbientes";
            this.AdministradorAmbientes.Size = new System.Drawing.Size(314, 22);
            this.AdministradorAmbientes.Text = "Administrador de Ambientes";
            this.AdministradorAmbientes.Click += new System.EventHandler(this.AdministradorAmbientes_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 288);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "Menú Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorAgrupacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorDeInstanciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorPlanesDeEstudioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorDeCargosPorEstablecimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdministradorAmbientes;
    }
}

