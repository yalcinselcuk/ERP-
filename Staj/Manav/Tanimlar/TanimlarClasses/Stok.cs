using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Manav.Db_Adress;
using Manav.DataSets;
using System.Windows.Forms;

namespace Manav.Tanimlar
{
    class Stok : ITanımlar
    {
        #region Objects
        SqlCommand cmd;
        SqlConnection conn = Mssql_Manav.GetDBConnection();
        SqlDataAdapter adtr;
        SqlCommandBuilder commandBuilder;
        DS_Tanimlar ds = null;
        int stokid;
        public DS_Tanimlar DS { get { return ds; } }
        #endregion

        #region Constuctor
        public Stok()
        {
            this.ds = new DS_Tanimlar();
        }
        #endregion

        #region Methods
        public void LoadData(int fisref)
        {
            stokid = fisref;
            adtr = new SqlDataAdapter("SELECT id, kod, aciklama FROM stok a ", conn);
            conn.Open();
            adtr.Fill(DS.stok);
            DS.stok.kodColumn.Unique = true;
            conn.Close();

            if (stokid < 0)
            {
                CreateNew();
            }
        }
        public void SaveData()
        {
            //DS.birim.AcceptChanges();
            EmptyRowControle();
            conn.Open();

            cmd = new SqlCommand("SELECT id, kod, aciklama FROM stok a ", conn);
            adtr.SelectCommand = cmd;
            commandBuilder = new SqlCommandBuilder(adtr);

            adtr.InsertCommand = commandBuilder.GetInsertCommand(true);
            adtr.DeleteCommand = commandBuilder.GetDeleteCommand(true);
            adtr.UpdateCommand = commandBuilder.GetUpdateCommand(true);

            adtr.Update(DS.stok);

            conn.Close();
        }

        public void EmptyRowControle()
        {

            for (int j = 0; j < DS.stok.Rows.Count; j++)
            {
                if ((DS.stok[j].kod == "" || DS.stok[j].kod == DBNull.Value.ToString()))
                {
                    DS.stok.Rows.RemoveAt(j);
                }
            }
            int i = RowKodIsNull();
            if (i == 0) { SetRowId(); }
        }
        public void SetRowId()
        {
            foreach (DataRow row in DS.stok.Rows)
            {
                if (row["id"].ToString() == "" && row["kod"].ToString() != "")
                {
                    stokid = helper.helperclass.GetId("stok");
                    row["id"] = stokid;
                }
            }
        }
        public int RowKodIsNull()
        {
            foreach (DataRow row in DS.stok.Rows)
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
            DataRow rnew = this.ds.stok.NewRow();
            this.ds.stok.Rows.Add(rnew);
        }
        public void RowDelete(/*int rid*/)
        {
            conn.Open();
            foreach (DataRow row in this.ds.stok.Rows)
            {
                switch (row.RowState)
                {
                    case DataRowState.Deleted:
                        SqlCommand cmd = new SqlCommand("DELETE FROM stok where id = @id", conn);
                        cmd.Parameters.AddWithValue("@id", row["id", DataRowVersion.Original]);
                        cmd.ExecuteNonQuery();

                        DS.stok.Rows.Remove(row);
                        break;
                }
            }
            conn.Close();
        }
        #endregion
    }
}
