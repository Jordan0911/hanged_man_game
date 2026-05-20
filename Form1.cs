namespace hanged_man_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            final_word.Hide();
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
        private void conferm_Click(object sender, EventArgs e)
        {
            int lives = Convert.ToInt32(n_lives.Text);
            bool letter_found = false;
            char letter = Convert.ToChar(letter_chosen.Text);
            string result = "";
            string decided_word = final_word.Text;
            char[] Censured_word = new char[final_word.Text.Length];
            if (word.Text == "greetings")
            {
                for (int i = 0; i < decided_word.Length; i++)
                {
                    Censured_word[i] = '_';
                }
            }


            for (int i = 0; i < decided_word.Length; i++)
            {
                if (letter == decided_word[i])
                {
                    Censured_word[i] = letter;
                    letter_found = true;
                }
            }
            if (letter_found == false)
            {
                lives--;
                if (lives == 0)
                {
                    word.Text ="YOU LOST!!!";

                }
                n_lives.Text = Convert.ToString(lives);
            }
            for (int i = 0; i < decided_word.Length; i++)
            {
               result += Censured_word[i];
            }
            word.Text = result;
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
                string placeholder = n_lives.Text;
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

        private void censured_word_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
