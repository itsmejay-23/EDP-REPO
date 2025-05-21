namespace ecomm_track_edp_proj
{
    partial class Reset
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblConfirmPassword;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtEmail = new TextBox();
            txtNewPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnReset = new Button();
            lblEmail = new Label();
            lblNewPassword = new Label();
            lblConfirmPassword = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(180, 47);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(180, 97);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(250, 23);
            txtNewPassword.TabIndex = 3;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(180, 147);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(250, 23);
            txtConfirmPassword.TabIndex = 5;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btnReset
            // 
            btnReset.ForeColor = Color.FromArgb(0, 64, 64);
            btnReset.Location = new Point(180, 200);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(250, 30);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset Password";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = SystemColors.Window;
            lblEmail.Location = new Point(50, 50);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.ForeColor = SystemColors.Window;
            lblNewPassword.Location = new Point(50, 100);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(87, 15);
            lblNewPassword.TabIndex = 2;
            lblNewPassword.Text = "New Password:";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.ForeColor = SystemColors.Window;
            lblConfirmPassword.Location = new Point(50, 150);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(107, 15);
            lblConfirmPassword.TabIndex = 4;
            lblConfirmPassword.Text = "Confirm Password:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = SystemColors.Window;
            linkLabel1.Location = new Point(348, 249);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(82, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back to Log In";
            linkLabel1.LinkClicked += this.linkLabel1_LinkClicked;
            // 
            // Reset
            // 
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(500, 300);
            Controls.Add(linkLabel1);
            Controls.Add(btnReset);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(lblNewPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Name = "Reset";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reset Password";
            ResumeLayout(false);
            PerformLayout();
        }
        private LinkLabel linkLabel1;
    }
}
