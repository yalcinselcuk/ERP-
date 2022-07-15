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

namespace Manav
{
    public partial class AltFisMenu : Form
    {

        #region Objects

        Fis fis;
        int column;
        public int id;
        public string kod = "";
        string dt;
        int rows;

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-8HOREQD2\\SQLEXPRESS;Initial Catalog=Manav;Integrated Security=True");
        SqlDataAdapter adtr;
        DataTable tbl = new DataTable();

        #endregion

        #region Events
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = e.RowIndex;

            adtr = new SqlDataAdapter("select id, kod, aciklama from " + dt, baglanti);
            adtr.Fill(tbl);
            ArrayList row = new ArrayList();
            foreach (DataRow dr in tbl.Rows)
            {
                row.Add(dr["kod"].ToString());
            }
            this.kod = row[e.RowIndex].ToString();

            this.Close();

            fis.dataGridFis.Rows.Add();
            fis.dataGridFis.Rows[rows].Cells[column].Value = kod;

            Fill_Kod(e.RowIndex);

        }

        private void Combo_Load(object sender, EventArgs e)
        {
            GetList();
        }
        #endregion

        #region Methods
        DataTable GetList()
        {
            tbl.Clear();

            adtr = new SqlDataAdapter("select id, kod, aciklama from " + dt, baglanti);
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;
            this.dataGridView1.Columns["id"].Visible = false;


            return tbl;
        }

        void Fill_Kod(int e)
        {
            adtr = new SqlDataAdapter("select id, kod, aciklama from " + dt, baglanti);
            adtr.Fill(tbl);
            ArrayList row = new ArrayList();
            foreach (DataRow dr in tbl.Rows)
            {
                row.Add(dr["id"]);
            }
            this.kod = row[e].ToString();
            if (column == 0)
            {
                fis.dataGridFis.Rows[rows].Cells[4].Value = kod;
                fis.uId = Convert.ToInt32(kod);
            }
            if (column == 1)
            {
                fis.dataGridFis.Rows[rows].Cells[5].Value = kod;
                fis.rId = Convert.ToInt32(kod);
            }
            if (column == 2)
            {
                fis.dataGridFis.Rows[rows].Cells[6].Value = kod;
                fis.bId = Convert.ToInt32(kod);
            }
            

        }

        



        #endregion

        #region Constuctor
        public AltFisMenu(string dt, Fis fis, int column, int rows)
        {
            InitializeComponent();
            this.dt = dt;
            this.fis = fis;
            this.column = column;
            this.rows = rows;

        }
        #endregion

    }
}
