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
using Microsoft.VisualBasic;//for the input box in resetattempsbutton

namespace WindowsFormsApp3
{
    public partial class AdminCashierMain : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ruchii-ROG-STRIX\Downloads\C\Database\ss.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminCashierMain()
        {
            InitializeComponent();
        }

        private void FoodDetailsProject_Load(object sender, EventArgs e)
        {
            string qry = "select * from cashier";
            SqlDataAdapter sqlData = new SqlDataAdapter(qry, connection);
            DataSet dataSet = new DataSet();
            sqlData.Fill(dataSet, "Cashier");
            dataGridView1.DataSource = dataSet.Tables[0];

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            AdminMain adminMain = new AdminMain();
            this.Dispose();
            adminMain.Show();
        }

        private void bt_CashierLogout_Click(object sender, EventArgs e)
        {
            AdminLoginForm adminLoginForm = new AdminLoginForm();
            this.Dispose();
            adminLoginForm.Show();
        }

        private void guna2GradientCircleButton2_Click(object sender, EventArgs e)
        {
            AdminCashierFindForm adminCashierFindForm = new AdminCashierFindForm();
            adminCashierFindForm.Show();
        }

        private void guna2GradientCircleButton3_Click(object sender, EventArgs e)
        {
            AdminCashierCreateForm adminCashierCreateForm = new AdminCashierCreateForm();
            adminCashierCreateForm.Show();
        }

        private void guna2GradientCircleButton1_Click_1(object sender, EventArgs e)
        {
            AdminCashierUpdate adminCashierUpdate = new AdminCashierUpdate();
            adminCashierUpdate.Show();
        }

        private void btn_cashfind_delete_Click(object sender, EventArgs e)
        {
            AdminCashierDelete adminCashierDelete = new AdminCashierDelete();
            adminCashierDelete.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
            string qry = "select * from cashier";
            SqlDataAdapter sqlData = new SqlDataAdapter(qry, connection);
            DataSet dataSet = new DataSet();
            sqlData.Fill(dataSet,"Cashier");
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btCashfind_reset_Click(object sender, EventArgs e)
        {
            string resetingcashid = Interaction.InputBox("Enter Cashier ID", "Reset Attempts", "", 100, 100);
            if(resetingcashid=="")
            {
                MessageBox.Show("Please Enter a Cashier ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else
            {
                try
                {
                    string qry2 = "update cashier set RemainingLoginAttempts = 5 where cashierID = '" + resetingcashid + "'";
                    string valqry = "select * from cashier where cashierID = '" + resetingcashid + "'";
                    SqlDataAdapter valadapter = new SqlDataAdapter(valqry, connection);
                    DataTable dt = new DataTable();
                    valadapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        SqlCommand sqlCommand = new SqlCommand(qry2, connection);

                        connection.Open();
                        try
                        {
                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Update Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        catch (Exception se1)
                        {
                            MessageBox.Show("" + se1);
                        }
                    }

                    else
                    {
                        MessageBox.Show("Cashier ID Does Not Exists", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

                catch(Exception)
                {
                    MessageBox.Show("Invalid Input!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                AdminCashierMain objthis = new AdminCashierMain();
                this.Dispose();
                objthis.Show();
                

                

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

