using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class LibroBE
    {
        private string autor;
        private string titulo;
        private int ejemplar;

        public string Autor { get { return autor; } set { autor = value; } }
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public int Ejemplar { get { return ejemplar; } set { ejemplar = value; } }  
    }
}
