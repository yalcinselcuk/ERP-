using Manav.Db_Adress;
using Manav.StokHar;
using Manav.Tanimlar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Manav.MyCommandBuilder
{

    public class MyCommandBuilders
    {
        public SqlCommand GetInsertCommand(DataTable stokharmain)
        {
            SqlConnection conn = Mssql_Manav.GetDBConnection();
            SqlCommand command = CreateInsertCommand(stokharmain);

            return command;
        }

        public static SqlCommand CreateInsertCommand(DataTable stokharmain)
        {
            string sql = BuildInsertSQL(stokharmain);
            SqlCommand command = CreateParameters(stokharmain);
            command.CommandText = sql;
            command.CommandType = System.Data.CommandType.Text;
            return command;
        }

        public static string BuildInsertSQL(DataTable stokharmain)
        {
            StringBuilder sql = new StringBuilder("INSERT INTO " + stokharmain.TableName + " (");
            StringBuilder values = new StringBuilder("VALUES (");
            bool bFirst = true;//ona göre virgül veya @ gelecek ; biz default boş olduğunu kabul ediyoruz string'in

            foreach (DataColumn column in stokharmain.Columns)
            {
                if (bFirst)
                    bFirst = false;
                else
                {
                    sql.Append(", ");
                    values.Append(", ");
                }
                sql.Append(column.ColumnName);
                values.Append("@");
                values.Append(column.ColumnName);
            }
            sql.Append(") ");
            sql.Append(values.ToString());
            sql.Append(")");

            return sql.ToString();
        }
        public static SqlCommand CreateParameters(DataTable maintable)
        {
            //StringBuilder sql = new StringBuilder();
            string _parameters;
            StringBuilder values = new StringBuilder();
            SqlCommand command = new SqlCommand();
            bool bFirst = true;//ona göre virgül veya @ gelecek ; biz default boş olduğunu kabul ediyoruz string'in

            foreach (DataColumn column in maintable.Columns)
            {
                _parameters = "@" + column.ColumnName;
                command.Parameters.AddWithValue(_parameters, maintable.Rows[0][column.ColumnName]);
            }
            return command;
        }
    }
}


