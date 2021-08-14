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
    public partial class CashierLoginForm : Form
    {
        
        public int attemptcount = 5;
        public CashierLoginForm()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if (attemptcount == 0)
            {
                MessageBox.Show("You are Out of Attempts\nPlease Contact Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try 
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ruchii-ROG-STRIX\Documents\GitHub\WFA-Final-Assignment\WindowsFormsApp3\WindowsFormsApp3\ss.mdf;Integrated Security=True;Connect Timeout=30");
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Cashier WHERE Username='" + tbcashierusername.Text + "' AND Password='" + tbcashierpassword.Text + "'", connection);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        CashierMain form3 = new CashierMain();
                        this.Hide();
                        form3.Show();

                    }

                    else if (tbcashierusername.Text == "" || tbcashierpassword.Text == "")
                        MessageBox.Show("Username or Password cannot be Empty");



                    else
                    {
                        SqlCommand decreaseattemts = new SqlCommand("update Cashier set [RemainingLoginAttempts] = [RemainingLoginAttempts] - 1 where Username = '"+tbcashierusername.Text+"'", connection);
                        connection.Open();
                        decreaseattemts.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Username and Password Does not Match\nOnly " + attemptcount + " Attempts Remaining", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }

                catch (SqlException en)
                {
                    MessageBox.Show("error",en.ToString());
                }
                
            }
        }

        private void CashierLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void jump(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                tbcashierpassword.Focus();
            }
        }

        private void login(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                gunaAdvenceButton1.PerformClick();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.Show();
        }
    }
}
