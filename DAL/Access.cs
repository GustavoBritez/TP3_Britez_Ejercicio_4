using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Access
    {
        private SqlConnection conexion = new SqlConnection();
        private SqlTransaction transaction;

        public void Open()
        {
            conexion.Open();
        }
        public void Close()
        {
            conexion.Close();
        }
        public void Start_TX()
        {
            transaction = conexion.BeginTransaction();
        }
        public void Cancel_TX()
        {
            transaction.Rollback();
        }
        public void Commit_TX()
        {
            transaction.Commit();
        }
        
        public int Escribir ( string Query , SqlParameter[] sp)
        {
            int resultado = 0;
            try
            {
                Open();
                using ( SqlCommand cmd = new SqlCommand( Query , conexion ))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    if (sp != null)
                        cmd.Parameters.AddRange(sp);
                    Start_TX();
                    resultado = cmd.ExecuteNonQuery();
                    Close();
                }
                return resultado ;
            }
            catch
            {
                Cancel_TX();
                return -1;
            }
            finally
            {
                Close();
            }
        }

        public DataTable Leer ( string Query , SqlParameter[] sp , string archive = null)
        {
            DataTable tabla_datos = new DataTable();    
            try
            {
                Open();
                using (SqlCommand cmd = new SqlCommand(Query, conexion))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    if (sp != null)
                        cmd.Parameters.AddRange(sp);
                    using ( SqlDataAdapter adapter = new(cmd) )
                    {
                        adapter.Fill(tabla_datos);
                    }
                }
                return tabla_datos;
            }
            catch( Exception ex ) when ( archive != null )
            {
                string path = $"{archive}.XML";
                if ( File.Exists(path))
                {
                    try
                    {
                        DataSet DS = new DataSet();
                        DS.ReadXml(path);
                        if (DS != null)
                            throw new ArgumentException($"No se pudo leer{path}");
                        if (DS.Tables.Count > 0)
                            tabla_datos = DS.Tables[0];  
                        
                        return tabla_datos;
                    }
                    catch( Exception XML )
                    {
                        throw new Exception($" Error al leer {path} : {archive} , {ex.Message}");
                    }
                }
            }
            finally
            {
                Close();
            }
            return tabla_datos;
        }

        /*public int Write( string Query , SqlParameter[] sp)
        {
            int ar;
            try
            {
                Open();
                Start_TX();
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conexion,
                    CommandText = Query ,
                    CommandType = CommandType.StoredProcedure
                };
                if (sp != null)
                    cmd.Parameters.AddRange(sp);
                ar = cmd.ExecuteNonQuery(); 
            }
            catch
            {
                Cancel_TX();
                ar = -1;
            }
            finally
            {
                Close();
            }
            return ar;
        }*/

        /*public DataTable Read( string Query , SqlParameter[] sp)
        {
            DataTable dataTable = new DataTable();
            try
            {
                Open();
                using ( SqlCommand cmd = new SqlCommand(Query, conexion) )
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if ( sp != null )
                        cmd.Parameters.AddRange( sp );
                    using ( SqlDataAdapter adapter = new SqlDataAdapter(cmd) )
                    {
                        adapter.Fill( dataTable );
                    }
                }
            }
            finally
            {
                Close();
            }
            return dataTable;   
        }*/

        /*public DataTable Read ( string Query , SqlParameter[] sp, string archive )
        {
            DataTable dataTable = new DataTable();
            try
            {
                Open();
                using ( SqlCommand cmd = new SqlCommand(Query,conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if ( sp != null )
                        cmd.Parameters.AddRange ( sp );

                    using ( SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch( Exception ex )
            {
                string path = $"{archive}.XML";
                if (File.Exists(path))
                {
                    try
                    {
                        DataSet ds = new DataSet();
                        ds.ReadXml(path);
                        if ( ds.Tables.Count > 0 )
                            dataTable = ds.Tables[0];
                    }
                    catch( Exception XML )
                    {
                        throw new Exception($"Error leyendo {path} {XML.Message}");
                    }
                }
            }
            finally
            {
                Close();
            }
            return dataTable;
        }*/
    }
}
