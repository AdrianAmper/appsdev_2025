namespace AdrianAmper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fNameValue = firstname.Text;
            string lNameValue = lastname.Text;
            MessageBox.Show($"Hello World: {fNameValue} {lNameValue}", "Greetings!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
