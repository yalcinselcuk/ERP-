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

namespace Manav.StokHar
{
    public partial class frmStokCikisFisi : Form
    {

        
        StokHarDetailInfo stokHarDetailInfo = null;
        StokHarMainInfo stokHarMainInfo = null;
        stokHareketClass stokHarClass = null;
        public StokHarDetailInfo _StokHarDetailInfo { get { return this.stokHarDetailInfo; } set { this.stokHarDetailInfo = value; } }
        public StokHarMainInfo _stokHarMainInfo { get { return this.stokHarMainInfo; } set { this.stokHarMainInfo = value; } }

        public frmStokCikisFisi()
        {
            stokHarDetailInfo = new StokHarDetailInfo();
            stokHarMainInfo = new StokHarMainInfo();
            this.stokHarClass = new stokHareketClass();
            InitializeComponent();
        }
        int depoid;
        public frmStokCikisFisi(int depoid)
        {
            this.depoid = depoid;
            stokHarDetailInfo = new StokHarDetailInfo();
            stokHarMainInfo = new StokHarMainInfo();
            this.stokHarClass = new stokHareketClass();
            InitializeComponent();
        }

        private void frmStokGiris_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataTable table = new DataTable();
            SqlConnection conn = Db_Adress.Mssql_Manav.GetDBConnection();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM vstokhargiris a WHERE a.urunid is not null and a.depoid = "+depoid, conn);
            conn.Open();
            adtr.Fill(table);
            dataGridView1.DataSource = table;
            conn.Close();

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;

            this.stokHarMainInfo.fisno = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells["fisno"].Value);
            //this.stokHarMainInfo.tarih = Convert.ToDateTime(dataGridView1.Rows[rowindex].Cells["tarih"].Value);
            this.stokHarMainInfo.firmaid = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells["firmaid"].Value);
            this.stokHarMainInfo.depoid = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells["depoid"].Value);
            this.stokHarMainInfo.firmakod = Convert.ToString(dataGridView1.Rows[rowindex].Cells["firmakod"].Value);
            this.stokHarMainInfo.depokod = Convert.ToString(dataGridView1.Rows[rowindex].Cells["depokod"].Value);
            
            this.stokHarDetailInfo.mainid = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells["mainid"].Value);
            this.stokHarDetailInfo.urunid = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells["urunid"].Value);
            this.stokHarDetailInfo.urunkod = dataGridView1.Rows[rowindex].Cells["urunkod"].Value.ToString();
            this.stokHarDetailInfo.renkid = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells["renkid"].Value);
            this.stokHarDetailInfo.renkkod = dataGridView1.Rows[rowindex].Cells["renkkod"].Value.ToString();
            this.stokHarDetailInfo.birimid = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells["birimid"].Value);
            this.stokHarDetailInfo.birimkod = dataGridView1.Rows[rowindex].Cells["birimkod"].Value.ToString();
            this.stokHarDetailInfo.miktar = Convert.ToDecimal(dataGridView1.Rows[rowindex].Cells["miktar"].Value);

           
            
            
            this.DialogResult = DialogResult.OK;
        }
    }
}
