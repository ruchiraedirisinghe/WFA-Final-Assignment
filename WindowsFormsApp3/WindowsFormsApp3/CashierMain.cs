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
    
    public partial class CashierMain : Form
    {
      
        public CashierMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            CashierLoginForm cashierLoginForm = new CashierLoginForm();

            this.Dispose();
            cashierLoginForm.Show();

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel19_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           




        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            CashierFoodDetails obj = new CashierFoodDetails();
            obj.Show();
        }

        private void CashierMain_Load(object sender, EventArgs e)
        {
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\WFA-Final-Assignment\WindowsFormsApp3\WindowsFormsApp3\ss.mdf;Integrated Security=True;Connect Timeout=30";
            string loadqry = "select * from OngoingBill";



            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(loadqry, constring);
            DataSet dataSet = new DataSet();


            sqlDataAdapter.Fill(dataSet, "OngoingBill");
            dataGridView1.DataSource = dataSet.Tables["OngoingBill"];
            
            

        }
    }
}
