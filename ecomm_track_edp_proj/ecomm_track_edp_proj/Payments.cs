using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ecomm_track_edp_proj
{
    public partial class Payments : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;database=ecommerce;uid=root;pwd=12345;");
        int selectedPaymentID = -1;

        public Payments()
        {
            InitializeComponent();
            LoadPayments();
        }

        private void LoadPayments()
        {
            try
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM payments", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridPayments.DataSource = dt;
                dataGridPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payments: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO payments (OrderID, PaymentDate, Amount) VALUES (@OrderID, @PaymentDate, @Amount)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderID", txtOrderID.Text);
                cmd.Parameters.AddWithValue("@PaymentDate", txtPaymentDate.Text);
                cmd.Parameters.AddWithValue("@Amount", txtAmount.Text);
                cmd.ExecuteNonQuery();
                LoadPayments();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding payment: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedPaymentID == -1)
            {
                MessageBox.Show("Please select a payment to update.");
                return;
            }

            try
            {
                conn.Open();
                string query = "UPDATE payments SET OrderID=@OrderID, PaymentDate=@PaymentDate, Amount=@Amount WHERE PaymentID=@PaymentID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderID", txtOrderID.Text);
                cmd.Parameters.AddWithValue("@PaymentDate", txtPaymentDate.Text);
                cmd.Parameters.AddWithValue("@Amount", txtAmount.Text);
                cmd.Parameters.AddWithValue("@PaymentID", selectedPaymentID);
                cmd.ExecuteNonQuery();
                LoadPayments();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating payment: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedPaymentID == -1)
            {
                MessageBox.Show("Please select a payment to delete.");
                return;
            }

            try
            {
                conn.Open();
                string query = "DELETE FROM payments WHERE PaymentID=@PaymentID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PaymentID", selectedPaymentID);
                cmd.ExecuteNonQuery();
                LoadPayments();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting payment: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dataGridPayments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedPaymentID = Convert.ToInt32(dataGridPayments.Rows[e.RowIndex].Cells["PaymentID"].Value);
                txtOrderID.Text = dataGridPayments.Rows[e.RowIndex].Cells["OrderID"].Value.ToString();
                txtPaymentDate.Text = dataGridPayments.Rows[e.RowIndex].Cells["PaymentDate"].Value.ToString();
                txtAmount.Text = dataGridPayments.Rows[e.RowIndex].Cells["Amount"].Value.ToString();
            }
        }

        private void ClearFields()
        {
            txtOrderID.Text = "";
            txtPaymentDate.Text = "";
            txtAmount.Text = "";
            selectedPaymentID = -1;
        }
    }
}
