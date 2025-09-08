using BE;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LibroDAL
    {
        private Access acceso = new();
        
        public void AgregarLibro_( LibroBE libroNuevo )
        {
            /// Levanta por burbujeo el error al llamador
            if (libroNuevo == null)
                throw new ArgumentNullException();
            try
            {
                acceso.Escribir("ALTA_LIBRO",AYUDANTE.Param(libroNuevo));
            }
            catch
            {

            }
        }

    }
}
