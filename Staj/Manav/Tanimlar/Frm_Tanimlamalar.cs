using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manav.Db_Adress;
using Manav.DataSets;
using Manav.Tanimlar;
using Manav.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Manav
{
    public partial class Frm_Tanimlamalar : Form
    {
        #region Constructor
        public Frm_Tanimlamalar()
        {
            InitializeComponent();
        }

        #endregion

        #region Objects
        SqlConnection conn = Mssql_Manav.GetDBConnection();
        #endregion

        #region Events
        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            saveData();
            CreateNew();
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Context == DataGridViewDataErrorContexts.Commit)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells["kod"].Value.ToString() != "" && dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString() != "")
                {
                    MessageBox.Show("'Kod' Alanı Boş Olamaz \nSildiğiniz Kod Geri Getirilecek", "KeyBilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Mükerrer Kayıt \nKayıt Otomatik Silindi", "KeyBilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        SqlDataAdapter adtr;
        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int kodisempty = RowKodIsNull;

                if (kodisempty == 0)
                {
                    SetRowId();
                    CreateNew();
                }
                if(kodisempty == 1) { MessageBox.Show("'KOD' Alanı Boş Olamaz", "KEY BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            if (e.KeyCode == Keys.Delete)
            {
                int deleterowcheck = DeleteRowCheck();
                if (deleterowcheck != 0)
                {
                    MessageBox.Show("Bu Veri Kullanımda \nSilinemez", "KEY BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                }
            }
        }

        //ipucu yazdirmak için kullanıyoruz
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)        /*If a header cell*/
                return;
            if (!(e.ColumnIndex == 0 || e.ColumnIndex == 1)) /*If not our desired columns*/
                return;

            if (e.Value == null || e.Value == DBNull.Value)  /*If value is null*/
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All
                    & ~(DataGridViewPaintParts.ContentForeground));

                TextRenderer.DrawText(e.Graphics, "Yeni Kayıt Giriniz", e.CellStyle.Font,
                    e.CellBounds, SystemColors.GrayText, TextFormatFlags.Left);

                e.Handled = true;
            }
        }

        //açılır açılmaz default select özelliğini kapatıyor 
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        #endregion

        #region Private
        Int32 rowusing = 0;
        private int DeleteRowCheck()
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(a.urunKod) from vdetail a where a.urunKod = '" + dataGridView1.CurrentCell.Value + "'", conn);
            conn.Open();
            rowusing = (Int32)cmd.ExecuteScalar();
            conn.Close();

            return rowusing;
        }
        #endregion

        #region Protected
        protected virtual void LoadData()
        {
        }
        protected virtual void Open_Conn()
        {
            conn.Open();
        }
        protected virtual void Close_Conn()
        {
            conn.Close();
        }
        protected virtual void Column_Name()
        {
        }
        protected virtual void saveData()
        {
        }
        protected virtual void CreateNew()
        {

        }
        protected virtual void SetRowId()
        {
        }

        private int num;
        protected virtual int RowKodIsNull
        {
            get { return num; }
            set { num = value; }
        }
        protected virtual void RowDelete(/*int rid*/)
        {

        }
        #endregion
    }
}
