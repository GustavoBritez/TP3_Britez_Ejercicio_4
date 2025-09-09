using Azure.Messaging;
using BE;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

                acceso.Escribir("ALTA_LIBROS", AYUDANTE.Param(libroNuevo));
            }
            catch (Exception ex )
            {
                throw new ArgumentException(" Error en LibroDAL ",ex.Message);
            }
        }

        public List<LibroBE> Obtener_Libros( )
        { 
            try
            {
                DataTable tabla = acceso.Leer("OBTENER_LIBROS",null);
                List<LibroBE> lista_Libros = new();

                foreach( DataRow rows in tabla.Rows )
                {
                    LibroBE libroObtenido = new LibroBE
                    {
                        Autor = rows["AUTOR"] != DBNull.Value ? Convert.ToString(rows["AUTOR"]) : string.Empty,
                        Titulo = rows["TITULO"] != DBNull.Value ? Convert.ToString(rows["TITULO"]) : string.Empty,
                        Ejemplar = rows["EJEMPLAR"] != DBNull.Value ? Convert.ToInt32(rows["EJEMPLAR"]) : 0
                    };
                    lista_Libros.Add(libroObtenido);
                }
                return lista_Libros;
            }
            catch( Exception ex )
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public void Eliminar_Libro( string TITULO  )
        {
            try
            {
                SqlParameter[] sp = new SqlParameter[]
                {
                    new SqlParameter("@TITULO", TITULO )
                };
                acceso.Escribir("BAJA_LIBRO", sp);
            }
            catch( Exception ex )
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public void Modificar_Libro( string titulo, LibroBE libronuevo)
        {
            if (libronuevo is null)
                throw new ArgumentException(" Error al modificar ( Desde DAL )");
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@BORRAR", titulo),
                    new SqlParameter("@AUTOR", libronuevo.Autor),
                    new SqlParameter("@TITULO", libronuevo.Titulo),
                    new SqlParameter("@EJEMPLAR", libronuevo.Ejemplar)
                };
                
                acceso.Escribir("MODIFICAR_LIBRO",param);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
