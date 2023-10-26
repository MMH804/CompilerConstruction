using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace LAB_MID_055
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            string input = InputTextBox.Text;
            if (ParseList(input))
                ResultLabel.Text = "Valid input!";
            else
                ResultLabel.Text = "Invalid input!";
        }
        private bool ParseList(string input)
        {
            input = input.Replace(" ", ""); // Remove spaces

            int currentIndex = 0;
            return ParseItem(input, ref currentIndex) && ParseRest(input, ref currentIndex) && currentIndex == input.Length;
        }
        private bool ParseRest(string input, ref int currentIndex)
        {
            if (currentIndex >= input.Length)
                return true;

            if (input[currentIndex] == ',')
            {
                currentIndex++;
                return ParseItem(input, ref currentIndex) && ParseRest(input, ref currentIndex);
            }

            return true; // ? (empty) case
        }

        private bool ParseItem(string input, ref int currentIndex)
        {
            if (currentIndex >= input.Length)
                return false;

            if (input[currentIndex] == 'i' && currentIndex + 1 < input.Length && input[currentIndex + 1] == 'd')
            {
                currentIndex += 2;
                return true;
            }
            else if (char.IsDigit(input[currentIndex]))
            {
                while (currentIndex < input.Length && char.IsDigit(input[currentIndex]))
                    currentIndex++;
                return true;
            }
            else if (input[currentIndex] == 's' && currentIndex + 5 < input.Length && input.Substring(currentIndex, 6) == "string")
            {
                currentIndex += 6;
                return true;
            }

            return false;
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            Q3 q3 = new Q3();
            q3.Show();
            this.Hide();

        }
    }
}