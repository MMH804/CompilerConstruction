using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LabLab3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            // Get the input text from a TextBox or any other source.
            string inputText = InputTextBox.Text;

            // Define the regular expression pattern for numbers in XeY format.
            string pattern = @"\d+(\.\d+)?e[-+]?\d+";

            // Create a DataTable to store the matched numbers.
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Numbers");

            // Use Regex to find matches in the input text.
            MatchCollection matches = Regex.Matches(inputText, pattern);

            // Add matched numbers to the DataTable.
            foreach (Match match in matches)
            {
                dataTable.Rows.Add(match.Value);
            }

            // Bind the DataTable to the DataGridView.
            dataGridView1.DataSource = dataTable;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Initialize the DataGridView with headers.
            dataGridView1.Columns.Add("Numbers", "Numbers");
        }

        // Create a TextBox for user input.
        private TextBox InputTextBox;

        private void InitializeComponents()
        {
            // Create a TextBox for user input.
            InputTextBox = new TextBox();
            InputTextBox.Dock = DockStyle.Top;
            InputTextBox.Multiline = true;
            InputTextBox.Height = 100;

            // Create a Button for extracting numbers.
            var extractButton = new Button();
            extractButton.Text = "Extract Numbers";
            extractButton.Dock = DockStyle.Top;
            extractButton.Click += btnResult_Click;

            // Create a DataGridView for displaying the matched numbers.
            dataGridView1 = new DataGridView();
            dataGridView1.Dock = DockStyle.Fill;

            // Add controls to the form.
            Controls.Add(dataGridView1);
            Controls.Add(extractButton);
            Controls.Add(InputTextBox);

            // Set the form properties.
            Text = "Number Extractor";
            Size = new System.Drawing.Size(400, 300);

            // Initialize the DataGridView with headers.
            dataGridView1.Columns.Add("Numbers", "Numbers");
        }

        private DataGridView dataGridView1;
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
