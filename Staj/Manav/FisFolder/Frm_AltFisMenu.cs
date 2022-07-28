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

namespace Manav
{
    public partial class Frm_AltFisMenu : Form
    {

        #region Constuctor

        public Frm_AltFisMenu()
        {
            InitializeComponent();
        }

       
        #endregion

        #region Methods

        protected virtual void LoadData()
        {
            
        }

        protected virtual void Column_Name()
        {
        }

        protected virtual void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        protected virtual void Fill_KodId(int rowIndex)
        {
            
        }

        private void Combo_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        #endregion

    }
}
