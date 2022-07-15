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
    public partial class Fis : Form
    {

        #region Constructor

        public Fis()
        {
            InitializeComponent();
            dataGridFis.Columns["urunId"].Visible = false;
            dataGridFis.Columns["renkId"].Visible = false;
            dataGridFis.Columns["birimId"].Visible = false;
        }



        #endregion

        #region Objects

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-8HOREQD2\\SQLEXPRESS;Initial Catalog=Manav;Integrated Security=True");
        SqlCommand cmdMain;
        SqlCommand cmdDetails;
        SqlCommand cmdMainId = new SqlCommand();
        SqlCommand cmdFirma;
        SqlCommand cmdDepo;
        SqlCommand cmdFisNo = new SqlCommand();
        SqlDataReader dr;
        public int uId;
        public int rId;
        public int bId;
        static int id;

        int fisNo;
        int eRowIndex;
        string miktarGelen;

        //table box deger atama 
        public int no = -1;
        public string tarih = null;
        public string belge = null;
        public string aciklama = null;
        public string firma = null;
        public string depo = null;
        public string urunAdi = null;
        public string renkAdi = null;
        public string birimAdi = null;
        public string miktarOlcu = null;
        public string fisinTipi = null;

        #endregion

        #region Methods

        private void Fis_Load(object sender, EventArgs e)
        {
            Fill_Firma();
            Fill_Depo();
            getFisNo();

            if(no != -1 && tarih != null && belge != null && aciklama != null && firma != null && depo != null
                && urunAdi != null && birimAdi != null && renkAdi != null && birimAdi != null && miktarOlcu != null)
            {
                fisNoTextBox.Text = no.ToString("000000");
                DateTime t = DateTime.ParseExact(tarih, "dd//MM/yyyy", null);
                tarihBox.Text = t.ToString();
                belgeNoTextBox.Text = belge.ToString();
                aciklamaTextBox.Text = aciklama.ToString();
                firmaComboBox.Text = firma.ToString();
                depoComboBox.Text = depo.ToString();
                dataGridFis.Rows[0].Cells[0].Value = urunAdi;
                dataGridFis.Rows[0].Cells[1].Value = renkAdi;
                dataGridFis.Rows[0].Cells[2].Value = birimAdi;
                dataGridFis.Rows[0].Cells[3].Value = miktarOlcu;

            }   
            

        }

        void Fill_Firma()
        {
            string sql = "select id, kod, aciklama from Tbl_Firmalar";
            cmdFirma = new SqlCommand(sql, baglanti);
            baglanti.Open();
            dr = cmdFirma.ExecuteReader();
            while (dr.Read())
            {
                firmaComboBox.Items.Add(dr["kod"]);
            }
            baglanti.Close();

        }

        void Fill_Depo()
        {
            string sql = "select id, kod, aciklama from Tbl_Depo";
            cmdDepo = new SqlCommand(sql, baglanti);
            baglanti.Open();
            dr = cmdDepo.ExecuteReader();
            while (dr.Read())
            {
                depoComboBox.Items.Add(dr["kod"]);
            }
            baglanti.Close();
        }

        void getFisNo()
        {
            baglanti.Open();
            dr = null;
            cmdFisNo.Connection = baglanti;
            cmdFisNo.CommandText = "Select Top (1) id from Tbl_Main order by id desc";


            dr = cmdFisNo.ExecuteReader();
            if (dr.Read())
            {
                fisNo = Convert.ToInt32(dr.GetValue(0));
                fisNo++;
            }
            fisNoTextBox.Text = fisNo.ToString("000000");
            dr.Close();
            baglanti.Close();
        }

        #endregion

        #region Events

        private void saveButtons_Click(object sender, EventArgs e)
        {
            SqlTransaction islem = null;
            try
            {
                baglanti.Open();
                islem = baglanti.BeginTransaction();

                cmdMain = new SqlCommand("insert into Tbl_Main(fisNo, fisTipi, tarih, belgeNo, aciklama, firmaId, firmaAdi, depoId, depoAdi) values (@d1, @d2, @d3, @d4, @d5, @d6, @d7, @d8, @d9)", baglanti);
                cmdMain.Transaction = islem; // bu eksikti
                cmdMain.Parameters.AddWithValue("@d1", fisNo.ToString());
                cmdMain.Parameters.AddWithValue("@d2", fisinTipi);
                cmdMain.Parameters.AddWithValue("@d3", tarihBox.Text);
                cmdMain.Parameters.AddWithValue("@d4", belgeNoTextBox.Text);
                cmdMain.Parameters.AddWithValue("@d5", aciklamaTextBox.Text);
                cmdMain.Parameters.AddWithValue("@d6", firmaComboBox.SelectedIndex + 1);
                cmdMain.Parameters.AddWithValue("@d7", firmaComboBox.Text);
                cmdMain.Parameters.AddWithValue("@d8", depoComboBox.SelectedIndex + 1);
                cmdMain.Parameters.AddWithValue("@d9", depoComboBox.Text);

                cmdMain.ExecuteNonQuery();

                dr = null;
                cmdMainId.Connection = baglanti;
                cmdMainId.CommandText = "Select Top (1) id from Tbl_Main order by id desc";
                cmdMainId.Transaction = islem;

                dr = cmdMainId.ExecuteReader();
                if (dr.Read())
                {
                    id = Convert.ToInt32(dr.GetValue(0));
                }
                MessageBox.Show("last id : " + id);
                dr.Close();

                if (dataGridFis.Rows[eRowIndex].Cells[3].Value != null)
                {
                    miktarGelen = dataGridFis.Rows[eRowIndex].Cells[3].Value.ToString();
                    MessageBox.Show("miktarGelen : " + miktarGelen);
                }
                else
                {
                    MessageBox.Show("miktar alanı boş");
                    miktarGelen = "";
                }



                cmdDetails = new SqlCommand("insert into Tbl_Details(mainId, urunId, urun, renkId, renk, birimId, birim, miktar) values (@d1, @d2, @d3, @d4, @d5, @d6, @d7, @d8)", baglanti);
                cmdDetails.Transaction = islem;
                cmdDetails.Parameters.AddWithValue("@d1", id);
                cmdDetails.Parameters.AddWithValue("@d2", uId);
                cmdDetails.Parameters.AddWithValue("@d3", dataGridFis.Rows[eRowIndex].Cells[0].Value.ToString());
                cmdDetails.Parameters.AddWithValue("@d4", rId);
                cmdDetails.Parameters.AddWithValue("@d5", dataGridFis.Rows[eRowIndex].Cells[1].Value.ToString());
                cmdDetails.Parameters.AddWithValue("@d6", bId);
                cmdDetails.Parameters.AddWithValue("@d7", dataGridFis.Rows[eRowIndex].Cells[2].Value.ToString());
                cmdDetails.Parameters.AddWithValue("@d8", miktarGelen);

                cmdDetails.ExecuteNonQuery();
                islem.Commit();

            }
            catch (Exception exp)
            {

                islem.Rollback();
                MessageBox.Show(exp.ToString());
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }


        }

        //void getLastID()
        //{


        //    SqlCommand cmd = new SqlCommand();
        //    dr = null;
        //    cmd.Connection = baglanti;
        //    cmd.CommandText = "Select Top (1) id from Tbl_Main order by id desc";

        //    dr = cmd.ExecuteReader();
        //    if (dr.Read())
        //    {
        //        id = Convert.ToInt32( dr.GetValue(0) );
        //    }
        //    MessageBox.Show("last id : "+id);

        //}

        private void dataGridFis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AltFisMenu fisMenuCombo;

            if (e.ColumnIndex == 0)
            {
                fisMenuCombo = new AltFisMenu("Tbl_Urunler", this, 0, e.RowIndex);
                fisMenuCombo.Text = "Ürünler";
                fisMenuCombo.Show();
            }
            if (e.ColumnIndex == 1)
            {
                fisMenuCombo = new AltFisMenu("Tbl_Renk", this, 1, e.RowIndex);
                fisMenuCombo.Text = "Renkler";
                fisMenuCombo.Show();
            }
            if (e.ColumnIndex == 2)
            {
                fisMenuCombo = new AltFisMenu("Tbl_Birim", this, 2, e.RowIndex);
                fisMenuCombo.Text = "Birimler";
                fisMenuCombo.Show();
            }
            this.eRowIndex = e.RowIndex;

        }

        #endregion


    }



}
