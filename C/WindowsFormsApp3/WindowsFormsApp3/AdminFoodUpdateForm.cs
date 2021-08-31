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
    public partial class AdminFoodUpdateForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ruchii-ROG-STRIX\Downloads\C\Database\ss.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminFoodUpdateForm()
        {
            InitializeComponent();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            CashierFoodDetails obj = new CashierFoodDetails();
            obj.Show();
        }

        private void btn_dataenter_Click(object sender, EventArgs e)
        {
            string qry = "select Foodname from Foods where foodid ='" + txt_enterid.Text + "'";
            string qry1 = "select Unitprice from foods where foodid ='" + txt_enterid.Text + "'";


            SqlCommand cmd = new SqlCommand(qry, connection);
            SqlCommand cmd1 = new SqlCommand(qry1, connection);



            string valqry = "select * from foods where foodid = '" + txt_enterid.Text + "'";
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
                    lbFoodName.Text = name["FoodName"].ToString();


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
                    SqlDataReader uprice = cmd1.ExecuteReader();
                    uprice.Read();

                    lbFUPrice.Text = uprice["UnitPrice"].ToString();


                }

                catch (Exception se2)
                {
                    MessageBox.Show("Invalid Input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connection.Close();
                }
            }

            else
            {
                MessageBox.Show("Food ID Does Not Exists", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btFNameUpdate_Click(object sender, EventArgs e)
        {
            if(txt_foodname.Text=="")
                MessageBox.Show("Null Values not Permitted", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string qry1 = "update foods set foodname = @fname where foodid = @fid";



                SqlCommand sqlCommand = new SqlCommand(qry1, connection);

                sqlCommand.Parameters.AddWithValue("@fid", txt_enterid.Text);
                sqlCommand.Parameters.AddWithValue("@fname", txt_foodname.Text);


                connection.Open();
                try
                {
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Update Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception se1)
                {
                    MessageBox.Show("Cannot Update Invalid Input Entered", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    connection.Close();
                }

            }

            AdminFoodUpdateForm objthis = new AdminFoodUpdateForm();
            this.Dispose();
            objthis.Show();

        }

        private void btFUPriceUpdate_Click(object sender, EventArgs e)
        {
            if (txt_unitprice.Text == "")
                MessageBox.Show("Null Values not Permitted", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    string qry1 = "update foods set unitprice = @fname where foodid = @fid";
                    int uprice = Convert.ToInt32(txt_unitprice.Text);


                    SqlCommand sqlCommand = new SqlCommand(qry1, connection);

                    sqlCommand.Parameters.AddWithValue("@fid", txt_enterid.Text);
                    sqlCommand.Parameters.AddWithValue("@fname", uprice);


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

                    finally
                    {
                        connection.Close();
                    }

                }

                catch (Exception)
                {
                    MessageBox.Show("Cannot Update Invalid Input Entered", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }




            }


            AdminFoodUpdateForm objthis = new AdminFoodUpdateForm();
            this.Dispose();
            objthis.Show();

        }

        private void guna2CustomGradientPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_AdminLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txt_enterid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
