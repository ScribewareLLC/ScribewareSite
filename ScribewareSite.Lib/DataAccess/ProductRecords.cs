using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ScribewareSite.Lib.Models;
using Microsoft.Data.SqlClient;

namespace ScribewareSite.Lib.DataAccess
{
    public static class Records
    {
        public static List<T> Get<T>(string conString, string storedProcedure, object parameters = null)
        {
            using(SqlConnection conn = new SqlConnection(conString))
            {
                return conn.Query<T>(storedProcedure, parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
            }
        }

        public static void Manipulate(string conString, string storedProcedure, object parameters)
        {
            using(SqlConnection conn = new SqlConnection(conString))
            {
                conn.Execute(storedProcedure, parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
