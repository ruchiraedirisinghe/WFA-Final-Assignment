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
    public partial class CashierMain : Form
    {
        public CashierMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void CashierMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ssDataSet.OngoingBill' table. You can move, or remove it, as needed.
            this.ongoingBillTableAdapter.Fill(this.ssDataSet.OngoingBill);

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel19_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            CashierFoodDetails obj = new CashierFoodDetails();
            obj.Show();
        }
    }
}
