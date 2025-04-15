namespace ecomm_app
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            button6 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 64);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(158, 315);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 64, 64);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleRight;
            button5.Location = new Point(13, 258);
            button5.Name = "button5";
            button5.Size = new Size(130, 45);
            button5.TabIndex = 6;
            button5.Text = "Revenue";
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 64, 64);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleRight;
            button4.Location = new Point(13, 207);
            button4.Name = "button4";
            button4.Size = new Size(130, 45);
            button4.TabIndex = 5;
            button4.Text = "Archived";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 64, 64);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(13, 156);
            button3.Name = "button3";
            button3.Size = new Size(130, 45);
            button3.TabIndex = 4;
            button3.Text = "Payment";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 64, 64);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(13, 105);
            button2.Name = "button2";
            button2.Size = new Size(130, 45);
            button2.TabIndex = 3;
            button2.Text = "Orders";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 64, 64);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(13, 54);
            button1.Name = "button1";
            button1.Size = new Size(130, 45);
            button1.TabIndex = 2;
            button1.Text = "Home";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 45);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(48, 22);
            label1.Name = "label1";
            label1.Size = new Size(95, 14);
            label1.TabIndex = 0;
            label1.Text = "ECOMM. TRACK";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button6);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(163, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(395, 315);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(119, 113);
            label2.Name = "label2";
            label2.Size = new Size(157, 37);
            label2.TabIndex = 0;
            label2.Text = "WELCOME!";
            label2.Click += label2_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(0, 64, 64);
            button6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Location = new Point(135, 156);
            button6.Name = "button6";
            button6.Size = new Size(123, 31);
            button6.TabIndex = 1;
            button6.Text = "ADMIN ACCESS";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 314);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            RightToLeftLayout = true;
            Text = "EcommTrackGUI";
            Load += Form1_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Panel panel2;
        private Label label2;
        private Button button6;
    }
}
