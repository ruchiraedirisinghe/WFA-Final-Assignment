
namespace WindowsFormsApp3
{
    partial class CashierLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierLoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tbcashierusername = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbcashierpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btCashierLogin = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(360, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cashier Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbcashierusername
            // 
            this.tbcashierusername.BackColor = System.Drawing.Color.Transparent;
            this.tbcashierusername.BorderRadius = 15;
            this.tbcashierusername.BorderThickness = 2;
            this.tbcashierusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbcashierusername.DefaultText = "";
            this.tbcashierusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbcashierusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbcashierusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbcashierusername.DisabledState.Parent = this.tbcashierusername;
            this.tbcashierusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbcashierusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbcashierusername.FocusedState.Parent = this.tbcashierusername;
            this.tbcashierusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbcashierusername.HoverState.Parent = this.tbcashierusername;
            this.tbcashierusername.Location = new System.Drawing.Point(407, 340);
            this.tbcashierusername.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbcashierusername.Name = "tbcashierusername";
            this.tbcashierusername.PasswordChar = '\0';
            this.tbcashierusername.PlaceholderText = "Insert Username";
            this.tbcashierusername.SelectedText = "";
            this.tbcashierusername.ShadowDecoration.Parent = this.tbcashierusername;
            this.tbcashierusername.Size = new System.Drawing.Size(297, 41);
            this.tbcashierusername.TabIndex = 1;
            this.tbcashierusername.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            this.tbcashierusername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.jump);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(277, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbcashierpassword
            // 
            this.tbcashierpassword.BackColor = System.Drawing.Color.Transparent;
            this.tbcashierpassword.BorderRadius = 15;
            this.tbcashierpassword.BorderThickness = 2;
            this.tbcashierpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbcashierpassword.DefaultText = "";
            this.tbcashierpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbcashierpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbcashierpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbcashierpassword.DisabledState.Parent = this.tbcashierpassword;
            this.tbcashierpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbcashierpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbcashierpassword.FocusedState.Parent = this.tbcashierpassword;
            this.tbcashierpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbcashierpassword.HoverState.Parent = this.tbcashierpassword;
            this.tbcashierpassword.Location = new System.Drawing.Point(407, 391);
            this.tbcashierpassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbcashierpassword.Name = "tbcashierpassword";
            this.tbcashierpassword.PasswordChar = '*';
            this.tbcashierpassword.PlaceholderText = "Insert Password";
            this.tbcashierpassword.SelectedText = "";
            this.tbcashierpassword.ShadowDecoration.Parent = this.tbcashierpassword;
            this.tbcashierpassword.Size = new System.Drawing.Size(297, 39);
            this.tbcashierpassword.TabIndex = 4;
            this.tbcashierpassword.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            this.tbcashierpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(279, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btCashierLogin
            // 
            this.btCashierLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCashierLogin.AnimationHoverSpeed = 0.07F;
            this.btCashierLogin.AnimationSpeed = 0.03F;
            this.btCashierLogin.BackColor = System.Drawing.Color.Transparent;
            this.btCashierLogin.BaseColor = System.Drawing.Color.MediumSlateBlue;
            this.btCashierLogin.BorderColor = System.Drawing.Color.Black;
            this.btCashierLogin.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btCashierLogin.CheckedBorderColor = System.Drawing.Color.Black;
            this.btCashierLogin.CheckedForeColor = System.Drawing.Color.White;
            this.btCashierLogin.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btCashierLogin.CheckedImage")));
            this.btCashierLogin.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btCashierLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btCashierLogin.FocusedColor = System.Drawing.Color.Empty;
            this.btCashierLogin.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCashierLogin.ForeColor = System.Drawing.Color.White;
            this.btCashierLogin.Image = null;
            this.btCashierLogin.ImageSize = new System.Drawing.Size(20, 20);
            this.btCashierLogin.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btCashierLogin.Location = new System.Drawing.Point(407, 452);
            this.btCashierLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCashierLogin.Name = "btCashierLogin";
            this.btCashierLogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btCashierLogin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btCashierLogin.OnHoverForeColor = System.Drawing.Color.White;
            this.btCashierLogin.OnHoverImage = null;
            this.btCashierLogin.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btCashierLogin.OnPressedColor = System.Drawing.Color.Black;
            this.btCashierLogin.Radius = 12;
            this.btCashierLogin.Size = new System.Drawing.Size(180, 42);
            this.btCashierLogin.TabIndex = 6;
            this.btCashierLogin.Text = "Log In";
            this.btCashierLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btCashierLogin.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // gunaGradientButton1
            // 
            this.gunaGradientButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton1.AnimationSpeed = 0.03F;
            this.gunaGradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton1.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.gunaGradientButton1.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.gunaGradientButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGradientButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.Image = null;
            this.gunaGradientButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton1.Location = new System.Drawing.Point(15, 558);
            this.gunaGradientButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Radius = 13;
            this.gunaGradientButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaGradientButton1.TabIndex = 7;
            this.gunaGradientButton1.Text = "Go Back";
            this.gunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton1.Click += new System.EventHandler(this.gunaGradientButton1_Click);
            // 
            // CashierLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(981, 613);
            this.Controls.Add(this.gunaGradientButton1);
            this.Controls.Add(this.btCashierLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbcashierpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbcashierusername);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "CashierLoginForm";
            this.Text = "Cashier Login";
            this.Load += new System.EventHandler(this.CashierLoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tbcashierusername;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbcashierpassword;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaAdvenceButton btCashierLogin;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
    }
}