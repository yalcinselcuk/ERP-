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
    public partial class frmStokCikis : Form
    {
        public frmStokCikis()
        {
            InitializeComponent();
        }

        private void frmStokCikisFisi_Load(object sender, EventArgs e)
        {
            DataTable datatable = new DataTable();
            SqlConnection conn = Db_Adress.Mssql_Manav.GetDBConnection();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM depo a", conn);
            conn.Open();
            adtr.Fill(datatable);
            conn.Close();

            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "kod";
            comboBox1.DataSource = datatable;

            comboBox1.Text = "";
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static int depoId;
        private void okeyButton_Click(object sender, EventArgs e)
        {
            depoId = Convert.ToInt32(comboBox1.SelectedValue);
            this.DialogResult = DialogResult.OK;
        }
    }
}
