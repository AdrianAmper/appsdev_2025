namespace AmperAdrian
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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to submit?",
                      "Confirmation", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    break;
                case DialogResult.No:
                    break;
            }

            {
                string fNameValue = firstname.Text;
                string lNameValue = lastname.Text;
                string mNameValue = middlename.Text;
                string sSuffixValue = suffix.Text;
                MessageBox.Show($"Hello There! {fNameValue} {mNameValue} {lNameValue} {sSuffixValue}", "Greetings!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
