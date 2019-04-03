namespace CollegeRegistration
{
    partial class FacultyForm
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
            this.FacultyName_textbox = new System.Windows.Forms.TextBox();
            this.FacultyID_textbox = new System.Windows.Forms.TextBox();
            this.FacultyName_Label = new System.Windows.Forms.Label();
            this.FacultyPhoneNum_Label = new System.Windows.Forms.Label();
            this.Remove_Button = new System.Windows.Forms.Button();
            this.RemoveFaculty_Button = new System.Windows.Forms.Button();
            this.UpdateFaculty_Button = new System.Windows.Forms.Button();
            this.AddFaculty_Button = new System.Windows.Forms.Button();
            this.FacultyID_Label = new System.Windows.Forms.Label();
            this.FacultyPhone_textbox = new System.Windows.Forms.TextBox();
            this.Menu_groupBox = new System.Windows.Forms.GroupBox();
            this.viewData_button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Update_Button = new System.Windows.Forms.Button();
            this.Faculty_Data = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacultyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacultyPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SwitchTo_Enrollment = new System.Windows.Forms.Button();
            this.SwitchTo_Course = new System.Windows.Forms.Button();
            this.SwitchTo_Major = new System.Windows.Forms.Button();
            this.SwitchTo_Section = new System.Windows.Forms.Button();
            this.SwitchTo_Student = new System.Windows.Forms.Button();
            this.Exit_Program_Button = new System.Windows.Forms.Button();
            this.Menu_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Faculty_Data)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FacultyName_textbox
            // 
            this.FacultyName_textbox.Location = new System.Drawing.Point(311, 171);
            this.FacultyName_textbox.Name = "FacultyName_textbox";
            this.FacultyName_textbox.Size = new System.Drawing.Size(117, 20);
            this.FacultyName_textbox.TabIndex = 0;
            // 
            // FacultyID_textbox
            // 
            this.FacultyID_textbox.Location = new System.Drawing.Point(311, 121);
            this.FacultyID_textbox.Name = "FacultyID_textbox";
            this.FacultyID_textbox.Size = new System.Drawing.Size(117, 20);
            this.FacultyID_textbox.TabIndex = 1;
            // 
            // FacultyName_Label
            // 
            this.FacultyName_Label.AutoSize = true;
            this.FacultyName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultyName_Label.Location = new System.Drawing.Point(113, 169);
            this.FacultyName_Label.Name = "FacultyName_Label";
            this.FacultyName_Label.Size = new System.Drawing.Size(192, 20);
            this.FacultyName_Label.TabIndex = 2;
            this.FacultyName_Label.Text = "Faculty Member Name:";
            // 
            // FacultyPhoneNum_Label
            // 
            this.FacultyPhoneNum_Label.AutoSize = true;
            this.FacultyPhoneNum_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultyPhoneNum_Label.Location = new System.Drawing.Point(230, 219);
            this.FacultyPhoneNum_Label.Name = "FacultyPhoneNum_Label";
            this.FacultyPhoneNum_Label.Size = new System.Drawing.Size(75, 20);
            this.FacultyPhoneNum_Label.TabIndex = 3;
            this.FacultyPhoneNum_Label.Text = "Phone#:";
            // 
            // Remove_Button
            // 
            this.Remove_Button.Location = new System.Drawing.Point(527, 293);
            this.Remove_Button.Name = "Remove_Button";
            this.Remove_Button.Size = new System.Drawing.Size(117, 42);
            this.Remove_Button.TabIndex = 5;
            this.Remove_Button.Text = "Submit";
            this.Remove_Button.UseVisualStyleBackColor = true;
            this.Remove_Button.Click += new System.EventHandler(this.Remove_Button_Click);
            // 
            // RemoveFaculty_Button
            // 
            this.RemoveFaculty_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveFaculty_Button.Location = new System.Drawing.Point(181, 32);
            this.RemoveFaculty_Button.Name = "RemoveFaculty_Button";
            this.RemoveFaculty_Button.Size = new System.Drawing.Size(117, 42);
            this.RemoveFaculty_Button.TabIndex = 6;
            this.RemoveFaculty_Button.Text = "Remove Faculty Member";
            this.RemoveFaculty_Button.UseVisualStyleBackColor = true;
            this.RemoveFaculty_Button.Click += new System.EventHandler(this.RemoveFaculty_Button_Click);
            // 
            // UpdateFaculty_Button
            // 
            this.UpdateFaculty_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateFaculty_Button.Location = new System.Drawing.Point(343, 32);
            this.UpdateFaculty_Button.Name = "UpdateFaculty_Button";
            this.UpdateFaculty_Button.Size = new System.Drawing.Size(117, 42);
            this.UpdateFaculty_Button.TabIndex = 7;
            this.UpdateFaculty_Button.Text = "Update Faculty Member";
            this.UpdateFaculty_Button.UseVisualStyleBackColor = true;
            this.UpdateFaculty_Button.Click += new System.EventHandler(this.UpdateFaculty_Button_Click);
            // 
            // AddFaculty_Button
            // 
            this.AddFaculty_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFaculty_Button.Location = new System.Drawing.Point(18, 32);
            this.AddFaculty_Button.Name = "AddFaculty_Button";
            this.AddFaculty_Button.Size = new System.Drawing.Size(117, 42);
            this.AddFaculty_Button.TabIndex = 8;
            this.AddFaculty_Button.Text = "Add Faculty Member";
            this.AddFaculty_Button.UseVisualStyleBackColor = true;
            this.AddFaculty_Button.Click += new System.EventHandler(this.AddFaculty_Button_Click);
            // 
            // FacultyID_Label
            // 
            this.FacultyID_Label.AutoSize = true;
            this.FacultyID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultyID_Label.Location = new System.Drawing.Point(272, 119);
            this.FacultyID_Label.Name = "FacultyID_Label";
            this.FacultyID_Label.Size = new System.Drawing.Size(33, 20);
            this.FacultyID_Label.TabIndex = 9;
            this.FacultyID_Label.Text = "ID:";
            // 
            // FacultyPhone_textbox
            // 
            this.FacultyPhone_textbox.Location = new System.Drawing.Point(311, 221);
            this.FacultyPhone_textbox.Name = "FacultyPhone_textbox";
            this.FacultyPhone_textbox.Size = new System.Drawing.Size(117, 20);
            this.FacultyPhone_textbox.TabIndex = 10;
            // 
            // Menu_groupBox
            // 
            this.Menu_groupBox.Controls.Add(this.viewData_button);
            this.Menu_groupBox.Controls.Add(this.AddFaculty_Button);
            this.Menu_groupBox.Controls.Add(this.RemoveFaculty_Button);
            this.Menu_groupBox.Controls.Add(this.UpdateFaculty_Button);
            this.Menu_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_groupBox.Location = new System.Drawing.Point(116, 12);
            this.Menu_groupBox.Name = "Menu_groupBox";
            this.Menu_groupBox.Size = new System.Drawing.Size(672, 103);
            this.Menu_groupBox.TabIndex = 11;
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
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(527, 293);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(117, 42);
            this.Add_Button.TabIndex = 12;
            this.Add_Button.Text = "Submit";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Update_Button
            // 
            this.Update_Button.Location = new System.Drawing.Point(527, 293);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(117, 42);
            this.Update_Button.TabIndex = 13;
            this.Update_Button.Text = "Submit";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // Faculty_Data
            // 
            this.Faculty_Data.AllowUserToDeleteRows = false;
            this.Faculty_Data.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Faculty_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Faculty_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.FacultyName,
            this.FacultyPhone});
            this.Faculty_Data.Location = new System.Drawing.Point(117, 121);
            this.Faculty_Data.Name = "Faculty_Data";
            this.Faculty_Data.ReadOnly = true;
            this.Faculty_Data.Size = new System.Drawing.Size(672, 226);
            this.Faculty_Data.TabIndex = 15;
            // 
            // StudentID
            // 
            this.StudentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentID.DataPropertyName = "Id";
            this.StudentID.HeaderText = "Faculty ID";
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            // 
            // FacultyName
            // 
            this.FacultyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FacultyName.DataPropertyName = "Name";
            this.FacultyName.HeaderText = "Faculty Name";
            this.FacultyName.Name = "FacultyName";
            this.FacultyName.ReadOnly = true;
            // 
            // FacultyPhone
            // 
            this.FacultyPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FacultyPhone.DataPropertyName = "PhoneNumber";
            this.FacultyPhone.HeaderText = "Faculty Phone";
            this.FacultyPhone.Name = "FacultyPhone";
            this.FacultyPhone.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Exit_Program_Button);
            this.groupBox1.Controls.Add(this.SwitchTo_Enrollment);
            this.groupBox1.Controls.Add(this.SwitchTo_Course);
            this.groupBox1.Controls.Add(this.SwitchTo_Major);
            this.groupBox1.Controls.Add(this.SwitchTo_Section);
            this.groupBox1.Controls.Add(this.SwitchTo_Student);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 388);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // SwitchTo_Enrollment
            // 
            this.SwitchTo_Enrollment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwitchTo_Enrollment.Location = new System.Drawing.Point(6, 270);
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
            // SwitchTo_Student
            // 
            this.SwitchTo_Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwitchTo_Student.Location = new System.Drawing.Point(5, 32);
            this.SwitchTo_Student.Name = "SwitchTo_Student";
            this.SwitchTo_Student.Size = new System.Drawing.Size(93, 42);
            this.SwitchTo_Student.TabIndex = 9;
            this.SwitchTo_Student.Text = "Student";
            this.SwitchTo_Student.UseVisualStyleBackColor = true;
            this.SwitchTo_Student.Click += new System.EventHandler(this.SwitchTo_Student_Click);
            // 
            // Exit_Program_Button
            // 
            this.Exit_Program_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Program_Button.Location = new System.Drawing.Point(5, 327);
            this.Exit_Program_Button.Name = "Exit_Program_Button";
            this.Exit_Program_Button.Size = new System.Drawing.Size(93, 42);
            this.Exit_Program_Button.TabIndex = 15;
            this.Exit_Program_Button.Text = "Exit Program";
            this.Exit_Program_Button.UseVisualStyleBackColor = true;
            this.Exit_Program_Button.Click += new System.EventHandler(this.Exit_Program_Button_Click);
            // 
            // FacultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Faculty_Data);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Menu_groupBox);
            this.Controls.Add(this.FacultyPhone_textbox);
            this.Controls.Add(this.FacultyID_Label);
            this.Controls.Add(this.Remove_Button);
            this.Controls.Add(this.FacultyPhoneNum_Label);
            this.Controls.Add(this.FacultyName_Label);
            this.Controls.Add(this.FacultyID_textbox);
            this.Controls.Add(this.FacultyName_textbox);
            this.Name = "FacultyForm";
            this.Text = "FacultyForm";
            this.Load += new System.EventHandler(this.FacultyForm_Load);
            this.Menu_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Faculty_Data)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FacultyName_textbox;
        private System.Windows.Forms.TextBox FacultyID_textbox;
        private System.Windows.Forms.Label FacultyName_Label;
        private System.Windows.Forms.Label FacultyPhoneNum_Label;
        private System.Windows.Forms.Button Remove_Button;
        private System.Windows.Forms.Button RemoveFaculty_Button;
        private System.Windows.Forms.Button UpdateFaculty_Button;
        private System.Windows.Forms.Button AddFaculty_Button;
        private System.Windows.Forms.Label FacultyID_Label;
        private System.Windows.Forms.TextBox FacultyPhone_textbox;
        private System.Windows.Forms.GroupBox Menu_groupBox;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.Button viewData_button;
        private System.Windows.Forms.DataGridView Faculty_Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacultyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacultyPhone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SwitchTo_Enrollment;
        private System.Windows.Forms.Button SwitchTo_Course;
        private System.Windows.Forms.Button SwitchTo_Major;
        private System.Windows.Forms.Button SwitchTo_Section;
        private System.Windows.Forms.Button SwitchTo_Student;
        private System.Windows.Forms.Button Exit_Program_Button;
    }
}