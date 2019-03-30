namespace CollegeRegistration
{
    partial class StudentForm1
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
            this.StudentData = new System.Windows.Forms.ListBox();
            this.StudentID_Label = new System.Windows.Forms.Label();
            this.StudentName_Label = new System.Windows.Forms.Label();
            this.StudentID_textbox = new System.Windows.Forms.TextBox();
            this.StudentName_textbox = new System.Windows.Forms.TextBox();
            this.Majors_List = new System.Windows.Forms.ListBox();
            this.Update_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Remove_Button = new System.Windows.Forms.Button();
            this.StudentMajor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_Data = new System.Windows.Forms.DataGridView();
            this.Menu_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Student_Data)).BeginInit();
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
            this.Menu_groupBox.TabIndex = 12;
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
            // StudentData
            // 
            this.StudentData.FormattingEnabled = true;
            this.StudentData.Location = new System.Drawing.Point(-3, 225);
            this.StudentData.Margin = new System.Windows.Forms.Padding(2);
            this.StudentData.Name = "StudentData";
            this.StudentData.Size = new System.Drawing.Size(267, 290);
            this.StudentData.TabIndex = 15;
            // 
            // StudentID_Label
            // 
            this.StudentID_Label.AutoSize = true;
            this.StudentID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentID_Label.Location = new System.Drawing.Point(258, 129);
            this.StudentID_Label.Name = "StudentID_Label";
            this.StudentID_Label.Size = new System.Drawing.Size(33, 20);
            this.StudentID_Label.TabIndex = 20;
            this.StudentID_Label.Text = "ID:";
            // 
            // StudentName_Label
            // 
            this.StudentName_Label.AutoSize = true;
            this.StudentName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentName_Label.Location = new System.Drawing.Point(162, 181);
            this.StudentName_Label.Name = "StudentName_Label";
            this.StudentName_Label.Size = new System.Drawing.Size(129, 20);
            this.StudentName_Label.TabIndex = 18;
            this.StudentName_Label.Text = "Student Name:";
            // 
            // StudentID_textbox
            // 
            this.StudentID_textbox.Location = new System.Drawing.Point(297, 131);
            this.StudentID_textbox.Name = "StudentID_textbox";
            this.StudentID_textbox.Size = new System.Drawing.Size(117, 20);
            this.StudentID_textbox.TabIndex = 17;
            // 
            // StudentName_textbox
            // 
            this.StudentName_textbox.Location = new System.Drawing.Point(297, 181);
            this.StudentName_textbox.Name = "StudentName_textbox";
            this.StudentName_textbox.Size = new System.Drawing.Size(117, 20);
            this.StudentName_textbox.TabIndex = 16;
            // 
            // Majors_List
            // 
            this.Majors_List.FormattingEnabled = true;
            this.Majors_List.Location = new System.Drawing.Point(534, 131);
            this.Majors_List.Name = "Majors_List";
            this.Majors_List.Size = new System.Drawing.Size(254, 199);
            this.Majors_List.TabIndex = 21;
            // 
            // Update_Button
            // 
            this.Update_Button.Location = new System.Drawing.Point(534, 353);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(117, 42);
            this.Update_Button.TabIndex = 22;
            this.Update_Button.Text = "Submit";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(645, 402);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(96, 36);
            this.Add_Button.TabIndex = 23;
            this.Add_Button.Text = "Submit";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Remove_Button
            // 
            this.Remove_Button.Location = new System.Drawing.Point(657, 359);
            this.Remove_Button.Name = "Remove_Button";
            this.Remove_Button.Size = new System.Drawing.Size(87, 30);
            this.Remove_Button.TabIndex = 24;
            this.Remove_Button.Text = "Submit";
            this.Remove_Button.UseVisualStyleBackColor = true;
            this.Remove_Button.Click += new System.EventHandler(this.Remove_Button_Click);
            // 
            // StudentMajor
            // 
            this.StudentMajor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentMajor.DataPropertyName = "MajorID";
            this.StudentMajor.HeaderText = "Major";
            this.StudentMajor.Name = "StudentMajor";
            this.StudentMajor.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Student ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Student_Data
            // 
            this.Student_Data.AllowUserToDeleteRows = false;
            this.Student_Data.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Student_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Student_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.StudentMajor});
            this.Student_Data.Location = new System.Drawing.Point(122, 92);
            this.Student_Data.Name = "Student_Data";
            this.Student_Data.ReadOnly = true;
            this.Student_Data.Size = new System.Drawing.Size(344, 230);
            this.Student_Data.TabIndex = 25;
            // 
            // StudentForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Student_Data);
            this.Controls.Add(this.Remove_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.Majors_List);
            this.Controls.Add(this.StudentData);
            this.Controls.Add(this.StudentID_Label);
            this.Controls.Add(this.StudentName_Label);
            this.Controls.Add(this.StudentID_textbox);
            this.Controls.Add(this.StudentName_textbox);
            this.Controls.Add(this.Menu_groupBox);
            this.Name = "StudentForm1";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.Menu_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Student_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Menu_groupBox;
        private System.Windows.Forms.Button viewData_button;
        private System.Windows.Forms.Button AddStudent_Button;
        private System.Windows.Forms.Button RemoveStudent_Button;
        private System.Windows.Forms.Button UpdateStudent_Button;
        private System.Windows.Forms.ListBox StudentData;
        private System.Windows.Forms.Label StudentID_Label;
        private System.Windows.Forms.Label StudentName_Label;
        private System.Windows.Forms.TextBox StudentID_textbox;
        private System.Windows.Forms.TextBox StudentName_textbox;
        private System.Windows.Forms.ListBox Majors_List;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Remove_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentMajor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridView Student_Data;
    }
}