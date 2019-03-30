using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CollegeRegistration
{
    public partial class StudentForm1: Form
    {
        RegistrationEntities studentRegistration;
        public StudentForm1()
        {
            InitializeComponent();
            

            studentRegistration = new RegistrationEntities();
            studentRegistration.Students.Load();
            studentRegistration.Majors.Load();
            

            // List Box Stuff 
            StudentData.DataSource = studentRegistration.Students.Local.ToBindingList();
            StudentData.DisplayMember = nameof(Student.BetterDisplay);
            Majors_List.DataSource = studentRegistration.Majors.Local.ToBindingList();
            Majors_List.DisplayMember = nameof(Major.TotalName);

            // Make everything hidden
            updateMajorList();
            updateTable();
            MakeHidden();
                
        }

        private void MakeHidden()
        {
            StudentID_Label.Visible = false;
            StudentID_textbox.Visible = false;

            StudentName_Label.Visible = false;
            StudentName_textbox.Visible = false;

            Majors_List.Visible = false;
            StudentData.Visible = false;

            Add_Button.Visible = false;
            Remove_Button.Visible = false;
            Update_Button.Visible = false;

        }
        private void clear_textbox()
        {
            StudentID_textbox.Text = String.Empty;
            StudentName_textbox.Text = String.Empty;
            Majors_List.SelectedItem = null;
        }

        private void updateTable()
        {
            Student_Data.AutoGenerateColumns = false;
            Student_Data.RowHeadersVisible = false;
            Student_Data.DataSource = studentRegistration.Faculties.ToList<Faculty>();
        }
        private void updateMajorList()
        {
            foreach (var element in studentRegistration.Majors)
            {
                Majors_List.Text += $"{element.Id} {element.Name} {element.College}";
            }
        }
        private void StudentForm_Load(object sender, EventArgs e)
        {

        }
        /* *********************  OPTIONS**********************************/
        private void AddStudent_Button_Click(object sender, EventArgs e)
        {
            MakeHidden();
            StudentName_Label.Visible = true;
            StudentName_textbox.Visible = true;
            Add_Button.Visible = true;
            Majors_List.Visible = true;
        }

        private void RemoveStudent_Button_Click(object sender, EventArgs e)
        {
            MakeHidden();
            StudentID_Label.Visible = true;
            StudentID_textbox.Visible = true;
            Remove_Button.Visible = true;

        }

        private void UpdateStudent_Button_Click(object sender, EventArgs e)
        {
            MakeHidden();
            StudentID_Label.Visible = true;
            StudentID_textbox.Visible = true; 
            StudentName_Label.Visible = true;
            StudentName_textbox.Visible = true;
            Update_Button.Visible = true;
            Majors_List.Visible = true;
        }

        private void viewData_button_Click(object sender, EventArgs e)
        {
            MakeHidden();
            StudentData.Visible = true;
        }
         /* ***************************SUBMIT BUTTONS************************** */
        private void Update_Button_Click(object sender, EventArgs e)
        {
            var temp1 = StudentName_textbox.Text;
            var temp = Convert.ToInt32(StudentID_textbox.Text);
            var Updatequery = from Student student in studentRegistration.Students
                              where student.Id == temp 
                              select student;

            foreach(var element in Updatequery)
            {
               if (StudentName_textbox.Text != String.Empty)
                {
                    element.Name = temp1;
                    
                }
               if(Majors_List.SelectedItem != null)
                {
                    
                    element.Major = Majors_List.SelectedItem as Major;
                    
                    
                }
                
            }
           
            studentRegistration.SaveChanges();
            updateTable();
            clear_textbox();

        }

        private void Remove_Button_Click(object sender, EventArgs e)
        {

            var Removequery = from Student student in studentRegistration.Students
                              where student.Id == Convert.ToInt32(StudentID_textbox.Text)
                              select student; 
            foreach(var element in Removequery)
            {
                studentRegistration.Students.Remove(element);
            }
            studentRegistration.SaveChanges();
            updateTable();
            clear_textbox();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (StudentName_textbox.Text == String.Empty ||Majors_List.SelectedItem == null)
            {
                MessageBox.Show("Enter a name and/or select a major");
            }
            else
            {
                Student newStudent = new Student
                {
                    Name = StudentName_textbox.Text,
                    Major = Majors_List.SelectedItem as Major

                };
                
                studentRegistration.Students.Add(newStudent);
            }
            studentRegistration.SaveChanges();
            updateTable();
            clear_textbox();
        }
        
       
    }
}
