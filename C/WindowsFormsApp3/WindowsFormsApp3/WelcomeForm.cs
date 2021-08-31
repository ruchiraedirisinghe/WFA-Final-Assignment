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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            CashierLoginForm form2 = new CashierLoginForm();
            this.Hide();
            form2.Show();
            
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton2_Click_1(object sender, EventArgs e)
        {
            AdminLoginForm adminLoginForm = new AdminLoginForm();
            this.Hide();
            adminLoginForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
