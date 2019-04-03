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


     public partial class CourseForm : Form
     {
          bool addActive = false;
          bool removeActive = false;
          bool updateActive = false;
          bool viewActive = false;
          RegistrationEntities RegistrationEntitiesCourse;
          public CourseForm()
          {
               
               InitializeComponent();
               RegistrationEntitiesCourse = new RegistrationEntities();
               RegistrationEntitiesCourse.Courses.Load();
               viewListBox.DataSource = RegistrationEntitiesCourse.Courses.Local.ToBindingList();
               viewListBox.DisplayMember = nameof(Course.CourseDisplay);
               dataGrid.DataSource = RegistrationEntitiesCourse.Courses.ToList<Course>();
               dataGrid.Visible = false;
               reset();


          }

          private void crudOperations()
          {

          }

          private void reset()
          {
               warningLabel.Visible = false;
               courseAddButton.BackColor = Color.LightGray;
               courseRemoveButton.BackColor = Color.LightGray;
               courseUpdateButton.BackColor = Color.LightGray;
               courseViewButton.BackColor = Color.LightGray;
               filterButton.Visible = false;
               viewListBox.Visible = false;
               courseId.Text = "";
               courseName.Text = "";
               courseNumber.Text = "";
               courseCredits.Text = "";
               courseDepartment.Text = "";

               //courseId.Visible = false;
               //courseName.Visible = false;
               //courseNumber.Visible = false;
               //courseCredits.Visible = false;
               //courseDepartment.Visible = false;

               //idLabel.Visible = false;
               //nameLabel.Visible = false;
               //numberLabel.Visible = false;
               //creditsLabel.Visible = false;
               //departmentLabel.Visible = false;

               //submitButton.Visible = false;
          }


          private void openSection_Click(object sender, EventArgs e)
          {
               SectionForm tempForm = new SectionForm();
               tempForm.Show();
               this.Hide();
               
          }


          private void addSubmit()
          {
               
               Course newCourse = new Course()
               {
                    Name = courseName.Text,
                    Number = courseNumber.Text,
                    Credits = Convert.ToInt32(courseCredits.Text),
                    Department = courseDepartment.Text

               };
               RegistrationEntitiesCourse.Courses.Add(newCourse);
               RegistrationEntitiesCourse.SaveChanges();
               dataGrid.DataSource = RegistrationEntitiesCourse.Courses.ToList<Course>();
               viewListBox.DisplayMember = nameof(Course.CourseDisplay);
          }

          private void courseAddButton_Click(object sender, EventArgs e)
          {
               addActive = true;
               removeActive = false;
               updateActive = false;
               viewActive = false;

               reset();
               courseAddButton.BackColor = Color.Gray;
               //courseId.Visible = true;
               //courseName.Visible = true;
               //courseNumber.Visible = true;
               //courseCredits.Visible = true;
               //courseDepartment.Visible = true;
               idLabel.Visible = false;
               courseId.Visible = false;
               submitButton.Visible = true;
               viewListBox.Visible = false;
               dataGrid.Visible = false;


          }


          private void updateSubmit()
          {
               int temp = Convert.ToInt32(courseId.Text);
               var updateQuery = from Course tempCourse in RegistrationEntitiesCourse.Courses
                                 where tempCourse.Id == temp
                                 select tempCourse;

               foreach (var result in updateQuery)
               {
                    if (courseName.Text != String.Empty)
                         result.Name = courseName.Text;
                    if (courseNumber.Text != String.Empty)
                         result.Number = courseNumber.Text;
                    if (courseCredits.Text != String.Empty)
                         result.Credits = Convert.ToInt32(courseCredits.Text);
                    if (courseDepartment.Text != String.Empty)
                         result.Department = courseDepartment.Text;
               }
               RegistrationEntitiesCourse.SaveChanges();
               viewListBox.DisplayMember = nameof(Course.CourseDisplay);
               dataGrid.DataSource = RegistrationEntitiesCourse.Courses.ToList<Course>();
          }

          private void courseUpdateButton_Click(object sender, EventArgs e)
          {
               addActive = false;
               removeActive = false;
               updateActive = true;
               viewActive = false;

               reset();
               courseUpdateButton.BackColor = Color.Gray;
               //courseId.Visible = true;
               //courseName.Visible = true;
               //courseNumber.Visible = true;
               //courseCredits.Visible = true;
               //courseDepartment.Visible = true;
               idLabel.Visible = true;
               courseId.Visible = true;
               submitButton.Visible = true;
               viewListBox.Visible = false;
               dataGrid.Visible = false;
          }


          private void removeSubmit()
          {
               int temp = Convert.ToInt32(courseId.Text);

               var removeQuery = from Course tempCourse in RegistrationEntitiesCourse.Courses
                                 where tempCourse.Id == temp
                                 select tempCourse;

               var fkQuery = from Section tempSection in RegistrationEntitiesCourse.Sections
                             where tempSection.CourseID == temp
                             select tempSection;

               if (fkQuery.Count() < 1)          //it's not in sections table
               {
                    foreach (var result in removeQuery)
                    {

                         RegistrationEntitiesCourse.Courses.Remove(result);

                    }
               }
               else
               {
                    MessageBox.Show("This id is a foreign key for section table");
               }

               RegistrationEntitiesCourse.SaveChanges();
               viewListBox.DisplayMember = nameof(Course.CourseDisplay);
               dataGrid.DataSource = RegistrationEntitiesCourse.Courses.ToList<Course>();
          }

          private void courseRemoveButton_Click(object sender, EventArgs e)
          {
               addActive = false;
               removeActive = true;
               updateActive = false;
               viewActive = false;

               reset();
               courseRemoveButton.BackColor = Color.Gray;
               idLabel.Visible = true;
               courseId.Visible = true;
               submitButton.Visible = true;
               viewListBox.Visible = false;
               dataGrid.Visible = false;

          }


          private void submitButton_Click(object sender, EventArgs e)
          {
               if (addActive)
                    addSubmit();
               else if (removeActive)
                    removeSubmit();
               else if (updateActive)
                    updateSubmit();
               else
               {
                    MessageBox.Show("No CRUD operation has been selected");
               }
               reset();
          }

          private void courseViewButton_Click(object sender, EventArgs e)
          {
               RegistrationEntitiesCourse.SaveChanges();
               viewListBox.DisplayMember = nameof(Course.CourseDisplay);
               dataGrid.DataSource = RegistrationEntitiesCourse.Courses.ToList<Course>();
               addActive = false;
               removeActive = false;
               updateActive = false;
               viewActive = true;

               reset();
               filterButton.Visible = true;
               courseViewButton.BackColor = Color.Gray;

               submitButton.Visible = false;
               viewListBox.Visible = true;
               dataGrid.Visible = true;

               RegistrationEntitiesCourse.SaveChanges();
          }

          private void closeButton_Click(object sender, EventArgs e)
          {
               this.Close();
          }

          private void filterButton_Click(object sender, EventArgs e)
          {
               //var semesterSelected = viewListBox.SelectedItem as Section;

               //var filterId = (from Section tempSection in RegistrationEntitiesSection.Sections
               //                where tempSection.Semester == semesterSelected.Semester
               //                orderby tempSection.Semester
               //                select tempSection).ToList();

               //dataGridView.DataSource = filterId;


               var departmentSelected = viewListBox.SelectedItem as Course;

               var filterDepart = (from Course tempCourse in RegistrationEntitiesCourse.Courses
                                   where tempCourse.Department == departmentSelected.Department
                                   orderby tempCourse.Department
                                   select tempCourse).ToList();

               dataGrid.DataSource = filterDepart;
          }

        private void openFaculty_Click(object sender, EventArgs e)
        {
            var faculty = new FacultyForm();
            faculty.Show();
            this.Hide();
        }

        private void openStudent_Click(object sender, EventArgs e)
        {
            var student = new StudentForm();
            student.Show();
            this.Hide();
        }

        private void openMajor_Click(object sender, EventArgs e)
        {
            var major = new MajorForm();
            major.Show();
            this.Hide();
        }

        private void openEnrollment_Click(object sender, EventArgs e)
        {
            var enrollment = new EnrollmentForm();
            enrollment.Show();
            this.Hide();
        }
    }
}
