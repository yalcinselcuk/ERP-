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
using Manav.StokHar;

namespace Manav
{
    public partial class Frm_StokHareketListesi : Form
    {

        #region Constructor
        public Frm_StokHareketListesi()
        {
            InitializeComponent();
        }
        #endregion

        #region Objects
        SqlConnection conn = Mssql_Manav.GetDBConnection();
        SqlDataAdapter adtr;
        DataTable tbl = new DataTable();

        stokHareketClass stokHarClass = new stokHareketClass();
        #endregion

        #region Methods

        private void girisFişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokHareketClass.fistype = 1;
            frmStokHar frmStokHar = new frmStokHar();
            frmStokHar.MdiParent = this.MdiParent;
            frmStokHar.Text = "Giriş Fişi";
            //frmStokHar.fisTipi = 1;
            frmStokHar.Show();
        }

        private void çıkışFişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokHareketClass.fistype = 0;
            //frmStokHar frmStokHar = new frmStokHar();
            //frmStokHar.MdiParent = this.MdiParent;
            //frmStokHar.Text = "Çıkış Fişi";
            //frmStokHar.Show();
            frmStokCikis frmStokCikisFisi = new frmStokCikis();
            if(frmStokCikisFisi.ShowDialog() == DialogResult.OK)
            {
                frmStokHar frmStokHar = new frmStokHar(frmStokCikis.depoId, 0);
                frmStokHar.MdiParent = this.MdiParent;
                frmStokHar.Text = "Çıkış Fişi";
                frmStokHar.Show();
            }
        }

        private void StokHareketListesi_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            tbl.Clear();

            adtr = new SqlDataAdapter("SELECT a.id, a.fisno, a.fistipi, a.tarih, " +
                                     "a.belgeno, a.aciklama, a.firmaid, firmakod = b.kod, a.depoid, depokod = c.kod," +
                                        "CASE a.fistipi" +
                                        "      WHEN '1' THEN 'Giriş Fişi'" +
                                        "      WHEN '0' THEN 'Çıkış Fişi' " +
                                        "END AS 'Fiş Kodu'" +
                                     "FROM stokharmain a " +
                                     "LEFT OUTER JOIN firmatanim b on b.id = a.firmaid " +
                                     "LEFT OUTER JOIN depotanim c on c.id = a.depoid", conn);

            adtr.Fill(tbl);

            datagridstok.DataSource = tbl;
            datagridstok.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            datagridstok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            frmStokHar frmStokHar = new frmStokHar(Convert.ToInt32(datagridstok.CurrentRow.Cells[0].Value));
            //frmStokHar.fisTipi = 1;
            stokHareketClass.fistype = 1;
            frmStokHar.MdiParent = this.MdiParent;

            frmStokHar.Show();

        }
        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion

        private void stokDatagrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            datagridstok.ClearSelection();
        }
    }
}
