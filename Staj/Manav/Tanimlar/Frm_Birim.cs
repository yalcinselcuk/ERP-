using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manav.Db_Adress;

namespace Manav
{
    public partial class Frm_Birim : Frm_Tanimlamalar
    {

        #region Constructor

        public Frm_Birim()
        {
            InitializeComponent();
        }

        #endregion

        #region Objects

        DataTable tbl = new DataTable();
        SqlConnection conn = Mssql_Manav.GetDBConnection();
        SqlDataAdapter adtr;
        SqlCommandBuilder commandBuilder;

        #endregion

        #region Methods

        protected override void LoadData()
        {
            tbl.Clear();
            adtr = new SqlDataAdapter("select id, kod, aciklama from Tbl_Birim", conn);
            base.Open_Conn();
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;
            Visible_False();
            Column_Name();
            base.Close_Conn();
        }
        protected override void saveData()
        {
            commandBuilder = new SqlCommandBuilder(adtr);
            adtr.Update(tbl);
            LoadData();
        }

        protected override void Column_Name()
        {
            dataGridView1.Columns[1].HeaderText = "KOD";
            dataGridView1.Columns[2].HeaderText = "AÇIKLAMA";
        }
        private void Visible_False()
        {
            dataGridView1.Columns[0].Visible = false;
        }

        #endregion
    }
}
