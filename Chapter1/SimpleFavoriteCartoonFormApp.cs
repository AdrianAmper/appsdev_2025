namespace AdrianAmper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] characters = { "Spongebob", "Patrick", "Mr. Krabs", "Sandy" };
            comboBox1.Items.AddRange(characters);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            string selectedCharacter = comboBox1.SelectedItem.ToString();
            switch (selectedCharacter)
            {
                case "Spongebob":
                    pictureBox1.Image = Image.FromFile(@"C:\Users\OO103\Downloads\NICKELODEON_SPONGEBOBSQUAREPANTSHD_001_V1_687106_1920x1080.jpg");
                    break;
                case "Patrick":
                    pictureBox1.Image = Image.FromFile(@"C:\Users\OO103\Downloads\download (1).jpg");
                    break;
                case "Mr. Krabs":
                    pictureBox1.Image = Image.FromFile(@"C:\Users\OO103\Downloads\images.png");
                    break;
                case "Sandy":
                    pictureBox1.Image = Image.FromFile(@"C:\Users\OO103\Downloads\download.jpg");
                    break;
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
