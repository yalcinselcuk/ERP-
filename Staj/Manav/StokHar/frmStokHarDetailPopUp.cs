using Manav.Controls;
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

    public partial class frmStokHarDetailPopUp : Form
    {

        #region Property
        DataRow rdetail = null;
        StokHarDetailInfo stokHarDetailInfo = null;
        public StokHarDetailInfo _StokHarDetailInfo { get { return this.stokHarDetailInfo; } set { this.stokHarDetailInfo = value; } }
        #endregion

        #region Constructors

        public frmStokHarDetailPopUp()
        {
            stokHarDetailInfo = new StokHarDetailInfo();
            InitializeComponent();
        }

        public frmStokHarDetailPopUp(StokHarDetailInfo stokHarDetailInfo)
        {
            //stokHarDetailInfo = new StokHarDetailInfo();
            this.stokHarDetailInfo = stokHarDetailInfo;
            this.rdetail = rdetail;
            InitializeComponent();
        }

        #endregion

        #region Private Methods

        //private void LoadCombos()
        //{
           
        //}

        int sayac;
        private Result Validate()
        {
            if (uruncombobox.Text.Trim() == "")
            {
                return new Result { resultbool = false, resultmessage = "Ürün Alanı Boş " };
            }
            //bu değer kullanıcı 
            //if(uruncombobox.DisplayMember != uruncombobox.Text)
            //{
            //    return new Result { resultbool = false, resultmessage = "Ürün Alanına Geçersiz Değer Girdiniz " };
            //}
            if (renkcombobox.Text == "")
            {
                return new Result { resultbool = false, resultmessage = "Renk Alanı Boş " };
            }
            if (birimcombobox.Text == "")
            {
                return new Result { resultbool = false, resultmessage = "Birim Alanı Boş " };
            }
            if (miktarTextbox.Text == "0")
            {
                return new Result { resultbool = false, resultmessage = "Miktar Alanı Boş " };
            }
            if(Convert.ToDecimal(miktarTextbox.Text) < 0)
            {
                return new Result { resultbool = false, resultmessage = "Miktar Alanı Eksili Olamaz !!! " };
            }
            return new Result { resultbool = true, resultmessage = "" };
        }

        #endregion

        #region Events

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var messages = Validate();

            if (messages.resultbool == false)
            {
                MessageBox.Show(messages.resultmessage);
            }
            else
            {
                this.stokHarDetailInfo.urunid = Convert.ToInt32(uruncombobox.ValueMember); 
                this.stokHarDetailInfo.urunkod = uruncombobox.Text;
                this.stokHarDetailInfo.renkid = Convert.ToInt32(renkcombobox.ValueMember); 
                this.stokHarDetailInfo.renkkod = renkcombobox.Text;
                this.stokHarDetailInfo.birimid = Convert.ToInt32(birimcombobox.ValueMember); 
                this.stokHarDetailInfo.birimkod = birimcombobox.Text;
                this.stokHarDetailInfo.miktar = Convert.ToDecimal(miktarTextbox.Text);

                this.DialogResult = DialogResult.OK;
            }
        }

        private void frmPopUp_Load(object sender, EventArgs e)
        {
            //LoadCombos();
            
            //if (stokHarDetailInfo != null)
            //{
                uruncombobox.Text = stokHarDetailInfo.urunkod;
                uruncombobox.ValueMember = stokHarDetailInfo.urunid.ToString();
                renkcombobox.Text = stokHarDetailInfo.renkkod;
                renkcombobox.ValueMember = stokHarDetailInfo.renkid.ToString();
                birimcombobox.Text = stokHarDetailInfo.birimkod;
                birimcombobox.ValueMember = stokHarDetailInfo.birimid.ToString();
                miktarTextbox.Text = stokHarDetailInfo.miktar.ToString();
            //}
        }
        #endregion

        
    }
}
