namespace AdrianAmper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] foods = { "Filipino", "Japanese", "Chinese", "Korean" };
            foodComboBox1.Items.AddRange(foods);

            foodComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            foodComboBox1.SelectedIndex = 0;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            string[] filipinoFoodsList = { "Tinola", "Menudo", "Sinigang", "Lumpia", "Sisig" };
            string[] japaneseFoodList = { "Ramen", "Sushi", "Onigiri", "Jiaozi", "Yakitori" };
            string[] chineseFoodList = { "Hot Pot", "Dumplings", "Chow Mein", "Dim Sum" };
            string[] koreanFoodList = { "Kimchi", "Japchae", "Bulgogi", "Bibimpap", "Korean Fried Chicken" };

            if (foodComboBox1.SelectedItem.ToString().Contains("Filipino"))
            {
                foodCheckedListBox1.Items.AddRange(filipinoFoodsList);
            }
            else if (foodComboBox1.SelectedItem.ToString().Contains("Japanese"))
            {
                foodCheckedListBox1.Items.AddRange(japaneseFoodList);
            }
            if (foodComboBox1.SelectedItem.ToString().Contains("Chinese"))
            {
                foodCheckedListBox1.Items.AddRange(chineseFoodList);
            }
            if (foodComboBox1.SelectedItem.ToString().Contains("Korean"))
            {
                foodCheckedListBox1.Items.AddRange(koreanFoodList);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in foodCheckedListBox1.Items)
            {
                bool isSelected = foodCheckedListBox1.GetItemChecked(foodCheckedListBox1.Items.IndexOf(item));
                if (isSelected && !foodListBox1.Items.Contains(item))
                {
                    foodListBox1.Items.Add(item);
                }
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (foodListBox1.Items.Count >= 1)
            {
                foodListBox1.Items.Remove(foodListBox1.SelectedItem);
            }
        }

        private void clearallBtn_Click(object sender, EventArgs e)
        {
            foodListBox1.Items.Clear();

        }

        private void foodComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void foodListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}