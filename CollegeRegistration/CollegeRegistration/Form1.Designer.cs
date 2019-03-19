namespace CollegeRegistration
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.studentsList = new System.Windows.Forms.ListBox();
            this.majorsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.majorNameTextBox = new System.Windows.Forms.TextBox();
            this.ericsClassesLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 57);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 0;
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(242, 54);
            this.addStudentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(102, 44);
            this.addStudentButton.TabIndex = 1;
            this.addStudentButton.Text = "Add Student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Name";
            // 
            // studentsList
            // 
            this.studentsList.FormattingEnabled = true;
            this.studentsList.Location = new System.Drawing.Point(24, 101);
            this.studentsList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.studentsList.Name = "studentsList";
            this.studentsList.Size = new System.Drawing.Size(251, 173);
            this.studentsList.TabIndex = 3;
            // 
            // majorsListBox
            // 
            this.majorsListBox.FormattingEnabled = true;
            this.majorsListBox.Location = new System.Drawing.Point(442, 103);
            this.majorsListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.majorsListBox.Name = "majorsListBox";
            this.majorsListBox.Size = new System.Drawing.Size(251, 173);
            this.majorsListBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Major Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(660, 57);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add Major";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // majorNameTextBox
            // 
            this.majorNameTextBox.Location = new System.Drawing.Point(512, 57);
            this.majorNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.majorNameTextBox.Name = "majorNameTextBox";
            this.majorNameTextBox.Size = new System.Drawing.Size(140, 20);
            this.majorNameTextBox.TabIndex = 4;
            // 
            // ericsClassesLabel
            // 
            this.ericsClassesLabel.AutoSize = true;
            this.ericsClassesLabel.Location = new System.Drawing.Point(309, 389);
            this.ericsClassesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ericsClassesLabel.Name = "ericsClassesLabel";
            this.ericsClassesLabel.Size = new System.Drawing.Size(74, 13);
            this.ericsClassesLabel.TabIndex = 8;
            this.ericsClassesLabel.Text = "Eric\'s Classes:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(778, 428);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 69);
            this.button2.TabIndex = 9;
            this.button2.Text = "Sections";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 552);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ericsClassesLabel);
            this.Controls.Add(this.majorsListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.majorNameTextBox);
            this.Controls.Add(this.studentsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox studentsList;
        private System.Windows.Forms.ListBox majorsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox majorNameTextBox;
        private System.Windows.Forms.Label ericsClassesLabel;
        private System.Windows.Forms.Button button2;
    }
}

