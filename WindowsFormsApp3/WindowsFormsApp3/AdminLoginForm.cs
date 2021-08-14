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
    
    public partial class AdminLoginForm : Form
    {
        
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if (txt_AdminName.Text == "admin" && txt_AdminPw.Text == "admin")
                {
                AdminMain adminmainform = new AdminMain();
                this.Hide();
                adminmainform.Show();
            }

            else
            {
                MessageBox.Show("Incorrect Username or Password", "Invalid Input", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

                
           
                
        }

        
        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void jump(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                txt_AdminPw.Focus();
            }
            
        }

        private void login(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
                bt_AdminLog.PerformClick();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_GoBack_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm();
            this.Dispose();
            welcomeForm.Show();
        }
    }
}
