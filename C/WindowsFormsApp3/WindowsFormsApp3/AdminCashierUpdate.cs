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
    public partial class AdminCashierUpdate : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ruchii-ROG-STRIX\Downloads\C\Database\ss.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminCashierUpdate()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            if (txt_up_cashpw.Text == "")
                MessageBox.Show("Null Values not Permitted", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                string qry9 = "update cashier set password = @pw where cashierID = @cashid";


                SqlCommand sqlCommand = new SqlCommand(qry9, connection);
                try
                {
                    sqlCommand.Parameters.AddWithValue("@cashid", txtEnterCashId.Text);
                    sqlCommand.Parameters.AddWithValue("@pw", txt_up_cashpw.Text);




                    connection.Open();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Update Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception se1)
                {
                    MessageBox.Show("invalid input" + se1);
                }

                finally
                {
                    connection.Close();
                }

            }
            
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            if (txt_up_cashuname.Text == "")
                MessageBox.Show("Null Values not Permitted", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                string qry6 = "update cashier set username = @uname where cashierID = @cashid";

                try
                {
                    SqlCommand sqlCommand = new SqlCommand(qry6, connection);

                    sqlCommand.Parameters.AddWithValue("@cashid", txtEnterCashId.Text);
                    sqlCommand.Parameters.AddWithValue("@uname", txt_up_cashuname.Text);


                    connection.Open();

                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Update Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception se1)
                {
                    MessageBox.Show("" + se1);
                }

                finally
                {
                    connection.Close();
                }

            }
            
        }

        private void bt_CashierLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void gunaLabel6_Click(object sender, EventArgs e)
        {

        }

        private void btEnterCashId_Click(object sender, EventArgs e)
        {
            
            string qry = "select Name from Cashier where CashierID ='" + txtEnterCashId.Text + "'";
            string qry1 = "select NIC from Cashier where CashierID ='" + txtEnterCashId.Text + "'";
            string qry2 = "select Username from Cashier where CashierID ='" + txtEnterCashId.Text + "'";
            string qry3 = "select Password from Cashier where CashierID ='" + txtEnterCashId.Text + "'";
            string qry5 = "select BirthDay from Cashier where CashierID ='" + txtEnterCashId.Text + "'";
            string qry6 = "select TelephoneNumber from Cashier where CashierID ='" + txtEnterCashId.Text + "'";
            SqlCommand cmd = new SqlCommand(qry, connection);
            SqlCommand cmd1 = new SqlCommand(qry1, connection);
            SqlCommand cmd2 = new SqlCommand(qry2, connection);
            SqlCommand cmd3 = new SqlCommand(qry3, connection);
            SqlCommand cmd5 = new SqlCommand(qry5, connection);
            SqlCommand cmd6 = new SqlCommand(qry6, connection);

            try
            {
                string valqry = "select * from cashier where cashierID = '" + txtEnterCashId.Text + "'";
                SqlDataAdapter valadapter = new SqlDataAdapter(valqry, connection);
                DataTable dt = new DataTable();
                valadapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader name = cmd.ExecuteReader();
                        name.Read();
                        lbCashName.Text = name["Name"].ToString();


                    }

                    catch (Exception se)
                    {
                        MessageBox.Show("Invalid Input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }





                    finally
                    {
                        connection.Close();
                    }

                    try
                    {
                        connection.Open();
                        SqlDataReader nic = cmd1.ExecuteReader();
                        nic.Read();

                        lbCashNIC.Text = nic["Nic"].ToString();


                    }

                    catch (Exception se2)
                    {
                        MessageBox.Show("Invalid Input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connection.Close();
                    }

                    try
                    {
                        connection.Open();
                        SqlDataReader usr = cmd2.ExecuteReader();
                        usr.Read();

                        lbCashUname.Text = usr["Username"].ToString();


                    }

                    catch (Exception se2)
                    {

                        MessageBox.Show("Invalid Input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }

                    try
                    {
                        connection.Open();
                        SqlDataReader pw = cmd3.ExecuteReader();
                        pw.Read();

                        lbCashPw.Text = pw["Password"].ToString();


                    }

                    catch (Exception se2)
                    {

                        MessageBox.Show("Invalid Input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }



                    try
                    {
                        connection.Open();
                        SqlDataReader bd = cmd5.ExecuteReader();
                        bd.Read();

                        DateTime date = Convert.ToDateTime(bd["BirthDay"].ToString());
                        lbCashAddress.Text = String.Format("{0}/{1}/{2}", date.Month, date.Day, date.Year);


                    }

                    catch (Exception se2)
                    {
                        MessageBox.Show("Invalid Input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connection.Close();
                    }

                    try
                    {
                        connection.Open();
                        SqlDataReader tp = cmd6.ExecuteReader();
                        tp.Read();

                        lbCashTP.Text = tp["TelephoneNumber"].ToString();


                    }

                    catch (Exception se2)
                    {


                    }
                    finally
                    {
                        connection.Close();
                    }

                    btn_upCash_uname.Enabled = true;
                    btn_upCash_address.Enabled = true;
                    btn_upCash_name.Enabled = true;
                    btn_upCash_nic.Enabled = true;
                    btn_upCash_pw.Enabled = true;
                    btn_upCash_tp.Enabled = true;

                }

                else
                {
                    btn_upCash_uname.Enabled = false;
                    btn_upCash_address.Enabled = false;
                    btn_upCash_name.Enabled = false;
                    btn_upCash_nic.Enabled = false;
                    btn_upCash_pw.Enabled = false;
                    btn_upCash_tp.Enabled = false;
                    MessageBox.Show("Cashier ID Does Not Exists", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            catch(Exception)
            {
                MessageBox.Show("Cashier ID Does Not Exists", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            

           
        }

        private void btn_upCash_name_Click(object sender, EventArgs e)
        {
            if(txt_up_cashName.Text=="")
                MessageBox.Show("Null Values not Permitted", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                string qry1 = "update cashier set name = @name where cashierID = @cashid";

                try
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand(qry1, connection);

                    sqlCommand.Parameters.AddWithValue("@cashid", txtEnterCashId.Text);
                    sqlCommand.Parameters.AddWithValue("@name", txt_up_cashName.Text);




                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Update Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception se1)
                {
                    MessageBox.Show("Invalid Input" + se1);
                }
                finally
                {
                    connection.Close();
                }

            }

            AdminCashierUpdate objthis = new AdminCashierUpdate();
            this.Dispose();
            objthis.Show();


        }

        private void btn_upCash_nic_Click(object sender, EventArgs e)
        {
            if (txt_up_cashNIC.Text == "")
                MessageBox.Show("Null Values not Permitted", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string qry2 = "update cashier set nic = @nic where cashierID = @cashid";

                try
                {

                    SqlCommand sqlCommand = new SqlCommand(qry2, connection);

                    sqlCommand.Parameters.AddWithValue("@cashid", txtEnterCashId.Text);
                    sqlCommand.Parameters.AddWithValue("@nic", txt_up_cashNIC.Text);


                    connection.Open();

                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Update Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception se1)
                {
                    MessageBox.Show("" + se1);
                }

            }

            AdminCashierUpdate objthis = new AdminCashierUpdate();
            this.Dispose();
            objthis.Show();

        }

        private void btn_upCash_address_Click(object sender, EventArgs e)
        {
            if (txt_up_cashaddress.Text == "")
                MessageBox.Show("Null Values not Permitted", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                try
                {
                    string qry2 = "update cashier set birthday = @bday where cashierID = @cashid";
                    DateTime date = Convert.ToDateTime(txt_up_cashaddress.Text);


                    SqlCommand sqlCommand = new SqlCommand(qry2, connection);
                    try
                    {
                        sqlCommand.Parameters.AddWithValue("@cashid", txtEnterCashId.Text);
                        sqlCommand.Parameters.AddWithValue("@bday", date);


                        connection.Open();

                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Update Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    catch (Exception se1)
                    {
                        MessageBox.Show("" + se1);
                    }
                    finally
                    {
                        connection.Close();
                    }

                }

                catch (Exception)
                {
                    MessageBox.Show("Input Error");
                }

            }

            AdminCashierUpdate objthis = new AdminCashierUpdate();
            this.Dispose();
            objthis.Show();


        }

        private void btn_upCash_tp_Click(object sender, EventArgs e)
        {
            if (txt_up_cashtp.Text == "")
                MessageBox.Show("Null Values not Permitted", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                string qry3 = "update cashier set telephonenumber = @tp where cashierID = @cashid";

                try
                {
                    SqlCommand sqlCommand = new SqlCommand(qry3, connection);

                    sqlCommand.Parameters.AddWithValue("@cashid", txtEnterCashId.Text);
                    sqlCommand.Parameters.AddWithValue("@tp", txt_up_cashtp.Text);




                    connection.Open();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Update Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception se1)
                {
                    MessageBox.Show("Invalid Input" + se1);
                }

                finally
                {
                    connection.Close();
                }
            }

            AdminCashierUpdate objthis = new AdminCashierUpdate();
            this.Dispose();
            objthis.Show();

        }

        private void AdminCashierUpdate_Load(object sender, EventArgs e)
        {
            txtEnterCashId.MaxLength = 10;
            txt_up_cashaddress.MaxLength = 10;
            txt_up_cashName.MaxLength = 28;
            txt_up_cashNIC.MaxLength = 12;
            txt_up_cashpw.MaxLength = 14;
            txt_up_cashtp.MaxLength = 10;
            txt_up_cashuname.MaxLength = 14;
        }

        private void txt_up_cashNIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEnterCashId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
