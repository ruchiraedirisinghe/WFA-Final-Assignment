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

namespace WindowsFormsApp3
{
    public partial class CashierFoodDetails : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ruchii-ROG-STRIX\Downloads\C\Database\ss.mdf;Integrated Security=True;Connect Timeout=30");
        public CashierFoodDetails()
        {
            InitializeComponent();
        }

        private void AdminItemSettings_Load(object sender, EventArgs e)
        {
            string qry = "select * from Foods";
            SqlDataAdapter sqlData = new SqlDataAdapter(qry, connection);
            DataSet dataSet = new DataSet();
            sqlData.Fill(dataSet, "foods");
            dataGridView1.DataSource = dataSet.Tables[0];


        }

        private void bt_CashierLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaLabel18_Click(object sender, EventArgs e)
        {

        }
    }
}
