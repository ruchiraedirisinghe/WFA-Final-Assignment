using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class AdminCashierMain : Form
    {
        public AdminCashierMain()
        {
            InitializeComponent();
        }

        private void FoodDetailsProject_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ssDataSet1.Cashier' table. You can move, or remove it, as needed.
            this.cashierTableAdapter.Fill(this.ssDataSet1.Cashier);

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
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

        private void guna2GradientCircleButton2_Click(object sender, EventArgs e)
        {
            AdminCashierFindForm adminCashierFindForm = new AdminCashierFindForm();
            adminCashierFindForm.Show();
        }

        private void guna2GradientCircleButton3_Click(object sender, EventArgs e)
        {
            AdminCashierCreateForm adminCashierCreateForm = new AdminCashierCreateForm();
            adminCashierCreateForm.Show();
        }

        private void guna2GradientCircleButton1_Click_1(object sender, EventArgs e)
        {
            AdminCashierUpdate adminCashierUpdate = new AdminCashierUpdate();
            adminCashierUpdate.Show();
        }

        private void btn_cashfind_delete_Click(object sender, EventArgs e)
        {
            AdminCashierDelete adminCashierDelete = new AdminCashierDelete();
            adminCashierDelete.Show();
        }
    }
}
