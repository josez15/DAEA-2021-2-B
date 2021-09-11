
namespace Lab02_01
{
    partial class PrincipalMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manteniminetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIRepInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSisSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemasToolStripMenuItem,
            this.manteniminetoToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manteniminetoToolStripMenuItem
            // 
            this.manteniminetoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManUsuarios,
            this.mnuManProductos,
            this.mnuManCategorias,
            this.mnuManProveedores,
            this.mnuManClientes});
            this.manteniminetoToolStripMenuItem.Name = "manteniminetoToolStripMenuItem";
            this.manteniminetoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.manteniminetoToolStripMenuItem.Text = "Mantenimineto";
            // 
            // mnuManUsuarios
            // 
            this.mnuManUsuarios.Name = "mnuManUsuarios";
            this.mnuManUsuarios.Size = new System.Drawing.Size(180, 22);
            this.mnuManUsuarios.Text = "Usuarios";
            this.mnuManUsuarios.Click += new System.EventHandler(this.mnuManUsuarios_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProcVenta,
            this.mnuProcCompra});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRepVentas,
            this.mnuRepCompras,
            this.mnuIRepInventario,
            this.mnuRepProveedores,
            this.mnuRepUsuarios,
            this.mnuRepClientes});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // sistemasToolStripMenuItem
            // 
            this.sistemasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSisSalir});
            this.sistemasToolStripMenuItem.Name = "sistemasToolStripMenuItem";
            this.sistemasToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.sistemasToolStripMenuItem.Text = "Sistemas";
            // 
            // mnuManProductos
            // 
            this.mnuManProductos.Name = "mnuManProductos";
            this.mnuManProductos.Size = new System.Drawing.Size(180, 22);
            this.mnuManProductos.Text = "Productos";
            this.mnuManProductos.Click += new System.EventHandler(this.mnuManProductos_Click);
            // 
            // mnuManCategorias
            // 
            this.mnuManCategorias.Name = "mnuManCategorias";
            this.mnuManCategorias.Size = new System.Drawing.Size(180, 22);
            this.mnuManCategorias.Text = "Categorias";
            // 
            // mnuManProveedores
            // 
            this.mnuManProveedores.Name = "mnuManProveedores";
            this.mnuManProveedores.Size = new System.Drawing.Size(180, 22);
            this.mnuManProveedores.Text = "Proveedores";
            // 
            // mnuManClientes
            // 
            this.mnuManClientes.Name = "mnuManClientes";
            this.mnuManClientes.Size = new System.Drawing.Size(180, 22);
            this.mnuManClientes.Text = "Clientes";
            // 
            // mnuProcVenta
            // 
            this.mnuProcVenta.Name = "mnuProcVenta";
            this.mnuProcVenta.Size = new System.Drawing.Size(180, 22);
            this.mnuProcVenta.Text = "Registrar venta";
            // 
            // mnuProcCompra
            // 
            this.mnuProcCompra.Name = "mnuProcCompra";
            this.mnuProcCompra.Size = new System.Drawing.Size(180, 22);
            this.mnuProcCompra.Text = "Registrar Compra";
            // 
            // mnuRepVentas
            // 
            this.mnuRepVentas.Name = "mnuRepVentas";
            this.mnuRepVentas.Size = new System.Drawing.Size(200, 22);
            this.mnuRepVentas.Text = "Reporte de ventas";
            // 
            // mnuRepCompras
            // 
            this.mnuRepCompras.Name = "mnuRepCompras";
            this.mnuRepCompras.Size = new System.Drawing.Size(200, 22);
            this.mnuRepCompras.Text = "Reporte de compras";
            // 
            // mnuIRepInventario
            // 
            this.mnuIRepInventario.Name = "mnuIRepInventario";
            this.mnuIRepInventario.Size = new System.Drawing.Size(200, 22);
            this.mnuIRepInventario.Text = "Inventario de productos";
            // 
            // mnuRepProveedores
            // 
            this.mnuRepProveedores.Name = "mnuRepProveedores";
            this.mnuRepProveedores.Size = new System.Drawing.Size(200, 22);
            this.mnuRepProveedores.Text = "Reporte de proveedores";
            // 
            // mnuRepUsuarios
            // 
            this.mnuRepUsuarios.Name = "mnuRepUsuarios";
            this.mnuRepUsuarios.Size = new System.Drawing.Size(200, 22);
            this.mnuRepUsuarios.Text = "Reporte de usuarios";
            // 
            // mnuRepClientes
            // 
            this.mnuRepClientes.Name = "mnuRepClientes";
            this.mnuRepClientes.Size = new System.Drawing.Size(200, 22);
            this.mnuRepClientes.Text = "Reporte de clientes";
            // 
            // mnuSisSalir
            // 
            this.mnuSisSalir.Name = "mnuSisSalir";
            this.mnuSisSalir.Size = new System.Drawing.Size(180, 22);
            this.mnuSisSalir.Text = "Salir del sistema";
            this.mnuSisSalir.Click += new System.EventHandler(this.mnuSisSalir_Click);
            // 
            // PrincipalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manteniminetoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuManUsuarios;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuManProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuManCategorias;
        private System.Windows.Forms.ToolStripMenuItem mnuManProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuManClientes;
        private System.Windows.Forms.ToolStripMenuItem mnuSisSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuProcVenta;
        private System.Windows.Forms.ToolStripMenuItem mnuProcCompra;
        private System.Windows.Forms.ToolStripMenuItem mnuRepVentas;
        private System.Windows.Forms.ToolStripMenuItem mnuRepCompras;
        private System.Windows.Forms.ToolStripMenuItem mnuIRepInventario;
        private System.Windows.Forms.ToolStripMenuItem mnuRepProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuRepUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuRepClientes;
    }
}