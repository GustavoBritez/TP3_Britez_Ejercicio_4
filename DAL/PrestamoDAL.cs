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
        public void Obtener_Prestamos()
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
