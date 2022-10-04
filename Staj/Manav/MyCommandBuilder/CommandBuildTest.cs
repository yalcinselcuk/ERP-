using Manav.Db_Adress;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manav.MyCommandBuilder
{
    class CommandBuildTest
    {
        public void dnm()
        {
            SqlDataAdapter adapter = null;
            SqlConnection conn = Mssql_Manav.GetDBConnection();

            string selectQuery = "SELECT * FROM Tbl_Main";
            adapter = new SqlDataAdapter(selectQuery, conn);

            adapter = SqlCommandBuildertest.BuildAll(adapter, conn);
        }
    }

    public static class SqlCommandBuildertest
    {
        public enum CommandType
        {
            Update = 0,
            Insert = 1,
            Delete = 2
        }

        public static SqlDataAdapter BuildAll(SqlDataAdapter adapter, SqlConnection connection, string database = null)
        {
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);

            if (database == null)
            {
                if (string.IsNullOrEmpty(connection.Database))
                {
                    throw new ArgumentException(
                        "Could not determine database from connection object. Please specify it manually"
                        );
                }
                database = connection.Database;
            }
            adapter.InsertCommand = BuildCommand(CommandType.Insert, connection, database, datatable);
            adapter.UpdateCommand = BuildCommand(CommandType.Update, connection, database, datatable);
            adapter.DeleteCommand = BuildCommand(CommandType.Delete, connection, database, datatable);

            return adapter;
        }

        public static SqlCommand BuildCommand(CommandType cmdtype, SqlConnection connection, string database, DataTable datatable)
        {
            StringBuilder sql = new StringBuilder("INSERT INTO " + datatable.TableName + " (");
            StringBuilder values = new StringBuilder("VALUES (");
            bool bFirst = true;//ona göre virgül veya @ gelecek ; biz default boş olduğunu kabul ediyoruz string'in

            string strCommand = null;

            switch (cmdtype)
            {
                case CommandType.Insert:

                    
                    break;
                case CommandType.Update:
                    

                    break;
                case CommandType.Delete:
                    
                    break;
            }

            SqlCommand command = new SqlCommand(strCommand, connection);

            //// cycle through all columns
            //for (int i = 0; i < allColumns.Length; i++)
            //{
            //    string col = allColumns[i];

            //    // create a parameter for that column
            //    SqlParameter para = new SqlParameter()
            //    {
            //        ParameterName = "@" + col.Replace(" ", ""),
            //        SourceColumn = col
            //    };
            //    // add the paramter to the command
            //    command.Parameters.Add(para);

            //    // in the special case of the update statement, extra parameters are needed for the
            //    // old values
            //    if (cmdtype == CommandType.Update)
            //    {
            //        // create a parameter for that column
            //        para = new SqlParameter()
            //        {
            //            ParameterName = "@old" + col.Replace(" ", ""),
            //            SourceColumn = col,
            //            SourceVersion = DataRowVersion.Original
            //        };
            //        // add the paramter to the command
            //        command.Parameters.Add(para);
            //    }
            //}

            return command;
        }
    }
}
