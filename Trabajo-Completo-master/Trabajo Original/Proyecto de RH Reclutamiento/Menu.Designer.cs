namespace Proyecto_de_RH_Reclutamiento
{
    partial class FrmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aspiranteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proximamenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contratacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rrporteDeAspirantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeAspirantesContratadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteTotalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verLaAyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeRecursosHumanosReclutamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.facturaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.transaccionesToolStripMenuItem,
            this.reporteToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.areasToolStripMenuItem,
            this.puestosToolStripMenuItem,
            this.facturaToolStripMenuItem,
            this.aspiranteToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(110, 23);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            this.mantenimientoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoToolStripMenuItem_Click);
            // 
            // areasToolStripMenuItem
            // 
            this.areasToolStripMenuItem.Name = "areasToolStripMenuItem";
            this.areasToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.areasToolStripMenuItem.Text = "Areas";
            this.areasToolStripMenuItem.Click += new System.EventHandler(this.areasToolStripMenuItem_Click);
            // 
            // puestosToolStripMenuItem
            // 
            this.puestosToolStripMenuItem.Name = "puestosToolStripMenuItem";
            this.puestosToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.puestosToolStripMenuItem.Text = "Puestos";
            this.puestosToolStripMenuItem.Click += new System.EventHandler(this.puestosToolStripMenuItem_Click);
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.facturaToolStripMenuItem.Text = "Factura";
            this.facturaToolStripMenuItem.Click += new System.EventHandler(this.facturaToolStripMenuItem_Click);
            // 
            // aspiranteToolStripMenuItem
            // 
            this.aspiranteToolStripMenuItem.Name = "aspiranteToolStripMenuItem";
            this.aspiranteToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.aspiranteToolStripMenuItem.Text = "Aspirante";
            this.aspiranteToolStripMenuItem.Click += new System.EventHandler(this.aspiranteToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.salirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.salirToolStripMenuItem.Text = "Salir ";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // transaccionesToolStripMenuItem
            // 
            this.transaccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proximamenteToolStripMenuItem,
            this.adicionDeEmpleadosToolStripMenuItem,
            this.contratacionToolStripMenuItem});
            this.transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(106, 23);
            this.transaccionesToolStripMenuItem.Text = "Transacciones";
            this.transaccionesToolStripMenuItem.Click += new System.EventHandler(this.transaccionesToolStripMenuItem_Click);
            // 
            // proximamenteToolStripMenuItem
            // 
            this.proximamenteToolStripMenuItem.Name = "proximamenteToolStripMenuItem";
            this.proximamenteToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.proximamenteToolStripMenuItem.Text = "Busqueda de Empleados";
            this.proximamenteToolStripMenuItem.Click += new System.EventHandler(this.proximamenteToolStripMenuItem_Click);
            // 
            // adicionDeEmpleadosToolStripMenuItem
            // 
            this.adicionDeEmpleadosToolStripMenuItem.Name = "adicionDeEmpleadosToolStripMenuItem";
            this.adicionDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.adicionDeEmpleadosToolStripMenuItem.Text = "Adicion de Empleados";
            this.adicionDeEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.adicionDeEmpleadosToolStripMenuItem_Click);
            // 
            // contratacionToolStripMenuItem
            // 
            this.contratacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaToolStripMenuItem1});
            this.contratacionToolStripMenuItem.Name = "contratacionToolStripMenuItem";
            this.contratacionToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.contratacionToolStripMenuItem.Text = "Contratacion";
            this.contratacionToolStripMenuItem.Click += new System.EventHandler(this.contratacionToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rrporteDeAspirantesToolStripMenuItem,
            this.reporteDeAspirantesContratadosToolStripMenuItem,
            this.reporteTotalesToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(76, 23);
            this.reporteToolStripMenuItem.Text = "Reportes";
            // 
            // rrporteDeAspirantesToolStripMenuItem
            // 
            this.rrporteDeAspirantesToolStripMenuItem.Name = "rrporteDeAspirantesToolStripMenuItem";
            this.rrporteDeAspirantesToolStripMenuItem.Size = new System.Drawing.Size(292, 24);
            this.rrporteDeAspirantesToolStripMenuItem.Text = "Reporte de Aspirantes";
            this.rrporteDeAspirantesToolStripMenuItem.Click += new System.EventHandler(this.rrporteDeAspirantesToolStripMenuItem_Click);
            // 
            // reporteDeAspirantesContratadosToolStripMenuItem
            // 
            this.reporteDeAspirantesContratadosToolStripMenuItem.Name = "reporteDeAspirantesContratadosToolStripMenuItem";
            this.reporteDeAspirantesContratadosToolStripMenuItem.Size = new System.Drawing.Size(292, 24);
            this.reporteDeAspirantesContratadosToolStripMenuItem.Text = "Reporte de Aspirantes Contratados";
            this.reporteDeAspirantesContratadosToolStripMenuItem.Click += new System.EventHandler(this.reporteDeAspirantesContratadosToolStripMenuItem_Click);
            // 
            // reporteTotalesToolStripMenuItem
            // 
            this.reporteTotalesToolStripMenuItem.Name = "reporteTotalesToolStripMenuItem";
            this.reporteTotalesToolStripMenuItem.Size = new System.Drawing.Size(292, 24);
            this.reporteTotalesToolStripMenuItem.Text = "Reporte Totales";
            this.reporteTotalesToolStripMenuItem.Click += new System.EventHandler(this.reporteTotalesToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verLaAyudaToolStripMenuItem,
            this.acercaDeRecursosHumanosReclutamientoToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // verLaAyudaToolStripMenuItem
            // 
            this.verLaAyudaToolStripMenuItem.Name = "verLaAyudaToolStripMenuItem";
            this.verLaAyudaToolStripMenuItem.Size = new System.Drawing.Size(351, 24);
            this.verLaAyudaToolStripMenuItem.Text = "Ver la Ayuda";
            // 
            // acercaDeRecursosHumanosReclutamientoToolStripMenuItem
            // 
            this.acercaDeRecursosHumanosReclutamientoToolStripMenuItem.Name = "acercaDeRecursosHumanosReclutamientoToolStripMenuItem";
            this.acercaDeRecursosHumanosReclutamientoToolStripMenuItem.Size = new System.Drawing.Size(351, 24);
            this.acercaDeRecursosHumanosReclutamientoToolStripMenuItem.Text = "Acerca de Recursos Humanos/Reclutamiento";
            this.acercaDeRecursosHumanosReclutamientoToolStripMenuItem.Click += new System.EventHandler(this.acercaDeRecursosHumanosReclutamientoToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 48);
            this.label1.TabIndex = 2;
            // 
            // facturaToolStripMenuItem1
            // 
            this.facturaToolStripMenuItem1.Name = "facturaToolStripMenuItem1";
            this.facturaToolStripMenuItem1.Size = new System.Drawing.Size(152, 24);
            this.facturaToolStripMenuItem1.Text = "Factura";
            this.facturaToolStripMenuItem1.Click += new System.EventHandler(this.facturaToolStripMenuItem1_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::Proyecto_de_RH_Reclutamiento.Properties.Resources.aprendizajes_rrhh1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(682, 341);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.TransparencyKey = System.Drawing.SystemColors.Window;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aspiranteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rrporteDeAspirantesToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem verLaAyudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeRecursosHumanosReclutamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proximamenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeAspirantesContratadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contratacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteTotalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem1;
    }
}

