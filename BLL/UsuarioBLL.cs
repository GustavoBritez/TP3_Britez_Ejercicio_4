using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using System.Security.Cryptography;
using Microsoft.Data.SqlClient;


namespace BLL
{
    public class UsuarioBLL
    {
        UsuarioDAL DAL_INTERACTION;
        public UsuarioBLL()
        {
            DAL_INTERACTION= new UsuarioDAL();  
        }
        public void Register( UsuarioBE Usuar )
        {
            try 
            {
                
            }
            catch ( Exception ex )
            {
                throw new ArgumentException(ex.Message);
            }
        }
        public void Login( string usuario, string contrasenia )
        {
            try
            {

            }
            catch
            {

            }
        }

    }
}
