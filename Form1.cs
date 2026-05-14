namespace hanged_man_game
{
    public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        
    }
    

    
    static string[] Word_chooser(int difficulty)
    {
        string[] raw = File.ReadAllLines("words.txt");
        Random roll = new Random();
        string[] arguments = { "sports", "war", "animals" };
        string[] result = new string[2];
        string chosen_word = "";
        int chosen_argument = roll.Next(0, 3);
        int a = 0;
        List<string> sports = new List<string>(raw[0].Split(','));
        List<string> war = new List<string>(raw[1].Split(','));
        List<string> animals = new List<string>(raw[2].Split(','));
        if (difficulty == 1)
        {
            a = roll.Next(0, 6);
        }
        else if (difficulty == 2)
        {
            a = roll.Next(6, 11);
        }
        else
        {
            a = roll.Next(10, 15);
        }
        if (chosen_argument == 0)
        {
            chosen_word = sports[a];
        }
        else if (chosen_argument == 1)
        {
            chosen_word = war[a];
        }
        else
        {
            chosen_word = animals[a];
        }

        result[0] = chosen_word;
        result[1] = arguments[chosen_argument];
        return result;
    }

    private void letter_chosen_TextChanged(object sender, EventArgs e)
    {
        
    }

    private void label5_Click(object sender, EventArgs e)
    {

    }
    private void button5_Click(object sender, EventArgs e)
    {
       
    }

    private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBox1.Checked) 
        {
            n_lives.Text = "12";
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            string placeholder = n_lives.Text;
            int difficulty = Convert.ToInt32(placeholder);
            string[] stuff = Word_chooser(difficulty);
            final_word.Text = stuff[0];
            argument.Text = stuff[1];
        }
    }

    private void checkBox2_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBox2.Checked)
        {
            n_lives.Text = "8";
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            string placeholder=n_lives.Text;
            int difficulty = Convert.ToInt32(placeholder);
            string[] stuff = Word_chooser(difficulty);
            final_word.Text = stuff[0];
            argument.Text = stuff[1];
        }
    }

    private void checkBox3_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBox3.Checked)
        {
            n_lives.Text = "6";
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            string placeholder = n_lives.Text;
            int difficulty = Convert.ToInt32(placeholder);
            string[] stuff = Word_chooser(difficulty);
            final_word.Text = stuff[0];
            argument.Text = stuff[1];
        }
    }
}
}
