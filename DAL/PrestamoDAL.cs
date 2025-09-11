using BE;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PrestamoDAL
    {
        public Access access = new();

        public void Solicitar_Prestamo(string Titulo, string mail)
        {
            try
            {
                SqlParameter[] libro_titulo = new SqlParameter[] {
                    new SqlParameter("@TITULO", Titulo),
                };

                SqlParameter[] Usuario_mail = new SqlParameter[] {
                    new SqlParameter("@MAIL", mail),
                };

                DataTable datos_libro = access.Leer("OBTENER_TITULO", libro_titulo);
                DataTable datos_usuario = access.Leer("OBTENER_USUARIO_CON_MAIL", Usuario_mail);

                DateTime fechaRetiro = DateTime.Now;  
                DateTime fechaDevuelta = DateTime.Now.AddDays(7);

                SqlParameter[] prestamoNuevo = new SqlParameter[]
                {
                    new SqlParameter("@AUTOR", datos_libro.Rows[0]["AUTOR"].ToString()),
                    new SqlParameter("@TITULO", datos_libro.Rows[0]["TITULO"].ToString()),
                    new SqlParameter("@EJEMPLAR", Convert.ToInt32(datos_libro.Rows[0]["EJEMPLAR"])),
                    new SqlParameter("@MAIL", datos_usuario.Rows[0]["MAIL"].ToString()),
                    new SqlParameter("@FECHA_RETIRO", fechaRetiro),
                    new SqlParameter("@FECHA_DEVUELTA", fechaDevuelta)
                };

                access.Escribir("CREAR_PRESTAMO",prestamoNuevo);
            }
            catch (Exception ex )
            {
                throw new ArgumentException($"Error en Solicitar Prestamo DAL \n Error \n {ex.Message}");
            }
        }

        public void Devolver_Prestamo( int numeroPrestamo )
        {
            try
            {
                SqlParameter[] sp = new SqlParameter[]
                {
                    new SqlParameter("@NUMERO_PRESTAMO", numeroPrestamo)
                };

                access.Escribir("DEVOLVER_PRESTAMO",sp);

            }
            catch (Exception ex) 
            {
                throw new ArgumentException($"Error en Devolver Prestamo DAL\n Error \n {ex.Message}");
            }
        }

        public List<PrestamoBE> Obtener_Prestamos()
        {
            try
            {
                List<PrestamoBE> lista_prestamos = new();

                DataTable tabla_prestamos = access.Leer("OBTENER_PRESTAMOS",null);

                if (tabla_prestamos is null || tabla_prestamos.Rows.Count == 0 )
                    throw new ArgumentException(" No se encontraron prestamos");

                foreach( DataRow linea in tabla_prestamos.Rows )
                {
                    PrestamoBE newPrestamo = new PrestamoBE
                    {
                        Autor = linea["AUTOR"].ToString(),
                        Titulo = linea["TITULO"].ToString(),
                        Ejemplar = Convert.ToInt32(linea["EJEMPLAR"]),
                        Nombre = linea["NOMBRE"].ToString(),
                        Mail = linea["MAIL"].ToString(),
                        NumeroPrestamo = Convert.ToInt32(linea["NUMERO_PRESTAMO"]),
                        Fecha_Retiro = Convert.ToDateTime(linea["FECHA_RETIRO"]),
                        Fecha_Devuelta = Convert.ToDateTime(linea["FECHA_DEVUELTA"])
                    };
                    lista_prestamos.Add(newPrestamo);
                }
                return lista_prestamos;
            }
            catch (Exception ex )
            {
                throw new ArgumentException($"Error en Obtener Prestamo DAL \n Error \n {ex.Message}");
            }
        }

    }
}
