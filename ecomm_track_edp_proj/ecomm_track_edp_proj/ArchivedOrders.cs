using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ecomm_track_edp_proj
{
    public partial class ArchivedOrders : Form
    {
        public ArchivedOrders()
        {
            InitializeComponent();  // This calls the method defined in Designer file
            LoadArchivedOrders();
        }

        private void LoadArchivedOrders()
        {
            string connectionString = "server=localhost;user=root;password=12345;database=ecommerce;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT OrderID, UserID, OrderDate, TotalAmount FROM archived_orders";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable ordersTable = new DataTable();
                    adapter.Fill(ordersTable);

                    dataGridArchivedOrders.DataSource = ordersTable;  // this refers to DataGridView from Designer
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load archived orders.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
