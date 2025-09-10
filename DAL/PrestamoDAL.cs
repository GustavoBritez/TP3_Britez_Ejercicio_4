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
                SqlParameter[] libro = new SqlParameter[] {
                    new SqlParameter("@TITULO", Titulo),
                };

                SqlParameter[] Usuario = new SqlParameter[] {
                    new SqlParameter("@TITULO", Titulo),
                };

                DataTable datos_libro = access.Leer("OBTENER_TITULO",null);
                DataTable datos_usuario = access.Leer("OBTENER_USUARIO_CON_MAIL", null);

                SqlParameter[] PrestamoNuevo = new SqlParameter[]
                {
                    new SqlParameter("@AUTOR", datos_libro.Rows[0]["AUTOR"].ToString()),
                    new SqlParameter("@TITULO", datos_libro.Rows[0]["TITULO"].ToString()),
                    new SqlParameter("@EJEMPLAR", Convert.ToInt32(datos_libro.Rows[0]["EJEMPLAR"])),
                    new SqlParameter("@MAIL", datos_usuario.Rows[0]["MAIL"].ToString()),
                    new SqlParameter("@FECHA_RETIRO", SqlDbType.Date),
                    new SqlParameter("@FECHA_DEVUELTA", SqlDbType.Date)
                };

                access.Escribir("CREAR_PRESTAMO",PrestamoNuevo);

            }
            catch
            {

            }
        }
        public void Devolver_Prestamo()
        {
            try
            {

            }
            catch
            {

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
                        Fecha_Retiro = Convert.ToDateTime(linea["FECHA_RETIRO"]),
                        Fecha_Devuelta = Convert.ToDateTime(linea["FECHA_DEVUELTA"])
                    };
                    lista_prestamos.Add(newPrestamo);
                }

                return lista_prestamos;
            }
            catch (Exception ex )
            {
                throw new ArgumentException(ex.Message);
            }
        }

    }
}
