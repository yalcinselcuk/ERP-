using Manav.Db_Adress;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manav.Tanimlar.TanimlarClasses;
using Manav.StokHar;
using Manav.DataSets;
using Manav.Tanimlar;

namespace Manav
{
    class Renk : ITanımlar
    {
        #region Objects
        SqlCommand cmd;
        SqlConnection conn = Mssql_Manav.GetDBConnection();
        SqlDataAdapter adtr;
        SqlCommandBuilder commandBuilder;
        DS_Tanimlar ds = null;
        int renkid;
        public DS_Tanimlar DS { get { return ds; } }
        #endregion

        #region Constuctor
        public Renk()
        {
            this.ds = new DS_Tanimlar();
        }
        #endregion

        #region Methods
        public void LoadData(int fisref)
        {
            renkid = fisref;
            adtr = new SqlDataAdapter("select id, kod, aciklama from renk", conn);
            conn.Open();
            adtr.Fill(DS.renk);
            DS.renk.kodColumn.Unique = true;
            conn.Close();

            if (renkid < 0)
            {
                CreateNew();
            }
        }
        public void SaveData()
        {
            //DS.birim.AcceptChanges();
            EmptyRowControle();
            conn.Open();

            cmd = new SqlCommand("SELECT id, kod, aciklama FROM renk", conn);
            adtr.SelectCommand = cmd;
            commandBuilder = new SqlCommandBuilder(adtr);

            adtr.InsertCommand = commandBuilder.GetInsertCommand(true);
            adtr.DeleteCommand = commandBuilder.GetDeleteCommand(true);
            adtr.UpdateCommand = commandBuilder.GetUpdateCommand(true);

            adtr.Update(DS.renk);

            conn.Close();
        }

        public void EmptyRowControle()
        {

            for (int j = 0; j < DS.renk.Rows.Count; j++)
            {
                if ((DS.renk[j].kod == "" || DS.renk[j].kod == DBNull.Value.ToString()))
                {
                    DS.renk.Rows.RemoveAt(j);
                }
            }
            int i = RowKodIsNull();
            if (i == 0) { SetRowId(); }
        }
        public void SetRowId()
        {
            foreach (DataRow row in DS.renk.Rows)
            {
                if (row["id"].ToString() == "" && row["kod"].ToString() != "")
                {
                    renkid = helper.helperclass.GetId("birim");
                    row["id"] = renkid;
                }
            }
        }
        public int RowKodIsNull()
        {
            foreach (DataRow row in DS.renk.Rows)
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
            DataRow rnew = this.ds.renk.NewRow();
            this.ds.renk.Rows.Add(rnew);
        }
        public void RowDelete(/*int rid*/)
        {
            conn.Open();
            foreach (DataRow row in this.ds.renk.Rows)
            {
                switch (row.RowState)
                {
                    case DataRowState.Deleted:
                        SqlCommand cmd = new SqlCommand("DELETE FROM renk where id = @id", conn);
                        cmd.Parameters.AddWithValue("@id", row["id", DataRowVersion.Original]);
                        cmd.ExecuteNonQuery();

                        DS.renk.Rows.Remove(row);
                        break;
                }
            }
            conn.Close();
        }
        #endregion
    }
}
