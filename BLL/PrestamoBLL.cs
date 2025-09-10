using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PrestamoBLL
    {
        PrestamoDAL mapper = new();
        public void Solicitar_Prestamo( string Titulo, string mail )
        {
            try
            {
                mapper.Solicitar_Prestamo ( Titulo, mail );
            }
            catch ( Exception ex ) 
            {
                throw new ArgumentException(ex.Message);
            }
        }
        public void Devolver_Prestamo()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        public List<PrestamoBE> Obtener_Prestamos()
        {
            try
            {
                return mapper.Obtener_Prestamos();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
