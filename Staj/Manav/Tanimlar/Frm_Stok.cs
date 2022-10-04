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
using Manav.Db_Adress;
using Manav.Tanimlar;

namespace Manav
{
    public partial class Frm_Stok : Frm_Tanimlamalar
    {

        #region Constructor
        public Frm_Stok()
        {
            InitializeComponent();
        }
        #endregion

        #region Objects
        Stok stok = null;
        #endregion

        #region Methods
        protected override void LoadData()
        {
            stok = new Stok();
            stok.LoadData(-1);
            dataGridView1.DataSource = stok.DS.stok;
            this.dataGridView1.Sort(this.dataGridView1.Columns["kod"], ListSortDirection.Ascending);
            Column_Name();
            Visible_False();
        }
        protected override void saveData()
        {
            RowDelete();
            stok.SaveData();

        }
        protected override void RowDelete()
        {
            stok.RowDelete();
        }
        protected override void CreateNew()
        {
            stok.CreateNew();
        }
        protected override void SetRowId()
        {
            stok.SetRowId();
        }
        protected override int RowKodIsNull { get { return stok.RowKodIsNull(); } }
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
