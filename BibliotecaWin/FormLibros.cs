using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaWin.Model;

namespace BibliotecaWin
{
    public partial class FormLibros : Form
    {
        private FormPrincipal frmPrincipal;
        
        public FormLibros()
        {
            InitializeComponent();
        }

        public FormPrincipal FrmPrincipal { get => frmPrincipal; set => frmPrincipal = value; }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            frmPrincipal.FileMann.AbrirArchivo();
            Libro libro1 = new Libro();
            libro1.ISBN = txtISBN.Text;
            libro1.Titulo = txtTitulo.Text;
            libro1.Editorial = txtEditorial.Text;
            libro1.Paginas = Convert.ToInt32(txtPaginas.Text);
            libro1.Year = Convert.ToInt32(txtAño.Text);
            libro1.Precio = Convert.ToSingle(txtPrecio.Text);

            //Utilizamos un método en un controlador
            //para agregar un libro
            //frmPrincipal.AgregaLibro(libro1);
            
            frmPrincipal.FileMann.EscribirLibro(libro1);
            
            txtISBN.Clear();
            txtTitulo.Clear();
            txtEditorial.Clear();
            txtPaginas.Clear();
            txtPrecio.Clear();
            txtAño.Clear();
            frmPrincipal.FileMann.CerrarArchivo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
