namespace pryDiFiniGestorClientes_BaseDeDatos_
{
    partial class frmGestorClientesBaseDeDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestorClientesBaseDeDatos));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesOrdenadoPorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeUnClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.ventasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca del desarrollador";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar...";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevoClienteToolStripMenuItem,
            this.listadoDeClientesToolStripMenuItem,
            this.listadoDeDeToolStripMenuItem,
            this.listadoDeClientesOrdenadoPorToolStripMenuItem,
            this.buscarClienteToolStripMenuItem,
            this.consultaDeUnClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // agregarNuevoClienteToolStripMenuItem
            // 
            this.agregarNuevoClienteToolStripMenuItem.Name = "agregarNuevoClienteToolStripMenuItem";
            this.agregarNuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.agregarNuevoClienteToolStripMenuItem.Text = "Agregar nuevo cliente...";
            // 
            // listadoDeClientesToolStripMenuItem
            // 
            this.listadoDeClientesToolStripMenuItem.Name = "listadoDeClientesToolStripMenuItem";
            this.listadoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.listadoDeClientesToolStripMenuItem.Text = "Listado de clientes...";
            this.listadoDeClientesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeClientesToolStripMenuItem_Click);
            // 
            // listadoDeDeToolStripMenuItem
            // 
            this.listadoDeDeToolStripMenuItem.Name = "listadoDeDeToolStripMenuItem";
            this.listadoDeDeToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.listadoDeDeToolStripMenuItem.Text = "Listado de deudores...";
            this.listadoDeDeToolStripMenuItem.Click += new System.EventHandler(this.listadoDeDeToolStripMenuItem_Click);
            // 
            // listadoDeClientesOrdenadoPorToolStripMenuItem
            // 
            this.listadoDeClientesOrdenadoPorToolStripMenuItem.Name = "listadoDeClientesOrdenadoPorToolStripMenuItem";
            this.listadoDeClientesOrdenadoPorToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.listadoDeClientesOrdenadoPorToolStripMenuItem.Text = "Listado de clientes ordenado por...";
            // 
            // buscarClienteToolStripMenuItem
            // 
            this.buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            this.buscarClienteToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.buscarClienteToolStripMenuItem.Text = "Buscar cliente...";
            this.buscarClienteToolStripMenuItem.Click += new System.EventHandler(this.buscarClienteToolStripMenuItem_Click);
            // 
            // consultaDeUnClienteToolStripMenuItem
            // 
            this.consultaDeUnClienteToolStripMenuItem.Name = "consultaDeUnClienteToolStripMenuItem";
            this.consultaDeUnClienteToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.consultaDeUnClienteToolStripMenuItem.Text = "Consulta de un cliente...";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.ventasToolStripMenuItem.Text = "Vendedores";
            // 
            // frmGestorClientesBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGestorClientesBaseDeDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Clientes (con Base de datos)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesOrdenadoPorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeUnClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
    }
}

