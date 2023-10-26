namespace LAB_MID_055
{
    partial class Q3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            firstNameTextBox = new TextBox();
            registrationNumberTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            passwordLabel = new Label();
            generateButton = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(180, 49);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(100, 23);
            firstNameTextBox.TabIndex = 0;
            // 
            // registrationNumberTextBox
            // 
            registrationNumberTextBox.Location = new Point(514, 130);
            registrationNumberTextBox.Name = "registrationNumberTextBox";
            registrationNumberTextBox.Size = new Size(100, 23);
            registrationNumberTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(345, 84);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(100, 23);
            lastNameTextBox.TabIndex = 2;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(180, 218);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(68, 15);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "PASSWORD";
            // 
            // generateButton
            // 
            generateButton.Location = new Point(46, 210);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(75, 23);
            generateButton.TabIndex = 4;
            generateButton.Text = "Generate";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 318);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(46, 52);
            label1.Name = "label1";
            label1.Size = new Size(85, 19);
            label1.TabIndex = 6;
            label1.Text = "First-Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(244, 88);
            label2.Name = "label2";
            label2.Size = new Size(84, 19);
            label2.TabIndex = 7;
            label2.Text = "Last-Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(374, 130);
            label3.Name = "label3";
            label3.Size = new Size(117, 19);
            label3.TabIndex = 8;
            label3.Text = "Registration-No";
            // 
            // Q3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(generateButton);
            Controls.Add(passwordLabel);
            Controls.Add(lastNameTextBox);
            Controls.Add(registrationNumberTextBox);
            Controls.Add(firstNameTextBox);
            Name = "Q3";
            Text = "Q3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNameTextBox;
        private TextBox registrationNumberTextBox;
        private TextBox lastNameTextBox;
        private Label passwordLabel;
        private Button generateButton;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}