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
    }
}
