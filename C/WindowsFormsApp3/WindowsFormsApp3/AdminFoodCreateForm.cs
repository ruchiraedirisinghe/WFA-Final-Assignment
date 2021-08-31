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
    public partial class AdminFoodCreateForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ruchii-ROG-STRIX\Downloads\C\Database\ss.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminFoodCreateForm()
        {
            InitializeComponent();
        }

        private void AdminFoodCreateForm_Load(object sender, EventArgs e)
        {
            txt_crfd_fdid.MaxLength = 10;
            txt_crfd_fdname.MaxLength = 20;
            txt_crfd_fdunit.MaxLength = 10;
        }

        private void btn_crfd_enter_Click(object sender, EventArgs e)
        {
            if (txt_crfd_fdid.Text == "" || txt_crfd_fdname.Text == "" || txt_crfd_fdunit.Text == "")
                MessageBox.Show("Cannot Contain Null Values!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



            else
            {
                string valqry = "select * from foods where foodid = '" + txt_crfd_fdid.Text + "'";
                SqlDataAdapter valadapter = new SqlDataAdapter(valqry, connection);
                DataTable dt = new DataTable();
                valadapter.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    try
                    {

                        string foodid = txt_crfd_fdid.Text;
                        string foodname = txt_crfd_fdname.Text;
                        int uprice = Convert.ToInt32(txt_crfd_fdunit.Text);


                        try
                        {

                            connection.Open();

                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = connection;
                            cmd.CommandText = "INSERT INTO Foods(FoodID, FoodName, UnitPrice)   VALUES(@fid,@fname,@fup)";

                            cmd.Parameters.AddWithValue("@fid", foodid);
                            cmd.Parameters.AddWithValue("@fname", foodname);
                            cmd.Parameters.AddWithValue("@fup", uprice);



                            cmd.ExecuteNonQuery();

                            connection.Close();

                            DialogResult result = MessageBox.Show("Record Inserted Succesfully", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (result == DialogResult.OK)
                            {
                                txt_crfd_fdid.Clear();
                                txt_crfd_fdname.Clear();
                                txt_crfd_fdunit.Clear();
                                this.Dispose();

                            }


                        }

                        catch (Exception se)
                        {

                            MessageBox.Show("Invalid or Null Input/Inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }



                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Invalid or Null Input/Inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }

                else
                {
                    MessageBox.Show("Food ID Already Exists", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
        private void bt_CashierLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txt_crfd_fdid_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
    
}

