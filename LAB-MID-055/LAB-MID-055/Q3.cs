using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_MID_055
{
    public partial class Q3 : Form
    {
        private Random random = new Random();
        public Q3()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string registrationNumber = registrationNumberTextBox.Text;

            string initials = GetInitials(firstName, lastName);
            string lastTwoDigits = GetLastTwoDigits(registrationNumber);

            string generatedPassword = GeneratePassword(initials, lastTwoDigits);

            passwordLabel.Text = "Generated Password: " + generatedPassword;
        }
        private string GetInitials(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
                return string.Empty;

            return (firstName[0].ToString() + lastName[0].ToString()).ToUpper();
        }

        private string GetLastTwoDigits(string registrationNumber)
        {
            if (string.IsNullOrWhiteSpace(registrationNumber) || registrationNumber.Length < 2)
                return "00";

            return registrationNumber.Substring(registrationNumber.Length - 2);
        }

        private string GeneratePassword(string initials, string lastTwoDigits)
        {
            int maxLength = 20;
            int requiredSpecialChars = 2;
            int requiredNumbers = 4;

            string specialChars = "!@#$%^&*()-_=+[]{}|;:,.<>?";
            string numbers = "0123456789";

            int maxRandomChars = maxLength - (initials.Length + lastTwoDigits.Length + requiredSpecialChars + requiredNumbers);

            // Generate special characters
            string generatedSpecialChars = new string(specialChars.ToCharArray().OrderBy(x => random.Next()).Take(requiredSpecialChars).ToArray());

            // Generate numbers (with the last two digits included)
            string generatedNumbers = lastTwoDigits + new string(numbers.ToCharArray().OrderBy(x => random.Next()).Take(requiredNumbers - 2).ToArray());

            // Generate random characters
            string randomChars = new string(Enumerable.Repeat("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ", maxRandomChars)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            // Combine all parts and shuffle
            string combined = initials + generatedSpecialChars + generatedNumbers + randomChars;
            string shuffledPassword = new string(combined.ToCharArray().OrderBy(x => random.Next()).ToArray());

            return shuffledPassword;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 t = new Form1();
            t.Show();
            this.Hide();
        }
    }
}
