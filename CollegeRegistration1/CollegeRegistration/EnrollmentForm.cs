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
/* Sources Used
 *https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/how-to-sort-elements-on-multiple-keys
 *https://github.com/EricCharnesky/CIS297-Winter2019/blob/master/CollegeRegistration/CollegeRegistration/Form1.cs
 * https://www.javatpoint.com/csharp-query-expression
 */
namespace CollegeRegistration
{
    public partial class EnrollmentForm : Form
    {

        RegistrationEntities EnrollmentEntities;
        public EnrollmentForm()
        {
            InitializeComponent();
            EnrollmentEntities = new RegistrationEntities();
            EnrollmentEntities.Enrollments.Load();
            UpdateTable();
            HideComponents();


            //******************************************* START OF INITILIZATION TEST. PLEASE DELETE BEFORE FINAL TURN IN****************************************************//
            //Section newSection = new Section
            //{
            //    Id = 1,
            //    CourseID = 1,
            //    FacultyID = 1,
            //    Day = "Wednesday",
            //    Time = "9:00AM",
            //    Semester = "Fall"
            //};
            //Section newSection1 = new Section
            //{
            //    Id = 1,
            //    CourseID = 1,
            //    FacultyID = 1,
            //    Day = "Wednesday",
            //    Time = "9:00AM",
            //    Semester = "Summer"
            //};

            //Student newStudent = new Student
            //{
            //    Id = 1,
            //    Name = "Avian",
            //    MajorID = 1
            //};

            //Faculty newFaculty = new Faculty
            //{
            //    Id = 1,
            //    Name = "Eric",
            //    PhoneNumber = "248-880-2020"
            //};

            //Course newCourse = new Course
            //{
            //    Id = 1,
            //    Name = "Intro C#",
            //    Number = "297",
            //    Credits = 4,
            //    Department = "CECS"
            //};

            //EnrollmentEntities.Sections.Add(newSection);
            //EnrollmentEntities.Sections.Add(newSection1);
            //EnrollmentEntities.Students.Add(newStudent);   
            //EnrollmentEntities.Faculties.Add(newFaculty);
            //EnrollmentEntities.Courses.Add(newCourse);

            //************************************** END OF INITILIZATION TESTS***********************************//

            EnrollmentEntities.SaveChanges();


        }


        private void Clear()
        {
            StudentIDtextBox.Text = "";
            GradetextBox.Text = "";
            SectionIDtextBox.Text = "";
            EnrollmentIDtextBox.Text = "";
        }

        private void UpdateTable()
        {
            EnrollmentListBox.DataSource = EnrollmentEntities.Enrollments.Local.ToBindingList();
           EnrollmentListBox.DisplayMember = nameof(Enrollment.CourseName_CourseNumber_FacultName_SectionID_StudentID_Grade);

        }

        private void HideComponents()
        {
            // section Id field
            SectionIDLabel.Visible = false;
            SectionIDtextBox.Visible = false;

            //  student id Field
            StudentIDLabel.Visible = false;
            StudentIDtextBox.Visible = false;
            

            // Grade field
            GradeLabel.Visible = false;
            GradetextBox.Visible = false;

            EnrollmentListBox.Visible = false;

            // buttons and labels
            SubmitButton.Visible = false;
            DeleteButton.Visible = false;
            UpdateDataButton.Visible = false;
            DeleteInfoLabel.Visible = false;
            AddCorrectLetterLabel.Visible = false;

            EnrollmentIDLabel.Visible = false;
            EnrollmentIDtextBox.Visible = false;
            FilterStudentIDButton.Visible = false;
            FilterSemesterAndStudentButton.Visible = false;
        }
        // ***************************** INSERT ********************
        private void AddButton_Click(object sender, EventArgs e)
        {
            HideComponents();
            StudentIDLabel.Visible = true;
            StudentIDtextBox.Visible = true;
            SectionIDLabel.Visible = true;
            SectionIDtextBox.Visible = true;
            GradeLabel.Visible = true;
            GradetextBox.Visible = true;
            SubmitButton.Visible = true;
            AddCorrectLetterLabel.Visible = true;
              
        }


        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (SectionIDtextBox.Text != string.Empty || StudentIDtextBox.Text != string.Empty || GradetextBox.Text != string.Empty)
            {
                Enrollment newEnrollment = new Enrollment()
                {
                    SectionID = Convert.ToInt32(SectionIDtextBox.Text),
                    StudentID = Convert.ToInt32(StudentIDtextBox.Text),
                    Grade = GradetextBox.Text
                };

                // Query for  Finding a matching section ID
                var SectionCheck = 0;
                var sectionID = Convert.ToInt32(SectionIDtextBox.Text);
                var FindMatchingSectionQuery = from Section section in EnrollmentEntities.Sections
                               where section.Id == sectionID
                               select section.Id;

                foreach(var element in FindMatchingSectionQuery)
                { 
                    SectionCheck++;
                }

                // Query for Finding a matching student ID
                var CheckStudent = 0;
                var studentID = Convert.ToInt32(StudentIDtextBox.Text);
                var FindMatchingStudentQuery = from Student student in EnrollmentEntities.Students
                                               where student.Id == studentID
                                               select student.Id;

                foreach (var element in FindMatchingStudentQuery)
                {
                    CheckStudent++;
                }

                // Compares if there is a match for both foreign keys
                if(SectionCheck != 0 && CheckStudent !=0 )
                {
                    EnrollmentEntities.Enrollments.Add(newEnrollment);
                    EnrollmentEntities.SaveChanges();
                    UpdateTable();
                    Clear();

                    
                }
                else if (SectionCheck ==0)
                {
                    MessageBox.Show("No section ID matches. Please try again");
                } else if (CheckStudent == 0)
                {
                    MessageBox.Show("No student ID matches. Please try again");
                }
 

                Clear();
            } else
            {
                 MessageBox.Show("You left a field empty, please re-enter your values and try again");
            }
        }

        //**************************** DELETE *****************************
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            HideComponents();

            EnrollmentListBox.Visible = true;
            DeleteButton.Visible = true;
            DeleteInfoLabel.Visible = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var selectedEnrollment = EnrollmentListBox.SelectedItem as Enrollment;
            if (selectedEnrollment != null)
            {
                
                    EnrollmentEntities.Enrollments.Remove(selectedEnrollment);
                    EnrollmentEntities.SaveChanges();
                
            }
        }
        //***************** UPDATE ******************************
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            HideComponents();
            SectionIDLabel.Visible = true;
            SectionIDtextBox.Visible = true;
            StudentIDLabel.Visible = true;
            StudentIDtextBox.Visible = true;
            GradeLabel.Visible = true;
            GradetextBox.Visible = true;
            UpdateDataButton.Visible = true;
            EnrollmentIDLabel.Visible = true;
            EnrollmentIDtextBox.Visible = true;
        }

        private void UpdateDataButton_Click(object sender, EventArgs e)
        {
            if (EnrollmentIDtextBox.Text != string.Empty)
            {
                var ChangeEnrollmentID = Convert.ToInt32(EnrollmentIDtextBox.Text);
                if (SectionIDtextBox.Text != string.Empty && StudentIDtextBox.Text != string.Empty && GradetextBox.Text != string.Empty)
                {
                    var newsectionID = Convert.ToInt32(SectionIDtextBox.Text);
                    var newstudentID = Convert.ToInt32(StudentIDtextBox.Text);
                    var newGrade = GradetextBox.Text;
                    var UpdateQuery = from Enrollment enrollment in EnrollmentEntities.Enrollments
                                      where enrollment.Id == ChangeEnrollmentID
                                      select enrollment;

                    foreach (var element in UpdateQuery)
                    {
                        
                        
                            element.SectionID = newsectionID;
                       
                            element.StudentID = newstudentID;
                        
                            element.Grade = newGrade;
                        
                    }

                    EnrollmentEntities.SaveChanges();
                    UpdateTable();
                    Clear();
                }
                else
                {
                    MessageBox.Show("You have an empty field/s missing. Please try again");
                }
            }
            else
            {
                MessageBox.Show("Enrollment ID field is empty. Please try again");
            }
        }

        // ****************************** VIEW DATA******************************
        private void ViewButton_Click(object sender, EventArgs e)
        {
            HideComponents();

            EnrollmentListBox.Visible = true;
            FilterStudentIDButton.Visible = true;
            FilterSemesterAndStudentButton.Visible = true;
            UpdateTable();
        }

        //***************** Form Switch ************************   PLEAAAAASE ADD
        private void SwitchFormToMajorButton_Click(object sender, EventArgs e)
        {
            MajorForm majorForm = new MajorForm();
            majorForm.Show();
            this.Hide();
        }

        private void Switch_To_Course_Button_Click(object sender, EventArgs e)
        {
            CourseForm tempForm = new CourseForm();
            tempForm.Show();
            this.Hide();
        }

        private void Switch_To_Section_Button_Click(object sender, EventArgs e)
        {
            var section = new SectionForm();
            section.Show();
            this.Hide();
        }

        private void Switch_To_Faculty_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var faculty = new FacultyForm();

            faculty.Show();
        }

        private void Switch_To_Student_Button_Click(object sender, EventArgs e)
        {
            var student = new StudentForm();
            student.Show();
            this.Hide();
        }
        private void EXIT_PROGRAM_BUTTON_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //**************************** SORTING*******************************************
        private void FilterStudentIDButton_Click(object sender, EventArgs e)
        {
            

                var Sortquery1 = (from Enrollment enrollment in EnrollmentEntities.Enrollments
                              orderby enrollment.StudentID
                              select enrollment).ToList();

                EnrollmentListBox.DataSource = Sortquery1;
            

            Clear();
        }

        private void FilterSemesterAndStudentButton_Click(object sender, EventArgs e)
        {
            var SortQuery = (from Enrollment enrollment in EnrollmentEntities.Enrollments
                            orderby enrollment.StudentID, enrollment.Section.Semester
                            select enrollment).ToList();

                EnrollmentListBox.DataSource = SortQuery;
                EnrollmentListBox.DisplayMember = nameof(Enrollment.Semester_StudentID_Grade_CourseName_CourseNumber_SectionID);

            Clear();
        }
    }
}
