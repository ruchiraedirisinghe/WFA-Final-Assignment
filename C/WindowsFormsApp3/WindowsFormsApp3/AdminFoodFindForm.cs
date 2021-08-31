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
    public partial class AdminFoodFindForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ruchii-ROG-STRIX\Downloads\C\Database\ss.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminFoodFindForm()
        {
            InitializeComponent();
        }

        private void btn_find_enter_Click(object sender, EventArgs e)
        {
            string qry = "select foodid from Foods where foodname ='" + txt_find_fdid.Text + "'";
            string qry1 = "select Unitprice from foods where foodname ='" + txt_find_fdid.Text + "'";


            SqlCommand cmd = new SqlCommand(qry, connection);
            SqlCommand cmd1 = new SqlCommand(qry1, connection);



            string valqry = "select * from foods where foodname = '" + txt_find_fdid.Text + "'";
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
                    lbFoodName.Text = name["foodid"].ToString();


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
                MessageBox.Show("Food Name Does Not Exists", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txt_find_fdid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
