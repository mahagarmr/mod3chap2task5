namespace mod3chap2task5
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
            searchWordTextBox = new TextBox();
            directoryPathTextBox = new TextBox();
            searchButton = new Button();
            resultListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // searchWordTextBox
            // 
            searchWordTextBox.Location = new Point(37, 74);
            searchWordTextBox.Name = "searchWordTextBox";
            searchWordTextBox.Size = new Size(100, 23);
            searchWordTextBox.TabIndex = 0;
            // 
            // directoryPathTextBox
            // 
            directoryPathTextBox.Location = new Point(213, 74);
            directoryPathTextBox.Name = "directoryPathTextBox";
            directoryPathTextBox.Size = new Size(100, 23);
            directoryPathTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(140, 135);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 2;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += SearchButton_Click;
            // 
            // resultListBox
            // 
            resultListBox.FormattingEnabled = true;
            resultListBox.ItemHeight = 15;
            resultListBox.Location = new Point(37, 197);
            resultListBox.Name = "resultListBox";
            resultListBox.Size = new Size(276, 229);
            resultListBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(213, 39);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 4;
            label1.Text = "Directory path";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 39);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 5;
            label2.Text = "Word to search";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(resultListBox);
            Controls.Add(searchButton);
            Controls.Add(directoryPathTextBox);
            Controls.Add(searchWordTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchWordTextBox;
        private TextBox directoryPathTextBox;
        private Button searchButton;
        private ListBox resultListBox;
        private Label label1;
        private Label label2;
    }
}