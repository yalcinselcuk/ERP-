using Manav.Db_Adress;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manav.Tanimlar.TanimlarClasses
{
    public class Tanimlars
    {
        #region Objects
        public DataSet dataSet = new DataSet();
        DataTable tbl = new DataTable("tanimlars");
        SqlConnection conn = Mssql_Manav.GetDBConnection();
        SqlDataAdapter adtr;
        SqlCommandBuilder commandBuilder;

        string tablename;
        #endregion

        #region Constructor

        public Tanimlars(string tablename)
        {
            this.tablename = tablename;
        }
        #endregion

        #region Methods

        public void LoadData()
        {
            tbl.Clear();

            adtr = new SqlDataAdapter("select id, kod, aciklama from " + tablename, conn);
            conn.Open();

            adtr.Fill(tbl);
            dataSet.Tables.Add(tbl);
            conn.Close();
        }

        public void SaveData()
        {
            commandBuilder = new SqlCommandBuilder(adtr);
            
            adtr.Update(dataSet.Tables["tanimlars"]);
        }
        #endregion
    }
}
