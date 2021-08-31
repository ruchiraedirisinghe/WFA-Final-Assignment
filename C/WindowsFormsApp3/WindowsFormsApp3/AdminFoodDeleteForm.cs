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
    public partial class AdminFoodDeleteForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ruchii-ROG-STRIX\Downloads\C\Database\ss.mdf;Integrated Security=True;Connect Timeout=30");

        public AdminFoodDeleteForm()
        {
            InitializeComponent();
        }

        private void btn_delfd_enter_Click(object sender, EventArgs e)
        {
            string qry = "select Foodname from Foods where foodid ='" + txt_delfd_enterid.Text + "'";
            string qry1 = "select Unitprice from foods where foodid ='" + txt_delfd_enterid.Text + "'";


            SqlCommand cmd = new SqlCommand(qry, connection);
            SqlCommand cmd1 = new SqlCommand(qry1, connection);



            string valqry = "select * from foods where foodid = '" + txt_delfd_enterid.Text + "'";
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

                        lbFoodUPrice.Text = uprice["UnitPrice"].ToString();


                    }

                    catch (Exception se2)
                    {
                        MessageBox.Show("Invalid Input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connection.Close();
                    }

                    bt_delfd_delete.Visible = true;


                }

                catch(Exception)
                {
                    
                }
               


            }

            else
            {
                MessageBox.Show("Food ID Does Not Exists", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void bt_delfd_delete_Click(object sender, EventArgs e)
        {
            string delqry = "delete from Foods where Foodid ='" + txt_delfd_enterid.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(delqry, connection);

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

                catch (Exception ex)
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

        private void bt_CashierLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txt_delfd_enterid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
