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
    public partial class AdminFoodItemMain : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ruchii-ROG-STRIX\Downloads\C\Database\ss.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminFoodItemMain()
        {
            InitializeComponent();
        }

        private void gunaLabel18_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_fditem_find_Click(object sender, EventArgs e)
        {
            AdminFoodFindForm adminFoodFindForm = new AdminFoodFindForm();

            adminFoodFindForm.Show();
        }

        private void btn_fditem_create_Click(object sender, EventArgs e)
        {
            AdminFoodCreateForm adminFoodCreateForm = new AdminFoodCreateForm();

            adminFoodCreateForm.Show();
        }

        private void btn_fditem_update_Click(object sender, EventArgs e)
        {
            AdminFoodUpdateForm adminFoodUpdateForm = new AdminFoodUpdateForm();

            adminFoodUpdateForm.Show();
        }

        private void btn_fditem_del_Click(object sender, EventArgs e)
        {
            AdminFoodDeleteForm adminFoodDeleteForm = new AdminFoodDeleteForm();

            adminFoodDeleteForm.Show();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string qry = "select * from foods";
            SqlDataAdapter sqlData = new SqlDataAdapter(qry, connection);
            DataSet dataSet = new DataSet();
            sqlData.Fill(dataSet, "foods");
            dataGridView1.DataSource = dataSet.Tables[0];
        }

       

        private void AdminFoodItemMain_Load(object sender, EventArgs e)
        {
            string qry = "select * from foods";
            SqlDataAdapter sqlData = new SqlDataAdapter(qry, connection);
            DataSet dataSet = new DataSet();
            sqlData.Fill(dataSet, "foods");
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AdminMain adminMain = new AdminMain();
            this.Dispose();
            adminMain.Show();
        }

        private void btAdminLogout_Click(object sender, EventArgs e)
        {
            AdminLoginForm adlogin = new AdminLoginForm();
            this.Dispose();
            adlogin.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
