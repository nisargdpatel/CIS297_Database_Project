namespace CollegeRegistration
{
    partial class SectionForm
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
            this.viewListBox = new System.Windows.Forms.ListBox();
            this.warningLabel = new System.Windows.Forms.Label();
            this.openEnrollment = new System.Windows.Forms.Button();
            this.openMajor = new System.Windows.Forms.Button();
            this.openStudent = new System.Windows.Forms.Button();
            this.openFaculty = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.creditsLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.openCourse = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.crud = new System.Windows.Forms.GroupBox();
            this.sectionViewButton = new System.Windows.Forms.Button();
            this.sectionAddButton = new System.Windows.Forms.Button();
            this.sectionRemoveButton = new System.Windows.Forms.Button();
            this.sectionUpdateButton = new System.Windows.Forms.Button();
            this.sectionTime = new System.Windows.Forms.TextBox();
            this.sectionDay = new System.Windows.Forms.TextBox();
            this.facultyId = new System.Windows.Forms.TextBox();
            this.courseId = new System.Windows.Forms.TextBox();
            this.sectionId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sectionSemester = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.section_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.section_course_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.section_faculty_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.section_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.section_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.section_semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeButton = new System.Windows.Forms.Button();
            this.filterButton = new System.Windows.Forms.Button();
            this.crud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // viewListBox
            // 
            this.viewListBox.FormattingEnabled = true;
            this.viewListBox.Location = new System.Drawing.Point(136, 299);
            this.viewListBox.Name = "viewListBox";
            this.viewListBox.Size = new System.Drawing.Size(534, 134);
            this.viewListBox.TabIndex = 40;
            this.viewListBox.Visible = false;
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Location = new System.Drawing.Point(414, 311);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 13);
            this.warningLabel.TabIndex = 39;
            // 
            // openEnrollment
            // 
            this.openEnrollment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openEnrollment.Location = new System.Drawing.Point(11, 260);
            this.openEnrollment.Name = "openEnrollment";
            this.openEnrollment.Size = new System.Drawing.Size(100, 37);
            this.openEnrollment.TabIndex = 38;
            this.openEnrollment.Text = "Enrollment";
            this.openEnrollment.UseVisualStyleBackColor = true;
            this.openEnrollment.Click += new System.EventHandler(this.openEnrollment_Click);
            // 
            // openMajor
            // 
            this.openMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openMajor.Location = new System.Drawing.Point(11, 217);
            this.openMajor.Name = "openMajor";
            this.openMajor.Size = new System.Drawing.Size(100, 37);
            this.openMajor.TabIndex = 37;
            this.openMajor.Text = "Major";
            this.openMajor.UseVisualStyleBackColor = true;
            this.openMajor.Click += new System.EventHandler(this.openMajor_Click);
            // 
            // openStudent
            // 
            this.openStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openStudent.Location = new System.Drawing.Point(11, 174);
            this.openStudent.Name = "openStudent";
            this.openStudent.Size = new System.Drawing.Size(100, 37);
            this.openStudent.TabIndex = 36;
            this.openStudent.Text = "Students";
            this.openStudent.UseVisualStyleBackColor = true;
            this.openStudent.Click += new System.EventHandler(this.openStudent_Click);
            // 
            // openFaculty
            // 
            this.openFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFaculty.Location = new System.Drawing.Point(11, 131);
            this.openFaculty.Name = "openFaculty";
            this.openFaculty.Size = new System.Drawing.Size(100, 37);
            this.openFaculty.TabIndex = 35;
            this.openFaculty.Text = "Faculty";
            this.openFaculty.UseVisualStyleBackColor = true;
            this.openFaculty.Click += new System.EventHandler(this.openFaculty_Click);
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(136, 303);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(534, 42);
            this.submitButton.TabIndex = 34;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentLabel.Location = new System.Drawing.Point(201, 232);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(47, 20);
            this.departmentLabel.TabIndex = 33;
            this.departmentLabel.Text = "Time:";
            // 
            // creditsLabel
            // 
            this.creditsLabel.AutoSize = true;
            this.creditsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsLabel.Location = new System.Drawing.Point(207, 193);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(41, 20);
            this.creditsLabel.TabIndex = 32;
            this.creditsLabel.Text = "Day:";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.Location = new System.Drawing.Point(166, 157);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(82, 20);
            this.numberLabel.TabIndex = 31;
            this.numberLabel.Text = "Faculty Id:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(166, 121);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(82, 20);
            this.nameLabel.TabIndex = 30;
            this.nameLabel.Text = "Course Id:";
            // 
            // openCourse
            // 
            this.openCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openCourse.Location = new System.Drawing.Point(11, 88);
            this.openCourse.Name = "openCourse";
            this.openCourse.Size = new System.Drawing.Size(100, 37);
            this.openCourse.TabIndex = 27;
            this.openCourse.Text = "Course";
            this.openCourse.UseVisualStyleBackColor = true;
            this.openCourse.Click += new System.EventHandler(this.openCourse_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(163, 88);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(85, 20);
            this.idLabel.TabIndex = 29;
            this.idLabel.Text = "Section Id:";
            // 
            // crud
            // 
            this.crud.Controls.Add(this.sectionViewButton);
            this.crud.Controls.Add(this.sectionAddButton);
            this.crud.Controls.Add(this.sectionRemoveButton);
            this.crud.Controls.Add(this.sectionUpdateButton);
            this.crud.Location = new System.Drawing.Point(129, 12);
            this.crud.Name = "crud";
            this.crud.Size = new System.Drawing.Size(541, 63);
            this.crud.TabIndex = 28;
            this.crud.TabStop = false;
            this.crud.Text = "CRUD";
            // 
            // sectionViewButton
            // 
            this.sectionViewButton.Location = new System.Drawing.Point(424, 15);
            this.sectionViewButton.Name = "sectionViewButton";
            this.sectionViewButton.Size = new System.Drawing.Size(86, 37);
            this.sectionViewButton.TabIndex = 10;
            this.sectionViewButton.Text = "View Data";
            this.sectionViewButton.UseVisualStyleBackColor = true;
            this.sectionViewButton.Click += new System.EventHandler(this.sectionViewButton_Click);
            // 
            // sectionAddButton
            // 
            this.sectionAddButton.Location = new System.Drawing.Point(33, 15);
            this.sectionAddButton.Name = "sectionAddButton";
            this.sectionAddButton.Size = new System.Drawing.Size(86, 37);
            this.sectionAddButton.TabIndex = 5;
            this.sectionAddButton.Text = "Add Section";
            this.sectionAddButton.UseVisualStyleBackColor = true;
            this.sectionAddButton.Click += new System.EventHandler(this.sectionAddButton_Click);
            // 
            // sectionRemoveButton
            // 
            this.sectionRemoveButton.Location = new System.Drawing.Point(165, 15);
            this.sectionRemoveButton.Name = "sectionRemoveButton";
            this.sectionRemoveButton.Size = new System.Drawing.Size(86, 37);
            this.sectionRemoveButton.TabIndex = 7;
            this.sectionRemoveButton.Text = "Remove Section";
            this.sectionRemoveButton.UseVisualStyleBackColor = true;
            this.sectionRemoveButton.Click += new System.EventHandler(this.sectionRemoveButton_Click);
            // 
            // sectionUpdateButton
            // 
            this.sectionUpdateButton.Location = new System.Drawing.Point(292, 15);
            this.sectionUpdateButton.Name = "sectionUpdateButton";
            this.sectionUpdateButton.Size = new System.Drawing.Size(86, 37);
            this.sectionUpdateButton.TabIndex = 6;
            this.sectionUpdateButton.Text = "Update Section";
            this.sectionUpdateButton.UseVisualStyleBackColor = true;
            this.sectionUpdateButton.Click += new System.EventHandler(this.sectionUpdateButton_Click);
            // 
            // sectionTime
            // 
            this.sectionTime.Location = new System.Drawing.Point(294, 232);
            this.sectionTime.Name = "sectionTime";
            this.sectionTime.Size = new System.Drawing.Size(100, 20);
            this.sectionTime.TabIndex = 26;
            // 
            // sectionDay
            // 
            this.sectionDay.Location = new System.Drawing.Point(294, 193);
            this.sectionDay.Name = "sectionDay";
            this.sectionDay.Size = new System.Drawing.Size(100, 20);
            this.sectionDay.TabIndex = 25;
            // 
            // facultyId
            // 
            this.facultyId.Location = new System.Drawing.Point(294, 157);
            this.facultyId.Name = "facultyId";
            this.facultyId.Size = new System.Drawing.Size(100, 20);
            this.facultyId.TabIndex = 24;
            // 
            // courseId
            // 
            this.courseId.Location = new System.Drawing.Point(294, 121);
            this.courseId.Name = "courseId";
            this.courseId.Size = new System.Drawing.Size(100, 20);
            this.courseId.TabIndex = 23;
            // 
            // sectionId
            // 
            this.sectionId.Location = new System.Drawing.Point(294, 88);
            this.sectionId.Name = "sectionId";
            this.sectionId.Size = new System.Drawing.Size(100, 20);
            this.sectionId.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Semester:";
            // 
            // sectionSemester
            // 
            this.sectionSemester.Location = new System.Drawing.Point(294, 268);
            this.sectionSemester.Name = "sectionSemester";
            this.sectionSemester.Size = new System.Drawing.Size(100, 20);
            this.sectionSemester.TabIndex = 42;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.section_Id,
            this.section_course_Id,
            this.section_faculty_id,
            this.section_day,
            this.section_time,
            this.section_semester});
            this.dataGridView.Location = new System.Drawing.Point(136, 88);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(534, 205);
            this.dataGridView.TabIndex = 43;
            this.dataGridView.Visible = false;
            // 
            // section_Id
            // 
            this.section_Id.DataPropertyName = "Id";
            this.section_Id.HeaderText = "Id";
            this.section_Id.Name = "section_Id";
            this.section_Id.ReadOnly = true;
            // 
            // section_course_Id
            // 
            this.section_course_Id.DataPropertyName = "CourseID";
            this.section_course_Id.HeaderText = "Course Id";
            this.section_course_Id.Name = "section_course_Id";
            this.section_course_Id.ReadOnly = true;
            // 
            // section_faculty_id
            // 
            this.section_faculty_id.DataPropertyName = "FacultyID";
            this.section_faculty_id.HeaderText = "Faculty Id";
            this.section_faculty_id.Name = "section_faculty_id";
            this.section_faculty_id.ReadOnly = true;
            // 
            // section_day
            // 
            this.section_day.DataPropertyName = "Day";
            this.section_day.HeaderText = "Day";
            this.section_day.Name = "section_day";
            this.section_day.ReadOnly = true;
            // 
            // section_time
            // 
            this.section_time.DataPropertyName = "Time";
            this.section_time.HeaderText = "Time";
            this.section_time.Name = "section_time";
            this.section_time.ReadOnly = true;
            // 
            // section_semester
            // 
            this.section_semester.DataPropertyName = "Semester";
            this.section_semester.HeaderText = "Semester";
            this.section_semester.Name = "section_semester";
            this.section_semester.ReadOnly = true;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Red;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(11, 303);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 37);
            this.closeButton.TabIndex = 44;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(676, 88);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(86, 37);
            this.filterButton.TabIndex = 46;
            this.filterButton.Text = "Filter by Semester";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // SectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.sectionSemester);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewListBox);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.openEnrollment);
            this.Controls.Add(this.openMajor);
            this.Controls.Add(this.openStudent);
            this.Controls.Add(this.openFaculty);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.creditsLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.openCourse);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.crud);
            this.Controls.Add(this.sectionTime);
            this.Controls.Add(this.sectionDay);
            this.Controls.Add(this.facultyId);
            this.Controls.Add(this.courseId);
            this.Controls.Add(this.sectionId);
            this.Name = "SectionForm";
            this.Text = "Sections";
            this.crud.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

          #endregion

          private System.Windows.Forms.ListBox viewListBox;
          private System.Windows.Forms.Label warningLabel;
          private System.Windows.Forms.Button openEnrollment;
          private System.Windows.Forms.Button openMajor;
          private System.Windows.Forms.Button openStudent;
          private System.Windows.Forms.Button openFaculty;
          private System.Windows.Forms.Button submitButton;
          private System.Windows.Forms.Label departmentLabel;
          private System.Windows.Forms.Label creditsLabel;
          private System.Windows.Forms.Label numberLabel;
          private System.Windows.Forms.Label nameLabel;
          private System.Windows.Forms.Button openCourse;
          private System.Windows.Forms.Label idLabel;
          private System.Windows.Forms.GroupBox crud;
          private System.Windows.Forms.Button sectionViewButton;
          private System.Windows.Forms.Button sectionAddButton;
          private System.Windows.Forms.Button sectionRemoveButton;
          private System.Windows.Forms.Button sectionUpdateButton;
          private System.Windows.Forms.TextBox sectionTime;
          private System.Windows.Forms.TextBox sectionDay;
          private System.Windows.Forms.TextBox facultyId;
          private System.Windows.Forms.TextBox courseId;
          private System.Windows.Forms.TextBox sectionId;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.TextBox sectionSemester;
          private System.Windows.Forms.DataGridView dataGridView;
          private System.Windows.Forms.DataGridViewTextBoxColumn section_Id;
          private System.Windows.Forms.DataGridViewTextBoxColumn section_course_Id;
          private System.Windows.Forms.DataGridViewTextBoxColumn section_faculty_id;
          private System.Windows.Forms.DataGridViewTextBoxColumn section_day;
          private System.Windows.Forms.DataGridViewTextBoxColumn section_time;
          private System.Windows.Forms.DataGridViewTextBoxColumn section_semester;
          private System.Windows.Forms.Button closeButton;
          private System.Windows.Forms.Button filterButton;
     }
}