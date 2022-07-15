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

namespace Manav
{
    public partial class Tanimlamalar : Form
    {
        public Tanimlamalar(string dt)
        {
            InitializeComponent();
            this.dt = dt;
        }


        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-8HOREQD2\\SQLEXPRESS;Initial Catalog=Manav;Integrated Security=True");
        SqlCommandBuilder commandBuilder;
        SqlDataAdapter adtr;
        DataTable tbl = new DataTable();



        string dt;



        DataTable GetList()
        {
            tbl.Clear();

            adtr = new SqlDataAdapter("select id, kod, aciklama from " + dt, baglanti);
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;
            this.dataGridView1.Columns["id"].Visible = false;


            return tbl;
        }



        private void saveButton_Click(object sender, EventArgs e)
        {
            commandBuilder = new SqlCommandBuilder(adtr);
            adtr.Update(tbl);
            GetList();
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GetList();
        }
    }
}
