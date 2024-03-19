namespace WFCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string email = "nguyenhanh";
        string password = "123";

        bool Check(string email, string password)
        {
            if (email == this.email && password == this.password)
            {
                return true;
            }

            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (Check(txbEmail.Text, txbPass.Text))
            {
                Calculator calculator = new Calculator();
                calculator.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
