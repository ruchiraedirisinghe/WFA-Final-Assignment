
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btn_cashfind_reset = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_cashfind_delete = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btn_cashfind_create = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btn_cashfind_find = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btn_cashfind_update = new Guna.UI2.WinForms.Guna2GradientCircleButton();
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
            this.gunaLabel18.Location = new System.Drawing.Point(334, 20);
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
            this.guna2Button7.Location = new System.Drawing.Point(698, 20);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.ShadowDecoration.Parent = this.guna2Button7;
            this.guna2Button7.Size = new System.Drawing.Size(222, 47);
            this.guna2Button7.TabIndex = 17;
            this.guna2Button7.Text = "Return to Admin Menu";
            this.guna2Button7.Click += new System.EventHandler(this.guna2Button7_Click);
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
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(947, 88);
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
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(3, 599);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.ShadowDecoration.Parent = this.guna2CustomGradientPanel2;
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(947, 89);
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
            this.bt_CashierLogout.Location = new System.Drawing.Point(785, 22);
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
            this.label2.Location = new System.Drawing.Point(141, 55);
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
            this.label1.Location = new System.Drawing.Point(138, 13);
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
            this.guna2CustomGradientPanel3.Location = new System.Drawing.Point(45, 13);
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
            this.panel1.Size = new System.Drawing.Size(936, 502);
            this.panel1.TabIndex = 5;
            // 
            // guna2CustomGradientPanel4
            // 
            this.guna2CustomGradientPanel4.BorderRadius = 50;
            this.guna2CustomGradientPanel4.Controls.Add(this.btn_cashfind_reset);
            this.guna2CustomGradientPanel4.Controls.Add(this.btn_cashfind_delete);
            this.guna2CustomGradientPanel4.Controls.Add(this.btn_cashfind_create);
            this.guna2CustomGradientPanel4.Controls.Add(this.btn_cashfind_find);
            this.guna2CustomGradientPanel4.Controls.Add(this.btn_cashfind_update);
            this.guna2CustomGradientPanel4.Location = new System.Drawing.Point(21, 370);
            this.guna2CustomGradientPanel4.Name = "guna2CustomGradientPanel4";
            this.guna2CustomGradientPanel4.ShadowDecoration.Parent = this.guna2CustomGradientPanel4;
            this.guna2CustomGradientPanel4.Size = new System.Drawing.Size(898, 111);
            this.guna2CustomGradientPanel4.TabIndex = 3;
            // 
            // btn_cashfind_reset
            // 
            this.btn_cashfind_reset.BackColor = System.Drawing.Color.Transparent;
            this.btn_cashfind_reset.BorderRadius = 20;
            this.btn_cashfind_reset.CheckedState.Parent = this.btn_cashfind_reset;
            this.btn_cashfind_reset.CustomImages.Parent = this.btn_cashfind_reset;
            this.btn_cashfind_reset.FillColor = System.Drawing.Color.Navy;
            this.btn_cashfind_reset.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cashfind_reset.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cashfind_reset.ForeColor = System.Drawing.Color.White;
            this.btn_cashfind_reset.HoverState.Parent = this.btn_cashfind_reset;
            this.btn_cashfind_reset.Location = new System.Drawing.Point(506, 26);
            this.btn_cashfind_reset.Name = "btn_cashfind_reset";
            this.btn_cashfind_reset.ShadowDecoration.Parent = this.btn_cashfind_reset;
            this.btn_cashfind_reset.Size = new System.Drawing.Size(364, 62);
            this.btn_cashfind_reset.TabIndex = 4;
            this.btn_cashfind_reset.Text = "Reset Cashier Attempts";
            // 
            // btn_cashfind_delete
            // 
            this.btn_cashfind_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_cashfind_delete.CheckedState.Parent = this.btn_cashfind_delete;
            this.btn_cashfind_delete.CustomImages.Parent = this.btn_cashfind_delete;
            this.btn_cashfind_delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_cashfind_delete.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_cashfind_delete.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cashfind_delete.ForeColor = System.Drawing.Color.White;
            this.btn_cashfind_delete.HoverState.Parent = this.btn_cashfind_delete;
            this.btn_cashfind_delete.Location = new System.Drawing.Point(385, 11);
            this.btn_cashfind_delete.Name = "btn_cashfind_delete";
            this.btn_cashfind_delete.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_cashfind_delete.ShadowDecoration.Parent = this.btn_cashfind_delete;
            this.btn_cashfind_delete.Size = new System.Drawing.Size(93, 89);
            this.btn_cashfind_delete.TabIndex = 3;
            this.btn_cashfind_delete.Text = "Delete";
            // 
            // btn_cashfind_create
            // 
            this.btn_cashfind_create.BackColor = System.Drawing.Color.Transparent;
            this.btn_cashfind_create.CheckedState.Parent = this.btn_cashfind_create;
            this.btn_cashfind_create.CustomImages.Parent = this.btn_cashfind_create;
            this.btn_cashfind_create.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_cashfind_create.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_cashfind_create.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cashfind_create.ForeColor = System.Drawing.Color.White;
            this.btn_cashfind_create.HoverState.Parent = this.btn_cashfind_create;
            this.btn_cashfind_create.Location = new System.Drawing.Point(158, 11);
            this.btn_cashfind_create.Name = "btn_cashfind_create";
            this.btn_cashfind_create.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_cashfind_create.ShadowDecoration.Parent = this.btn_cashfind_create;
            this.btn_cashfind_create.Size = new System.Drawing.Size(92, 89);
            this.btn_cashfind_create.TabIndex = 2;
            this.btn_cashfind_create.Text = "Create";
            this.btn_cashfind_create.Click += new System.EventHandler(this.guna2GradientCircleButton3_Click);
            // 
            // btn_cashfind_find
            // 
            this.btn_cashfind_find.BackColor = System.Drawing.Color.Transparent;
            this.btn_cashfind_find.CheckedState.Parent = this.btn_cashfind_find;
            this.btn_cashfind_find.CustomImages.Parent = this.btn_cashfind_find;
            this.btn_cashfind_find.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_cashfind_find.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_cashfind_find.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cashfind_find.ForeColor = System.Drawing.Color.White;
            this.btn_cashfind_find.HoverState.Parent = this.btn_cashfind_find;
            this.btn_cashfind_find.Location = new System.Drawing.Point(44, 11);
            this.btn_cashfind_find.Name = "btn_cashfind_find";
            this.btn_cashfind_find.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_cashfind_find.ShadowDecoration.Parent = this.btn_cashfind_find;
            this.btn_cashfind_find.Size = new System.Drawing.Size(91, 89);
            this.btn_cashfind_find.TabIndex = 1;
            this.btn_cashfind_find.Text = "Find";
            this.btn_cashfind_find.Click += new System.EventHandler(this.guna2GradientCircleButton2_Click);
            // 
            // btn_cashfind_update
            // 
            this.btn_cashfind_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_cashfind_update.CheckedState.Parent = this.btn_cashfind_update;
            this.btn_cashfind_update.CustomImages.Parent = this.btn_cashfind_update;
            this.btn_cashfind_update.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_cashfind_update.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_cashfind_update.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cashfind_update.ForeColor = System.Drawing.Color.White;
            this.btn_cashfind_update.HoverState.Parent = this.btn_cashfind_update;
            this.btn_cashfind_update.Location = new System.Drawing.Point(273, 11);
            this.btn_cashfind_update.Name = "btn_cashfind_update";
            this.btn_cashfind_update.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_cashfind_update.ShadowDecoration.Parent = this.btn_cashfind_update;
            this.btn_cashfind_update.Size = new System.Drawing.Size(95, 89);
            this.btn_cashfind_update.TabIndex = 0;
            this.btn_cashfind_update.Text = "Update";
            this.btn_cashfind_update.Click += new System.EventHandler(this.guna2GradientCircleButton1_Click_1);
            // 
            // guna2CustomGradientPanel5
            // 
            this.guna2CustomGradientPanel5.BorderRadius = 50;
            this.guna2CustomGradientPanel5.Controls.Add(this.guna2DataGridView1);
            this.guna2CustomGradientPanel5.Location = new System.Drawing.Point(21, 15);
            this.guna2CustomGradientPanel5.Name = "guna2CustomGradientPanel5";
            this.guna2CustomGradientPanel5.ShadowDecoration.Parent = this.guna2CustomGradientPanel5;
            this.guna2CustomGradientPanel5.Size = new System.Drawing.Size(898, 328);
            this.guna2CustomGradientPanel5.TabIndex = 2;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridView1.ColumnHeadersHeight = 21;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cashierIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.nicDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.remainingLoginAttemptsDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.cashierBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(26, 19);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 62;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(844, 295);
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
            this.ClientSize = new System.Drawing.Size(952, 691);
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
        private Guna.UI2.WinForms.Guna2GradientButton btn_cashfind_reset;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btn_cashfind_delete;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btn_cashfind_create;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btn_cashfind_find;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btn_cashfind_update;
    }
}