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
    public partial class AdminCashierCreateForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ruchii-ROG-STRIX\Downloads\C\Database\ss.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminCashierCreateForm()
        {
            InitializeComponent();
        }

        private void bt_CashierLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_dataentry_Click(object sender, EventArgs e)
        {
            if (txt_cashdob.Text == "" || txt_cashid.Text == "" || txt_cashname.Text == ""|| txt_cashNIC.Text == ""|| txt_cashpw.Text == ""|| txt_cashtp.Text == ""|| txt_cashun.Text == "")
                MessageBox.Show("Cannot Contain Null Values!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                try
                {
                    string valqry = "select * from cashier where cashierID = '" + Convert.ToInt32(txt_cashid.Text) + "'";
                    SqlDataAdapter valadapter = new SqlDataAdapter(valqry, connection);
                    DataTable dt = new DataTable();
                    valadapter.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        try
                        {
                            int id = Convert.ToInt32(txt_cashid.Text);
                            string name = txt_cashname.Text;
                            string nic = txt_cashNIC.Text;
                            string us = txt_cashun.Text;
                            string pw = txt_cashpw.Text;
                            int rem = 5;
                            DateTime date = Convert.ToDateTime(txt_cashdob.Text);
                            string tel = txt_cashtp.Text;

                            try
                            {

                                connection.Open();

                                SqlCommand cmd = new SqlCommand();
                                cmd.Connection = connection;
                                cmd.CommandText = "INSERT INTO Cashier(CashierID, Name, Nic, Username, Password, RemainingLoginAttempts, BirthDay, TelephoneNumber)   VALUES(@cid,@name,@nic,@user,@pw,@rem,@date,@tel)";

                                cmd.Parameters.AddWithValue("@cid", id);
                                cmd.Parameters.AddWithValue("@name", name);
                                cmd.Parameters.AddWithValue("@nic", nic);
                                cmd.Parameters.AddWithValue("@user", us);
                                cmd.Parameters.AddWithValue("@pw", pw);
                                cmd.Parameters.AddWithValue("@rem", rem);
                                try
                                {
                                    cmd.Parameters.AddWithValue("@date", date);
                                }

                                catch (Exception)
                                {
                                    MessageBox.Show("InvalidDateInput");
                                }

                                cmd.Parameters.AddWithValue("@tel", tel);

                                cmd.ExecuteNonQuery();

                                connection.Close();

                                DialogResult result = MessageBox.Show("Record Inserted Succesfully", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (result == DialogResult.OK)

                                    txt_cashid.Clear();
                                txt_cashname.Clear();
                                txt_cashun.Clear();
                                txt_cashpw.Clear();
                                txt_cashdob.Clear();
                                txt_cashtp.Clear();
                                txt_cashNIC.Clear();
                                this.Dispose();
                            }

                            catch (Exception se)
                            {
                                MessageBox.Show("" + se);
                            }



                        }

                        catch (Exception)
                        {
                            MessageBox.Show("Invalid or Null Input/Inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }

                    else
                    {
                        MessageBox.Show("Cashier ID Already Exists", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

                catch (Exception)
                {
                    MessageBox.Show("Invalid Input", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            
        }

            

        private void AdminCashierCreateForm_Load(object sender, EventArgs e)
        {
            txt_cashid.MaxLength = 10;
            txt_cashdob.MaxLength = 10;
            txt_cashname.MaxLength = 28;
            txt_cashNIC.MaxLength = 12;
            txt_cashpw.MaxLength = 14;
            txt_cashtp.MaxLength = 10;
            txt_cashun.MaxLength = 14;

        }

        private void gunaLabel18_Click(object sender, EventArgs e)
        {

        }
    }
}
