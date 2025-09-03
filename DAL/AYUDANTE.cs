using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class AYUDANTE
    {

        /// La idea de esta clase es declararla dentro de la capa DAL para acceder a datos de manera flexible
        
        public static SqlParameter[] Param<T> ( T entidad)
        {
            try
            {
                if (entidad == null)
                    throw new ArgumentNullException(nameof(entidad));
                List<SqlParameter> lista_parametros = new List<SqlParameter>();

                var props = typeof(T).GetProperties();

                foreach( var propiedades in props)
                {
                    var nombre_propiedad = "@" + propiedades.Name.ToUpper();
                    var valor = propiedades.GetValue(entidad) ?? DBNull.Value;

                    lista_parametros.Add(new SqlParameter(nombre_propiedad, valor));
                }

                return lista_parametros.ToArray();

            }
            catch( Exception ex )
            {
                throw new ArgumentException(ex.Message);
            }
        }


    }
}
