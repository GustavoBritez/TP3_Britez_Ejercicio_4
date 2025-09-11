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
        UsuarioDAL DAL_INTERACTION = new();
        public UsuarioBLL()
        {
            DAL_INTERACTION= new UsuarioDAL();  
        }
        public void Register( UsuarioBE Usuar )
        {
            try 
            {
                
                if (Usuar is null)
                    throw new ArgumentException("El usuario esta vacio");

                DAL_INTERACTION.Register(Usuar);


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
            catch (Exception ex)
            {
                throw new ArgumentException($"{ex.Message}");
            }
        }

        public void Eliminar( int idNumero )
        {
            try
            {
                DAL_INTERACTION.Eliminar(idNumero);
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Error en Eliminar UsuarioBLL \n  {ex.Message}");
            }
        }
        public List<UsuarioBE> Obtener_Usuarios()
        {
            try
            {
                List<UsuarioBE> Obtener_dal = new();

                Obtener_dal = DAL_INTERACTION.Obtener_Usuarios();

                return Obtener_dal;
            }
            catch( Exception ex )
            {
                throw new ArgumentException("Error al obtener usuarios en BLL");
            }
        }



    }
}
