
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DAM.DAL
{
    public class Connect
    {
        //public static string connectString = @"data source=ptpm\sqlexpress;initial catalog=SOF205_PS31516;Integrated Security = True";
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["QLBH"].ConnectionString;

        public static SqlConnection getConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
