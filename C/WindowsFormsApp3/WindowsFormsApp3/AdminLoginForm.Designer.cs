
namespace WindowsFormsApp3
{
    partial class AdminLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLoginForm));
            this.bt_AdminLog = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_AdminPw = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_AdminName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_GoBack = new Guna.UI.WinForms.GunaGradientButton();
            this.SuspendLayout();
            // 
            // bt_AdminLog
            // 
            this.bt_AdminLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_AdminLog.AnimationHoverSpeed = 0.07F;
            this.bt_AdminLog.AnimationSpeed = 0.03F;
            this.bt_AdminLog.BackColor = System.Drawing.Color.Transparent;
            this.bt_AdminLog.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.bt_AdminLog.BorderColor = System.Drawing.Color.Black;
            this.bt_AdminLog.CheckedBaseColor = System.Drawing.Color.Gray;
            this.bt_AdminLog.CheckedBorderColor = System.Drawing.Color.Black;
            this.bt_AdminLog.CheckedForeColor = System.Drawing.Color.White;
            this.bt_AdminLog.CheckedImage = ((System.Drawing.Image)(resources.GetObject("bt_AdminLog.CheckedImage")));
            this.bt_AdminLog.CheckedLineColor = System.Drawing.Color.DimGray;
            this.bt_AdminLog.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bt_AdminLog.FocusedColor = System.Drawing.Color.Empty;
            this.bt_AdminLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AdminLog.ForeColor = System.Drawing.Color.White;
            this.bt_AdminLog.Image = null;
            this.bt_AdminLog.ImageSize = new System.Drawing.Size(20, 20);
            this.bt_AdminLog.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.bt_AdminLog.Location = new System.Drawing.Point(393, 462);
            this.bt_AdminLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_AdminLog.Name = "bt_AdminLog";
            this.bt_AdminLog.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.bt_AdminLog.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_AdminLog.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_AdminLog.OnHoverImage = null;
            this.bt_AdminLog.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.bt_AdminLog.OnPressedColor = System.Drawing.Color.Black;
            this.bt_AdminLog.Radius = 12;
            this.bt_AdminLog.Size = new System.Drawing.Size(180, 42);
            this.bt_AdminLog.TabIndex = 11;
            this.bt_AdminLog.Text = "Log In";
            this.bt_AdminLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_AdminLog.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(285, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 34);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // txt_AdminPw
            // 
            this.txt_AdminPw.BackColor = System.Drawing.Color.Transparent;
            this.txt_AdminPw.BorderRadius = 12;
            this.txt_AdminPw.BorderThickness = 2;
            this.txt_AdminPw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_AdminPw.DefaultText = "";
            this.txt_AdminPw.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_AdminPw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_AdminPw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_AdminPw.DisabledState.Parent = this.txt_AdminPw;
            this.txt_AdminPw.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_AdminPw.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_AdminPw.FocusedState.Parent = this.txt_AdminPw;
            this.txt_AdminPw.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_AdminPw.HoverState.Parent = this.txt_AdminPw;
            this.txt_AdminPw.Location = new System.Drawing.Point(411, 404);
            this.txt_AdminPw.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_AdminPw.Name = "txt_AdminPw";
            this.txt_AdminPw.PasswordChar = '*';
            this.txt_AdminPw.PlaceholderText = "Insert Password";
            this.txt_AdminPw.SelectedText = "";
            this.txt_AdminPw.ShadowDecoration.Parent = this.txt_AdminPw;
            this.txt_AdminPw.Size = new System.Drawing.Size(286, 38);
            this.txt_AdminPw.TabIndex = 9;
            this.txt_AdminPw.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            this.txt_AdminPw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(283, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 34);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username";
            // 
            // txt_AdminName
            // 
            this.txt_AdminName.BackColor = System.Drawing.Color.Transparent;
            this.txt_AdminName.BorderRadius = 12;
            this.txt_AdminName.BorderThickness = 2;
            this.txt_AdminName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_AdminName.DefaultText = "";
            this.txt_AdminName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_AdminName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_AdminName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_AdminName.DisabledState.Parent = this.txt_AdminName;
            this.txt_AdminName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_AdminName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_AdminName.FocusedState.Parent = this.txt_AdminName;
            this.txt_AdminName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_AdminName.HoverState.Parent = this.txt_AdminName;
            this.txt_AdminName.Location = new System.Drawing.Point(411, 352);
            this.txt_AdminName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_AdminName.Name = "txt_AdminName";
            this.txt_AdminName.PasswordChar = '\0';
            this.txt_AdminName.PlaceholderText = "Insert Username";
            this.txt_AdminName.SelectedText = "";
            this.txt_AdminName.ShadowDecoration.Parent = this.txt_AdminName;
            this.txt_AdminName.Size = new System.Drawing.Size(286, 39);
            this.txt_AdminName.TabIndex = 7;
            this.txt_AdminName.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            this.txt_AdminName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.jump);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(344, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 65);
            this.label1.TabIndex = 12;
            this.label1.Text = "Admin Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bt_GoBack
            // 
            this.bt_GoBack.AnimationHoverSpeed = 0.07F;
            this.bt_GoBack.AnimationSpeed = 0.03F;
            this.bt_GoBack.BackColor = System.Drawing.Color.Transparent;
            this.bt_GoBack.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.bt_GoBack.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.bt_GoBack.BorderColor = System.Drawing.Color.Black;
            this.bt_GoBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bt_GoBack.FocusedColor = System.Drawing.Color.Empty;
            this.bt_GoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_GoBack.ForeColor = System.Drawing.Color.White;
            this.bt_GoBack.Image = null;
            this.bt_GoBack.ImageSize = new System.Drawing.Size(20, 20);
            this.bt_GoBack.Location = new System.Drawing.Point(14, 558);
            this.bt_GoBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_GoBack.Name = "bt_GoBack";
            this.bt_GoBack.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.bt_GoBack.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.bt_GoBack.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_GoBack.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_GoBack.OnHoverImage = null;
            this.bt_GoBack.OnPressedColor = System.Drawing.Color.Black;
            this.bt_GoBack.Radius = 13;
            this.bt_GoBack.Size = new System.Drawing.Size(160, 42);
            this.bt_GoBack.TabIndex = 13;
            this.bt_GoBack.Text = "Go Back";
            this.bt_GoBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_GoBack.Click += new System.EventHandler(this.bt_GoBack_Click);
            // 
            // AdminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(981, 613);
            this.Controls.Add(this.bt_GoBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_AdminLog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_AdminPw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_AdminName);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "AdminLoginForm";
            this.Text = "Admin Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton bt_AdminLog;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_AdminPw;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_AdminName;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaGradientButton bt_GoBack;
    }
}