using Manav.Db_Adress;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manav.FisFolder
{
    public partial class Frm_AltUrunMenu : Frm_AltFisMenu
    {
        
        #region Objects

        string kod;
        string id;
        int rows;
        Fis fis;

        SqlCommandBuilder commandBuilder;
        SqlDataAdapter adtr;
        DataTable tbl = new DataTable();
        SqlConnection conn = Mssql_Manav.GetDBConnection();

        #endregion

        #region Constructor

        public Frm_AltUrunMenu()
        {
            InitializeComponent();
        }
        public Frm_AltUrunMenu(Fis fis, int rows)
        {
            InitializeComponent();
            this.fis = fis;
            this.rows = rows;
        }

        #endregion

        #region Methods

        protected override void LoadData()
        {
            tbl.Clear();

            adtr = new SqlDataAdapter("select id, kod, aciklama from Tbl_Urunler", conn);
            conn.Open();
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;
            Visible_False();
            Column_Name();
            conn.Close();
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
        protected override void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            adtr = new SqlDataAdapter("select id, kod, aciklama from Tbl_Urunler", conn);
            adtr.Fill(tbl);

            ArrayList row = new ArrayList();
            foreach (DataRow dr in tbl.Rows)
            {
                row.Add(dr["kod"].ToString());
            }
            this.kod = row[e.RowIndex].ToString();

            this.Close();

            fis.dataGridFis.Rows[rows].Cells[0].Value = kod;

            Fill_KodId(e.RowIndex);
        }

        protected override void Fill_KodId(int rowIndex)
        {
            adtr = new SqlDataAdapter("select id, kod, aciklama from Tbl_Urunler", conn);
            adtr.Fill(tbl);

            ArrayList row = new ArrayList();
            foreach (DataRow dr in tbl.Rows)
            {
                row.Add(dr["id"]);
            }
            this.id = row[rowIndex].ToString();
            fis.dataGridFis.Rows[rows].Cells[4].Value = id;

        }

        #endregion


    }
}
