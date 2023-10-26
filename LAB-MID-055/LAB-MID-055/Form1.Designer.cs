namespace LAB_MID_055
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            InputTextBox = new TextBox();
            ParseButton = new Button();
            button1 = new Button();
            ResultLabel = new Label();
            SuspendLayout();
            // 
            // InputTextBox
            // 
            InputTextBox.Location = new Point(276, 44);
            InputTextBox.Multiline = true;
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(199, 60);
            InputTextBox.TabIndex = 0;
            // 
            // ParseButton
            // 
            ParseButton.Location = new Point(324, 127);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(90, 42);
            ParseButton.TabIndex = 1;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = true;
            ParseButton.Click += ParseButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(324, 290);
            button1.Name = "button1";
            button1.Size = new Size(90, 38);
            button1.TabIndex = 2;
            button1.Text = "Q3";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Location = new Point(345, 222);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(49, 15);
            ResultLabel.TabIndex = 3;
            ResultLabel.Text = "RESULT";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ResultLabel);
            Controls.Add(button1);
            Controls.Add(ParseButton);
            Controls.Add(InputTextBox);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputTextBox;
        private Button ParseButton;
        private Button button1;
        private Label ResultLabel;
    }
}