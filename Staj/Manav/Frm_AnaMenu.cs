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

        Frm_Stok urunler;
        private void ürünlerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (urunler == null || urunler.IsDisposed)
            {
                urunler = new Frm_Stok();
                urunler.MdiParent = this;
                urunler.Text = "Ürünler";
                urunler.Show();

            }
        }

        Frm_Birim birim;
        private void birimToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (birim == null || birim.IsDisposed)
            {
                birim = new Frm_Birim();
                birim.MdiParent = this;
                birim.Text = "Birim";
                birim.Show();
            }
        }

        Frm_Depo depo;
        private void depoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (depo == null || depo.IsDisposed)
            {
                depo = new Frm_Depo();
                depo.MdiParent = this;
                depo.Text = "Depolar";
                depo.Show();
            }
        }

        Frm_Firmalar firmalar;
        private void firmalarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (firmalar == null || firmalar.IsDisposed)
            {
                firmalar = new Frm_Firmalar();

                firmalar.MdiParent = this;
                this.Text = "Firmalar";
                firmalar.Show();
            }
        }

        Frm_Renk renk;
        private void renkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (renk == null || renk.IsDisposed)
            {
                renk = new Frm_Renk();

                renk.MdiParent = this;
                this.Text = "Renkler";
                renk.Show();
            }
        }

        Frm_StokHareketListesi stokHareketListesi;
        private void stokHareketleriStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stokHareketListesi == null || stokHareketListesi.IsDisposed)
            {
                stokHareketListesi = new Frm_StokHareketListesi();

                stokHareketListesi.MdiParent = this;
                
                this.Text = "Stok Hareketleri";
                stokHareketListesi.Show();
            }
        }
        #endregion
    }
}
