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
using Manav.Db_Adress;
using Manav.FisFolder;
//using Manav.FisFolder;

namespace Manav
{
    public partial class Fis : Form
    {

        #region Constructor

        public Fis()
        {
            InitializeComponent();


        }



        #endregion

        #region Objects

        SqlCommand cmd;
        SqlConnection conn = Mssql_Manav.GetDBConnection();
        SqlDataReader dr;

        public int uId;
        public int rId;
        public int bId;

        int fisNo;
        string miktarGelen;

        public int no = -1;
        public string tarih = null;
        public string belge = null;
        public string aciklama = null;
        public string firma = null;
        public string depo = null;
        public string mainId = null;
        public string fisinTipi = null;


        string findName;
        string urunName;
        string renkName;
        string birimName;
        string miktarName;

        

        List<int> detailsId = new List<int>();


        #endregion

        #region Methods

        private void Fis_Load(object sender, EventArgs e)
        {
            Fill_FirmaComboBox();
            Fill_FirmaId();
            Fill_DepoComboBox();
            Fill_DepoId();
            getFisNo();



            tarihBox.Text = DateTime.Now.ToString();

            if (no != -1 && tarih != null && belge != null && aciklama != null && firma != null && depo != null)
            {
                fisNoTextBox.Text = no.ToString("000000");
                DateTime t = DateTime.ParseExact(tarih, "dd//MM/yyyy", null);
                tarihBox.Text = t.ToString();
                belgeNoTextBox.Text = belge.ToString();
                aciklamaTextBox.Text = aciklama.ToString();
                dataGridFis.Rows[0].Cells[4].Value = uId;
                dataGridFis.Rows[0].Cells[5].Value = rId;
                dataGridFis.Rows[0].Cells[6].Value = bId;
                saveButtons.Text = "Güncelle";


                Find_FirmaName(firma);
                Find_DepoName(depo);
                GetDetailsObjects(mainId);

            }


        }

        //public delegate void Fill_Kod(String kod);


        private void saveButtons_Click(object sender, EventArgs e)
        {

            if (saveButtons.Text == "Güncelle")
            {
                guncelleMetodu();
            }

            //else if (fisinTipi == "Cikis Fisi")
            //{
                
            //    conn.Open();
            //    cmd = new SqlCommand("select  a.firmaId, a.depoId, b.urun, b.renk, b.birim, b.miktar from Tbl_Main a left outer join Tbl_Details b on b.mainId = a.fisNo ",conn);
            //    dr = cmd.ExecuteReader();
            //    string[,] cikisFisi = new string[15, 6];
            //    int i = 0, j = 0;
            //    while (dr.Read())
            //    {
            //        cikisFisi[i, j] = dr[j].ToString();
            //        j++;
            //        if (j == 6)
            //            i++;
            //    }

            //    for (int k = 0; k < 15; k++)
            //        for (int l = 0; l < 6; l++)
            //            Console.WriteLine(k + " , " + l + " = " + cikisFisi[k, l]);
            //}
            else
            {
                SqlTransaction islem = null;
                try
                {
                    conn.Open();
                    islem = conn.BeginTransaction();
                    cmd = new SqlCommand("insert into Tbl_Main(fisNo, fisTipi, tarih, belgeNo, aciklama, firmaId, depoId) values (@d1, @d2, @d3, @d4, @d5, @d6, @d7)", conn);
                    cmd.Transaction = islem; // bu eksikti
                    cmd.Parameters.AddWithValue("@d1", fisNo.ToString());
                    cmd.Parameters.AddWithValue("@d2", fisinTipi);
                    cmd.Parameters.AddWithValue("@d3", tarihBox.Text);
                    cmd.Parameters.AddWithValue("@d4", belgeNoTextBox.Text);
                    cmd.Parameters.AddWithValue("@d5", aciklamaTextBox.Text);
                    cmd.Parameters.AddWithValue("@d6", comboBox1.Items[firmaComboBox.SelectedIndex].ToString());// firma'nın id'sini aldık
                    cmd.Parameters.AddWithValue("@d7", comboBox2.Items[depoComboBox.SelectedIndex].ToString());// depo'nun id'sini aldık

                    cmd.ExecuteNonQuery();



                    //butun satirlari kaydetmek icin satirlarda dolasiyoruz
                    for (int i = 0; i < dataGridFis.Rows.Count - 1; i++)
                    {


                        cmd = new SqlCommand("insert into Tbl_Details(mainId, urunId, urun, renkId, renk, birimId, birim, miktar) values (@d1, @d2, @d3, @d4, @d5, @d6, @d7, @d8)", conn);
                        cmd.Transaction = islem;
                        cmd.Parameters.AddWithValue("@d1", fisNo);
                        cmd.Parameters.AddWithValue("@d2", dataGridFis.Rows[i].Cells[4].Value.ToString());
                        cmd.Parameters.AddWithValue("@d3", dataGridFis.Rows[i].Cells[0].Value.ToString());
                        cmd.Parameters.AddWithValue("@d4", dataGridFis.Rows[i].Cells[5].Value.ToString());
                        cmd.Parameters.AddWithValue("@d5", dataGridFis.Rows[i].Cells[1].Value.ToString());
                        cmd.Parameters.AddWithValue("@d6", dataGridFis.Rows[i].Cells[6].Value.ToString());
                        cmd.Parameters.AddWithValue("@d7", dataGridFis.Rows[i].Cells[2].Value.ToString());
                        cmd.Parameters.AddWithValue("@d8", dataGridFis.Rows[i].Cells[3].Value.ToString());
                        cmd.ExecuteNonQuery();

                    }


                    islem.Commit();

                }
                catch (Exception exp)
                {

                    islem.Rollback();
                    MessageBox.Show(exp.ToString());
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }

                MessageBox.Show("Kaydedildi...");
            }


            saveButtons.Text = "Güncelle";

        }

        private void guncelleMetodu()
        {
            SqlTransaction islem = null;
            string firmaId = comboBox1.Items[firmaComboBox.SelectedIndex].ToString();
            string depoId = comboBox2.Items[depoComboBox.SelectedIndex].ToString();


            conn.Open();

            cmd = new SqlCommand("update Tbl_Main set tarih ='" + tarihBox.Text + "',belgeNo ='" + belgeNoTextBox.Text + "' ,aciklama ='" + aciklamaTextBox.Text + "',firmaId ='" + firmaId + "',depoId ='" + depoId + "' where fisNo=" + fisNoTextBox.Text + "", conn);
            cmd.ExecuteNonQuery();

            for (int i = 0; i < dataGridFis.Rows.Count - 1; i++)
            {
                cmd = new SqlCommand("update Tbl_Details set urunId ='" + dataGridFis.Rows[i].Cells[4].Value.ToString() + "',urun ='" + dataGridFis.Rows[i].Cells[0].Value + "' ,renkId ='" + dataGridFis.Rows[i].Cells[5].Value.ToString()
                    + "',renk ='" + dataGridFis.Rows[i].Cells[1].Value.ToString() + "',birimId ='" + dataGridFis.Rows[i].Cells[6].Value.ToString()
                    + "',birim ='" + dataGridFis.Rows[i].Cells[2].Value.ToString() + "',miktar ='" + dataGridFis.Rows[i].Cells[3].Value.ToString() + "' where id=" + detailsId[i] + "", conn);
                cmd.ExecuteNonQuery();
            }

            conn.Close();


            MessageBox.Show("Güncellendi...");


        }

        private void dataGridFis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Frm_AltFisMenu altMenu;

            if (e.ColumnIndex == 0)
            {
                Frm_AltUrunMenu altFis = new Frm_AltUrunMenu(this, e.RowIndex);
                altFis.Text = "Ürünler";
                altFis.Show();
            }
            if (e.ColumnIndex == 1)
            {
                Frm_AltRenkMenu altFis = new Frm_AltRenkMenu(this, e.RowIndex);
                altFis.Text = "Renkler";
                altFis.Show();
            }
            if (e.ColumnIndex == 2)
            {
                Frm_AltBirimMenu altFis = new Frm_AltBirimMenu(this, e.RowIndex);
                altFis.Text = "Birim";
                altFis.Show();
            }

        }

        void Find_FirmaName(string firma)
        {


            SqlCommand cmd = new SqlCommand("Select id, kod, aciklama from Tbl_Firmalar where id = " + firma, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                findName = Convert.ToString(dr["kod"]);
            }
            firmaComboBox.Text = findName.ToString();
            cmd.Dispose();
            conn.Close();
        }
        void Find_DepoName(string depo)
        {


            SqlCommand cmd = new SqlCommand("Select id, kod, aciklama from Tbl_Depo where id = " + depo, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                findName = Convert.ToString(dr["kod"]);
            }
            depoComboBox.Text = findName.ToString();
            cmd.Dispose();
            conn.Close();
        }
        void GetDetailsObjects(string mainId)
        {


            SqlCommand cmd = new SqlCommand("Select * from Tbl_Details where mainId = " + mainId, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                urunName = Convert.ToString(dr["urun"]);
                renkName = Convert.ToString(dr["renk"]);
                birimName = Convert.ToString(dr["birim"]);
                miktarName = Convert.ToString(dr["miktar"]);
                uId = Convert.ToInt32(dr["urunId"]);
                rId = Convert.ToInt32(dr["renkId"]);
                bId = Convert.ToInt32(dr["birimID"]);
                detailsId.Add(Convert.ToInt32(dr["id"]));//tikladigimiz fisteki Details id'lerini attik
     
                dataGridFis.Rows.Add();

                dataGridFis.Rows[i].Cells[0].Value = urunName.ToString();
                dataGridFis.Rows[i].Cells[1].Value = renkName.ToString();
                dataGridFis.Rows[i].Cells[2].Value = birimName.ToString();
                dataGridFis.Rows[i].Cells[3].Value = miktarName.ToString();
                dataGridFis.Rows[i].Cells[4].Value = uId.ToString();
                dataGridFis.Rows[i].Cells[5].Value = rId.ToString();
                dataGridFis.Rows[i].Cells[6].Value = bId.ToString();
                i++;
            }
            cmd.Dispose();
            conn.Close();
        }

        void Fill_FirmaComboBox()
        {
            string sql = "select id, kod, aciklama from Tbl_Firmalar";
            cmd = new SqlCommand(sql, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                firmaComboBox.Items.Add(dr["kod"]);
            }
            conn.Close();

        }
        void Fill_FirmaId()
        {
            string sql = "select id, kod, aciklama from Tbl_Firmalar";
            cmd = new SqlCommand(sql, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                comboBox1.Items.Add(dr["id"]);
            }
            conn.Close();
        }
        void Fill_DepoId()
        {
            string sql = "select id, kod, aciklama from Tbl_Depo";
            cmd = new SqlCommand(sql, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                comboBox2.Items.Add(dr["id"]);
            }
            conn.Close();
        }

        void Fill_DepoComboBox()
        {
            string sql = "select id, kod, aciklama from Tbl_Depo";
            cmd = new SqlCommand(sql, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                depoComboBox.Items.Add(dr["kod"]);
            }
            conn.Close();
        }

        //Main Tablosundan son id yi alip Details tablosuna da eklemek icin kullaniyoruz
        //Form load olurken de box'a atiyoruz
        void getFisNo()
        {
            conn.Open();
            dr = null;
            cmd.Connection = conn;


            cmd.CommandText = "Select Top (1) id from Tbl_Main order by id desc";


            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                fisNo = Convert.ToInt32(dr.GetValue(0));
                fisNo++;
            }
            else
            {
                fisNo = 1;
            }
            fisNoTextBox.Text = fisNo.ToString("000000");
            dr.Close();
            conn.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmdMain = new SqlCommand("delete from Tbl_Main where fisNo = " + fisNoTextBox.Text, conn);
            SqlCommand cmdDetails = new SqlCommand("delete from Tbl_Details where mainId = " + fisNoTextBox.Text, conn);

            conn.Open();
            cmdMain.ExecuteNonQuery();
            cmdDetails.ExecuteNonQuery();
            conn.Close();

            fisNoTextBox.Text = "";
            tarihBox.Text = "";
            belgeNoTextBox.Text = "";
            aciklamaTextBox.Text = "";
            firmaComboBox.Text = "";
            depoComboBox.Text = "";
            dataGridFis.Rows[0].Cells[0].Value = "";
            dataGridFis.Rows[0].Cells[1].Value = "";
            dataGridFis.Rows[0].Cells[2].Value = "";
            dataGridFis.Rows[0].Cells[3].Value = "";

            MessageBox.Show("Veriler Silindi", "KEY BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        #endregion
    }
}
