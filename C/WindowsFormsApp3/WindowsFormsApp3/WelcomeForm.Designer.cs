
namespace WindowsFormsApp3
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.bt_LoginCashier = new Guna.UI.WinForms.GunaGradientButton();
            this.bt_LoginAdmin = new Guna.UI.WinForms.GunaGradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_LoginCashier
            // 
            this.bt_LoginCashier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_LoginCashier.AnimationHoverSpeed = 0.07F;
            this.bt_LoginCashier.AnimationSpeed = 0.03F;
            this.bt_LoginCashier.BackColor = System.Drawing.Color.Transparent;
            this.bt_LoginCashier.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.bt_LoginCashier.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.bt_LoginCashier.BorderColor = System.Drawing.Color.Black;
            this.bt_LoginCashier.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bt_LoginCashier.FocusedColor = System.Drawing.Color.Empty;
            this.bt_LoginCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_LoginCashier.ForeColor = System.Drawing.Color.White;
            this.bt_LoginCashier.Image = null;
            this.bt_LoginCashier.ImageSize = new System.Drawing.Size(20, 20);
            this.bt_LoginCashier.Location = new System.Drawing.Point(54, 269);
            this.bt_LoginCashier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_LoginCashier.Name = "bt_LoginCashier";
            this.bt_LoginCashier.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.bt_LoginCashier.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.bt_LoginCashier.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_LoginCashier.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_LoginCashier.OnHoverImage = null;
            this.bt_LoginCashier.OnPressedColor = System.Drawing.Color.Black;
            this.bt_LoginCashier.Radius = 20;
            this.bt_LoginCashier.Size = new System.Drawing.Size(209, 46);
            this.bt_LoginCashier.TabIndex = 0;
            this.bt_LoginCashier.Text = "Log In as Cashier";
            this.bt_LoginCashier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_LoginCashier.Click += new System.EventHandler(this.gunaGradientButton1_Click);
            // 
            // bt_LoginAdmin
            // 
            this.bt_LoginAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_LoginAdmin.AnimationHoverSpeed = 0.07F;
            this.bt_LoginAdmin.AnimationSpeed = 0.03F;
            this.bt_LoginAdmin.BackColor = System.Drawing.Color.Transparent;
            this.bt_LoginAdmin.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.bt_LoginAdmin.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.bt_LoginAdmin.BorderColor = System.Drawing.Color.Black;
            this.bt_LoginAdmin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bt_LoginAdmin.FocusedColor = System.Drawing.Color.Empty;
            this.bt_LoginAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_LoginAdmin.ForeColor = System.Drawing.Color.White;
            this.bt_LoginAdmin.Image = null;
            this.bt_LoginAdmin.ImageSize = new System.Drawing.Size(20, 20);
            this.bt_LoginAdmin.Location = new System.Drawing.Point(54, 217);
            this.bt_LoginAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_LoginAdmin.Name = "bt_LoginAdmin";
            this.bt_LoginAdmin.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.bt_LoginAdmin.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.bt_LoginAdmin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bt_LoginAdmin.OnHoverForeColor = System.Drawing.Color.White;
            this.bt_LoginAdmin.OnHoverImage = null;
            this.bt_LoginAdmin.OnPressedColor = System.Drawing.Color.Black;
            this.bt_LoginAdmin.Radius = 20;
            this.bt_LoginAdmin.Size = new System.Drawing.Size(209, 43);
            this.bt_LoginAdmin.TabIndex = 1;
            this.bt_LoginAdmin.Text = "Log In as Admin";
            this.bt_LoginAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bt_LoginAdmin.Click += new System.EventHandler(this.gunaGradientButton2_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.bt_LoginAdmin);
            this.panel1.Controls.Add(this.bt_LoginCashier);
            this.panel1.Location = new System.Drawing.Point(225, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 374);
            this.panel1.TabIndex = 2;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(736, 498);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "WelcomeForm";
            this.Text = " Smart Meals POS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientButton bt_LoginCashier;
        private Guna.UI.WinForms.GunaGradientButton bt_LoginAdmin;
        private System.Windows.Forms.Panel panel1;
    }
}

