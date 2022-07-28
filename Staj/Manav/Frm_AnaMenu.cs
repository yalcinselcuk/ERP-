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
    public partial class Frm_AnaMenu : Form
    {

        #region Constructor

        public Frm_AnaMenu()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ürünlerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Urunler f2 = new Frm_Urunler();
            f2.MdiParent = this;
            f2.Text = "Ürünler";
            f2.Show();
        }

        private void birimToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Birim f2 = new Frm_Birim();
            f2.MdiParent = this;
            f2.Text = "Birim";
            f2.Show();
        }

        private void depoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Depo f2 = new Frm_Depo();
            f2.MdiParent = this;
            f2.Text = "Depolar";
            f2.Show();
        }

        private void firmalarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Firmalar f2 = new Frm_Firmalar();
            f2.MdiParent = this;
            f2.Text = "Firmalar";
            f2.Show();
        }


        private void renkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Renk f2 = new Frm_Renk();
            f2.MdiParent = this;
            f2.Text = "Renkler";
            f2.Show();
        }


        private void stokHareketleriStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_StokHareketListesi stokHareketListesi = new Frm_StokHareketListesi();
            stokHareketListesi.MdiParent = this;
            stokHareketListesi.Show();
            this.Text = "Stok Hareketleri";
        }
        #endregion

        
    }
}
