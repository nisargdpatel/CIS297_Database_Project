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
     public partial class SectionForm : Form
     {
          bool addActive = false;
          bool removeActive = false;
          bool updateActive = false;
          RegistrationEntities RegistrationEntitiesSection;
          public SectionForm()
          {
               InitializeComponent();
               RegistrationEntitiesSection = new RegistrationEntities();
               RegistrationEntitiesSection.Sections.Load();
               viewListBox.DataSource = RegistrationEntitiesSection.Sections.Local.ToBindingList();
               viewListBox.DisplayMember = nameof(Section.SectionDisplay);
               dataGridView.DataSource = RegistrationEntitiesSection.Sections.ToList<Section>();

               reset();
          }

          private void reset()
          {
               warningLabel.Visible = false;
               filterButton.Visible = false;
               sectionAddButton.BackColor = Color.LightGray;
               sectionRemoveButton.BackColor = Color.LightGray;
               sectionUpdateButton.BackColor = Color.LightGray;
               sectionViewButton.BackColor = Color.LightGray;
               viewListBox.Visible = false;
               sectionId.Text = "";
               courseId.Text = "";
               facultyId.Text = "";
               sectionDay.Text = "";
               sectionTime.Text = "";
               sectionSemester.Text = "";
          }

          private void openCourse_Click(object sender, EventArgs e)
          {
               CourseForm tempForm = new CourseForm();
               tempForm.Show();
               this.Hide();
          }

          private void addSubmit()
          {
               Section newSection = new Section()
               {
                    CourseID = Convert.ToInt32(courseId.Text),
                    FacultyID = Convert.ToInt32(facultyId.Text),
                    Day = sectionDay.Text,
                    Time = sectionTime.Text,
                    Semester = sectionSemester.Text
               };
               RegistrationEntitiesSection.Sections.Add(newSection);
               RegistrationEntitiesSection.SaveChanges();
               viewListBox.DisplayMember = nameof(Section.SectionDisplay);
               dataGridView.DataSource = RegistrationEntitiesSection.Sections.ToList<Section>();
          }

          private void sectionAddButton_Click(object sender, EventArgs e)
          {
               addActive = true;
               removeActive = false;
               updateActive = false;

               reset();
               sectionAddButton.BackColor = Color.Gray;

               idLabel.Visible = false;
               sectionId.Visible = false;
               submitButton.Visible = true;
               viewListBox.Visible = false;
               dataGridView.Visible = false;
          }

          private void updateSubmit()
          {
               int temp = Convert.ToInt32(sectionId.Text);
               var updateQuery = from Section tempSection in RegistrationEntitiesSection.Sections
                                 where tempSection.Id == temp
                                 select tempSection;

               foreach (var result in updateQuery)
               {
                    if (courseId.Text != String.Empty)
                         result.CourseID = Convert.ToInt32(courseId.Text);
                    if (facultyId.Text != String.Empty)
                         result.FacultyID = Convert.ToInt32(facultyId.Text);
                    if (sectionDay.Text != String.Empty)
                         result.Day = sectionDay.Text;
                    if (sectionTime.Text != String.Empty)
                         result.Time = sectionTime.Text;
                    if (sectionSemester.Text != String.Empty)
                         result.Semester = sectionSemester.Text;
               }
               RegistrationEntitiesSection.SaveChanges();
               viewListBox.DisplayMember = nameof(Section.SectionDisplay);
               dataGridView.DataSource = RegistrationEntitiesSection.Sections.ToList<Section>();
          }

          private void sectionUpdateButton_Click(object sender, EventArgs e)
          {
               addActive = false;
               removeActive = false;
               updateActive = true;

               reset();
               sectionUpdateButton.BackColor = Color.Gray;
               idLabel.Visible = true;
               sectionId.Visible = true;
               submitButton.Visible = true;
               viewListBox.Visible = false;
               dataGridView.Visible = false;
          }

          private void removeSubmit()
          {
               int temp = Convert.ToInt32(sectionId.Text);
               var removeQuery = from Section tempSection in RegistrationEntitiesSection.Sections
                                 where tempSection.Id == temp
                                 select tempSection;

               if (removeQuery != null)
               {
                    foreach (var result in removeQuery)
                    {
                         RegistrationEntitiesSection.Sections.Remove(result);
                    }
               }

               RegistrationEntitiesSection.SaveChanges();
               viewListBox.DisplayMember = nameof(Section.SectionDisplay);
               dataGridView.DataSource = RegistrationEntitiesSection.Sections.ToList<Section>();
          }

          private void sectionRemoveButton_Click(object sender, EventArgs e)
          {
               addActive = false;
               removeActive = true;
               updateActive = false;

               reset();
               sectionRemoveButton.BackColor = Color.Gray;
               idLabel.Visible = true;
               sectionId.Visible = true;
               submitButton.Visible = true;
               viewListBox.Visible = false;
               dataGridView.Visible = false;
          }

          private void submitButton_Click(object sender, EventArgs e)
          {
               viewListBox.Visible = true;
               viewListBox.DataSource = RegistrationEntitiesSection.Sections.Local.ToBindingList();
               viewListBox.DisplayMember = nameof(Section.SectionDisplay);
               if (addActive)
                    addSubmit();
               else if (removeActive)
                    removeSubmit();
               else if (updateActive)
                    updateSubmit();
               else
               {
                    warningLabel.Visible = true;
                    warningLabel.Text = "Error: Unknown CRUD operation";
               }
               reset();
          }

          private void sectionViewButton_Click(object sender, EventArgs e)
          {
               RegistrationEntitiesSection.SaveChanges();
               viewListBox.DisplayMember = nameof(Section.SectionDisplay);
               dataGridView.DataSource = RegistrationEntitiesSection.Sections.ToList<Section>();
               dataGridView.Visible = true;
               addActive = false;
               removeActive = false;
               updateActive = false;
               

               reset();
               filterButton.Visible = true;
               sectionViewButton.BackColor = Color.Gray;

               submitButton.Visible = false;
               viewListBox.Visible = true;

               RegistrationEntitiesSection.SaveChanges();

          }

          private void closeButton_Click(object sender, EventArgs e)
          {
               this.Close();
          }

          private void filterButton_Click(object sender, EventArgs e)
          {
               var semesterSelected = viewListBox.SelectedItem as Section;

               var filterId = (from Section tempSection in RegistrationEntitiesSection.Sections
                              where tempSection.Semester == semesterSelected.Semester
                              orderby tempSection.Semester
                              select tempSection).ToList();

               dataGridView.DataSource = filterId;
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
