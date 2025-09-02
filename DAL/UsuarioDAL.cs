using System;
using System.Collections.Generic;
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
        public Access mapper;

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

                int resultado = mapper.Write("Insertar_Usuario", param);

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

                DataTable resultado = mapper.Read("Obtener_Usuario", param);

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
    }
}
