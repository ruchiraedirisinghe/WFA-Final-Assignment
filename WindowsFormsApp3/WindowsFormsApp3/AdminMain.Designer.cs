
namespace WindowsFormsApp3
{
    partial class AdminMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMain));
            this.bt_GoToCashier = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_AdminSignOut = new Guna.UI.WinForms.GunaGradientButton();
            this.guna2CustomGradientPanel4 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btCASHIERSET = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btREVSET = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btITEMSET = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel5 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CustomGradientPanel4.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.guna2CustomGradientPanel3.SuspendLayout();
            this.guna2CustomGradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_GoToCashier
            // 
            this.bt_GoToCashier.BackColor = System.Drawing.Color.Transparent;
            this.bt_GoToCashier.BorderRadius = 20;
            this.bt_GoToCashier.CheckedState.Parent = this.bt_GoToCashier;
            this.bt_GoToCashier.CustomImages.Parent = this.bt_GoToCashier;
            this.bt_GoToCashier.FillColor = System.Drawing.Color.Blue;
            this.bt_GoToCashier.FillColor2 = System.Drawing.Color.Red;
            this.bt_GoToCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_GoToCashier.ForeColor = System.Drawing.Color.White;
            this.bt_GoToCashier.HoverState.Parent = this.bt_GoToCashier;
            this.bt_GoToCashier.Location = new System.Drawing.Point(1271, 25);
            this.bt_GoToCashier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_GoToCashier.Name = "bt_GoToCashier";
            this.bt_GoToCashier.ShadowDecoration.Parent = this.bt_GoToCashier;
            this.bt_GoToCashier.Size = new System.Drawing.Size(243, 68);
            this.bt_GoToCashier.TabIndex = 0;
            this.bt_GoToCashier.Text = "Switch to Cashier";
            this.bt_GoToCashier.Click += new System.EventHandler(this.guna2GradientTileButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(311, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(954, 106);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome To The Admin Menu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // bt_AdminSignOut
            // 
            this.bt_AdminSignOut.AnimationHoverSpeed = 0.07F;
            this.bt_AdminSignOut.AnimationSpeed = 0.03F;
            this.bt_AdminSignOut.BackColor = System.Drawing.Color.Transparent;
            this.bt_AdminSignOut.BaseColor1 = System.Drawing.Color.Blue;
            this.bt_AdminSignOut.BaseColor2 = System.Drawing.Color.Crimson;
            this.bt_AdminSignOut.BorderColor = System.Drawing.Color.Black;
            this.bt_AdminSignOut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bt_AdminSignOut.FocusedColor = System.Drawing.Color.Empty;
            this.bt_AdminSignOut.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AdminSignOut.ForeColor = System.Drawing.Color.White;
            this.bt_AdminSignOut.Image = null;
            this.bt_AdminSignOut.ImageSize = new System.Drawing.Size(20, 20);
            this.bt_AdminSignOut.Location = new System.Drawing.Point(1537, 26);
            this.bt_AdminSignOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_AdminSignOut.Name = "bt_AdminSignOut";
            this.bt_AdminSignOut.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.bt_AdminSignOut.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.bt_AdminSignOut.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_AdminSignOut.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_AdminSignOut.OnHoverImage = null;
            this.bt_AdminSignOut.OnPressedColor = System.Drawing.Color.Black;
            this.bt_AdminSignOut.Radius = 15;
            this.bt_AdminSignOut.Size = new System.Drawing.Size(229, 64);
            this.bt_AdminSignOut.TabIndex = 4;
            this.bt_AdminSignOut.Text = "Sign Out";
            this.bt_AdminSignOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_AdminSignOut.Click += new System.EventHandler(this.gunaGradientButton2_Click);
            // 
            // guna2CustomGradientPanel4
            // 
            this.guna2CustomGradientPanel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel4.BorderRadius = 35;
            this.guna2CustomGradientPanel4.Controls.Add(this.btCASHIERSET);
            this.guna2CustomGradientPanel4.Location = new System.Drawing.Point(53, 178);
            this.guna2CustomGradientPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2CustomGradientPanel4.Name = "guna2CustomGradientPanel4";
            this.guna2CustomGradientPanel4.ShadowDecoration.Parent = this.guna2CustomGradientPanel4;
            this.guna2CustomGradientPanel4.Size = new System.Drawing.Size(532, 576);
            this.guna2CustomGradientPanel4.TabIndex = 5;
            // 
            // btCASHIERSET
            // 
            this.btCASHIERSET.BorderRadius = 35;
            this.btCASHIERSET.CheckedState.Parent = this.btCASHIERSET;
            this.btCASHIERSET.CustomImages.Parent = this.btCASHIERSET;
            this.btCASHIERSET.FillColor = System.Drawing.Color.ForestGreen;
            this.btCASHIERSET.FillColor2 = System.Drawing.Color.DarkGreen;
            this.btCASHIERSET.Font = new System.Drawing.Font("Poppins", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCASHIERSET.ForeColor = System.Drawing.Color.White;
            this.btCASHIERSET.HoverState.Parent = this.btCASHIERSET;
            this.btCASHIERSET.Location = new System.Drawing.Point(25, 20);
            this.btCASHIERSET.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCASHIERSET.Name = "btCASHIERSET";
            this.btCASHIERSET.ShadowDecoration.Parent = this.btCASHIERSET;
            this.btCASHIERSET.Size = new System.Drawing.Size(479, 537);
            this.btCASHIERSET.TabIndex = 0;
            this.btCASHIERSET.Text = "Cashier Settings";
            this.btCASHIERSET.Click += new System.EventHandler(this.btCASHIERSET_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderRadius = 35;
            this.guna2CustomGradientPanel1.Controls.Add(this.btREVSET);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(632, 178);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(528, 576);
            this.guna2CustomGradientPanel1.TabIndex = 6;
            // 
            // btREVSET
            // 
            this.btREVSET.BorderRadius = 35;
            this.btREVSET.CheckedState.Parent = this.btREVSET;
            this.btREVSET.CustomImages.Parent = this.btREVSET;
            this.btREVSET.FillColor = System.Drawing.Color.Firebrick;
            this.btREVSET.FillColor2 = System.Drawing.Color.Maroon;
            this.btREVSET.Font = new System.Drawing.Font("Poppins", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btREVSET.ForeColor = System.Drawing.Color.White;
            this.btREVSET.HoverState.Parent = this.btREVSET;
            this.btREVSET.Location = new System.Drawing.Point(27, 20);
            this.btREVSET.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btREVSET.Name = "btREVSET";
            this.btREVSET.ShadowDecoration.Parent = this.btREVSET;
            this.btREVSET.Size = new System.Drawing.Size(479, 537);
            this.btREVSET.TabIndex = 1;
            this.btREVSET.Text = "Revenue & Expenditures";
            this.btREVSET.Click += new System.EventHandler(this.btREVSET_Click);
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel2.BorderRadius = 35;
            this.guna2CustomGradientPanel2.Controls.Add(this.btITEMSET);
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(1208, 178);
            this.guna2CustomGradientPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.ShadowDecoration.Parent = this.guna2CustomGradientPanel2;
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(528, 576);
            this.guna2CustomGradientPanel2.TabIndex = 7;
            // 
            // btITEMSET
            // 
            this.btITEMSET.BorderRadius = 35;
            this.btITEMSET.CheckedState.Parent = this.btITEMSET;
            this.btITEMSET.CustomImages.Parent = this.btITEMSET;
            this.btITEMSET.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btITEMSET.FillColor2 = System.Drawing.Color.Black;
            this.btITEMSET.Font = new System.Drawing.Font("Poppins", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btITEMSET.ForeColor = System.Drawing.Color.White;
            this.btITEMSET.HoverState.Parent = this.btITEMSET;
            this.btITEMSET.Location = new System.Drawing.Point(27, 20);
            this.btITEMSET.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btITEMSET.Name = "btITEMSET";
            this.btITEMSET.ShadowDecoration.Parent = this.btITEMSET;
            this.btITEMSET.Size = new System.Drawing.Size(479, 537);
            this.btITEMSET.TabIndex = 1;
            this.btITEMSET.Text = "Item Settings";
            this.btITEMSET.Click += new System.EventHandler(this.btITEMSET_Click);
            // 
            // guna2CustomGradientPanel3
            // 
            this.guna2CustomGradientPanel3.BorderRadius = 20;
            this.guna2CustomGradientPanel3.Controls.Add(this.label1);
            this.guna2CustomGradientPanel3.Controls.Add(this.label3);
            this.guna2CustomGradientPanel3.Controls.Add(this.guna2CustomGradientPanel5);
            this.guna2CustomGradientPanel3.Controls.Add(this.bt_AdminSignOut);
            this.guna2CustomGradientPanel3.Controls.Add(this.bt_GoToCashier);
            this.guna2CustomGradientPanel3.FillColor = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel3.FillColor2 = System.Drawing.Color.Gray;
            this.guna2CustomGradientPanel3.FillColor3 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel3.FillColor4 = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2CustomGradientPanel3.Location = new System.Drawing.Point(4, 905);
            this.guna2CustomGradientPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
            this.guna2CustomGradientPanel3.ShadowDecoration.Parent = this.guna2CustomGradientPanel3;
            this.guna2CustomGradientPanel3.Size = new System.Drawing.Size(1831, 110);
            this.guna2CustomGradientPanel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(207, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(730, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "2021 All Rights Reserved.  Sample Software. Group Assignment - C# - Batch of 20.3" +
    "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(204, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 53);
            this.label3.TabIndex = 3;
            this.label3.Text = "SMART MEALS";
            // 
            // guna2CustomGradientPanel5
            // 
            this.guna2CustomGradientPanel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel5.BorderRadius = 15;
            this.guna2CustomGradientPanel5.Controls.Add(this.pictureBox1);
            this.guna2CustomGradientPanel5.Location = new System.Drawing.Point(84, 20);
            this.guna2CustomGradientPanel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2CustomGradientPanel5.Name = "guna2CustomGradientPanel5";
            this.guna2CustomGradientPanel5.ShadowDecoration.Parent = this.guna2CustomGradientPanel5;
            this.guna2CustomGradientPanel5.Size = new System.Drawing.Size(96, 80);
            this.guna2CustomGradientPanel5.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(4, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 65);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2CustomGradientPanel2);
            this.panel1.Controls.Add(this.guna2CustomGradientPanel1);
            this.panel1.Controls.Add(this.guna2CustomGradientPanel4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(35, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1791, 809);
            this.panel1.TabIndex = 9;
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1841, 1018);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2CustomGradientPanel3);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AdminMain";
            this.Text = "a";
            this.Load += new System.EventHandler(this.AdminMain_Load);
            this.guna2CustomGradientPanel4.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel3.ResumeLayout(false);
            this.guna2CustomGradientPanel3.PerformLayout();
            this.guna2CustomGradientPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientTileButton bt_GoToCashier;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaGradientButton bt_AdminSignOut;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel4;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientTileButton btCASHIERSET;
        private Guna.UI2.WinForms.Guna2GradientTileButton btREVSET;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2GradientTileButton btITEMSET;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}