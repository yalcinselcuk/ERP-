using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manav.Db_Adress
{
    public static class Mssql_Manav
    {
        public static SqlConnection GetDBConnection()
        {
            SqlConnection conn = new SqlConnection(
            "Data Source=LAPTOP-8HOREQD2;Initial Catalog=textileproject;Integrated Security=True");
            return conn;
        }
    }
}
