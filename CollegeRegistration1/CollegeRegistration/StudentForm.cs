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
/*Sources used
 * https://stackoverflow.com/questions/30578790/open-another-form-from-main-form-and-then-close-the-main-form-on-c-sharp-project 
 * 
 https://stackoverflow.com/questions/19726884/convert-iqueryable-to-bindinglist 
 
https://www.youtube.com/watch?v=hg3H_pAzoPI&t=1160s 

 Project based on a project by Eric Charnesky 
 https://github.com/EricCharnesky/CIS297-Winter2019/tree/master/CollegeRegistration */
namespace CollegeRegistration
{
    public partial class StudentForm : Form
    {
        RegistrationEntities studentRegistration;
        public StudentForm()
        {
            InitializeComponent();

            studentRegistration = new RegistrationEntities();
            studentRegistration.Students.Load();
            studentRegistration.Majors.Load();
        
            Majors_List.DataSource = studentRegistration.Majors.Local.ToBindingList();
            Majors_List.DisplayMember = nameof(Major.TotalName);
            
            updateMajorList();
            updateTable();
            MakeHidden();


        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            var temp1 = StudentName_textbox.Text;
            var temp = Convert.ToInt32(StudentID_textbox.Text);
            var Updatequery = from Student student in studentRegistration.Students
                              where student.Id == temp
                              select student;

            foreach (var element in Updatequery)
            {
                if (StudentName_textbox.Text != String.Empty)
                {
                    element.Name = temp1;

                }
                if (Majors_List.SelectedItem != null)
                {

                    element.Major = Majors_List.SelectedItem as Major;


                }

            }

            studentRegistration.SaveChanges();
            updateTable();
            clear_textbox();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (StudentName_textbox.Text == String.Empty || Majors_List.SelectedItem == null)
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

        private void Remove_Button_Click(object sender, EventArgs e)
        {
            var temp = Convert.ToInt32(StudentID_textbox.Text);
            var Removequery = from Student student in studentRegistration.Students
                              where student.Id == temp
                              select student;
            foreach (var element in Removequery)
            {
                studentRegistration.Students.Remove(element);
            }
            studentRegistration.SaveChanges();
            updateTable();
            clear_textbox();
        }





        /****************OPTIONS******************************/
        private void AddStudent_Button_Click(object sender, EventArgs e)
        {
            MakeHidden();
            StudentName_Label.Visible = true;
            StudentName_textbox.Visible = true;
            Add_Button.Visible = true;
            Majors_List.Visible = true;
            updateTable();
        }

        private void RemoveStudent_Button_Click(object sender, EventArgs e)
        {
            MakeHidden();
            StudentID_Label.Visible = true;
            StudentID_textbox.Visible = true;
            Remove_Button.Visible = true;
            updateTable();

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
            updateTable();
        }

        private void viewData_button_Click(object sender, EventArgs e)
        {
            MakeHidden();
            Student_Data.Visible = true;
            Sort_by_Major.Visible = true;
            Majors_List.Visible = true;
            updateTable();
        }

       
        private void Sort_by_Major_Click(object sender, EventArgs e)

        {
            Student_Data.AutoGenerateColumns = false;
            Student_Data.RowHeadersVisible = false;
            var query = (from Student student in studentRegistration.Students
                        orderby student.MajorID 
                        select student).ToList();

            
            Student_Data.DataSource = query;
          

        }
        private void Filter_by_Major_Click(object sender, EventArgs e)
        {
            if(Majors_List.SelectedItem == null)
            {
                MessageBox.Show("Please select a major to filter");
            }
            else
            {
                var major_selected = Majors_List.SelectedItem as Major;
                var query = (from Student student in studentRegistration.Students
                             where student.MajorID == major_selected.Id
                             select student).ToList();
                Student_Data.DataSource = query;
            }

            clear_textbox();
        }
        /***********View Functions********************/
        private void MakeHidden()
        {
            StudentID_Label.Visible = false;
            StudentID_textbox.Visible = false;

            StudentName_Label.Visible = false;
            StudentName_textbox.Visible = false;

            Majors_List.Visible = false;


            Add_Button.Visible = false;
            Remove_Button.Visible = false;
            Update_Button.Visible = false;

            Student_Data.Visible = false;
            Sort_by_Major.Visible = false;

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
            Student_Data.DataSource = studentRegistration.Students.ToList<Student>();

          
        }
        private void updateMajorList()
        {
            foreach (var element in studentRegistration.Majors)
            {
                Majors_List.Text += $"{element.Id} {element.Name} {element.College}";
            }
        }
        private void addMajor()
        {
            Major newMajor = new Major
            {
                Name = "CS101",
                College = "CECS"
            };
            studentRegistration.Majors.Add(newMajor);
            studentRegistration.SaveChanges();
        }
        

        /***************SWITCH TO OTHER FORMS****************/
        private void SwitchTo_Faculty_Click(object sender, EventArgs e)
        {
            this.Hide();
            var faculty = new FacultyForm();
           
            faculty.Show();
            
          
        }
    

        private void SwitchTo_Major_Click(object sender, EventArgs e)
        {
            this.Hide();
            var major = new MajorForm();
            major.Show();
        }

        private void SwitchTo_Section_Click(object sender, EventArgs e)
        {
            var section = new SectionForm();
            section.Show();
            this.Hide();
        }

        private void SwitchTo_Course_Click(object sender, EventArgs e)
        {
            var course  = new CourseForm();
            course.Show();
            this.Hide();
        }

        private void SwitchTo_Enrollment_Click(object sender, EventArgs e)
        {
            this.Hide();
            var enrollment = new EnrollmentForm();
            enrollment.Show();
        }

        private void Exit_Program_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
