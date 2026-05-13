namespace hanged_man_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        static string[] Word_chooser(int difficulty)
        {
            string[] raw = File.ReadAllLines("words.txt");
            Random roll = new Random();
            string[] arguments = { "sports", "war", "animals" };
            string[] result = new string[2];
            string chosen_word = "";
            int chosen_argument = roll.Next(0, 3), a = 0;
            List<string> sports = new List<string>();
            List<string> war = new List<string>();
            List<string> animals = new List<string>();
            sports.Add(raw[0]);
            war.Add(raw[1]);
            animals.Add(raw[2]);
            sports[0].Split(',');
            war[0].Split(',');
            animals[0].Split(',');
            if (difficulty == 1)
            {
                a = roll.Next(0, 6);
            }
            if (difficulty == 2)
            {
                a = roll.Next(6, 11);
            }
            if (difficulty == 3)
            {
                a = roll.Next(10, 16);
            }
            if (chosen_argument == 0)
            {
                chosen_word ="";
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

    }
}
