namespace ecomm_track_edp_proj
{
    partial class Revenue
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridRevenue;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dataGridRevenue = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridRevenue).BeginInit();
            SuspendLayout();
            // 
            // dataGridRevenue
            // 
            dataGridRevenue.AllowUserToAddRows = false;
            dataGridRevenue.AllowUserToDeleteRows = false;
            dataGridRevenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridRevenue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridRevenue.Location = new Point(20, 20);
            dataGridRevenue.Name = "dataGridRevenue";
            dataGridRevenue.ReadOnly = true;
            dataGridRevenue.Size = new Size(760, 410);
            dataGridRevenue.TabIndex = 0;
            // 
            // Revenue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridRevenue);
            Name = "Revenue";
            Text = "Revenue Summary";
            ((System.ComponentModel.ISupportInitialize)dataGridRevenue).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
