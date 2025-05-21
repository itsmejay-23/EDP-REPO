using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

namespace ecomm_track_edp_proj
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void xpss_TextChanged(object sender, EventArgs e)
        {

        }

        private bool AuthenticateAdmin(string email, string password)
        {
            string connectionString = "server=localhost;user=root;password=12345;database=ecommerce;";
            bool isValid = false;

            string hashedPassword = ComputeSha256Hash(password);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM admin WHERE Email = @Email AND PasswordHash = @PasswordHash";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        isValid = count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }

            return isValid;
        }

        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // hide current form
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Call a function to verify login
            string emailInput = email.Text.Trim();
            string passwordInput = xpss.Text.Trim();

            if (AuthenticateAdmin(emailInput, passwordInput))
            {
                Dashboard DashboardForm = new Dashboard();
                DashboardForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password. Please try again.");
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reset resetForm = new Reset();

            // Show the Reset form
            resetForm.Show();

            // Optionally hide the current form
            this.Hide();
        }
    }
}
