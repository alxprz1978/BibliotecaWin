using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BibliotecaWin.Model;

namespace BibliotecaWin
{
    public class FileManager
    {
        StreamWriter swLibro;
        string ruta;

        public void Init(string ruta)
        {
            this.ruta = ruta;
        }

        public void EscribirLibro(Libro libroT)
        {
            swLibro.WriteLine($"{libroT.ISBN},{libroT.Titulo},{libroT.Editorial},{libroT.Paginas},{libroT.Precio},{libroT.Year}");
        }

        public void CerrarArchivo()
        {
            swLibro.Close();
        }

        public void AbrirArchivo()
        {
            swLibro = new StreamWriter(ruta, true);
        }

    }
}
