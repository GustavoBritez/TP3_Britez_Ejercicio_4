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
                    new SqlParameter("@TITULO", SqlDbType.VarChar,100) {Value = Titulo},
                };

                SqlParameter[] Usuario_mail = new SqlParameter[] {
                    new SqlParameter("@MAIL", SqlDbType.VarChar,100) {Value = mail},
                };

                DateTime fechaRetiro = DateTime.Now;  
                DateTime fechaDevuelta = DateTime.Now.AddDays(7);

                DataTable libro = access.Leer("OBTENER_TITULO",libro_titulo);
                DataTable usuario = access.Leer("OBTENER_USUARIO_CON_MAIL", Usuario_mail);

                SqlParameter[] prestamoNuevo = new SqlParameter[]
                {
                    new SqlParameter("@TITULO", SqlDbType.VarChar,100) {Value = libro.Rows[0]["TITULO"]},
                    new SqlParameter("@ID_USUARIO", SqlDbType.Int) { Value = Convert.ToInt32(usuario.Rows[0]["ID_USUARIOS"]) },
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

                foreach( DataRow linea in tabla_prestamos.Rows )
                {
                    PrestamoBE newPrestamo = new PrestamoBE
                    {
                        NumeroPrestamo = Convert.ToInt32(linea["ID_PRESTAMO"]),
                        IdUsuario = Convert.ToInt32(linea["ID_USUARIOS"]),
                        Titulo = Convert.ToString(linea["TITULO"]),
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
