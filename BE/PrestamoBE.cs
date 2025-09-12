using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PrestamoBE
    {

        private int numeroPrestamo;
        private int idUsuario;
        private string titulo;
        private DateTime fecha_Retiro;
        private DateTime fecha_Devuelta;

        public int NumeroPrestamo { get => numeroPrestamo; set {  numeroPrestamo = value; } }
        public int IdUsuario { get => this.idUsuario; set { idUsuario = value; } }
        public string Titulo { get => this.titulo; set { titulo = value; } }
        public DateTime Fecha_Retiro {  get { return fecha_Retiro; } set { fecha_Retiro = value; } }
        public DateTime Fecha_Devuelta {  get { return fecha_Devuelta; } set { fecha_Devuelta = value; } }
    }
}
