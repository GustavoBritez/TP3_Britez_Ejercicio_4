using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DAL
{
    public class Access
    {
        SqlConnection conexion = new SqlConnection();
        SqlTransaction transaction;

        public void Open()
        { conexion.Open(); }
        public void Close()
        {  conexion.Close(); }

        public void Start_TX()
        {
            transaction = conexion.BeginTransaction();
        }

        public void Accept_TX()
        {
            transaction.Commit();
        }

        public void Cancel_TX()
        {
            transaction.Rollback();
        }

        internal int Writer(string query ,SqlTransaction[] sp )
        {
            int ar;
            try
            {
                Open();
                Start_TX();
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conexion,
                    CommandType = CommandType.Text,
                    CommandText = query
                };
                cmd.Parameters.AddRange( sp );
                Accept_TX();
                ar  = cmd.ExecuteNonQuery();
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
        }
        internal DataTable Read(string query , SqlParameter[] sp)
        {
            DataTable tabla_datos = new DataTable();
            try
            {
                Open();
                SqlDataAdapter adapter = new SqlDataAdapter
                {
                    SelectCommand = new SqlCommand
                    {
                        Connection = conexion,
                        CommandType = CommandType.StoredProcedure,
                        CommandText = query,
                    }
                };
                if ( sp != null )
                    adapter.SelectCommand.Parameters.AddRange( sp );
                adapter.Fill(tabla_datos);
            }
            finally
            {
                Close();
            }
            return tabla_datos;
        }
        internal DataTable Read(string query, SqlParameter[] sp , string archivo)
        {
            DataTable dataTable = new DataTable();
            try
            {
                Open();
                SqlDataAdapter adaper = new SqlDataAdapter
                {
                    SelectCommand = new SqlCommand
                    {
                        Connection = conexion,
                        CommandType = CommandType.StoredProcedure,
                        CommandText = query,
                    }
                };
                if ( sp != null )
                    adaper.SelectCommand.Parameters.AddRange( sp );
                adaper.Fill(dataTable);
            }
            catch
            {
                DataSet ds = new DataSet();
                ds.ReadXml($"{archivo}.xml");
                dataTable = ds.Tables[0];
            }
            finally
            {
                Close();
            }
            return dataTable;
        }

        internal string ReadData(string query, SqlParameter[] sp)
        {
            string data = null;
            try
            {
                Open();
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conexion,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = query,
                };
                if (sp != null)
                    cmd.Parameters.AddRange(sp);
                object result = cmd.ExecuteScalar();
                data = result?.ToString();
            }
            finally 
            {
                Close();
            }
            return data;
        }
    }
}
