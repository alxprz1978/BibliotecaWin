
namespace BibliotecaWin
{
    partial class FormVerLibros
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
            this.txtListaLibros = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtListaLibros
            // 
            this.txtListaLibros.Location = new System.Drawing.Point(3, 36);
            this.txtListaLibros.Multiline = true;
            this.txtListaLibros.Name = "txtListaLibros";
            this.txtListaLibros.Size = new System.Drawing.Size(453, 229);
            this.txtListaLibros.TabIndex = 0;
            // 
            // FormVerLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 274);
            this.Controls.Add(this.txtListaLibros);
            this.Name = "FormVerLibros";
            this.Text = "FormVerLibros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtListaLibros;
    }
}