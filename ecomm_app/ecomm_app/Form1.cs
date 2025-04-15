namespace ecomm_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new Form2());
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new Form3());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new Form4());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new Form5());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new Form6());
        }
        private void button6_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new Form7());
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

    }
}
