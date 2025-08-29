using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
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
        public void Close_TX()
        {
            transaction.Commit();
        }
    }
}
