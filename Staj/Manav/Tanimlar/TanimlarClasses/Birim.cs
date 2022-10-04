using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manav.DataSets;
using Manav.DataSets;
using Manav.Db_Adress;

namespace Manav.Tanimlar
{
    class Birim : ITanımlar
    {
        #region Objects
        SqlCommand cmd;
        SqlConnection conn = Mssql_Manav.GetDBConnection();
        SqlDataAdapter adtr;
        SqlCommandBuilder commandBuilder;
        DS_Tanimlar ds = null;
        int birimid;
        public DS_Tanimlar DS { get { return ds; } }
        #endregion

        #region Constuctor
        public Birim()
        {
            this.ds = new DS_Tanimlar();
        }
        #endregion

        #region Methods
        public void LoadData(int fisref)
        {
            birimid = fisref;
            adtr = new SqlDataAdapter("select id, kod, aciklama from birim", conn);
            conn.Open();
            adtr.Fill(DS.birim);
            DS.birim.kodColumn.Unique = true;
            conn.Close();

            if (birimid < 0)
            {
                CreateNew();
            }
        }
        public void SaveData()
        {
            //DS.birim.AcceptChanges();
            EmptyRowControle();
            conn.Open();

            cmd = new SqlCommand("SELECT id, kod, aciklama FROM birim", conn);
            adtr.SelectCommand = cmd;
            commandBuilder = new SqlCommandBuilder(adtr);

            adtr.InsertCommand = commandBuilder.GetInsertCommand(true);
            adtr.DeleteCommand = commandBuilder.GetDeleteCommand(true);
            adtr.UpdateCommand = commandBuilder.GetUpdateCommand(true);

            adtr.Update(DS.birim);

            conn.Close();
        }

        public void EmptyRowControle()
        {

            for (int j = 0; j < DS.birim.Rows.Count; j++)
            {
                if ((DS.birim[j].kod == "" || DS.birim[j].kod == DBNull.Value.ToString()))
                {
                    DS.birim.Rows.RemoveAt(j);
                }
            }
            int i = RowKodIsNull();
            if (i == 0) { SetRowId(); }
        }
        public void SetRowId()
        {
            foreach (DataRow row in DS.birim.Rows)
            {
                if (row["id"].ToString() == "" && row["kod"].ToString() != "")
                {
                    birimid = helper.helperclass.GetId("birim");
                    row["id"] = birimid;
                }
            }
        }
        public int RowKodIsNull()
        {
            foreach (DataRow row in DS.birim.Rows)
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
            DataRow rnew = this.ds.birim.NewRow();
            this.ds.birim.Rows.Add(rnew);
        }
        public void RowDelete(/*int rid*/)
        {
            conn.Open();
            foreach (DataRow row in this.ds.birim.Rows)
            {
                switch (row.RowState)
                {
                    case DataRowState.Deleted:
                        SqlCommand cmd = new SqlCommand("DELETE FROM birim where id = @id", conn);
                        cmd.Parameters.AddWithValue("@id", row["id", DataRowVersion.Original]);
                        cmd.ExecuteNonQuery();

                        DS.birim.Rows.Remove(row);
                        break;
                }
            }
            conn.Close();
        }
        #endregion
    }
}

