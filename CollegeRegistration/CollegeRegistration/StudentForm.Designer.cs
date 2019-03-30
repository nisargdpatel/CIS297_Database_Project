namespace CollegeRegistration
{
    partial class StudentForm
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
            this.Menu_groupBox = new System.Windows.Forms.GroupBox();
            this.viewData_button = new System.Windows.Forms.Button();
            this.AddStudent_Button = new System.Windows.Forms.Button();
            this.RemoveStudent_Button = new System.Windows.Forms.Button();
            this.UpdateStudent_Button = new System.Windows.Forms.Button();
            this.StudentID_Label = new System.Windows.Forms.Label();
            this.StudentName_Label = new System.Windows.Forms.Label();
            this.StudentID_textbox = new System.Windows.Forms.TextBox();
            this.StudentName_textbox = new System.Windows.Forms.TextBox();
            this.Student_Data = new System.Windows.Forms.DataGridView();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentMajor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Majors_List = new System.Windows.Forms.ListBox();
            this.Update_Button = new System.Windows.Forms.Button();
            this.Remove_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Sort_by_Major = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SwitchTo_Enrollment = new System.Windows.Forms.Button();
            this.SwitchTo_Course = new System.Windows.Forms.Button();
            this.SwitchTo_Major = new System.Windows.Forms.Button();
            this.SwitchTo_Section = new System.Windows.Forms.Button();
            this.SwitchTo_Faculty = new System.Windows.Forms.Button();
            this.Filter_by_Major = new System.Windows.Forms.Button();
            this.Exit_Program_Button = new System.Windows.Forms.Button();
            this.Menu_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Student_Data)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_groupBox
            // 
            this.Menu_groupBox.Controls.Add(this.viewData_button);
            this.Menu_groupBox.Controls.Add(this.AddStudent_Button);
            this.Menu_groupBox.Controls.Add(this.RemoveStudent_Button);
            this.Menu_groupBox.Controls.Add(this.UpdateStudent_Button);
            this.Menu_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_groupBox.Location = new System.Drawing.Point(116, 12);
            this.Menu_groupBox.Name = "Menu_groupBox";
            this.Menu_groupBox.Size = new System.Drawing.Size(672, 103);
            this.Menu_groupBox.TabIndex = 13;
            this.Menu_groupBox.TabStop = false;
            this.Menu_groupBox.Text = "Options";
            // 
            // viewData_button
            // 
            this.viewData_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewData_button.Location = new System.Drawing.Point(508, 32);
            this.viewData_button.Name = "viewData_button";
            this.viewData_button.Size = new System.Drawing.Size(117, 42);
            this.viewData_button.TabIndex = 14;
            this.viewData_button.Text = "View Data";
            this.viewData_button.UseVisualStyleBackColor = true;
            this.viewData_button.Click += new System.EventHandler(this.viewData_button_Click);
            // 
            // AddStudent_Button
            // 
            this.AddStudent_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudent_Button.Location = new System.Drawing.Point(18, 32);
            this.AddStudent_Button.Name = "AddStudent_Button";
            this.AddStudent_Button.Size = new System.Drawing.Size(117, 42);
            this.AddStudent_Button.TabIndex = 8;
            this.AddStudent_Button.Text = "Add Student";
            this.AddStudent_Button.UseVisualStyleBackColor = true;
            this.AddStudent_Button.Click += new System.EventHandler(this.AddStudent_Button_Click);
            // 
            // RemoveStudent_Button
            // 
            this.RemoveStudent_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveStudent_Button.Location = new System.Drawing.Point(181, 32);
            this.RemoveStudent_Button.Name = "RemoveStudent_Button";
            this.RemoveStudent_Button.Size = new System.Drawing.Size(117, 42);
            this.RemoveStudent_Button.TabIndex = 6;
            this.RemoveStudent_Button.Text = "Remove Student";
            this.RemoveStudent_Button.UseVisualStyleBackColor = true;
            this.RemoveStudent_Button.Click += new System.EventHandler(this.RemoveStudent_Button_Click);
            // 
            // UpdateStudent_Button
            // 
            this.UpdateStudent_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateStudent_Button.Location = new System.Drawing.Point(343, 32);
            this.UpdateStudent_Button.Name = "UpdateStudent_Button";
            this.UpdateStudent_Button.Size = new System.Drawing.Size(117, 42);
            this.UpdateStudent_Button.TabIndex = 7;
            this.UpdateStudent_Button.Text = "Update Student";
            this.UpdateStudent_Button.UseVisualStyleBackColor = true;
            this.UpdateStudent_Button.Click += new System.EventHandler(this.UpdateStudent_Button_Click);
            // 
            // StudentID_Label
            // 
            this.StudentID_Label.AutoSize = true;
            this.StudentID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentID_Label.Location = new System.Drawing.Point(258, 132);
            this.StudentID_Label.Name = "StudentID_Label";
            this.StudentID_Label.Size = new System.Drawing.Size(33, 20);
            this.StudentID_Label.TabIndex = 24;
            this.StudentID_Label.Text = "ID:";
            // 
            // StudentName_Label
            // 
            this.StudentName_Label.AutoSize = true;
            this.StudentName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentName_Label.Location = new System.Drawing.Point(162, 184);
            this.StudentName_Label.Name = "StudentName_Label";
            this.StudentName_Label.Size = new System.Drawing.Size(129, 20);
            this.StudentName_Label.TabIndex = 23;
            this.StudentName_Label.Text = "Student Name:";
            // 
            // StudentID_textbox
            // 
            this.StudentID_textbox.Location = new System.Drawing.Point(297, 134);
            this.StudentID_textbox.Name = "StudentID_textbox";
            this.StudentID_textbox.Size = new System.Drawing.Size(117, 20);
            this.StudentID_textbox.TabIndex = 22;
            // 
            // StudentName_textbox
            // 
            this.StudentName_textbox.Location = new System.Drawing.Point(297, 184);
            this.StudentName_textbox.Name = "StudentName_textbox";
            this.StudentName_textbox.Size = new System.Drawing.Size(117, 20);
            this.StudentName_textbox.TabIndex = 21;
            // 
            // Student_Data
            // 
            this.Student_Data.AllowUserToDeleteRows = false;
            this.Student_Data.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Student_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Student_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.StudentName,
            this.StudentMajor});
            this.Student_Data.Location = new System.Drawing.Point(116, 122);
            this.Student_Data.Name = "Student_Data";
            this.Student_Data.ReadOnly = true;
            this.Student_Data.Size = new System.Drawing.Size(412, 230);
            this.Student_Data.TabIndex = 26;
            // 
            // StudentId
            // 
            this.StudentId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentId.DataPropertyName = "Id";
            this.StudentId.HeaderText = "Student ID";
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            // 
            // StudentName
            // 
            this.StudentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentName.DataPropertyName = "Name";
            this.StudentName.HeaderText = "Name";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // StudentMajor
            // 
            this.StudentMajor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentMajor.DataPropertyName = "BetterDisplay";
            this.StudentMajor.HeaderText = "Student Major";
            this.StudentMajor.Name = "StudentMajor";
            this.StudentMajor.ReadOnly = true;
            // 
            // Majors_List
            // 
            this.Majors_List.FormattingEnabled = true;
            this.Majors_List.Location = new System.Drawing.Point(645, 121);
            this.Majors_List.Name = "Majors_List";
            this.Majors_List.Size = new System.Drawing.Size(143, 199);
            this.Majors_List.TabIndex = 27;
            // 
            // Update_Button
            // 
            this.Update_Button.Location = new System.Drawing.Point(534, 353);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(117, 42);
            this.Update_Button.TabIndex = 28;
            this.Update_Button.Text = "Submit";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // Remove_Button
            // 
            this.Remove_Button.Location = new System.Drawing.Point(534, 353);
            this.Remove_Button.Name = "Remove_Button";
            this.Remove_Button.Size = new System.Drawing.Size(117, 42);
            this.Remove_Button.TabIndex = 29;
            this.Remove_Button.Text = "Submit";
            this.Remove_Button.UseVisualStyleBackColor = true;
            this.Remove_Button.Click += new System.EventHandler(this.Remove_Button_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(534, 353);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(117, 42);
            this.Add_Button.TabIndex = 30;
            this.Add_Button.Text = "Submit";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Sort_by_Major
            // 
            this.Sort_by_Major.Location = new System.Drawing.Point(372, 376);
            this.Sort_by_Major.Name = "Sort_by_Major";
            this.Sort_by_Major.Size = new System.Drawing.Size(117, 42);
            this.Sort_by_Major.TabIndex = 31;
            this.Sort_by_Major.Text = "Sort by Major";
            this.Sort_by_Major.UseVisualStyleBackColor = true;
            this.Sort_by_Major.Click += new System.EventHandler(this.Sort_by_Major_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Exit_Program_Button);
            this.groupBox1.Controls.Add(this.SwitchTo_Enrollment);
            this.groupBox1.Controls.Add(this.SwitchTo_Course);
            this.groupBox1.Controls.Add(this.SwitchTo_Major);
            this.groupBox1.Controls.Add(this.SwitchTo_Section);
            this.groupBox1.Controls.Add(this.SwitchTo_Faculty);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 383);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // SwitchTo_Enrollment
            // 
            this.SwitchTo_Enrollment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwitchTo_Enrollment.Location = new System.Drawing.Point(5, 266);
            this.SwitchTo_Enrollment.Name = "SwitchTo_Enrollment";
            this.SwitchTo_Enrollment.Size = new System.Drawing.Size(93, 42);
            this.SwitchTo_Enrollment.TabIndex = 13;
            this.SwitchTo_Enrollment.Text = "Enrollment";
            this.SwitchTo_Enrollment.UseVisualStyleBackColor = true;
            this.SwitchTo_Enrollment.Click += new System.EventHandler(this.SwitchTo_Enrollment_Click);
            // 
            // SwitchTo_Course
            // 
            this.SwitchTo_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwitchTo_Course.Location = new System.Drawing.Point(6, 212);
            this.SwitchTo_Course.Name = "SwitchTo_Course";
            this.SwitchTo_Course.Size = new System.Drawing.Size(93, 42);
            this.SwitchTo_Course.TabIndex = 12;
            this.SwitchTo_Course.Text = "Course";
            this.SwitchTo_Course.UseVisualStyleBackColor = true;
            this.SwitchTo_Course.Click += new System.EventHandler(this.SwitchTo_Course_Click);
            // 
            // SwitchTo_Major
            // 
            this.SwitchTo_Major.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwitchTo_Major.Location = new System.Drawing.Point(5, 89);
            this.SwitchTo_Major.Name = "SwitchTo_Major";
            this.SwitchTo_Major.Size = new System.Drawing.Size(93, 42);
            this.SwitchTo_Major.TabIndex = 11;
            this.SwitchTo_Major.Text = "Major";
            this.SwitchTo_Major.UseVisualStyleBackColor = true;
            this.SwitchTo_Major.Click += new System.EventHandler(this.SwitchTo_Major_Click);
            // 
            // SwitchTo_Section
            // 
            this.SwitchTo_Section.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwitchTo_Section.Location = new System.Drawing.Point(5, 150);
            this.SwitchTo_Section.Name = "SwitchTo_Section";
            this.SwitchTo_Section.Size = new System.Drawing.Size(93, 42);
            this.SwitchTo_Section.TabIndex = 10;
            this.SwitchTo_Section.Text = "Section";
            this.SwitchTo_Section.UseVisualStyleBackColor = true;
            this.SwitchTo_Section.Click += new System.EventHandler(this.SwitchTo_Section_Click);
            // 
            // SwitchTo_Faculty
            // 
            this.SwitchTo_Faculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwitchTo_Faculty.Location = new System.Drawing.Point(5, 32);
            this.SwitchTo_Faculty.Name = "SwitchTo_Faculty";
            this.SwitchTo_Faculty.Size = new System.Drawing.Size(93, 42);
            this.SwitchTo_Faculty.TabIndex = 9;
            this.SwitchTo_Faculty.Text = "Faculty";
            this.SwitchTo_Faculty.UseVisualStyleBackColor = true;
            this.SwitchTo_Faculty.Click += new System.EventHandler(this.SwitchTo_Faculty_Click);
            // 
            // Filter_by_Major
            // 
            this.Filter_by_Major.Location = new System.Drawing.Point(196, 376);
            this.Filter_by_Major.Name = "Filter_by_Major";
            this.Filter_by_Major.Size = new System.Drawing.Size(117, 42);
            this.Filter_by_Major.TabIndex = 33;
            this.Filter_by_Major.Text = "Filter by Major";
            this.Filter_by_Major.UseVisualStyleBackColor = true;
            this.Filter_by_Major.Click += new System.EventHandler(this.Filter_by_Major_Click);
            // 
            // Exit_Program_Button
            // 
            this.Exit_Program_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Program_Button.Location = new System.Drawing.Point(5, 327);
            this.Exit_Program_Button.Name = "Exit_Program_Button";
            this.Exit_Program_Button.Size = new System.Drawing.Size(93, 42);
            this.Exit_Program_Button.TabIndex = 14;
            this.Exit_Program_Button.Text = "Exit Program";
            this.Exit_Program_Button.UseVisualStyleBackColor = true;
            this.Exit_Program_Button.Click += new System.EventHandler(this.Exit_Program_Button_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Filter_by_Major);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Sort_by_Major);
            this.Controls.Add(this.Student_Data);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Remove_Button);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.Majors_List);
            this.Controls.Add(this.StudentID_Label);
            this.Controls.Add(this.StudentName_Label);
            this.Controls.Add(this.StudentID_textbox);
            this.Controls.Add(this.StudentName_textbox);
            this.Controls.Add(this.Menu_groupBox);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Menu_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Student_Data)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Menu_groupBox;
        private System.Windows.Forms.Button viewData_button;
        private System.Windows.Forms.Button AddStudent_Button;
        private System.Windows.Forms.Button RemoveStudent_Button;
        private System.Windows.Forms.Button UpdateStudent_Button;
        private System.Windows.Forms.Label StudentID_Label;
        private System.Windows.Forms.Label StudentName_Label;
        private System.Windows.Forms.TextBox StudentID_textbox;
        private System.Windows.Forms.TextBox StudentName_textbox;
        private System.Windows.Forms.DataGridView Student_Data;
        private System.Windows.Forms.ListBox Majors_List;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.Button Remove_Button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Sort_by_Major;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SwitchTo_Enrollment;
        private System.Windows.Forms.Button SwitchTo_Course;
        private System.Windows.Forms.Button SwitchTo_Major;
        private System.Windows.Forms.Button SwitchTo_Section;
        private System.Windows.Forms.Button SwitchTo_Faculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentMajor;
        private System.Windows.Forms.Button Filter_by_Major;
        private System.Windows.Forms.Button Exit_Program_Button;
    }
}