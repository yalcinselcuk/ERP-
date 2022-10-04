using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Manav.Db_Adress;
using Manav.Tanimlar.TanimlarClasses;
using Manav.Tanimlar;

namespace Manav
{
    public partial class Frm_Renk : Frm_Tanimlamalar
    {
        #region Constructor
        public Frm_Renk()
        {
            InitializeComponent();
        }
        #endregion

        #region Objects
        Renk renk = null;
        #endregion

        #region Methods
        protected override void LoadData()
        {
            renk = new Renk();
            renk.LoadData(-1);
            dataGridView1.DataSource = renk.DS.renk;
            this.dataGridView1.Sort(this.dataGridView1.Columns["kod"], ListSortDirection.Ascending);
            Column_Name();
            Visible_False();
        }
        protected override void saveData()
        {
            RowDelete();
            renk.SaveData();

        }
        protected override void RowDelete()
        {
            renk.RowDelete();
        }
        protected override void CreateNew()
        {
            renk.CreateNew();
        }
        protected override void SetRowId()
        {
            renk.SetRowId();
        }
        protected override int RowKodIsNull { get { return renk.RowKodIsNull(); } }
        protected override void Column_Name()
        {
            dataGridView1.Columns[1].HeaderText = "KOD";
            dataGridView1.Columns[2].HeaderText = "AÇIKLAMA";
        }
        private void Visible_False()
        {
            dataGridView1.Columns[0].Visible = false;
        }
        #endregion
    }
}
