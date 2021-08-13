
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
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.bt_CashierLogout = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CustomGradientPanel4 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientCircleButton4 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2GradientCircleButton3 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2GradientCircleButton2 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2GradientCircleButton1 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
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
            this.gunaLabel18.Location = new System.Drawing.Point(555, 22);
            this.gunaLabel18.Name = "gunaLabel18";
            this.gunaLabel18.Size = new System.Drawing.Size(278, 48);
            this.gunaLabel18.TabIndex = 17;
            this.gunaLabel18.Text = "CASHIER SETTINGS";
            // 
            // guna2Button7
            // 
            this.guna2Button7.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button7.BorderRadius = 20;
            this.guna2Button7.CheckedState.Parent = this.guna2Button7;
            this.guna2Button7.CustomImages.Parent = this.guna2Button7;
            this.guna2Button7.FillColor = System.Drawing.Color.MidnightBlue;
            this.guna2Button7.Font = new System.Drawing.Font("Poppins SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.guna2Button7.ForeColor = System.Drawing.Color.White;
            this.guna2Button7.HoverState.Parent = this.guna2Button7;
            this.guna2Button7.Location = new System.Drawing.Point(1109, 22);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.ShadowDecoration.Parent = this.guna2Button7;
            this.guna2Button7.Size = new System.Drawing.Size(222, 47);
            this.guna2Button7.TabIndex = 17;
            this.guna2Button7.Text = "Return to Admin Menu";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 35;
            this.guna2CustomGradientPanel1.Controls.Add(this.gunaLabel18);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2Button7);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(3, 2);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1375, 88);
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
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(4, 736);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.ShadowDecoration.Parent = this.guna2CustomGradientPanel2;
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(1373, 89);
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
            this.bt_CashierLogout.Location = new System.Drawing.Point(1174, 23);
            this.bt_CashierLogout.Name = "bt_CashierLogout";
            this.bt_CashierLogout.ShadowDecoration.Parent = this.bt_CashierLogout;
            this.bt_CashierLogout.Size = new System.Drawing.Size(135, 47);
            this.bt_CashierLogout.TabIndex = 5;
            this.bt_CashierLogout.Text = "LOGOUT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(155, 47);
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
            this.panel1.Location = new System.Drawing.Point(4, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 636);
            this.panel1.TabIndex = 5;
            // 
            // guna2CustomGradientPanel4
            // 
            this.guna2CustomGradientPanel4.BorderRadius = 50;
            this.guna2CustomGradientPanel4.Controls.Add(this.guna2GradientButton1);
            this.guna2CustomGradientPanel4.Controls.Add(this.guna2GradientCircleButton4);
            this.guna2CustomGradientPanel4.Controls.Add(this.guna2GradientCircleButton3);
            this.guna2CustomGradientPanel4.Controls.Add(this.guna2GradientCircleButton2);
            this.guna2CustomGradientPanel4.Controls.Add(this.guna2GradientCircleButton1);
            this.guna2CustomGradientPanel4.Location = new System.Drawing.Point(402, 375);
            this.guna2CustomGradientPanel4.Name = "guna2CustomGradientPanel4";
            this.guna2CustomGradientPanel4.ShadowDecoration.Parent = this.guna2CustomGradientPanel4;
            this.guna2CustomGradientPanel4.Size = new System.Drawing.Size(629, 240);
            this.guna2CustomGradientPanel4.TabIndex = 3;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderRadius = 20;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Navy;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(80, 149);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(489, 62);
            this.guna2GradientButton1.TabIndex = 4;
            this.guna2GradientButton1.Text = "Reset Cashier Attempts";
            // 
            // guna2GradientCircleButton4
            // 
            this.guna2GradientCircleButton4.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientCircleButton4.CheckedState.Parent = this.guna2GradientCircleButton4;
            this.guna2GradientCircleButton4.CustomImages.Parent = this.guna2GradientCircleButton4;
            this.guna2GradientCircleButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2GradientCircleButton4.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2GradientCircleButton4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientCircleButton4.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton4.HoverState.Parent = this.guna2GradientCircleButton4;
            this.guna2GradientCircleButton4.Location = new System.Drawing.Point(476, 14);
            this.guna2GradientCircleButton4.Name = "guna2GradientCircleButton4";
            this.guna2GradientCircleButton4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton4.ShadowDecoration.Parent = this.guna2GradientCircleButton4;
            this.guna2GradientCircleButton4.Size = new System.Drawing.Size(116, 116);
            this.guna2GradientCircleButton4.TabIndex = 3;
            this.guna2GradientCircleButton4.Text = "Delete";
            // 
            // guna2GradientCircleButton3
            // 
            this.guna2GradientCircleButton3.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientCircleButton3.CheckedState.Parent = this.guna2GradientCircleButton3;
            this.guna2GradientCircleButton3.CustomImages.Parent = this.guna2GradientCircleButton3;
            this.guna2GradientCircleButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2GradientCircleButton3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2GradientCircleButton3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientCircleButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton3.HoverState.Parent = this.guna2GradientCircleButton3;
            this.guna2GradientCircleButton3.Location = new System.Drawing.Point(182, 14);
            this.guna2GradientCircleButton3.Name = "guna2GradientCircleButton3";
            this.guna2GradientCircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton3.ShadowDecoration.Parent = this.guna2GradientCircleButton3;
            this.guna2GradientCircleButton3.Size = new System.Drawing.Size(116, 116);
            this.guna2GradientCircleButton3.TabIndex = 2;
            this.guna2GradientCircleButton3.Text = "Create";
            // 
            // guna2GradientCircleButton2
            // 
            this.guna2GradientCircleButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientCircleButton2.CheckedState.Parent = this.guna2GradientCircleButton2;
            this.guna2GradientCircleButton2.CustomImages.Parent = this.guna2GradientCircleButton2;
            this.guna2GradientCircleButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2GradientCircleButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2GradientCircleButton2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientCircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton2.HoverState.Parent = this.guna2GradientCircleButton2;
            this.guna2GradientCircleButton2.Location = new System.Drawing.Point(40, 14);
            this.guna2GradientCircleButton2.Name = "guna2GradientCircleButton2";
            this.guna2GradientCircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton2.ShadowDecoration.Parent = this.guna2GradientCircleButton2;
            this.guna2GradientCircleButton2.Size = new System.Drawing.Size(116, 116);
            this.guna2GradientCircleButton2.TabIndex = 1;
            this.guna2GradientCircleButton2.Text = "Find";
            // 
            // guna2GradientCircleButton1
            // 
            this.guna2GradientCircleButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientCircleButton1.CheckedState.Parent = this.guna2GradientCircleButton1;
            this.guna2GradientCircleButton1.CustomImages.Parent = this.guna2GradientCircleButton1;
            this.guna2GradientCircleButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2GradientCircleButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2GradientCircleButton1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientCircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton1.HoverState.Parent = this.guna2GradientCircleButton1;
            this.guna2GradientCircleButton1.Location = new System.Drawing.Point(327, 14);
            this.guna2GradientCircleButton1.Name = "guna2GradientCircleButton1";
            this.guna2GradientCircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton1.ShadowDecoration.Parent = this.guna2GradientCircleButton1;
            this.guna2GradientCircleButton1.Size = new System.Drawing.Size(116, 116);
            this.guna2GradientCircleButton1.TabIndex = 0;
            this.guna2GradientCircleButton1.Text = "Update";
            // 
            // guna2CustomGradientPanel5
            // 
            this.guna2CustomGradientPanel5.BorderRadius = 50;
            this.guna2CustomGradientPanel5.Controls.Add(this.guna2DataGridView1);
            this.guna2CustomGradientPanel5.Location = new System.Drawing.Point(17, 51);
            this.guna2CustomGradientPanel5.Name = "guna2CustomGradientPanel5";
            this.guna2CustomGradientPanel5.ShadowDecoration.Parent = this.guna2CustomGradientPanel5;
            this.guna2CustomGradientPanel5.Size = new System.Drawing.Size(1341, 299);
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
            this.guna2DataGridView1.Location = new System.Drawing.Point(28, 18);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1290, 265);
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
            this.cashierIDDataGridViewTextBoxColumn.Name = "cashierIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // nicDataGridViewTextBoxColumn
            // 
            this.nicDataGridViewTextBoxColumn.DataPropertyName = "Nic";
            this.nicDataGridViewTextBoxColumn.HeaderText = "Nic";
            this.nicDataGridViewTextBoxColumn.Name = "nicDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // remainingLoginAttemptsDataGridViewTextBoxColumn
            // 
            this.remainingLoginAttemptsDataGridViewTextBoxColumn.DataPropertyName = "RemainingLoginAttempts";
            this.remainingLoginAttemptsDataGridViewTextBoxColumn.HeaderText = "RemainingLoginAttempts";
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
            this.ClientSize = new System.Drawing.Size(1381, 827);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2CustomGradientPanel2);
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
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
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
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton4;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton3;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton2;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton1;
    }
}