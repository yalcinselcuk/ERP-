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

        SqlDataAdapter adtr;
        DataTable tbl = new DataTable();
        SqlConnection conn = Mssql_Manav.GetDBConnection();

        #endregion

        #region Methods

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

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            saveData();
        }
        protected virtual void saveData()
        {
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;

        }

        #endregion


    }
}
