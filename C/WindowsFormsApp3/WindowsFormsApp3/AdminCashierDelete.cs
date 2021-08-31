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
    public partial class AdminCashierDelete : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ruchii-ROG-STRIX\Downloads\C\Database\ss.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminCashierDelete()
        {
            InitializeComponent();
        }

        private void bt_CashierLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btEnterCashId_Click(object sender, EventArgs e)
        {
            
            string qry = "select Name from Cashier where CashierID ='" + txtEnterCashId.Text + "'";
            string qry1 = "select NIC from Cashier where CashierID ='" + txtEnterCashId.Text + "'";
            string qry2 = "select birthday from Cashier where CashierID ='" + txtEnterCashId.Text + "'";
            string qry3 = "select telephonenumber from Cashier where CashierID ='" + txtEnterCashId.Text + "'";
            string qry4 = "select username from Cashier where CashierID ='" + txtEnterCashId.Text + "'";
            string qry5 = "select password from Cashier where CashierID ='" + txtEnterCashId.Text + "'";
            string qry6 = "select RemainingLoginAttempts from Cashier where CashierID ='" + txtEnterCashId.Text + "'";
            SqlCommand cmd = new SqlCommand(qry, connection);
            SqlCommand cmd1 = new SqlCommand(qry1, connection);
            SqlCommand cmd2 = new SqlCommand(qry2, connection);
            SqlCommand cmd3 = new SqlCommand(qry3, connection);
            SqlCommand cmd4 = new SqlCommand(qry4, connection);
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
                            SqlDataReader bd = cmd2.ExecuteReader();
                            bd.Read();

                            DateTime date = Convert.ToDateTime(bd["BirthDay"].ToString());
                            lbCashDOB.Text = String.Format("{0}/{1}/{2}", date.Month, date.Day, date.Year);


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
                            SqlDataReader tp = cmd3.ExecuteReader();
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

                        try
                        {
                            connection.Open();
                            SqlDataReader usr = cmd4.ExecuteReader();
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
                            SqlDataReader pw = cmd5.ExecuteReader();
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
                            SqlDataReader name = cmd6.ExecuteReader();
                            name.Read();
                            lbRLAttempts.Text = name["RemainingLoginAttempts"].ToString();


                        }

                        catch (Exception se)
                        {
                            MessageBox.Show("Invalid Input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }





                        finally
                        {
                            connection.Close();
                        }

                        btDeleteCash.Visible = true;
                    }

                    catch (Exception)
                    {

                    }

                }

                else
                {
                    MessageBox.Show("Cashier ID Does Not Exists", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            catch(Exception)
            {
                MessageBox.Show("Cashier ID Does Not Exists", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

            
        }

        private void guna2CustomGradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbCashAddress_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel6_Click(object sender, EventArgs e)
        {

        }

        private void btDeleteCash_Click(object sender, EventArgs e)
        {
            string delqry = "delete from Cashier where CashierID ='" + txtEnterCashId.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(delqry,connection);

            DialogResult dialogResult = MessageBox.Show("Do You Want To Delete This Record", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    connection.Open();
                    sqlCommand.ExecuteNonQuery();

                    DialogResult result = MessageBox.Show("Record Deleted Succesfully", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                        this.Dispose();
                    
                }

                catch(Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                
                finally
                {
                    connection.Close();
                }

            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        private void AdminCashierDelete_Load(object sender, EventArgs e)
        {
            txtEnterCashId.MaxLength = 10;
            
        }

        private void txtEnterCashId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
