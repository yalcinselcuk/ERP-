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
    class Firmalar : ITanımlar
    {
        #region Objects
        SqlCommand cmd;
        SqlConnection conn = Mssql_Manav.GetDBConnection();
        SqlDataAdapter adtr;
        SqlCommandBuilder commandBuilder;
        DS_Tanimlar ds = null;
        int firmaid;
        public DS_Tanimlar DS { get { return ds; } }
        #endregion

        #region Constuctor
        public Firmalar()
        {
            this.ds = new DS_Tanimlar();
        }
        #endregion

        #region Methods
        public void LoadData(int fisref)
        {
            firmaid = fisref;
            adtr = new SqlDataAdapter("select id, kod, aciklama from firma", conn);
            conn.Open();
            adtr.Fill(DS.firma);
            DS.firma.kodColumn.Unique = true;
            conn.Close();

            if (firmaid < 0)
            {
                CreateNew();
            }
        }
        public void SaveData()
        {
            //DS.birim.AcceptChanges();
            EmptyRowControle();
            conn.Open();

            cmd = new SqlCommand("SELECT id, kod, aciklama FROM firma", conn);
            adtr.SelectCommand = cmd;
            commandBuilder = new SqlCommandBuilder(adtr);

            adtr.InsertCommand = commandBuilder.GetInsertCommand(true);
            adtr.DeleteCommand = commandBuilder.GetDeleteCommand(true);
            adtr.UpdateCommand = commandBuilder.GetUpdateCommand(true);

            adtr.Update(DS.firma);

            conn.Close();
        }

        public void EmptyRowControle()
        {

            for (int j = 0; j < DS.firma.Rows.Count; j++)
            {
                if ((DS.firma[j].kod == "" || DS.firma[j].kod == DBNull.Value.ToString()))
                {
                    DS.firma.Rows.RemoveAt(j);
                }
            }
            int i = RowKodIsNull();
            if (i == 0) { SetRowId(); }
        }
        public void SetRowId()
        {
            foreach (DataRow row in DS.firma.Rows)
            {
                if (row["id"].ToString() == "" && row["kod"].ToString() != "")
                {
                    firmaid = helper.helperclass.GetId("firma");
                    row["id"] = firmaid;
                }
            }
        }
        public int RowKodIsNull()
        {
            foreach (DataRow row in DS.firma.Rows)
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
            DataRow rnew = this.ds.firma.NewRow();
            this.ds.firma.Rows.Add(rnew);
        }
        public void RowDelete(/*int rid*/)
        {
            conn.Open();
            foreach (DataRow row in this.ds.firma.Rows)
            {
                switch (row.RowState)
                {
                    case DataRowState.Deleted:
                        SqlCommand cmd = new SqlCommand("DELETE FROM firma where id = @id", conn);
                        cmd.Parameters.AddWithValue("@id", row["id", DataRowVersion.Original]);
                        cmd.ExecuteNonQuery();

                        DS.firma.Rows.Remove(row);
                        break;
                }
            }
            conn.Close();
        }
        #endregion

    }
}
