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
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ruchii-ROG-STRIX\Downloads\C\Database\ss.mdf;Integrated Security=True;Connect Timeout=30");
        public static string SetValueForText1;
        public static string SetValueForText2;
        

        public int attemptcount = 5;
        public CashierLoginForm()
        {
            InitializeComponent();
        }

        public void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            string valqry = "select * from cashier where Username = '" + tbcashierusername.Text + "'";
            SqlDataAdapter valadapter = new SqlDataAdapter(valqry, connection);
            DataTable dt = new DataTable();
            valadapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                //creating a variable for remaining login attempts
                string readRLA = "Select RemainingLoginAttempts from cashier where username = '" + tbcashierusername.Text + "'";
                connection.Open();
                SqlCommand readcom = new SqlCommand(readRLA, connection);
                SqlDataReader readint = readcom.ExecuteReader();
                readint.Read();
                int remainingla = Convert.ToInt32(readint["RemainingLoginAttempts"].ToString());
                remainingla = remainingla - 1;
                connection.Close();

                if (remainingla < 1)
                {
                    MessageBox.Show("You are Out of Attempts\nPlease Contact Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {

                    try
                    {

                        SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Cashier WHERE Username='" + tbcashierusername.Text + "' AND Password='" + tbcashierpassword.Text + "'", connection);
                        DataTable dt1 = new DataTable();
                        sda.Fill(dt1);
                        if (dt1.Rows[0][0].ToString() == "1")
                        {

                            CashierMain form3 = new CashierMain();
                            SetValueForText1 = tbcashierusername.Text;
                            SetValueForText2 = tbcashierpassword.Text;
                            this.Hide();
                            form3.Show();


                        }

                        else if (tbcashierusername.Text == "" || tbcashierpassword.Text == "")
                            MessageBox.Show("Username or Password cannot be Empty");



                        else
                        {
                            SqlCommand decreaseattemts = new SqlCommand("update Cashier set [RemainingLoginAttempts] = [RemainingLoginAttempts] - 1 where Username = '" + tbcashierusername.Text + "'", connection);
                            connection.Open();
                            decreaseattemts.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Username and Password Does not Match\nOnly " + (remainingla) + " Attempts Remaining", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }

                    catch (SqlException en)
                    {
                        MessageBox.Show("error", en.ToString());
                    }

                }

            }

            else
            {
                MessageBox.Show("Username Does Not Exists", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                btCashierLogin.PerformClick();
            
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.Show();
        }
    }
}
