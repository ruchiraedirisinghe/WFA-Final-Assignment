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
    public partial class CashierFoodDetails : Form
    {
        public CashierFoodDetails()
        {
            InitializeComponent();
        }

        private void AdminItemSettings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ssDataSet4.Foods' table. You can move, or remove it, as needed.
            this.foodsTableAdapter.Fill(this.ssDataSet4.Foods);

        }

        private void bt_CashierLogout_Click(object sender, EventArgs e)
        {

        }
    }
}
