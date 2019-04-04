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
            this.addStudentButton = new System.Windows.Forms.Button();
            this.studentsList = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.TableSelector = new System.Windows.Forms.ComboBox();
            this.TableSelector2 = new System.Windows.Forms.ComboBox();
            this.EntrySelector = new System.Windows.Forms.ComboBox();
            this.sortedListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(267, 103);
            this.addStudentButton.Margin = new System.Windows.Forms.Padding(2);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(102, 44);
            this.addStudentButton.TabIndex = 1;
            this.addStudentButton.Text = "Show Stuff";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // studentsList
            // 
            this.studentsList.FormattingEnabled = true;
            this.studentsList.Location = new System.Drawing.Point(12, 40);
            this.studentsList.Margin = new System.Windows.Forms.Padding(2);
            this.studentsList.Name = "studentsList";
            this.studentsList.Size = new System.Drawing.Size(251, 173);
            this.studentsList.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Edit Student";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(688, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(93, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Edit Section";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(174, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "Edit Major";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(255, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 14;
            this.button7.Text = "Edit Faculty";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(336, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(88, 23);
            this.button8.TabIndex = 15;
            this.button8.Text = "Edit Enrollment";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(430, 12);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(88, 23);
            this.button9.TabIndex = 16;
            this.button9.Text = "Edit Course";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // TableSelector
            // 
            this.TableSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TableSelector.FormattingEnabled = true;
            this.TableSelector.Location = new System.Drawing.Point(268, 77);
            this.TableSelector.Name = "TableSelector";
            this.TableSelector.Size = new System.Drawing.Size(121, 21);
            this.TableSelector.TabIndex = 17;
            // 
            // TableSelector2
            // 
            this.TableSelector2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TableSelector2.FormattingEnabled = true;
            this.TableSelector2.Location = new System.Drawing.Point(12, 313);
            this.TableSelector2.Name = "TableSelector2";
            this.TableSelector2.Size = new System.Drawing.Size(121, 21);
            this.TableSelector2.TabIndex = 18;
            this.TableSelector2.SelectedIndexChanged += new System.EventHandler(this.TableSelector2_SelectedIndexChanged);
            // 
            // EntrySelector
            // 
            this.EntrySelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EntrySelector.FormattingEnabled = true;
            this.EntrySelector.Location = new System.Drawing.Point(142, 313);
            this.EntrySelector.Name = "EntrySelector";
            this.EntrySelector.Size = new System.Drawing.Size(121, 21);
            this.EntrySelector.TabIndex = 19;
            this.EntrySelector.SelectedIndexChanged += new System.EventHandler(this.EntrySelector_SelectedIndexChanged);
            // 
            // sortedListBox
            // 
            this.sortedListBox.FormattingEnabled = true;
            this.sortedListBox.Location = new System.Drawing.Point(268, 313);
            this.sortedListBox.Margin = new System.Windows.Forms.Padding(2);
            this.sortedListBox.Name = "sortedListBox";
            this.sortedListBox.Size = new System.Drawing.Size(251, 173);
            this.sortedListBox.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 552);
            this.Controls.Add(this.sortedListBox);
            this.Controls.Add(this.EntrySelector);
            this.Controls.Add(this.TableSelector2);
            this.Controls.Add(this.TableSelector);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.studentsList);
            this.Controls.Add(this.addStudentButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.ListBox studentsList;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ComboBox TableSelector;
        private System.Windows.Forms.ComboBox TableSelector2;
        private System.Windows.Forms.ComboBox EntrySelector;
        private System.Windows.Forms.ListBox sortedListBox;
    }
}

