namespace CollegeRegistration
{
    partial class EnrollmentForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ViewButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SectionIDLabel = new System.Windows.Forms.Label();
            this.StudentIDLabel = new System.Windows.Forms.Label();
            this.GradeLabel = new System.Windows.Forms.Label();
            this.SectionIDtextBox = new System.Windows.Forms.TextBox();
            this.StudentIDtextBox = new System.Windows.Forms.TextBox();
            this.GradetextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.EnrollmentListBox = new System.Windows.Forms.ListBox();
            this.SwitchFormToMajorButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DeleteInfoLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Switch_To_Student_Button = new System.Windows.Forms.Button();
            this.Switch_To_Course_Button = new System.Windows.Forms.Button();
            this.Switch_To_Faculty_Button = new System.Windows.Forms.Button();
            this.Switch_To_Section_Button = new System.Windows.Forms.Button();
            this.EXIT_PROGRAM_BUTTON = new System.Windows.Forms.Button();
            this.UpdateDataButton = new System.Windows.Forms.Button();
            this.AddCorrectLetterLabel = new System.Windows.Forms.Label();
            this.EnrollmentIDLabel = new System.Windows.Forms.Label();
            this.EnrollmentIDtextBox = new System.Windows.Forms.TextBox();
            this.FilterStudentIDButton = new System.Windows.Forms.Button();
            this.FilterSemesterAndStudentButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.TabIndex = 1;
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
            this.UpdateButton.Text = "Update Enrollment";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(225, 37);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(90, 45);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove Enrollment";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(45, 37);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(90, 45);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add Enrollment";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SectionIDLabel
            // 
            this.SectionIDLabel.AutoSize = true;
            this.SectionIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionIDLabel.Location = new System.Drawing.Point(202, 292);
            this.SectionIDLabel.Name = "SectionIDLabel";
            this.SectionIDLabel.Size = new System.Drawing.Size(94, 20);
            this.SectionIDLabel.TabIndex = 2;
            this.SectionIDLabel.Text = "Section ID";
            // 
            // StudentIDLabel
            // 
            this.StudentIDLabel.AutoSize = true;
            this.StudentIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentIDLabel.Location = new System.Drawing.Point(202, 365);
            this.StudentIDLabel.Name = "StudentIDLabel";
            this.StudentIDLabel.Size = new System.Drawing.Size(97, 20);
            this.StudentIDLabel.TabIndex = 3;
            this.StudentIDLabel.Text = "Student ID";
            // 
            // GradeLabel
            // 
            this.GradeLabel.AutoSize = true;
            this.GradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradeLabel.Location = new System.Drawing.Point(202, 431);
            this.GradeLabel.Name = "GradeLabel";
            this.GradeLabel.Size = new System.Drawing.Size(59, 20);
            this.GradeLabel.TabIndex = 4;
            this.GradeLabel.Text = "Grade";
            // 
            // SectionIDtextBox
            // 
            this.SectionIDtextBox.Location = new System.Drawing.Point(376, 292);
            this.SectionIDtextBox.Name = "SectionIDtextBox";
            this.SectionIDtextBox.Size = new System.Drawing.Size(118, 20);
            this.SectionIDtextBox.TabIndex = 5;
            // 
            // StudentIDtextBox
            // 
            this.StudentIDtextBox.Location = new System.Drawing.Point(376, 365);
            this.StudentIDtextBox.Name = "StudentIDtextBox";
            this.StudentIDtextBox.Size = new System.Drawing.Size(118, 20);
            this.StudentIDtextBox.TabIndex = 6;
            // 
            // GradetextBox
            // 
            this.GradetextBox.Location = new System.Drawing.Point(376, 431);
            this.GradetextBox.Name = "GradetextBox";
            this.GradetextBox.Size = new System.Drawing.Size(118, 20);
            this.GradetextBox.TabIndex = 7;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(386, 513);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(90, 45);
            this.SubmitButton.TabIndex = 4;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // EnrollmentListBox
            // 
            this.EnrollmentListBox.FormattingEnabled = true;
            this.EnrollmentListBox.Location = new System.Drawing.Point(794, 225);
            this.EnrollmentListBox.Name = "EnrollmentListBox";
            this.EnrollmentListBox.Size = new System.Drawing.Size(570, 342);
            this.EnrollmentListBox.TabIndex = 8;
            // 
            // SwitchFormToMajorButton
            // 
            this.SwitchFormToMajorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwitchFormToMajorButton.Location = new System.Drawing.Point(6, 52);
            this.SwitchFormToMajorButton.Name = "SwitchFormToMajorButton";
            this.SwitchFormToMajorButton.Size = new System.Drawing.Size(90, 45);
            this.SwitchFormToMajorButton.TabIndex = 9;
            this.SwitchFormToMajorButton.Text = "Major";
            this.SwitchFormToMajorButton.UseVisualStyleBackColor = true;
            this.SwitchFormToMajorButton.Click += new System.EventHandler(this.SwitchFormToMajorButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(502, 513);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(90, 45);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeleteInfoLabel
            // 
            this.DeleteInfoLabel.AutoSize = true;
            this.DeleteInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteInfoLabel.Location = new System.Drawing.Point(202, 474);
            this.DeleteInfoLabel.Name = "DeleteInfoLabel";
            this.DeleteInfoLabel.Size = new System.Drawing.Size(540, 20);
            this.DeleteInfoLabel.TabIndex = 20;
            this.DeleteInfoLabel.Text = "Highlight the row you want to delete and then hit the delete button";
            this.DeleteInfoLabel.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Switch_To_Student_Button);
            this.groupBox2.Controls.Add(this.Switch_To_Course_Button);
            this.groupBox2.Controls.Add(this.Switch_To_Faculty_Button);
            this.groupBox2.Controls.Add(this.Switch_To_Section_Button);
            this.groupBox2.Controls.Add(this.SwitchFormToMajorButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(102, 378);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Change Forms";
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
            // EXIT_PROGRAM_BUTTON
            // 
            this.EXIT_PROGRAM_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT_PROGRAM_BUTTON.Location = new System.Drawing.Point(1264, 593);
            this.EXIT_PROGRAM_BUTTON.Name = "EXIT_PROGRAM_BUTTON";
            this.EXIT_PROGRAM_BUTTON.Size = new System.Drawing.Size(100, 47);
            this.EXIT_PROGRAM_BUTTON.TabIndex = 27;
            this.EXIT_PROGRAM_BUTTON.Text = "EXIT";
            this.EXIT_PROGRAM_BUTTON.UseVisualStyleBackColor = true;
            this.EXIT_PROGRAM_BUTTON.Click += new System.EventHandler(this.EXIT_PROGRAM_BUTTON_Click);
            // 
            // UpdateDataButton
            // 
            this.UpdateDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDataButton.Location = new System.Drawing.Point(269, 513);
            this.UpdateDataButton.Name = "UpdateDataButton";
            this.UpdateDataButton.Size = new System.Drawing.Size(90, 45);
            this.UpdateDataButton.TabIndex = 28;
            this.UpdateDataButton.Text = "Update";
            this.UpdateDataButton.UseVisualStyleBackColor = true;
            this.UpdateDataButton.Visible = false;
            this.UpdateDataButton.Click += new System.EventHandler(this.UpdateDataButton_Click);
            // 
            // AddCorrectLetterLabel
            // 
            this.AddCorrectLetterLabel.AutoSize = true;
            this.AddCorrectLetterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCorrectLetterLabel.Location = new System.Drawing.Point(202, 575);
            this.AddCorrectLetterLabel.Name = "AddCorrectLetterLabel";
            this.AddCorrectLetterLabel.Size = new System.Drawing.Size(593, 20);
            this.AddCorrectLetterLabel.TabIndex = 29;
            this.AddCorrectLetterLabel.Text = "If you want to enter an A then type \"A=\" and so on for other letter grades";
            this.AddCorrectLetterLabel.Visible = false;
            // 
            // EnrollmentIDLabel
            // 
            this.EnrollmentIDLabel.AutoSize = true;
            this.EnrollmentIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnrollmentIDLabel.Location = new System.Drawing.Point(202, 236);
            this.EnrollmentIDLabel.Name = "EnrollmentIDLabel";
            this.EnrollmentIDLabel.Size = new System.Drawing.Size(119, 20);
            this.EnrollmentIDLabel.TabIndex = 30;
            this.EnrollmentIDLabel.Text = "Enrollment ID";
            this.EnrollmentIDLabel.Visible = false;
            // 
            // EnrollmentIDtextBox
            // 
            this.EnrollmentIDtextBox.Location = new System.Drawing.Point(376, 238);
            this.EnrollmentIDtextBox.Name = "EnrollmentIDtextBox";
            this.EnrollmentIDtextBox.Size = new System.Drawing.Size(118, 20);
            this.EnrollmentIDtextBox.TabIndex = 31;
            this.EnrollmentIDtextBox.Visible = false;
            // 
            // FilterStudentIDButton
            // 
            this.FilterStudentIDButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterStudentIDButton.Location = new System.Drawing.Point(1096, 157);
            this.FilterStudentIDButton.Name = "FilterStudentIDButton";
            this.FilterStudentIDButton.Size = new System.Drawing.Size(90, 45);
            this.FilterStudentIDButton.TabIndex = 4;
            this.FilterStudentIDButton.Text = "Filter by StudentID";
            this.FilterStudentIDButton.UseVisualStyleBackColor = true;
            this.FilterStudentIDButton.Visible = false;
            this.FilterStudentIDButton.Click += new System.EventHandler(this.FilterStudentIDButton_Click);
            // 
            // FilterSemesterAndStudentButton
            // 
            this.FilterSemesterAndStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterSemesterAndStudentButton.Location = new System.Drawing.Point(966, 143);
            this.FilterSemesterAndStudentButton.Name = "FilterSemesterAndStudentButton";
            this.FilterSemesterAndStudentButton.Size = new System.Drawing.Size(90, 72);
            this.FilterSemesterAndStudentButton.TabIndex = 32;
            this.FilterSemesterAndStudentButton.Text = "Filter by Semester and StudentID";
            this.FilterSemesterAndStudentButton.UseVisualStyleBackColor = true;
            this.FilterSemesterAndStudentButton.Visible = false;
            this.FilterSemesterAndStudentButton.Click += new System.EventHandler(this.FilterSemesterAndStudentButton_Click);
            // 
            // EnrollmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 652);
            this.Controls.Add(this.FilterSemesterAndStudentButton);
            this.Controls.Add(this.FilterStudentIDButton);
            this.Controls.Add(this.EnrollmentIDtextBox);
            this.Controls.Add(this.EnrollmentIDLabel);
            this.Controls.Add(this.AddCorrectLetterLabel);
            this.Controls.Add(this.UpdateDataButton);
            this.Controls.Add(this.EXIT_PROGRAM_BUTTON);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DeleteInfoLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EnrollmentListBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.GradetextBox);
            this.Controls.Add(this.StudentIDtextBox);
            this.Controls.Add(this.SectionIDtextBox);
            this.Controls.Add(this.GradeLabel);
            this.Controls.Add(this.StudentIDLabel);
            this.Controls.Add(this.SectionIDLabel);
            this.Controls.Add(this.groupBox1);
            this.Name = "EnrollmentForm";
            this.Text = "EnrollmentForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label SectionIDLabel;
        private System.Windows.Forms.Label StudentIDLabel;
        private System.Windows.Forms.Label GradeLabel;
        private System.Windows.Forms.TextBox SectionIDtextBox;
        private System.Windows.Forms.TextBox StudentIDtextBox;
        private System.Windows.Forms.TextBox GradetextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.ListBox EnrollmentListBox;
        private System.Windows.Forms.Button SwitchFormToMajorButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label DeleteInfoLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Switch_To_Student_Button;
        private System.Windows.Forms.Button Switch_To_Course_Button;
        private System.Windows.Forms.Button Switch_To_Faculty_Button;
        private System.Windows.Forms.Button Switch_To_Section_Button;
        private System.Windows.Forms.Button EXIT_PROGRAM_BUTTON;
        private System.Windows.Forms.Button UpdateDataButton;
        private System.Windows.Forms.Label AddCorrectLetterLabel;
        private System.Windows.Forms.Label EnrollmentIDLabel;
        private System.Windows.Forms.TextBox EnrollmentIDtextBox;
        private System.Windows.Forms.Button FilterStudentIDButton;
        private System.Windows.Forms.Button FilterSemesterAndStudentButton;
    }
}