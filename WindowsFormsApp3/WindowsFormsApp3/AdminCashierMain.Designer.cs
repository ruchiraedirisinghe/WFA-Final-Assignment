
namespace WindowsFormsApp3
{
    partial class AdminCashierMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCashierMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaLabel18 = new Guna.UI.WinForms.GunaLabel();
            this.btn_rtnadmin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.bt_CashierLogout = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CustomGradientPanel4 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btn_cashreset = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_cashdel = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btn_cashcreate = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btn_cashfind = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btn_cashupdate = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2CustomGradientPanel5 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cashierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainingLoginAttemptsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ssDataSet1 = new WindowsFormsApp3.ssDataSet1();
            this.cashierTableAdapter = new WindowsFormsApp3.ssDataSet1TableAdapters.CashierTableAdapter();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.guna2CustomGradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.guna2CustomGradientPanel4.SuspendLayout();
            this.guna2CustomGradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel18
            // 
            this.gunaLabel18.AutoSize = true;
            this.gunaLabel18.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel18.Font = new System.Drawing.Font("Poppins Black", 20F, System.Drawing.FontStyle.Bold);
            this.gunaLabel18.ForeColor = System.Drawing.Color.Navy;
            this.gunaLabel18.Location = new System.Drawing.Point(308, 21);
            this.gunaLabel18.Name = "gunaLabel18";
            this.gunaLabel18.Size = new System.Drawing.Size(278, 48);
            this.gunaLabel18.TabIndex = 17;
            this.gunaLabel18.Text = "CASHIER SETTINGS";
            // 
            // btn_rtnadmin
            // 
            this.btn_rtnadmin.BackColor = System.Drawing.Color.Transparent;
            this.btn_rtnadmin.BorderRadius = 20;
            this.btn_rtnadmin.CheckedState.Parent = this.btn_rtnadmin;
            this.btn_rtnadmin.CustomImages.Parent = this.btn_rtnadmin;
            this.btn_rtnadmin.FillColor = System.Drawing.Color.MidnightBlue;
            this.btn_rtnadmin.Font = new System.Drawing.Font("Poppins SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_rtnadmin.ForeColor = System.Drawing.Color.White;
            this.btn_rtnadmin.HoverState.Parent = this.btn_rtnadmin;
            this.btn_rtnadmin.Location = new System.Drawing.Point(693, 21);
            this.btn_rtnadmin.Name = "btn_rtnadmin";
            this.btn_rtnadmin.ShadowDecoration.Parent = this.btn_rtnadmin;
            this.btn_rtnadmin.Size = new System.Drawing.Size(222, 47);
            this.btn_rtnadmin.TabIndex = 17;
            this.btn_rtnadmin.Text = "Return to Admin Menu";
            this.btn_rtnadmin.Click += new System.EventHandler(this.guna2Button7_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 35;
            this.guna2CustomGradientPanel1.Controls.Add(this.gunaLabel18);
            this.guna2CustomGradientPanel1.Controls.Add(this.btn_rtnadmin);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(3, 2);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(937, 88);
            this.guna2CustomGradientPanel1.TabIndex = 3;
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BorderRadius = 20;
            this.guna2CustomGradientPanel2.Controls.Add(this.bt_CashierLogout);
            this.guna2CustomGradientPanel2.Controls.Add(this.label2);
            this.guna2CustomGradientPanel2.Controls.Add(this.label1);
            this.guna2CustomGradientPanel2.Controls.Add(this.guna2CustomGradientPanel3);
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.Gray;
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(3, 515);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.ShadowDecoration.Parent = this.guna2CustomGradientPanel2;
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(933, 82);
            this.guna2CustomGradientPanel2.TabIndex = 4;
            // 
            // bt_CashierLogout
            // 
            this.bt_CashierLogout.BackColor = System.Drawing.Color.Transparent;
            this.bt_CashierLogout.BorderRadius = 10;
            this.bt_CashierLogout.CheckedState.Parent = this.bt_CashierLogout;
            this.bt_CashierLogout.CustomImages.Parent = this.bt_CashierLogout;
            this.bt_CashierLogout.FillColor = System.Drawing.Color.Blue;
            this.bt_CashierLogout.FillColor2 = System.Drawing.Color.Red;
            this.bt_CashierLogout.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CashierLogout.ForeColor = System.Drawing.Color.White;
            this.bt_CashierLogout.HoverState.Parent = this.bt_CashierLogout;
            this.bt_CashierLogout.Location = new System.Drawing.Point(760, 22);
            this.bt_CashierLogout.Name = "bt_CashierLogout";
            this.bt_CashierLogout.ShadowDecoration.Parent = this.bt_CashierLogout;
            this.bt_CashierLogout.Size = new System.Drawing.Size(135, 47);
            this.bt_CashierLogout.TabIndex = 5;
            this.bt_CashierLogout.Text = "LOGOUT";
            this.bt_CashierLogout.Click += new System.EventHandler(this.bt_CashierLogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(156, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(563, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "2021 All Rights Reserved.  Sample Software. Group Assignment - C# - Batch of 20.3" +
    "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(153, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "SMART MEALS";
            // 
            // guna2CustomGradientPanel3
            // 
            this.guna2CustomGradientPanel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel3.BorderRadius = 15;
            this.guna2CustomGradientPanel3.Controls.Add(this.pictureBox1);
            this.guna2CustomGradientPanel3.Location = new System.Drawing.Point(63, 9);
            this.guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
            this.guna2CustomGradientPanel3.ShadowDecoration.Parent = this.guna2CustomGradientPanel3;
            this.guna2CustomGradientPanel3.Size = new System.Drawing.Size(72, 65);
            this.guna2CustomGradientPanel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 53);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2CustomGradientPanel4);
            this.panel1.Controls.Add(this.guna2CustomGradientPanel5);
            this.panel1.Controls.Add(this.guna2CustomGradientPanel2);
            this.panel1.Location = new System.Drawing.Point(4, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 636);
            this.panel1.TabIndex = 5;
            // 
            // guna2CustomGradientPanel4
            // 
            this.guna2CustomGradientPanel4.BorderRadius = 50;
            this.guna2CustomGradientPanel4.Controls.Add(this.btn_cashreset);
            this.guna2CustomGradientPanel4.Controls.Add(this.btn_cashdel);
            this.guna2CustomGradientPanel4.Controls.Add(this.btn_cashcreate);
            this.guna2CustomGradientPanel4.Controls.Add(this.btn_cashfind);
            this.guna2CustomGradientPanel4.Controls.Add(this.btn_cashupdate);
            this.guna2CustomGradientPanel4.Location = new System.Drawing.Point(45, 359);
            this.guna2CustomGradientPanel4.Name = "guna2CustomGradientPanel4";
            this.guna2CustomGradientPanel4.ShadowDecoration.Parent = this.guna2CustomGradientPanel4;
            this.guna2CustomGradientPanel4.Size = new System.Drawing.Size(869, 133);
            this.guna2CustomGradientPanel4.TabIndex = 3;
            // 
            // btn_cashreset
            // 
            this.btn_cashreset.BackColor = System.Drawing.Color.Transparent;
            this.btn_cashreset.BorderRadius = 20;
            this.btn_cashreset.CheckedState.Parent = this.btn_cashreset;
            this.btn_cashreset.CustomImages.Parent = this.btn_cashreset;
            this.btn_cashreset.FillColor = System.Drawing.Color.Navy;
            this.btn_cashreset.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cashreset.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cashreset.ForeColor = System.Drawing.Color.White;
            this.btn_cashreset.HoverState.Parent = this.btn_cashreset;
            this.btn_cashreset.Location = new System.Drawing.Point(497, 37);
            this.btn_cashreset.Name = "btn_cashreset";
            this.btn_cashreset.ShadowDecoration.Parent = this.btn_cashreset;
            this.btn_cashreset.Size = new System.Drawing.Size(344, 57);
            this.btn_cashreset.TabIndex = 4;
            this.btn_cashreset.Text = "Reset Cashier Attempts";
            this.btn_cashreset.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // btn_cashdel
            // 
            this.btn_cashdel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cashdel.CheckedState.Parent = this.btn_cashdel;
            this.btn_cashdel.CustomImages.Parent = this.btn_cashdel;
            this.btn_cashdel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_cashdel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_cashdel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cashdel.ForeColor = System.Drawing.Color.White;
            this.btn_cashdel.HoverState.Parent = this.btn_cashdel;
            this.btn_cashdel.Location = new System.Drawing.Point(385, 14);
            this.btn_cashdel.Name = "btn_cashdel";
            this.btn_cashdel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_cashdel.ShadowDecoration.Parent = this.btn_cashdel;
            this.btn_cashdel.Size = new System.Drawing.Size(93, 94);
            this.btn_cashdel.TabIndex = 3;
            this.btn_cashdel.Text = "Delete";
            // 
            // btn_cashcreate
            // 
            this.btn_cashcreate.BackColor = System.Drawing.Color.Transparent;
            this.btn_cashcreate.CheckedState.Parent = this.btn_cashcreate;
            this.btn_cashcreate.CustomImages.Parent = this.btn_cashcreate;
            this.btn_cashcreate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_cashcreate.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_cashcreate.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cashcreate.ForeColor = System.Drawing.Color.White;
            this.btn_cashcreate.HoverState.Parent = this.btn_cashcreate;
            this.btn_cashcreate.Location = new System.Drawing.Point(155, 14);
            this.btn_cashcreate.Name = "btn_cashcreate";
            this.btn_cashcreate.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_cashcreate.ShadowDecoration.Parent = this.btn_cashcreate;
            this.btn_cashcreate.Size = new System.Drawing.Size(96, 94);
            this.btn_cashcreate.TabIndex = 2;
            this.btn_cashcreate.Text = "Create";
            this.btn_cashcreate.Click += new System.EventHandler(this.guna2GradientCircleButton3_Click);
            // 
            // btn_cashfind
            // 
            this.btn_cashfind.BackColor = System.Drawing.Color.Transparent;
            this.btn_cashfind.CheckedState.Parent = this.btn_cashfind;
            this.btn_cashfind.CustomImages.Parent = this.btn_cashfind;
            this.btn_cashfind.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_cashfind.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_cashfind.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cashfind.ForeColor = System.Drawing.Color.White;
            this.btn_cashfind.HoverState.Parent = this.btn_cashfind;
            this.btn_cashfind.Location = new System.Drawing.Point(40, 14);
            this.btn_cashfind.Name = "btn_cashfind";
            this.btn_cashfind.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_cashfind.ShadowDecoration.Parent = this.btn_cashfind;
            this.btn_cashfind.Size = new System.Drawing.Size(95, 94);
            this.btn_cashfind.TabIndex = 1;
            this.btn_cashfind.Text = "Find";
            this.btn_cashfind.Click += new System.EventHandler(this.guna2GradientCircleButton2_Click);
            // 
            // btn_cashupdate
            // 
            this.btn_cashupdate.BackColor = System.Drawing.Color.Transparent;
            this.btn_cashupdate.CheckedState.Parent = this.btn_cashupdate;
            this.btn_cashupdate.CustomImages.Parent = this.btn_cashupdate;
            this.btn_cashupdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_cashupdate.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_cashupdate.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cashupdate.ForeColor = System.Drawing.Color.White;
            this.btn_cashupdate.HoverState.Parent = this.btn_cashupdate;
            this.btn_cashupdate.Location = new System.Drawing.Point(270, 14);
            this.btn_cashupdate.Name = "btn_cashupdate";
            this.btn_cashupdate.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_cashupdate.ShadowDecoration.Parent = this.btn_cashupdate;
            this.btn_cashupdate.Size = new System.Drawing.Size(94, 94);
            this.btn_cashupdate.TabIndex = 0;
            this.btn_cashupdate.Text = "Update";
            this.btn_cashupdate.Click += new System.EventHandler(this.guna2GradientCircleButton1_Click_1);
            // 
            // guna2CustomGradientPanel5
            // 
            this.guna2CustomGradientPanel5.BorderRadius = 50;
            this.guna2CustomGradientPanel5.Controls.Add(this.guna2DataGridView1);
            this.guna2CustomGradientPanel5.Location = new System.Drawing.Point(17, 27);
            this.guna2CustomGradientPanel5.Name = "guna2CustomGradientPanel5";
            this.guna2CustomGradientPanel5.ShadowDecoration.Parent = this.guna2CustomGradientPanel5;
            this.guna2CustomGradientPanel5.Size = new System.Drawing.Size(919, 312);
            this.guna2CustomGradientPanel5.TabIndex = 2;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 21;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cashierIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.nicDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.remainingLoginAttemptsDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.cashierBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(28, 16);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 62;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(853, 267);
            this.guna2DataGridView1.TabIndex = 0;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 21;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // cashierIDDataGridViewTextBoxColumn
            // 
            this.cashierIDDataGridViewTextBoxColumn.DataPropertyName = "CashierID";
            this.cashierIDDataGridViewTextBoxColumn.HeaderText = "CashierID";
            this.cashierIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cashierIDDataGridViewTextBoxColumn.Name = "cashierIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // nicDataGridViewTextBoxColumn
            // 
            this.nicDataGridViewTextBoxColumn.DataPropertyName = "Nic";
            this.nicDataGridViewTextBoxColumn.HeaderText = "Nic";
            this.nicDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nicDataGridViewTextBoxColumn.Name = "nicDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // remainingLoginAttemptsDataGridViewTextBoxColumn
            // 
            this.remainingLoginAttemptsDataGridViewTextBoxColumn.DataPropertyName = "RemainingLoginAttempts";
            this.remainingLoginAttemptsDataGridViewTextBoxColumn.HeaderText = "RemainingLoginAttempts";
            this.remainingLoginAttemptsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.remainingLoginAttemptsDataGridViewTextBoxColumn.Name = "remainingLoginAttemptsDataGridViewTextBoxColumn";
            // 
            // cashierBindingSource
            // 
            this.cashierBindingSource.DataMember = "Cashier";
            this.cashierBindingSource.DataSource = this.ssDataSet1;
            // 
            // ssDataSet1
            // 
            this.ssDataSet1.DataSetName = "ssDataSet1";
            this.ssDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cashierTableAdapter
            // 
            this.cashierTableAdapter.ClearBeforeFill = true;
            // 
            // AdminCashierMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(952, 690);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.MaximizeBox = false;
            this.Name = "AdminCashierMain";
            this.Text = "FoodDetailsProject";
            this.Load += new System.EventHandler(this.FoodDetailsProject_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel2.PerformLayout();
            this.guna2CustomGradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.guna2CustomGradientPanel4.ResumeLayout(false);
            this.guna2CustomGradientPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel18;
        private Guna.UI2.WinForms.Guna2Button btn_rtnadmin;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2GradientTileButton bt_CashierLogout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel5;
        private ssDataSet1 ssDataSet1;
        private System.Windows.Forms.BindingSource cashierBindingSource;
        private ssDataSet1TableAdapters.CashierTableAdapter cashierTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainingLoginAttemptsDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel4;
        private Guna.UI2.WinForms.Guna2GradientButton btn_cashreset;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btn_cashdel;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btn_cashcreate;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btn_cashfind;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btn_cashupdate;
    }
}