namespace CollegeRegistration
{
    partial class MajorForm
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
            this.MajorListBox = new System.Windows.Forms.ListBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CollegetextBox = new System.Windows.Forms.TextBox();
            this.MajorNametextBox = new System.Windows.Forms.TextBox();
            this.MajorIDtextBox = new System.Windows.Forms.TextBox();
            this.CollegeLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.MajorIDLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ViewButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DeleteInfoLabel = new System.Windows.Forms.Label();
            this.UpdateDataButton = new System.Windows.Forms.Button();
            this.Switch_to_Enrollment_Button = new System.Windows.Forms.Button();
            this.Switch_To_Course_Button = new System.Windows.Forms.Button();
            this.Switch_To_Section_Button = new System.Windows.Forms.Button();
            this.Switch_To_Faculty_Button = new System.Windows.Forms.Button();
            this.Switch_To_Student_Button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EXIT_PROGRAM_BUTTON = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MajorListBox
            // 
            this.MajorListBox.FormattingEnabled = true;
            this.MajorListBox.Location = new System.Drawing.Point(871, 260);
            this.MajorListBox.Name = "MajorListBox";
            this.MajorListBox.Size = new System.Drawing.Size(345, 251);
            this.MajorListBox.TabIndex = 17;
            this.MajorListBox.Visible = false;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(386, 513);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(90, 45);
            this.SubmitButton.TabIndex = 12;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CollegetextBox
            // 
            this.CollegetextBox.Location = new System.Drawing.Point(376, 431);
            this.CollegetextBox.Name = "CollegetextBox";
            this.CollegetextBox.Size = new System.Drawing.Size(118, 20);
            this.CollegetextBox.TabIndex = 16;
            // 
            // MajorNametextBox
            // 
            this.MajorNametextBox.Location = new System.Drawing.Point(376, 365);
            this.MajorNametextBox.Name = "MajorNametextBox";
            this.MajorNametextBox.Size = new System.Drawing.Size(118, 20);
            this.MajorNametextBox.TabIndex = 15;
            // 
            // MajorIDtextBox
            // 
            this.MajorIDtextBox.Location = new System.Drawing.Point(376, 292);
            this.MajorIDtextBox.Name = "MajorIDtextBox";
            this.MajorIDtextBox.Size = new System.Drawing.Size(118, 20);
            this.MajorIDtextBox.TabIndex = 14;
            // 
            // CollegeLabel
            // 
            this.CollegeLabel.AutoSize = true;
            this.CollegeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollegeLabel.Location = new System.Drawing.Point(202, 431);
            this.CollegeLabel.Name = "CollegeLabel";
            this.CollegeLabel.Size = new System.Drawing.Size(69, 20);
            this.CollegeLabel.TabIndex = 13;
            this.CollegeLabel.Text = "College";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(202, 365);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(60, 20);
            this.NameLabel.TabIndex = 11;
            this.NameLabel.Text = "Name ";
            // 
            // MajorIDLabel
            // 
            this.MajorIDLabel.AutoSize = true;
            this.MajorIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MajorIDLabel.Location = new System.Drawing.Point(202, 292);
            this.MajorIDLabel.Name = "MajorIDLabel";
            this.MajorIDLabel.Size = new System.Drawing.Size(77, 20);
            this.MajorIDLabel.TabIndex = 10;
            this.MajorIDLabel.Text = "Major ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ViewButton);
            this.groupBox1.Controls.Add(this.UpdateButton);
            this.groupBox1.Controls.Add(this.RemoveButton);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(161, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 120);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPTIONS";
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(590, 37);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(90, 45);
            this.ViewButton.TabIndex = 3;
            this.ViewButton.Text = "View Data";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(410, 37);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(90, 45);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.Text = "Update Major";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(225, 37);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(90, 45);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove Major";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(45, 37);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(90, 45);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add Major";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(502, 513);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(90, 45);
            this.DeleteButton.TabIndex = 18;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Visible = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeleteInfoLabel
            // 
            this.DeleteInfoLabel.AutoSize = true;
            this.DeleteInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteInfoLabel.Location = new System.Drawing.Point(202, 474);
            this.DeleteInfoLabel.Name = "DeleteInfoLabel";
            this.DeleteInfoLabel.Size = new System.Drawing.Size(540, 20);
            this.DeleteInfoLabel.TabIndex = 19;
            this.DeleteInfoLabel.Text = "Highlight the row you want to delete and then hit the delete button";
            this.DeleteInfoLabel.Visible = false;
            // 
            // UpdateDataButton
            // 
            this.UpdateDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDataButton.Location = new System.Drawing.Point(269, 513);
            this.UpdateDataButton.Name = "UpdateDataButton";
            this.UpdateDataButton.Size = new System.Drawing.Size(90, 45);
            this.UpdateDataButton.TabIndex = 4;
            this.UpdateDataButton.Text = "Update";
            this.UpdateDataButton.UseVisualStyleBackColor = true;
            this.UpdateDataButton.Visible = false;
            this.UpdateDataButton.Click += new System.EventHandler(this.UpdateDataButton_Click);
            // 
            // Switch_to_Enrollment_Button
            // 
            this.Switch_to_Enrollment_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Switch_to_Enrollment_Button.Location = new System.Drawing.Point(6, 52);
            this.Switch_to_Enrollment_Button.Name = "Switch_to_Enrollment_Button";
            this.Switch_to_Enrollment_Button.Size = new System.Drawing.Size(90, 45);
            this.Switch_to_Enrollment_Button.TabIndex = 20;
            this.Switch_to_Enrollment_Button.Text = "Enrollment";
            this.Switch_to_Enrollment_Button.UseVisualStyleBackColor = true;
            this.Switch_to_Enrollment_Button.Click += new System.EventHandler(this.Switch_to_Enrollment_Button_Click);
            // 
            // Switch_To_Course_Button
            // 
            this.Switch_To_Course_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Switch_To_Course_Button.Location = new System.Drawing.Point(6, 114);
            this.Switch_To_Course_Button.Name = "Switch_To_Course_Button";
            this.Switch_To_Course_Button.Size = new System.Drawing.Size(90, 45);
            this.Switch_To_Course_Button.TabIndex = 21;
            this.Switch_To_Course_Button.Text = "Course";
            this.Switch_To_Course_Button.UseVisualStyleBackColor = true;
            this.Switch_To_Course_Button.Click += new System.EventHandler(this.Switch_To_Course_Button_Click);
            // 
            // Switch_To_Section_Button
            // 
            this.Switch_To_Section_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Switch_To_Section_Button.Location = new System.Drawing.Point(6, 182);
            this.Switch_To_Section_Button.Name = "Switch_To_Section_Button";
            this.Switch_To_Section_Button.Size = new System.Drawing.Size(90, 45);
            this.Switch_To_Section_Button.TabIndex = 22;
            this.Switch_To_Section_Button.Text = "Section";
            this.Switch_To_Section_Button.UseVisualStyleBackColor = true;
            this.Switch_To_Section_Button.Click += new System.EventHandler(this.Switch_To_Section_Button_Click);
            // 
            // Switch_To_Faculty_Button
            // 
            this.Switch_To_Faculty_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Switch_To_Faculty_Button.Location = new System.Drawing.Point(6, 249);
            this.Switch_To_Faculty_Button.Name = "Switch_To_Faculty_Button";
            this.Switch_To_Faculty_Button.Size = new System.Drawing.Size(90, 45);
            this.Switch_To_Faculty_Button.TabIndex = 23;
            this.Switch_To_Faculty_Button.Text = "Faculty";
            this.Switch_To_Faculty_Button.UseVisualStyleBackColor = true;
            this.Switch_To_Faculty_Button.Click += new System.EventHandler(this.Switch_To_Faculty_Button_Click);
            // 
            // Switch_To_Student_Button
            // 
            this.Switch_To_Student_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Switch_To_Student_Button.Location = new System.Drawing.Point(6, 322);
            this.Switch_To_Student_Button.Name = "Switch_To_Student_Button";
            this.Switch_To_Student_Button.Size = new System.Drawing.Size(90, 45);
            this.Switch_To_Student_Button.TabIndex = 24;
            this.Switch_To_Student_Button.Text = "Student";
            this.Switch_To_Student_Button.UseVisualStyleBackColor = true;
            this.Switch_To_Student_Button.Click += new System.EventHandler(this.Switch_To_Student_Button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Switch_to_Enrollment_Button);
            this.groupBox2.Controls.Add(this.Switch_To_Student_Button);
            this.groupBox2.Controls.Add(this.Switch_To_Course_Button);
            this.groupBox2.Controls.Add(this.Switch_To_Faculty_Button);
            this.groupBox2.Controls.Add(this.Switch_To_Section_Button);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(102, 378);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Change Forms";
            // 
            // EXIT_PROGRAM_BUTTON
            // 
            this.EXIT_PROGRAM_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT_PROGRAM_BUTTON.Location = new System.Drawing.Point(1264, 593);
            this.EXIT_PROGRAM_BUTTON.Name = "EXIT_PROGRAM_BUTTON";
            this.EXIT_PROGRAM_BUTTON.Size = new System.Drawing.Size(100, 47);
            this.EXIT_PROGRAM_BUTTON.TabIndex = 26;
            this.EXIT_PROGRAM_BUTTON.Text = "EXIT";
            this.EXIT_PROGRAM_BUTTON.UseVisualStyleBackColor = true;
            this.EXIT_PROGRAM_BUTTON.Click += new System.EventHandler(this.EXIT_PROGRAM_BUTTON_Click);
            // 
            // MajorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 652);
            this.Controls.Add(this.EXIT_PROGRAM_BUTTON);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.UpdateDataButton);
            this.Controls.Add(this.DeleteInfoLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.MajorListBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.CollegetextBox);
            this.Controls.Add(this.MajorNametextBox);
            this.Controls.Add(this.MajorIDtextBox);
            this.Controls.Add(this.CollegeLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.MajorIDLabel);
            this.Controls.Add(this.groupBox1);
            this.Name = "MajorForm";
            this.Text = "MajorForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MajorListBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox CollegetextBox;
        private System.Windows.Forms.TextBox MajorNametextBox;
        private System.Windows.Forms.TextBox MajorIDtextBox;
        private System.Windows.Forms.Label CollegeLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label MajorIDLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label DeleteInfoLabel;
        private System.Windows.Forms.Button UpdateDataButton;
        private System.Windows.Forms.Button Switch_to_Enrollment_Button;
        private System.Windows.Forms.Button Switch_To_Course_Button;
        private System.Windows.Forms.Button Switch_To_Section_Button;
        private System.Windows.Forms.Button Switch_To_Faculty_Button;
        private System.Windows.Forms.Button Switch_To_Student_Button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button EXIT_PROGRAM_BUTTON;
    }
}