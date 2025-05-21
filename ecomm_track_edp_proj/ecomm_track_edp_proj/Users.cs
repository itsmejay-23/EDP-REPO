using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ecomm_track_edp_proj
{
    public partial class Users : Form
    {
        private string connString = "server=localhost;userid=root;password=12345;database=ecommerce;";

        public Users()
        {
            InitializeComponent();
            LoadUsers();
        }

        // Load data from DB into DataGridView
        private void LoadUsers()
        {
            try
            {
                using var conn = new MySqlConnection(connString);
                conn.Open();

                string query = "SELECT UserID, Username, Email FROM users";
                using var cmd = new MySqlCommand(query, conn);
                using var adapter = new MySqlDataAdapter(cmd);

                var dt = new DataTable();
                adapter.Fill(dt);

                dataGridUsers.DataSource = dt;

                // Hide UserID column or make it read-only (optional)
                dataGridUsers.Columns["UserID"].ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        // Clear input fields
        private void ClearFields()
        {
            txtUserID.Text = "";
            txtUsername.Text = "";
            txtEmail.Text = "";
        }

        // Add new user
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter both Username and Email.");
                return;
            }

            try
            {
                using var conn = new MySqlConnection(connString);
                conn.Open();

                string query = "INSERT INTO users (Username, Email) VALUES (@Username, @Email)";
                using var cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("User added successfully.");
                LoadUsers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding user: " + ex.Message);
            }
        }

        // Update selected user
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserID.Text))
            {
                MessageBox.Show("Please select a user to update.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter both Username and Email.");
                return;
            }

            try
            {
                using var conn = new MySqlConnection(connString);
                conn.Open();

                string query = "UPDATE users SET Username=@Username, Email=@Email WHERE UserID=@UserID";
                using var cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@UserID", int.Parse(txtUserID.Text));
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("User updated successfully.");
                LoadUsers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message);
            }
        }

        // Delete selected user
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserID.Text))
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using var conn = new MySqlConnection(connString);
                conn.Open();

                string query = "DELETE FROM users WHERE UserID=@UserID";
                using var cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@UserID", int.Parse(txtUserID.Text));

                cmd.ExecuteNonQuery();

                MessageBox.Show("User deleted successfully.");
                LoadUsers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user: " + ex.Message);
            }
        }

        // When a grid row is clicked, load data into input fields
        private void dataGridUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridUsers.Rows[e.RowIndex];
                txtUserID.Text = row.Cells["UserID"].Value.ToString();
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
            }
        }

        // Clear button click
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
