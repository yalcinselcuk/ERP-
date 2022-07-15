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

namespace Manav
{
    public partial class StokHareketListesi : Form
    {

        #region Objects


        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-8HOREQD2\\SQLEXPRESS;Initial Catalog=Manav;Integrated Security=True");
        SqlCommandBuilder commandBuilder;
        SqlDataAdapter adtr;
        DataTable tbl = new DataTable();


        #endregion


        #region Constructor
        public StokHareketListesi()
        {
            InitializeComponent();
            GetList();
        }

       

        #endregion

        #region Events

        private void girisFişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fis fis = new Fis();
            fis.fisinTipi = "Giris Fisi";
            fis.Show();

        }

        private void çıkışFişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fis fis = new Fis();
            fis.fisinTipi = "Satış Fisi";
            fis.Show();
        }


        #endregion

        private void StokHareketListesi_Load(object sender, EventArgs e)
        {
            GetList();
        }

        DataTable GetList()
        {
            tbl.Clear();

            adtr = new SqlDataAdapter("select * from Tbl_Main m full outer join Tbl_Details d on m.id=d.mainId", baglanti);
            adtr.Fill(tbl);
            
            dataGridView1.DataSource = tbl;
            this.dataGridView1.Columns["id"].Visible = false;
            this.dataGridView1.Columns["id1"].Visible = false;
            this.dataGridView1.Columns["firmaId"].Visible = false;
            this.dataGridView1.Columns["depoId"].Visible = false;
            this.dataGridView1.Columns["urunId"].Visible = false;
            this.dataGridView1.Columns["renkId"].Visible = false;
            this.dataGridView1.Columns["birimId"].Visible = false;
            this.dataGridView1.Columns["mainId"].Visible = false;

            return tbl;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Fis fis = new Fis();
            fis.no = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value );
            fis.tarih = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            fis.belge = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            fis.aciklama = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            fis.firma = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);
            fis.depo = Convert.ToString(dataGridView1.CurrentRow.Cells[9].Value);
            fis.urunAdi = Convert.ToString(dataGridView1.CurrentRow.Cells[13].Value);
            fis.renkAdi = Convert.ToString(dataGridView1.CurrentRow.Cells[15].Value);
            fis.birimAdi = Convert.ToString(dataGridView1.CurrentRow.Cells[17].Value);
            fis.miktarOlcu = Convert.ToString(dataGridView1.CurrentRow.Cells[18].Value);
            fis.Show();   
        }

        

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetList();
        }
    }
}
