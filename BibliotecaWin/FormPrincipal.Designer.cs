
namespace BibliotecaWin
{
    partial class FormPrincipal
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
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verListaDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAutoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verListaDeAutoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.librosToolStripMenuItem,
            this.autoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(776, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarLibrosToolStripMenuItem,
            this.verListaDeLibrosToolStripMenuItem});
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.librosToolStripMenuItem.Text = "Libros";
            // 
            // agregarLibrosToolStripMenuItem
            // 
            this.agregarLibrosToolStripMenuItem.Name = "agregarLibrosToolStripMenuItem";
            this.agregarLibrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarLibrosToolStripMenuItem.Text = "Agregar libros";
            this.agregarLibrosToolStripMenuItem.Click += new System.EventHandler(this.agregarLibrosToolStripMenuItem_Click);
            // 
            // verListaDeLibrosToolStripMenuItem
            // 
            this.verListaDeLibrosToolStripMenuItem.Name = "verListaDeLibrosToolStripMenuItem";
            this.verListaDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verListaDeLibrosToolStripMenuItem.Text = "Ver lista de libros";
            this.verListaDeLibrosToolStripMenuItem.Click += new System.EventHandler(this.verListaDeLibrosToolStripMenuItem_Click);
            // 
            // autoresToolStripMenuItem
            // 
            this.autoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarAutoresToolStripMenuItem,
            this.verListaDeAutoresToolStripMenuItem});
            this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            this.autoresToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.autoresToolStripMenuItem.Text = "Autores";
            // 
            // agregarAutoresToolStripMenuItem
            // 
            this.agregarAutoresToolStripMenuItem.Name = "agregarAutoresToolStripMenuItem";
            this.agregarAutoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarAutoresToolStripMenuItem.Text = "Agregar autores";
            this.agregarAutoresToolStripMenuItem.Click += new System.EventHandler(this.agregarAutoresToolStripMenuItem_Click);
            // 
            // verListaDeAutoresToolStripMenuItem
            // 
            this.verListaDeAutoresToolStripMenuItem.Name = "verListaDeAutoresToolStripMenuItem";
            this.verListaDeAutoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verListaDeAutoresToolStripMenuItem.Text = "Ver lista de autores";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(776, 532);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormPrincipal";
            this.Text = "Biblioteca - Principal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verListaDeLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarAutoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verListaDeAutoresToolStripMenuItem;
    }
}

