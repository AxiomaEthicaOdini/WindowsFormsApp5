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

namespace WindowsFormsApp5
{
    public partial class FormCalısanlar : Form
    {
        public FormCalısanlar()
        {
            InitializeComponent();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=03-06\\SQLEXPRESS; Initial Catalog =MaasHesaplama; Integrated Security = true";

            SqlDataAdapter daPersonel = new SqlDataAdapter("SELECT * FROM personel", cn);


            DataSet dsPersonel = new DataSet();
            cn.Open();
            daPersonel.Fill(dsPersonel);
            cn.Close();
            dataGridView1.DataSource = dsPersonel.Tables[0].DefaultView;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
