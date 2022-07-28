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
    public partial class Frm_StokHareketListesi : Form
    {

        #region Constructor
        public Frm_StokHareketListesi()
        {
            InitializeComponent();
            LoadData();

        }


        #endregion

        #region Objects


        SqlConnection conn = Mssql_Manav.GetDBConnection();
        SqlCommandBuilder commandBuilder;
        SqlDataAdapter adtr;
        DataTable tbl = new DataTable();
        SqlDataReader dr;



        #endregion

        #region Methods

        private void girisFişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fis fis = new Fis();
            fis.fisinTipi = "Giris Fisi";
            fis.Text = "Giriş Fişi";
            fis.Show();

        }

        private void çıkışFişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fis fis = new Fis();
            fis.fisinTipi = "Cikis Fisi";
            fis.Text = "Çıkış Fişi";
            fis.Show();
            
        }

        private void StokHareketListesi_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            tbl.Clear();

            adtr = new SqlDataAdapter("select a.fisNo, a.fisTipi, a.tarih, a.belgeNo, a.aciklama, a.firmaId, a.depoId from Tbl_Main a " +
                "left outer join Tbl_Firmalar b on b.id = a.firmaId " +
                "left outer join Tbl_Depo c on c.id = a.depoId", conn);
            adtr.Fill(tbl);

            stokDatagrid.DataSource = tbl;


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Fis fis = new Fis();

            fis.no = Convert.ToInt32(stokDatagrid.CurrentRow.Cells[0].Value);
            fis.fisinTipi = Convert.ToString(stokDatagrid.CurrentRow.Cells[1].Value);
            fis.tarih = Convert.ToString(stokDatagrid.CurrentRow.Cells[2].Value);
            fis.belge = Convert.ToString(stokDatagrid.CurrentRow.Cells[3].Value);
            fis.aciklama = Convert.ToString(stokDatagrid.CurrentRow.Cells[4].Value);
            fis.firma = Convert.ToString(stokDatagrid.CurrentRow.Cells[5].Value);
            fis.depo = Convert.ToString(stokDatagrid.CurrentRow.Cells[6].Value);
            fis.mainId = Convert.ToString(stokDatagrid.CurrentRow.Cells[0].Value);


            fis.Show();

        }
        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        #endregion

    }
}
