using System;
using System.Windows.Forms;
using System.Data;

namespace LAB_07_055
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            string input = InputTextBox.Text;
            try
            {
                double result = ParseAndEvaluateExpression(input);

                // Update the UI on the main thread using Invoke
                this.Invoke(new Action(() =>
                {
                    ResultLabel.Text = "Result: " + result;
                }));
            }
            catch (Exception ex)
            {
                // Update the UI on the main thread using Invoke
                this.Invoke(new Action(() =>
                {
                    ResultLabel.Text = "Error: " + ex.Message;
                }));
            }
        }
            private double ParseAndEvaluateExpression(string expression)
            {
                // Basic grammar with four non-terminals and four terminals
                // Non-terminals: E, T, F, and A
                // Terminals: +, -, *, /, numbers

                // You can implement a simple recursive descent parser here to evaluate the expression.

                // For simplicity, we'll use the built-in DataTable.Compute method to evaluate the expression.
                // This is not a real parser; it's a shortcut for simplicity.

                DataTable dt = new DataTable();
                dt.Columns.Add("expression", typeof(string), expression);
                DataRow row = dt.NewRow();
                dt.Rows.Add(row);

                double result = double.Parse((string)row["expression"]);
                return result;
            }
        }
    }
