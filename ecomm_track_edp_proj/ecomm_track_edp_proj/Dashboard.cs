using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ecomm_track_edp_proj;

namespace ecomm_track_edp_proj
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private decimal GetTotalRevenue()
        {
            decimal totalRevenue = 0;

            string connectionString = "Server=localhost;Database=ecommerce;Uid=root;Pwd=12345;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT SUM(TotalRevenue) FROM revenuesummary"; // change "sales" and "total_price" to match your table/column
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalRevenue = Convert.ToDecimal(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return totalRevenue;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            decimal revenue = GetTotalRevenue();
            label7.Text = "₱" + revenue.ToString("N2");

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            decimal revenue = GetTotalRevenue();
            label7.Text = "₱" + revenue.ToString("N2");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var welcomeForm = new ecomm_track_edp_proj.Welcome();
            welcomeForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new Orders());
        }

        private void LoadFormIntoPanel(Form childForm)
        {
            panel2.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear(); // Clear anything already in the panel

            Users usersForm = new Users();
            usersForm.TopLevel = false; // Makes it behave like a control, not a window
            usersForm.FormBorderStyle = FormBorderStyle.None; // Removes the border
            usersForm.Dock = DockStyle.Fill; // Makes it fill the panel

            panel2.Controls.Add(usersForm); // Add the form to the panel
            usersForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear(); // Clear whatever is inside panel2

            Payments paymentsForm = new Payments();
            paymentsForm.TopLevel = false; // Make it a control inside the panel
            paymentsForm.FormBorderStyle = FormBorderStyle.None; // Remove border and title bar
            paymentsForm.Dock = DockStyle.Fill; // Fill the panel

            panel2.Controls.Add(paymentsForm); // Add the payments form to the panel
            paymentsForm.Show(); // Show the form
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear(); // Clear whatever is inside panel2

            Revenue revenueForm = new Revenue();
            revenueForm.TopLevel = false; // Make it a control inside the panel
            revenueForm.FormBorderStyle = FormBorderStyle.None; // Remove border and title bar
            revenueForm.Dock = DockStyle.Fill; // Fill the panel

            panel2.Controls.Add(revenueForm); // Add the Revenue form to the panel
            revenueForm.Show(); // Show the form
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear(); // Clear whatever is inside panel2

            ArchivedOrders archivedOrdersForm = new ArchivedOrders();
            archivedOrdersForm.TopLevel = false; // Make it a control inside the panel
            archivedOrdersForm.FormBorderStyle = FormBorderStyle.None; // Remove border and title bar
            archivedOrdersForm.Dock = DockStyle.Fill; // Fill the panel

            panel2.Controls.Add(archivedOrdersForm); // Add the archived orders form to the panel
            archivedOrdersForm.Show(); // Show the form
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear(); // Clear whatever is inside panel2

            ReportGeneration reportGenerationForm = new ReportGeneration();
            reportGenerationForm.TopLevel = false; // Make it a control inside the panel
            reportGenerationForm.FormBorderStyle = FormBorderStyle.None; // Remove border and title bar
            reportGenerationForm.Dock = DockStyle.Fill; // Fill the panel

            panel2.Controls.Add(reportGenerationForm); // Add the ReportGeneration form to the panel
            reportGenerationForm.Show(); // Show the form
        }
    }
}
