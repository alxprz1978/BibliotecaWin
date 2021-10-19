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
    public partial class FormPrincipal : Form
    {
        private FormLibros frmAgregaLibro = new FormLibros();
        private FormVerLibros frmVerLibros = new FormVerLibros();
        private FileManager fileMann = new FileManager();

        List<Libro> libros = new List<Libro>();

        public FileManager FileMann { get => fileMann; set => fileMann = value; }

        public FormPrincipal()
        {
            InitializeComponent();
        }


        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            fileMann.Init("C:\\Users\\Usuario1\\Documents\\test.csv");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void agregarLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmAgregaLibro.IsDisposed)
                frmAgregaLibro = new FormLibros();

            frmAgregaLibro.FrmPrincipal = this;
            frmAgregaLibro.MdiParent = this;
            frmAgregaLibro.Show();

        }

        public void AgregaLibro(Libro libroT)
        {
            libros.Add(libroT);
        }

        private void verListaDeLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmVerLibros.IsDisposed)
                frmVerLibros = new FormVerLibros();

            frmVerLibros.FrmPrincipal = this;
            frmVerLibros.MdiParent = this;
            frmVerLibros.Show();
            frmVerLibros.MuestraLista(libros);
        }

        private void agregarAutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
