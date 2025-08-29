using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ClienteBE
    {
        private int id_ciente;
        private string nombre;
        private string mail;
        private string contrasenia;

        public int Id_Cliente {  get { return id_ciente; } set { id_ciente = value; }}
        public string Nombre { get { return nombre; } set { nombre = value; }}
        public string Mail { get { return mail; } set { mail = value; }}    
        public string Contrasenia { get { return contrasenia; } set { contrasenia = value; }}
    }
}
