using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Microsoft.Data.SqlClient;

namespace DAL
{
    public class UsuarioDAL
    {
        public Access mapper = new();

        public bool Register( UsuarioBE agregar )
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@NOMBRE",System.Data.SqlDbType.NVarChar ){ Value = agregar.Nombre},
                    new SqlParameter("@MAIL",System.Data.SqlDbType.VarChar ){Value = agregar.Mail},
                    new SqlParameter("@CONTRASENIA",System.Data.SqlDbType.VarChar ){Value = agregar.Contrasenia}
                };
                mapper = new();
                int resultado = mapper.Escribir("ALTA_USUARIO", param);

                return resultado > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool Login( string usuario , string contrasenia )
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@USUARIO",System.Data.SqlDbType.NChar){ Value = usuario },
                    new SqlParameter("@CONTRASENIA",System.Data.SqlDbType.NVarChar) {Value = contrasenia}
                };

                DataTable resultado = mapper.Leer("Obtener_Usuario", param);

                if (resultado.Rows.Count == 0)
                    return false;
                string guardado = resultado.Rows[0]["Contrasenia"].ToString();

                if (string.IsNullOrEmpty(guardado))
                    return false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<UsuarioBE> Obtener_Usuarios()
        {
            try
            {
                List<UsuarioBE> list_usuario = new List<UsuarioBE>();

                DataTable tabla = mapper.Leer("OBTENER_USUARIOS",null);

                foreach( DataRow linea in tabla.Rows )
                {
                    UsuarioBE usuario = new UsuarioBE
                    {
                        Id_Usuario = linea["ID_USUARIOS"] != DBNull.Value ? Convert.ToInt32(linea["ID_USUARIOS"]) : 0,
                        Nombre = linea["NOMBRE"] != DBNull.Value ? Convert.ToString(linea["NOMBRE"]) : string.Empty,
                        Mail = linea["MAIL"] != DBNull.Value ? Convert.ToString(linea["MAIL"]) : string.Empty,
                        Contrasenia = linea["CONTRASENIA"] != DBNull.Value ? Convert.ToString(linea["CONTRASENIA"]) : string.Empty
                    };
                    list_usuario.Add(usuario);
                }
                
                return list_usuario;
            }
            catch( Exception ex )
            {
                throw new ArgumentException(" Error al obtener usuarios en la DAL ");
            }
        }
    }
}
