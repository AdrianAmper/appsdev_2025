namespace AdrianAmper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !listbox.Items.Contains(textBox1.Text))
            {
                listbox.Items.Add(textBox1.Text);  // Add the text from the TextBox to the ListBox
            }
        }
        private void listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text.Trim();

            if (!string.IsNullOrWhiteSpace(input) && !listbox.Items.Contains(input))
            {
                listbox.Items.Add(input);

                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid, non-duplicate name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listbox.SelectedItem != null)
            {
                listbox.Items.Remove(listbox.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select an item to remove.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listbox.Items.Count > 0)
            {
                listbox.Items.Clear();
                MessageBox.Show("All items have been cleared.", "Clear", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The list is already empty.", "No Items", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
    