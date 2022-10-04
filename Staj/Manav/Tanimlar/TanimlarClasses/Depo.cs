using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manav.DataSets;
using Manav.Db_Adress;

namespace Manav.Tanimlar
{
    class Depo :ITanımlar
    {
        #region Objects
        SqlCommand cmd;
        SqlConnection conn = Mssql_Manav.GetDBConnection();
        SqlDataAdapter adtr;
        SqlCommandBuilder commandBuilder;
        DS_Tanimlar ds = null;
        int depoid;
        public DS_Tanimlar DS { get { return ds; } }
        #endregion

        #region Constructor
        public Depo()
        {
            this.ds = new DS_Tanimlar();
        }
        #endregion

        #region Methods
        public void LoadData(int fisref)
        {
            depoid = fisref;
            adtr = new SqlDataAdapter("select id, kod, aciklama from depo", conn);
            conn.Open();
            adtr.Fill(DS.depo);
            DS.depo.kodColumn.Unique = true;
            conn.Close();

            if (depoid < 0)
            {
                CreateNew();
            }
        }
        public void SaveData()
        {
            EmptyRowControle();
            conn.Open();

            cmd = new SqlCommand("SELECT id, kod, aciklama FROM depo", conn);
            adtr.SelectCommand = cmd;
            commandBuilder = new SqlCommandBuilder(adtr);

            adtr.InsertCommand = commandBuilder.GetInsertCommand();
            adtr.DeleteCommand = commandBuilder.GetDeleteCommand();
            adtr.UpdateCommand = commandBuilder.GetUpdateCommand();

            adtr.Update(DS.depo);

            conn.Close();
        }

        public void EmptyRowControle()
        {

            for (int j = 0; j < DS.depo.Rows.Count; j++)
            {
                if ((DS.depo[j].kod == "" || DS.depo[j].kod == DBNull.Value.ToString()))
                {
                    DS.depo.Rows.RemoveAt(j);
                }
            }
            int i = RowKodIsNull();
            if (i == 0) { SetRowId(); }
        }
        public void SetRowId()
        {
            foreach (DataRow row in DS.depo.Rows)
            {
                if (row["id"].ToString() == "" && row["kod"].ToString() != "")
                {
                    depoid = helper.helperclass.GetId("depo");
                    row["id"] = depoid;
                }
            }
        }
        public int RowKodIsNull()
        {
            foreach (DataRow row in DS.depo.Rows)
            {

                if (row["kod"].ToString() == "" && row["aciklama"].ToString() != "")
                {
                    return 1;
                }
                if (row["kod"].ToString() == "" && row["aciklama"].ToString() == "")
                {
                    return 2;
                }
            }
            return 0;
        }
        public void CreateNew()
        {
            DataRow rnew = this.ds.depo.NewRow();
            this.ds.depo.Rows.Add(rnew);
        }
        public void RowDelete(/*int rid*/)
        {
            conn.Open();
            foreach (DataRow row in this.ds.depo.Rows)
            {
                switch (row.RowState)
                {
                    case DataRowState.Deleted:
                        SqlCommand cmd = new SqlCommand("DELETE FROM depo where id = @id", conn);
                        cmd.Parameters.AddWithValue("@id", row["id", DataRowVersion.Original]);
                        cmd.ExecuteNonQuery();

                        DS.depo.Rows.Remove(row);
                        break;
                }
            }
            conn.Close();
        }
        #endregion
    }
}
