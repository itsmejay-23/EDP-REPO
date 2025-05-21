namespace ecomm_track_edp_proj
{
    partial class ReportGeneration
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cbTables;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Button btnExportExcel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cbTables = new System.Windows.Forms.ComboBox();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.btnExportExcel = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();

            // cbTables
            this.cbTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTables.Location = new System.Drawing.Point(20, 20);
            this.cbTables.Size = new System.Drawing.Size(200, 25);
            this.cbTables.SelectedIndexChanged += new System.EventHandler(this.cbTables_SelectedIndexChanged);

            // dgvReport
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.Location = new System.Drawing.Point(20, 60);
            this.dgvReport.Size = new System.Drawing.Size(760, 370);
            this.dgvReport.ReadOnly = true;

            // btnExportExcel
            this.btnExportExcel.Location = new System.Drawing.Point(240, 20);
            this.btnExportExcel.Size = new System.Drawing.Size(120, 25);
            this.btnExportExcel.Text = "Export to Excel";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);

            // ReportGeneration
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbTables);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.btnExportExcel);
            this.Text = "Report Generation";

            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
