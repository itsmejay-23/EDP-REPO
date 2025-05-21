using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ecomm_track_edp_proj
{
    public partial class Revenue : Form
    {
        public Revenue()
        {
            InitializeComponent();
            LoadRevenueData();
        }

        private void LoadRevenueData()
        {
            string connectionString = "server=localhost;user=root;password=12345;database=ecommerce;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT TotalRevenue FROM revenuesummary";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable revenueTable = new DataTable();
                    adapter.Fill(revenueTable);

                    dataGridRevenue.DataSource = revenueTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load revenue data.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
