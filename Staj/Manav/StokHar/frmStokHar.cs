//using Manav.Components;
using Manav.Db_Adress;
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
    public partial class frmStokHar : Form
    {

        #region Property

        SqlConnection conn = Mssql_Manav.GetDBConnection();
        SqlDataAdapter adtr;
        DataTable dt;

        stokHareketClass stokHarClass = null;

        #endregion

        #region Constructors

        public frmStokHar()
        {
            this.stokHarClass = new stokHareketClass();
            this.stokHarClass.LoadData(-1);
            InitializeComponent();
            BindObject();
            dataGridFis.DataSource = stokHarClass.DS.stokhardetail;
            tarihBox.Text = DateTime.Now.ToString();
            if (stokHarClass.DS.stokharmain.Rows[0]["fistipi"].ToString() == "0")
            {
                sihirbaziac.Visible = true;
            }
        }
        public frmStokHar(int fisref)
        {
            this.stokHarClass = new stokHareketClass();
            this.stokHarClass.LoadData(fisref);
            InitializeComponent();
            BindObject();
            dataGridFis.DataSource = stokHarClass.DS.stokhardetail;

            if (stokHarClass.DS.stokharmain.Rows[0]["fistipi"].ToString() == "0")
            {
                sihirbaziac.Visible = true;
               
            }
        }
        int depoıd;
        int cikisfisi;
        public frmStokHar(int depoıd,int cikisfisi)
        {
            this.depoıd = depoıd;
            this.cikisfisi = cikisfisi;
            this.stokHarClass = new stokHareketClass();
            this.stokHarClass.LoadData(-1);
            InitializeComponent();
            BindObject();
            dataGridFis.DataSource = stokHarClass.DS.stokhardetail;
            tarihBox.Text = DateTime.Now.ToString();
            if (stokHarClass.DS.stokharmain.Rows[0]["fistipi"].ToString() == "0")
            {
                sihirbaziac.Visible = true;
            }
        }
        #endregion

        #region Private Methods

        private void BindObject()
        {
            fisNoTextBox.DataBindings.Add("Text", stokHarClass.DS.stokharmain, "fisno", true);

            tarihBox.DataBindings.Add("Value", stokHarClass.DS.stokharmain, stokHarClass.DS.stokharmain.tarihColumn.ColumnName, true);

            belgeNoTextBox.DataBindings.Add("Text", stokHarClass.DS.stokharmain, "belgeno", true);

            aciklamaTextBox.DataBindings.Add("Text", stokHarClass.DS.stokharmain, stokHarClass.DS.stokharmain.aciklamaColumn.ColumnName, true);

            firmaComboBox.DataBindings.Add("Text", stokHarClass.DS.stokharmain, stokHarClass.DS.stokharmain.firmakodColumn.ColumnName, true);
            firmaComboBox.DataBindings.Add("SelectedValue", stokHarClass.DS.stokharmain, stokHarClass.DS.stokharmain.firmaidColumn.ColumnName, true);

            depoComboBox.DataBindings.Add("Text", stokHarClass.DS.stokharmain, stokHarClass.DS.stokharmain.depokodColumn.ColumnName, true);
            depoComboBox.DataBindings.Add("SelectedValue", stokHarClass.DS.stokharmain, stokHarClass.DS.stokharmain.depoidColumn.ColumnName, true);
        }
        private void LoadCombos()
        {
            Fill_FirmaCombobox();
            Fill_DepoCombobox();

            depoComboBox.Text = stokHarClass.DS.stokharmain.Rows[0]["depokod"].ToString();
            firmaComboBox.Text = stokHarClass.DS.stokharmain.Rows[0]["firmakod"].ToString();
            
        }

        private void Fill_FirmaCombobox()
        {
            dt = new DataTable();
            adtr = new SqlDataAdapter("SELECT id, kod, aciklama FROM firmatanim a", conn);
            conn.Open();
            adtr.Fill(dt);
            conn.Close();

            firmaComboBox.ValueMember = "id";//arka planda tutulacak olan hucre
            firmaComboBox.DisplayMember = "kod";//comboda gorunecek olan hucre
            firmaComboBox.DataSource = dt;

            firmaComboBox.Text = "";
        }

        private void Fill_DepoCombobox()
        {
            dt = new DataTable();

            adtr = new SqlDataAdapter("SELECT id, kod, aciklama FROM depotanim a", conn);
            conn.Open();
            adtr.Fill(dt);
            conn.Close();

            depoComboBox.ValueMember = "id";
            depoComboBox.DisplayMember = "kod";
            depoComboBox.DataSource = dt;

            depoComboBox.Text = "";
        }


        #endregion

        #region Events

        private void frmStokHar_Load(object sender, EventArgs e)
        {
            LoadCombos();

        }


        private void dataGridFis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow r = stokHarClass.DS.stokhardetail.Select("id = " + Convert.ToInt32(dataGridFis.CurrentRow.Cells[0].Value), "", DataViewRowState.CurrentRows)[0];

            StokHarDetailInfo stokHarDetailInfo = new StokHarDetailInfo();
            stokHarDetailInfo.mainid = Convert.ToInt32(r["mainid"]);
            stokHarDetailInfo.urunkod = Convert.ToString(r["urunkod"]);
            stokHarDetailInfo.urunid = Convert.ToInt32(r["urunid"]);
            stokHarDetailInfo.renkid = Convert.ToInt32(r["renkid"]);
            stokHarDetailInfo.renkkod = Convert.ToString(r["renkkod"]);
            stokHarDetailInfo.birimid = Convert.ToInt32(r["birimid"]);
            stokHarDetailInfo.birimkod = Convert.ToString(r["birimkod"]);
            stokHarDetailInfo.miktar = Convert.ToDecimal(r["miktar"]);

            frmStokHarDetailPopUp f = new frmStokHarDetailPopUp(stokHarDetailInfo);

            if (f.ShowDialog() == DialogResult.OK)
            {
                int duplicatecontrol = stokHarClass.DataGridDuplicateControl(stokHarDetailInfo);
                if (duplicatecontrol == 0)
                {
                    r["urunid"] = f._StokHarDetailInfo.urunid;
                    r["urunkod"] = f._StokHarDetailInfo.urunkod;
                    r["renkid"] = f._StokHarDetailInfo.renkid;
                    r["renkkod"] = f._StokHarDetailInfo.renkkod;
                    r["birimid"] = f._StokHarDetailInfo.birimid;
                    r["birimkod"] = f._StokHarDetailInfo.birimkod;
                    r["miktar"] = f._StokHarDetailInfo.miktar;
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            stokHarClass.Delete();
            MessageBox.Show("Veriler Silindi", "KEY BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }


        private void saveButtons_Click(object sender, EventArgs e)
        {
            var validatemessages = stokHarClass.Validate();

            if (validatemessages.resultbool == false)
            {
                MessageBox.Show(validatemessages.resultmessage, "KEY BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var savemessages = stokHarClass.Save();

                if (savemessages.resultbool == false)
                {
                    MessageBox.Show(savemessages.resultmessage, "KEY BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Saved", "KEY BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addrow_Click(object sender, EventArgs e)
        {
            frmStokHarDetailPopUp f = new frmStokHarDetailPopUp();
            if (f.ShowDialog() == DialogResult.OK)
            {
                stokHarClass.AddDetailsRow(f._StokHarDetailInfo);
            }

        }

        private void dataGridFis_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Mükerrer Kayıt Girdiniz \nMükerrer Kayıt : " + dataGridFis.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), "KEY BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        #endregion

        private void dataGridFis_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridFis.ClearSelection();
        }

        private void sihirbaziac_Click(object sender, EventArgs e)
        {
            frmStokCikisFisi fstokcikisfisi = new frmStokCikisFisi(depoıd);
            if (fstokcikisfisi.ShowDialog() == DialogResult.OK)
            {
                stokHarClass.AddDetailsRow(fstokcikisfisi._StokHarDetailInfo);
                stokHarClass.AddMainRow(fstokcikisfisi._stokHarMainInfo);
            }
        }
    }
}
