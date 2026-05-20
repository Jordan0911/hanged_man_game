namespace hanged_man_game
{
   partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            letter_chosen = new TextBox();
            word = new Label();
            argument = new Label();
            label5 = new Label();
            confirm = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            n_lives = new Label();
            final_word = new Label();
            SuspendLayout();
            // 
            // letter_chosen
            // 
            letter_chosen.Location = new Point(231, 335);
            letter_chosen.Name = "letter_chosen";
            letter_chosen.Size = new Size(214, 23);
            letter_chosen.TabIndex = 0;
            letter_chosen.TextChanged += letter_chosen_TextChanged;
            // 
            // word
            // 
            word.AutoSize = true;
            word.BackColor = Color.FromArgb(255, 128, 128);
            word.Font = new Font("Playbill", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            word.Location = new Point(254, 186);
            word.Name = "word";
            word.Size = new Size(157, 65);
            word.TabIndex = 1;
            word.Text = "greetings";
            word.TextAlign = ContentAlignment.MiddleCenter;
            word.Click += censured_word_Click;
            // 
            // argument
            // 
            argument.AutoSize = true;
            argument.Font = new Font("OCR A Extended", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            argument.Location = new Point(256, 280);
            argument.Name = "argument";
            argument.Size = new Size(149, 29);
            argument.TabIndex = 2;
            argument.Text = "argument";
            argument.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(311, 70);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 3;
            label5.Click += label5_Click;
            // 
            // confirm
            // 
            confirm.Location = new Point(256, 380);
            confirm.Name = "confirm";
            confirm.Size = new Size(155, 59);
            confirm.TabIndex = 4;
            confirm.Text = "button5";
            confirm.UseVisualStyleBackColor = true;
            confirm.Click += conferm_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(85, 100);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(49, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Easy";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(85, 124);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(71, 19);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "Medium";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(85, 148);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(68, 19);
            checkBox3.TabIndex = 7;
            checkBox3.Text = "Difficult";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // n_lives
            // 
            n_lives.AutoSize = true;
            n_lives.Location = new Point(147, 342);
            n_lives.Name = "n_lives";
            n_lives.Size = new Size(89, 15);
            n_lives.TabIndex = 8;
            n_lives.Text = "number of lives";
            // 
            // final_word
            // 
            final_word.AutoSize = true;
            final_word.Font = new Font("Old English Text MT", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            final_word.Location = new Point(273, 112);
            final_word.Name = "final_word";
            final_word.Size = new Size(113, 44);
            final_word.TabIndex = 9;
            final_word.Text = "label6";
            final_word.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            ClientSize = new Size(710, 623);
            Controls.Add(final_word);
            Controls.Add(n_lives);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(confirm);
            Controls.Add(label5);
            Controls.Add(argument);
            Controls.Add(word);
            Controls.Add(letter_chosen);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox n1;
        private System.Windows.Forms.TextBox n2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox letter_chosen;
        private System.Windows.Forms.Label word;
        private System.Windows.Forms.Label argument;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label n_lives;
        private System.Windows.Forms.Label final_word;
    }
}
