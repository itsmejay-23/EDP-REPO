namespace ecomm_track_edp_proj
{
    partial class Welcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupbox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            xpss = new TextBox();
            email = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            groupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupbox1
            // 
            groupbox1.Controls.Add(label5);
            groupbox1.Controls.Add(label4);
            groupbox1.Controls.Add(label3);
            groupbox1.Controls.Add(linkLabel1);
            groupbox1.Controls.Add(button1);
            groupbox1.Controls.Add(xpss);
            groupbox1.Controls.Add(email);
            groupbox1.Location = new Point(387, 36);
            groupbox1.Name = "groupbox1";
            groupbox1.Size = new Size(365, 299);
            groupbox1.TabIndex = 3;
            groupbox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(59, 146);
            label5.Name = "label5";
            label5.Size = new Size(65, 17);
            label5.TabIndex = 13;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Window;
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(59, 79);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(39, 17);
            label4.TabIndex = 12;
            label4.Text = "Email";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(126, 31);
            label3.Name = "label3";
            label3.Size = new Size(114, 17);
            label3.TabIndex = 11;
            label3.Text = "Log In As Admin";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = SystemColors.Window;
            linkLabel1.Location = new Point(207, 234);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(100, 15);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(0, 64, 64);
            button1.Location = new Point(59, 230);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // xpss
            // 
            xpss.Location = new Point(59, 166);
            xpss.Name = "xpss";
            xpss.Size = new Size(248, 23);
            xpss.TabIndex = 8;
            xpss.TextChanged += xpss_TextChanged;
            // 
            // email
            // 
            email.Location = new Point(59, 99);
            email.Name = "email";
            email.Size = new Size(248, 23);
            email.TabIndex = 6;
            email.TextChanged += email_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Malgun Gothic", 20.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(50, 58);
            label1.Name = "label1";
            label1.Size = new Size(256, 37);
            label1.TabIndex = 4;
            label1.Text = "E-commerce Track";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(60, 95);
            label2.Name = "label2";
            label2.Size = new Size(226, 21);
            label2.TabIndex = 5;
            label2.Text = "DRIVE SMARTER DECISIONS";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dataanalyticsBG__1__removebg_preview;
            pictureBox1.Location = new Point(50, 135);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 184);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(804, 374);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupbox1);
            Name = "Welcome";
            Text = "Form1";
            Load += login_Load;
            groupbox1.ResumeLayout(false);
            groupbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void textBox2_TextChanged_1(object sender, EventArgs e) { }

        private void login_Load(object sender, EventArgs e) { }
        private GroupBox groupbox1;
        private Label label1;
        private Label label2;
        private TextBox email;
        private LinkLabel linkLabel1;
        private Button button1;
        private TextBox xpss;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
    }

}
