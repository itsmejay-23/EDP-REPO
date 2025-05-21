using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ecomm_track_edp_proj
{
    public partial class Orders : Form
    {
        private string connectionString = "server=localhost;user=root;password=12345;database=ecommerce;";

        public Orders()
        {
            InitializeComponent();
            LoadOrders(); // Optional: load immediately on constructor
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                using var conn = new MySqlConnection(connectionString);
                conn.Open();

                string query = "SELECT * FROM orders";
                using var cmd = new MySqlCommand(query, conn);
                using var adapter = new MySqlDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                dataGridOrders.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using var conn = new MySqlConnection(connectionString);
                conn.Open();

                string query = "INSERT INTO orders (UserID, OrderDate, TotalAmount, OrderStatus) VALUES (@uid, @od, @ta, @os)";
                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@uid", txtUserID.Text);
                cmd.Parameters.AddWithValue("@od", DateTime.Parse(txtOrderDate.Text));
                cmd.Parameters.AddWithValue("@ta", decimal.Parse(txtTotalAmount.Text));
                cmd.Parameters.AddWithValue("@os", txtOrderStatus.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Order Added");
                LoadOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding order: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridOrders.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to update.");
                    return;
                }

                int orderId = Convert.ToInt32(dataGridOrders.SelectedRows[0].Cells["OrderID"].Value);

                using var conn = new MySqlConnection(connectionString);
                conn.Open();

                string query = "UPDATE orders SET UserID=@uid, OrderDate=@od, TotalAmount=@ta, OrderStatus=@os WHERE OrderID=@id";
                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@uid", txtUserID.Text);
                cmd.Parameters.AddWithValue("@od", DateTime.Parse(txtOrderDate.Text));
                cmd.Parameters.AddWithValue("@ta", decimal.Parse(txtTotalAmount.Text));
                cmd.Parameters.AddWithValue("@os", txtOrderStatus.Text);
                cmd.Parameters.AddWithValue("@id", orderId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Order Updated");
                LoadOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating order: " + ex.Message);
            }
        }

        private void dataGridOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridOrders.Rows[e.RowIndex];

                txtUserID.Text = row.Cells["UserID"].Value?.ToString();
                txtOrderDate.Text = Convert.ToDateTime(row.Cells["OrderDate"].Value).ToString("yyyy-MM-dd");
                txtTotalAmount.Text = row.Cells["TotalAmount"].Value?.ToString();
                txtOrderStatus.Text = row.Cells["OrderStatus"].Value?.ToString();
            }
        }

    }

}
