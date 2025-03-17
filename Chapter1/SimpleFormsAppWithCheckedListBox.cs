namespace AdrianAmper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            string[] movies = { "Inside Out 2", "Deadpool and Wolverine", "Moana 2", "Despicable Me 4" };
            moviesCheckListBox.Items.AddRange(movies);

            moviesCheckListBox.CheckOnClick = true;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            foreach (var movie in moviesCheckListBox.Items)
            {
                // Check if the movie is checked
                bool isSelected = moviesCheckListBox.GetItemChecked(moviesCheckListBox.Items.IndexOf(movie));

                // Add the movie if it's checked and not already in the ListBox
                if (isSelected && !moviesListBox.Items.Contains(movie))
                {
                    moviesListBox.Items.Add(movie);
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearallBtn_Click(object sender, EventArgs e)
        {
            moviesListBox.Items.Clear();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (moviesListBox.SelectedItem != null)  // Ensure an item is selected
            {
                moviesListBox.Items.Remove(moviesListBox.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select a movie to remove.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}