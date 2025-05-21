namespace ecomm_track_edp_proj
{
    partial class ArchivedOrders
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridArchivedOrders;

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
            this.dataGridArchivedOrders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArchivedOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridArchivedOrders
            // 
            this.dataGridArchivedOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridArchivedOrders.Location = new System.Drawing.Point(12, 12);
            this.dataGridArchivedOrders.Name = "dataGridArchivedOrders";
            this.dataGridArchivedOrders.Size = new System.Drawing.Size(776, 426);
            this.dataGridArchivedOrders.TabIndex = 0;
            // 
            // ArchivedOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridArchivedOrders);
            this.Name = "ArchivedOrders";
            this.Text = "Archived Orders";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArchivedOrders)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
