using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PrestamoBE
    {
        private string autor;
        private string titulo;
        private int ejemplar;
        private string nombre;
        private string mail;
        private int numeroPrestamo;
        private DateTime fecha_Retiro;
        private DateTime fecha_Devuelta;


        public string Autor { get { return autor; } set { autor = value; } }
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public int Ejemplar { get { return ejemplar; } set { ejemplar = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Mail { get { return mail; } set { mail = value; } }
        public int NumeroPrestamo { get => numeroPrestamo; set {  numeroPrestamo = value; } }
        public DateTime Fecha_Retiro {  get { return fecha_Retiro; } set { fecha_Retiro = value; } }
        public DateTime Fecha_Devuelta {  get { return fecha_Devuelta; } set { fecha_Devuelta = value; } }
        
    }
}
