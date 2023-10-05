namespace LAB_06
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
            calculateFirstSetButton = new Button();
            inputTextBox = new TextBox();
            firstSetsTextBox = new TextBox();
            SuspendLayout();
            // 
            // calculateFirstSetButton
            // 
            calculateFirstSetButton.Location = new Point(285, 154);
            calculateFirstSetButton.Name = "calculateFirstSetButton";
            calculateFirstSetButton.Size = new Size(219, 52);
            calculateFirstSetButton.TabIndex = 0;
            calculateFirstSetButton.Text = "calculateFirstSetButton";
            calculateFirstSetButton.UseVisualStyleBackColor = true;
            calculateFirstSetButton.Click += calculateFirstSetButton_Click;
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(285, 16);
            inputTextBox.Multiline = true;
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(216, 132);
            inputTextBox.TabIndex = 1;
            // 
            // firstSetsTextBox
            // 
            firstSetsTextBox.Location = new Point(285, 212);
            firstSetsTextBox.Multiline = true;
            firstSetsTextBox.Name = "firstSetsTextBox";
            firstSetsTextBox.Size = new Size(216, 132);
            firstSetsTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(firstSetsTextBox);
            Controls.Add(inputTextBox);
            Controls.Add(calculateFirstSetButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calculateFirstSetButton;
        private TextBox inputTextBox;
        private TextBox firstSetsTextBox;
    }
}