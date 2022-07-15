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
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void ürünlerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel_Close();
            Tanimlamalar f2 = new Tanimlamalar("Tbl_Urunler");
            f2.MdiParent = this;
            f2.Text = "Ürünler";
            f2.Show();

        }

        private void birimToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel_Close();
            Tanimlamalar f2 = new Tanimlamalar("Tbl_Birim");
            f2.MdiParent = this;
            f2.Text = "Birim";
            f2.Show();
        }

        private void depoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel_Close();
            Tanimlamalar f2 = new Tanimlamalar("Tbl_Depo");
            f2.MdiParent = this;
            f2.Text = "Depo";
            f2.Show();
        }

        private void firmalarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel_Close();
            Tanimlamalar f2 = new Tanimlamalar("Tbl_Firmalar");
            f2.MdiParent = this;
            f2.Text = "Firmalar";
            f2.Show();


        }


        private void renkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel_Close();
            Tanimlamalar f2 = new Tanimlamalar("Tbl_Renk");
            f2.MdiParent = this;
            f2.Text = "Renk";
            f2.Show();

        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }



        void panel_Close()
        {
            anaMenuPanel.Visible = false ;
            menuStrip.BackColor = SystemColors.Control;
        }

        private void stokHareketleriStripMenuItem_Click(object sender, EventArgs e)
        {
            anaMenuPanel.Visible = true;
            menuStrip.BackColor = Color.DarkGray;
            StokHareketListesi stokHareketListesi = new StokHareketListesi();
            stokHareketListesi.MdiParent = this;
            anaMenuPanel.Controls.Add(stokHareketListesi);
            stokHareketListesi.Show();
            this.Text = "Stok Hareketleri";
        }
    }
}
