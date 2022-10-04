using Manav.Db_Adress;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manav.helper
{
    public static class helperclass
    {
     
        public static int GetId(string tablename)
        {
            int tableref = -1;
            SqlConnection conn = Mssql_Manav.GetDBConnection();
            SqlDataReader dr = null;
 
            SqlCommand cmdNew = new SqlCommand();
            conn.Open();
            dr = null;
            cmdNew.Connection = conn;


            cmdNew.CommandText = "SELECT a.id  FROM id a WHERE a.tablename = '" + tablename + "' ";

            dr = cmdNew.ExecuteReader();

            while (dr.Read())
            {
                // value is null
                if (dr.GetValue(0) != DBNull.Value)
                {
                
                    tableref = Convert.ToInt32(dr.GetValue(0));
                  
                }
            }
            dr.Close();

            if(tableref == -1)
            {
                tableref = 1;
                cmdNew.CommandText = "INSERT INTO id (tablename,id) VALUES(@tablename, @id)";
                cmdNew.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = tableref;
                cmdNew.Parameters.Add("@tablename", System.Data.SqlDbType.VarChar).Value = tablename;
                cmdNew.ExecuteNonQuery();

            }
            else
            {
                tableref++;
                cmdNew.CommandText = "update id set id = @id where tablename = @tablename";
                cmdNew.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = tableref;
                cmdNew.Parameters.Add("@tablename", System.Data.SqlDbType.VarChar).Value = tablename;
                cmdNew.ExecuteNonQuery();
            }

            conn.Close();

            return tableref;
        }

    }
}
