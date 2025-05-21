using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OfficeOpenXml;
using System.IO;

namespace ecomm_track_edp_proj
{
    public partial class ReportGeneration : Form
    {
        // Change this to your actual MySQL connection string
        string connectionString = "server=localhost;user=root;password=12345;database=ecommerce;";

        public ReportGeneration()
        {
            InitializeComponent();
            LoadTables();
        }

        private void LoadTables()
        {
            // List of tables you want to allow for reporting
            cbTables.Items.Clear();
            cbTables.Items.Add("archived_orders");
            cbTables.Items.Add("payments");
            cbTables.Items.Add("orders");
            // Add other tables here as needed

            cbTables.SelectedIndex = 0;
        }

        private void LoadTableData()
        {
            if (cbTables.SelectedItem == null) return;

            string selectedTable = cbTables.SelectedItem.ToString();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = $"SELECT * FROM {selectedTable}";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvReport.DataSource = dt;
            }
        }

        private void cbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTableData();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (dgvReport.DataSource == null)
            {
                MessageBox.Show("No data to export.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (ExcelPackage package = new ExcelPackage())
                    {
                        ExcelWorksheet sheet = package.Workbook.Worksheets.Add("Report");

                        // Add headers
                        for (int i = 0; i < dgvReport.Columns.Count; i++)
                        {
                            sheet.Cells[1, i + 1].Value = dgvReport.Columns[i].HeaderText;
                        }

                        // Add rows
                        for (int i = 0; i < dgvReport.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvReport.Columns.Count; j++)
                            {
                                sheet.Cells[i + 2, j + 1].Value = dgvReport.Rows[i].Cells[j].Value?.ToString();
                            }
                        }

                        File.WriteAllBytes(sfd.FileName, package.GetAsByteArray());
                        MessageBox.Show("Exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
