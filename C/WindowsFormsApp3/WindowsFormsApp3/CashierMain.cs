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
using Microsoft.VisualBasic;

namespace WindowsFormsApp3
{

    public partial class CashierMain : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ruchii-ROG-STRIX\Downloads\C\Database\ss.mdf;Integrated Security=True;Connect Timeout=30");
        int removeprice = 10;
        public CashierMain()
        {
            InitializeComponent();
        }

        private void DGVBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            CashierLoginForm cashierLoginForm = new CashierLoginForm();

            this.Dispose();
            cashierLoginForm.Show();

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel19_Click(object sender, EventArgs e)
        {

        }
        public bool dyflag = true;
        int sum = 0;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            sum = 0;
            if(txtFCode.Text==""||txtQty.Text=="")
            {
                MessageBox.Show("Empty Input", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {

                int unitprice = Convert.ToInt32(lbUPrice.Text);
                string foodname = lbFoodName.Text;




                if (dyflag == true)
                {
                    lbBillDate.Text = DateTime.Now.ToShortDateString();
                    lbBillTime.Text = DateTime.Now.ToShortTimeString();
                    dyflag = false;
                }




                //Add rows to DataTable.
                dt.Rows.Add(null, txtFCode.Text, foodname, unitprice, txtQty.Text, (unitprice * Convert.ToInt32(this.txtQty.Text)));


                DGVBill.DataSource = dt;



                for (int i = 0; i < DGVBill.Rows.Count; ++i)

                {

                    sum = sum + Convert.ToInt32(DGVBill.Rows[i].Cells["total"].Value);

                }

                lbSubTotal.Text = sum.ToString();


                btAddBill.Enabled = false;
                txtFCode.Clear();
                lbFoodName.Text = "";
                lbUPrice.Text = "";





            }

            
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            CashierFoodDetails obj = new CashierFoodDetails();
            obj.Show();
        }

        DataTable dt = new DataTable();
        public int seed = 1;

        private void CashierMain_Load(object sender, EventArgs e)
        {
            txtAddDis.DefaultText = "0";
            string getuname = CashierLoginForm.SetValueForText1;




            string cashidreadqry = "select cashierid from cashier where username = '" + getuname + "'";
            string cashnamereadqry = "select name from cashier where username = '" + getuname + "'";
            SqlCommand readidcmd = new SqlCommand(cashidreadqry, connection);
            SqlCommand readnamecmd = new SqlCommand(cashnamereadqry, connection);
            connection.Open();
            SqlDataReader readid = readidcmd.ExecuteReader();
            readid.Read();
            lbCashId.Text = readid["cashierid"].ToString();
            connection.Close(); 
            connection.Open();
            SqlDataReader readname = readnamecmd.ExecuteReader();
            readname.Read();
            lbCashName.Text = readname["name"].ToString();
            connection.Close();


            //Add columns to DataTable.
            dt.Columns.AddRange(new DataColumn[6] { new DataColumn("#"), new DataColumn("Food Code"), new DataColumn("Food Name"), new DataColumn("Unit Price"), new DataColumn("Quantity"), new DataColumn("Total") });

            //Set AutoIncrement True for the First Column.
            dt.Columns["#"].AutoIncrement = true;

            //Set the Starting or Seed value.
            dt.Columns["#"].AutoIncrementSeed = seed;

            //Set the Increment value.
            dt.Columns["#"].AutoIncrementStep = 1;




            DGVBill.DataSource = dt;

            btPrintBill.Enabled = false;

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string adminpwinput = Interaction.InputBox("Enter ADMIN Password - ", "Requieres Authorization", "", 100, 100);
            
            if(adminpwinput=="admin")
            {
                CashierMain cashierMain = new CashierMain();
                this.Dispose();
                cashierMain.Show();

            }

            else
            {
                MessageBox.Show("Incorrect Password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (txtAddDis.Text == "")
                MessageBox.Show("Null Values not Permitted", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                try
                {
                    

                    int sub = int.Parse(lbSubTotal.Text);
                    int disval = int.Parse(txtAddDis.Text);

                    float discount = ((float)sub / 100) * (float)disval;

                    lbDis2.Text = discount.ToString();

                    float total = sub - discount;
                    lbTotal.Text = total.ToString();

                    lbDis1.Text = txtAddDis.Text;
                    lbDiscountPresent.Text = txtAddDis.Text + "%";

                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Input", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

            

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            btAddBill.Enabled = false;
            gunaButton1.Enabled = false;
            btAddDis.Enabled = true;
            txtAddDis.Enabled = true;
            btRemoveItem.Enabled = true;

            btPrintBill.Enabled = true;

            lbTotal.Text = sum.ToString();
            btFinishBill.Enabled = false;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (DGVBill.Rows.Count > 0)
            {
                if (txtAddDis.Text == "")
                    txtAddDis.Text = "0";

                DGVBill.CurrentRow.Selected = true;
                removeprice = Convert.ToInt32(DGVBill.CurrentRow.Cells[5].Value.ToString());
                DGVBill.Rows.RemoveAt(DGVBill.SelectedRows[0].Index);
                sum = sum - removeprice;
                lbSubTotal.Text = sum.ToString();
                lbTotal.Text = sum.ToString();
                btAddDis.PerformClick();
                

            }

            else
                MessageBox.Show("Bill is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel9_Click(object sender, EventArgs e)
        {

        }

        private void printBill_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Bitmap objprintBillBitmap = new Bitmap(this.panelBill.Width, this.panelBill.Height);
            panelBill.DrawToBitmap(objprintBillBitmap, new Rectangle(0, 0, this.panelBill.Width, this.panelBill.Height));
            e.Graphics.DrawImage(objprintBillBitmap, 0, 0);
        }

        private void btPrintBill_Click(object sender, EventArgs e)
        {
            var foodiflist = dt.AsEnumerable().Select(r => r["Food Code"].ToString());
            string list = string.Join(", ", foodiflist);
            float revtotal = float.Parse(lbTotal.Text);

            if (DGVBill.Rows.Count > 0)
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO todaysale(description,total) VALUES(@li,@rev)";
                    cmd.Parameters.AddWithValue("@rev", revtotal);
                    cmd.Parameters.AddWithValue("@li", list);
                    cmd.ExecuteNonQuery();

                }

                catch (Exception se)
                {
                    MessageBox.Show("Connection Error Data Not Sent" + se);
                }

                finally
                {
                    connection.Close();
                }

                PrintDialog objprintBillPrintDialog = new PrintDialog();
                objprintBillPrintDialog.Document = printDGVBill;
                objprintBillPrintDialog.UseEXDialog = true;

                DialogResult objprintBillDialogResult = objprintBillPrintDialog.ShowDialog();


                if(objprintBillDialogResult == DialogResult.OK)
                {

                    printDGVBill.DocumentName = "Smart Food Print Bill";
                    printDGVBill.Print();
                }
                

            }

            else
                MessageBox.Show("Bill is Empty Cannot Print!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);




        }

            private void gunaButton1_Click(object sender, EventArgs e)
        {
            
            string qry = "select UnitPrice from Foods where FoodID ='" + txtFCode.Text + "'";
            string qry1 = "select FoodName from Foods where FoodID ='" + txtFCode.Text + "'";
            SqlCommand cmd = new SqlCommand(qry, connection);
            SqlCommand cmd2 = new SqlCommand(qry1, connection);
           
            try
            {
                try
                {
                    connection.Open();
                    SqlDataReader uprice = cmd.ExecuteReader();
                    uprice.Read();
                    lbUPrice.Text = uprice["UnitPrice"].ToString();


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
                    SqlDataReader fdname = cmd2.ExecuteReader();
                    fdname.Read();

                    lbFoodName.Text = fdname["FoodName"].ToString();
                    btAddBill.Enabled = true;


                }

                catch (Exception se2)
                {


                }
                finally
                {
                    connection.Close();
                }

                

            }

            catch(Exception)
            {

            }

            
        }

        private void guna2CustomGradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtAddDis_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panelBill_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelTotal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
