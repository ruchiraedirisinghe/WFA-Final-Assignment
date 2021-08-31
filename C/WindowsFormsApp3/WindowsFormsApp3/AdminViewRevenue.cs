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
    public partial class AdminViewRevenue : Form
    {
        int revsum;
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ruchii-ROG-STRIX\Downloads\C\Database\ss.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminViewRevenue()
        {
            InitializeComponent();
        }

        private void AdminViewRevenue_Load(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString();
            string qry = "select * from todaysale";
            SqlDataAdapter revdata = new SqlDataAdapter(qry, connection);
            DataSet dataSet = new DataSet();
            revdata.Fill(dataSet, "todaysale");
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void btn_viewrev_fddetail_Click(object sender, EventArgs e)
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString();



        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string qry = "select * from todaysale";
            SqlDataAdapter revdata = new SqlDataAdapter(qry, connection);
            DataSet dataSet = new DataSet();
            revdata.Fill(dataSet, "todaysale");
            dataGridView1.DataSource = dataSet.Tables[0];

            

            try
            {
                revsum = 0;

                for (int i = 0; i < dataGridView1.Rows.Count; ++i)

                {

                    revsum = revsum + Convert.ToInt32(dataGridView1.Rows[i].Cells["total"].Value);

                }

                label6.Text = revsum.ToString();


            }

            catch (Exception se)
            {
                MessageBox.Show(""+se);
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objprintBillBitmap = new Bitmap(this.panel1.Width, this.panel1.Height);
            panel1.DrawToBitmap(objprintBillBitmap, new Rectangle(0, 0, this.panel1.Width, this.panel1.Height));
            e.Graphics.DrawImage(objprintBillBitmap, 0, 0);
        }


        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DialogResult revprintresult = MessageBox.Show("Confrim Your Action", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (revprintresult == DialogResult.Yes)
            {
                PrintDialog printrevdialog = new PrintDialog();
                printrevdialog.Document = printDocument1;
                printrevdialog.UseEXDialog = true;

                DialogResult objprintBillDialogResult = printrevdialog.ShowDialog();


                if (objprintBillDialogResult == DialogResult.OK)
                {

                    printDocument1.DocumentName = "Rev Report";
                    printDocument1.Print();
                    MessageBox.Show("Print Done","Done",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    string sqlStatement = "delete from todaysale";

                    try
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand(sqlStatement, connection);
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();

                    }
                    finally
                    {
                        connection.Close();
                    }
                }

            }

            else
            {
                MessageBox.Show("Operation Canelled", "Cancelled!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

        
    }
}
