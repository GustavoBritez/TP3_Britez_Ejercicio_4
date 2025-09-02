using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class UsuarioBE
    {
        private int id_usuario;
        private string nombre;
        private string mail;
        private string contrasenia;

        public int Id_Usuario { get { return id_usuario; } set { id_usuario = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Mail { get { return mail; } set { mail = value; } }
        public string Contrasenia { get { return contrasenia; } set { contrasenia = value; } }
    }
}
