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
    public partial class FormVerLibros : Form
    {
        private FormPrincipal frmPrincipal;

        public FormVerLibros()
        {
            InitializeComponent();
        }

        public FormPrincipal FrmPrincipal { get => frmPrincipal; set => frmPrincipal = value; }

        public void MuestraLista(List<Libro> libros)
        {
            foreach (Libro libroT in libros)
            {
                txtListaLibros.Text += ($"ISBN: {libroT.ISBN}, Titulo:{libroT.Titulo}, Editorial:{libroT.Editorial}\n");
            }
        }
    }
}
