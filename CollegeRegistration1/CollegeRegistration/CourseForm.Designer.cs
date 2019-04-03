namespace CollegeRegistration
{
     partial class CourseForm
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
            this.courseId = new System.Windows.Forms.TextBox();
            this.courseName = new System.Windows.Forms.TextBox();
            this.courseNumber = new System.Windows.Forms.TextBox();
            this.courseCredits = new System.Windows.Forms.TextBox();
            this.courseDepartment = new System.Windows.Forms.TextBox();
            this.courseAddButton = new System.Windows.Forms.Button();
            this.courseUpdateButton = new System.Windows.Forms.Button();
            this.courseRemoveButton = new System.Windows.Forms.Button();
            this.openSection = new System.Windows.Forms.Button();
            this.crud = new System.Windows.Forms.GroupBox();
            this.courseViewButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.creditsLabel = new System.Windows.Forms.Label();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.openFaculty = new System.Windows.Forms.Button();
            this.openStudent = new System.Windows.Forms.Button();
            this.openMajor = new System.Windows.Forms.Button();
            this.openEnrollment = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
            this.viewListBox = new System.Windows.Forms.ListBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.course_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course_credits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course_department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeButton = new System.Windows.Forms.Button();
            this.filterButton = new System.Windows.Forms.Button();
            this.crud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // courseId
            // 
            this.courseId.Location = new System.Drawing.Point(295, 88);
            this.courseId.Name = "courseId";
            this.courseId.Size = new System.Drawing.Size(100, 20);
            this.courseId.TabIndex = 0;
            // 
            // courseName
            // 
            this.courseName.Location = new System.Drawing.Point(295, 129);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(100, 20);
            this.courseName.TabIndex = 1;
            // 
            // courseNumber
            // 
            this.courseNumber.Location = new System.Drawing.Point(295, 172);
            this.courseNumber.Name = "courseNumber";
            this.courseNumber.Size = new System.Drawing.Size(100, 20);
            this.courseNumber.TabIndex = 2;
            // 
            // courseCredits
            // 
            this.courseCredits.Location = new System.Drawing.Point(295, 217);
            this.courseCredits.Name = "courseCredits";
            this.courseCredits.Size = new System.Drawing.Size(100, 20);
            this.courseCredits.TabIndex = 3;
            // 
            // courseDepartment
            // 
            this.courseDepartment.Location = new System.Drawing.Point(295, 263);
            this.courseDepartment.Name = "courseDepartment";
            this.courseDepartment.Size = new System.Drawing.Size(100, 20);
            this.courseDepartment.TabIndex = 4;
            // 
            // courseAddButton
            // 
            this.courseAddButton.Location = new System.Drawing.Point(33, 15);
            this.courseAddButton.Name = "courseAddButton";
            this.courseAddButton.Size = new System.Drawing.Size(86, 37);
            this.courseAddButton.TabIndex = 5;
            this.courseAddButton.Text = "Add Course";
            this.courseAddButton.UseVisualStyleBackColor = true;
            this.courseAddButton.Click += new System.EventHandler(this.courseAddButton_Click);
            // 
            // courseUpdateButton
            // 
            this.courseUpdateButton.Location = new System.Drawing.Point(292, 15);
            this.courseUpdateButton.Name = "courseUpdateButton";
            this.courseUpdateButton.Size = new System.Drawing.Size(86, 37);
            this.courseUpdateButton.TabIndex = 6;
            this.courseUpdateButton.Text = "Update Course";
            this.courseUpdateButton.UseVisualStyleBackColor = true;
            this.courseUpdateButton.Click += new System.EventHandler(this.courseUpdateButton_Click);
            // 
            // courseRemoveButton
            // 
            this.courseRemoveButton.Location = new System.Drawing.Point(165, 15);
            this.courseRemoveButton.Name = "courseRemoveButton";
            this.courseRemoveButton.Size = new System.Drawing.Size(86, 37);
            this.courseRemoveButton.TabIndex = 7;
            this.courseRemoveButton.Text = "Remove Course";
            this.courseRemoveButton.UseVisualStyleBackColor = true;
            this.courseRemoveButton.Click += new System.EventHandler(this.courseRemoveButton_Click);
            // 
            // openSection
            // 
            this.openSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openSection.Location = new System.Drawing.Point(12, 88);
            this.openSection.Name = "openSection";
            this.openSection.Size = new System.Drawing.Size(100, 37);
            this.openSection.TabIndex = 8;
            this.openSection.Text = "Sections";
            this.openSection.UseVisualStyleBackColor = true;
            this.openSection.Click += new System.EventHandler(this.openSection_Click);
            // 
            // crud
            // 
            this.crud.Controls.Add(this.courseViewButton);
            this.crud.Controls.Add(this.courseAddButton);
            this.crud.Controls.Add(this.courseRemoveButton);
            this.crud.Controls.Add(this.courseUpdateButton);
            this.crud.Location = new System.Drawing.Point(130, 12);
            this.crud.Name = "crud";
            this.crud.Size = new System.Drawing.Size(541, 63);
            this.crud.TabIndex = 9;
            this.crud.TabStop = false;
            this.crud.Text = "CRUD";
            // 
            // courseViewButton
            // 
            this.courseViewButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.courseViewButton.Location = new System.Drawing.Point(424, 15);
            this.courseViewButton.Name = "courseViewButton";
            this.courseViewButton.Size = new System.Drawing.Size(86, 37);
            this.courseViewButton.TabIndex = 10;
            this.courseViewButton.Text = "View Data";
            this.courseViewButton.UseVisualStyleBackColor = true;
            this.courseViewButton.Click += new System.EventHandler(this.courseViewButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(222, 88);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(27, 20);
            this.idLabel.TabIndex = 10;
            this.idLabel.Text = "Id:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(194, 127);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(55, 20);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Name:";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.Location = new System.Drawing.Point(180, 172);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(69, 20);
            this.numberLabel.TabIndex = 12;
            this.numberLabel.Text = "Number:";
            // 
            // creditsLabel
            // 
            this.creditsLabel.AutoSize = true;
            this.creditsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsLabel.Location = new System.Drawing.Point(186, 215);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(63, 20);
            this.creditsLabel.TabIndex = 13;
            this.creditsLabel.Text = "Credits:";
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentLabel.Location = new System.Drawing.Point(159, 263);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(98, 20);
            this.departmentLabel.TabIndex = 14;
            this.departmentLabel.Text = "Department:";
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(137, 303);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(534, 42);
            this.submitButton.TabIndex = 15;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // openFaculty
            // 
            this.openFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFaculty.Location = new System.Drawing.Point(12, 131);
            this.openFaculty.Name = "openFaculty";
            this.openFaculty.Size = new System.Drawing.Size(100, 37);
            this.openFaculty.TabIndex = 16;
            this.openFaculty.Text = "Faculty";
            this.openFaculty.UseVisualStyleBackColor = true;
            this.openFaculty.Click += new System.EventHandler(this.openFaculty_Click);
            // 
            // openStudent
            // 
            this.openStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openStudent.Location = new System.Drawing.Point(12, 174);
            this.openStudent.Name = "openStudent";
            this.openStudent.Size = new System.Drawing.Size(100, 37);
            this.openStudent.TabIndex = 17;
            this.openStudent.Text = "Students";
            this.openStudent.UseVisualStyleBackColor = true;
            this.openStudent.Click += new System.EventHandler(this.openStudent_Click);
            // 
            // openMajor
            // 
            this.openMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openMajor.Location = new System.Drawing.Point(12, 217);
            this.openMajor.Name = "openMajor";
            this.openMajor.Size = new System.Drawing.Size(100, 37);
            this.openMajor.TabIndex = 18;
            this.openMajor.Text = "Major";
            this.openMajor.UseVisualStyleBackColor = true;
            this.openMajor.Click += new System.EventHandler(this.openMajor_Click);
            // 
            // openEnrollment
            // 
            this.openEnrollment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openEnrollment.Location = new System.Drawing.Point(12, 260);
            this.openEnrollment.Name = "openEnrollment";
            this.openEnrollment.Size = new System.Drawing.Size(100, 37);
            this.openEnrollment.TabIndex = 19;
            this.openEnrollment.Text = "Enrollment";
            this.openEnrollment.UseVisualStyleBackColor = true;
            this.openEnrollment.Click += new System.EventHandler(this.openEnrollment_Click);
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Location = new System.Drawing.Point(415, 311);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 13);
            this.warningLabel.TabIndex = 20;
            // 
            // viewListBox
            // 
            this.viewListBox.FormattingEnabled = true;
            this.viewListBox.Location = new System.Drawing.Point(130, 311);
            this.viewListBox.Name = "viewListBox";
            this.viewListBox.Size = new System.Drawing.Size(541, 121);
            this.viewListBox.TabIndex = 21;
            this.viewListBox.Visible = false;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.course_id,
            this.course_name,
            this.course_number,
            this.course_credits,
            this.course_department});
            this.dataGrid.Location = new System.Drawing.Point(130, 88);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(541, 212);
            this.dataGrid.TabIndex = 22;
            // 
            // course_id
            // 
            this.course_id.DataPropertyName = "Id";
            this.course_id.HeaderText = "Course Id";
            this.course_id.Name = "course_id";
            this.course_id.ReadOnly = true;
            // 
            // course_name
            // 
            this.course_name.DataPropertyName = "Name";
            this.course_name.HeaderText = "Course Name";
            this.course_name.Name = "course_name";
            this.course_name.ReadOnly = true;
            // 
            // course_number
            // 
            this.course_number.DataPropertyName = "Number";
            this.course_number.HeaderText = "Course Number";
            this.course_number.Name = "course_number";
            this.course_number.ReadOnly = true;
            // 
            // course_credits
            // 
            this.course_credits.DataPropertyName = "Credits";
            this.course_credits.HeaderText = "Course Credits";
            this.course_credits.Name = "course_credits";
            this.course_credits.ReadOnly = true;
            // 
            // course_department
            // 
            this.course_department.DataPropertyName = "Department";
            this.course_department.HeaderText = "Course Department";
            this.course_department.Name = "course_department";
            this.course_department.ReadOnly = true;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Red;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(12, 308);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 37);
            this.closeButton.TabIndex = 23;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(677, 88);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(86, 37);
            this.filterButton.TabIndex = 47;
            this.filterButton.Text = "Filter by Department";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 450);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.dataGrid);
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
            this.Controls.Add(this.openSection);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.crud);
            this.Controls.Add(this.courseDepartment);
            this.Controls.Add(this.courseCredits);
            this.Controls.Add(this.courseNumber);
            this.Controls.Add(this.courseName);
            this.Controls.Add(this.courseId);
            this.Name = "CourseForm";
            this.Text = "Courses";
            this.crud.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.TextBox courseId;
          private System.Windows.Forms.TextBox courseName;
          private System.Windows.Forms.TextBox courseNumber;
          private System.Windows.Forms.TextBox courseCredits;
          private System.Windows.Forms.TextBox courseDepartment;
          private System.Windows.Forms.Button courseAddButton;
          private System.Windows.Forms.Button courseUpdateButton;
          private System.Windows.Forms.Button courseRemoveButton;
          private System.Windows.Forms.Button openSection;
          private System.Windows.Forms.GroupBox crud;
          private System.Windows.Forms.Button courseViewButton;
          private System.Windows.Forms.Label idLabel;
          private System.Windows.Forms.Label nameLabel;
          private System.Windows.Forms.Label numberLabel;
          private System.Windows.Forms.Label creditsLabel;
          private System.Windows.Forms.Label departmentLabel;
          private System.Windows.Forms.Button submitButton;
          private System.Windows.Forms.Button openFaculty;
          private System.Windows.Forms.Button openStudent;
          private System.Windows.Forms.Button openMajor;
          private System.Windows.Forms.Button openEnrollment;
          private System.Windows.Forms.Label warningLabel;
          private System.Windows.Forms.ListBox viewListBox;
          private System.Windows.Forms.DataGridView dataGrid;
          private System.Windows.Forms.DataGridViewTextBoxColumn course_id;
          private System.Windows.Forms.DataGridViewTextBoxColumn course_name;
          private System.Windows.Forms.DataGridViewTextBoxColumn course_number;
          private System.Windows.Forms.DataGridViewTextBoxColumn course_credits;
          private System.Windows.Forms.DataGridViewTextBoxColumn course_department;
          private System.Windows.Forms.Button closeButton;
          private System.Windows.Forms.Button filterButton;
          //private System.Windows.Forms.DataGridViewTextBoxColumn Name;
          //private System.Windows.Forms.DataGridViewTextBoxColumn Number;
          //private System.Windows.Forms.DataGridViewTextBoxColumn Credits;
          //private System.Windows.Forms.DataGridViewTextBoxColumn Department;
     }
}