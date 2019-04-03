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
 *
 *https://github.com/EricCharnesky/CIS297-Winter2019/blob/master/CollegeRegistration/CollegeRegistration/Form1.cs
 * 
 */


namespace CollegeRegistration
{
    public partial class MajorForm : Form
    {


        RegistrationEntities MajorEntities;

        public MajorForm()
        {
            InitializeComponent();
            MajorEntities = new RegistrationEntities();
            MajorEntities.Majors.Load();
            UpdateTable();
            HideComponents();

        }


        private void Clear()
        {
            MajorIDtextBox.Text = "";
            MajorNametextBox.Text = "";
            CollegetextBox.Text = "";
        }


        private void UpdateTable()
        {
            MajorListBox.DataSource = MajorEntities.Majors.Local.ToBindingList();
            MajorListBox.DisplayMember = nameof(Major.IDAndNameAndCollege);

        }

        private void HideComponents()
        {
            // Id field
            MajorIDLabel.Visible = false;
            MajorIDtextBox.Visible = false;

            // Name Field
            NameLabel.Visible = false;
            MajorNametextBox.Visible = false;


            // College field
            CollegeLabel.Visible = false;
            CollegetextBox.Visible = false;

            MajorListBox.Visible = false;

            // buttons and labels
            SubmitButton.Visible = false;
            DeleteButton.Visible = false;
            UpdateDataButton.Visible = false;
            DeleteInfoLabel.Visible = false;
        }

        // ***************************** INSERT ********************
        private void AddButton_Click(object sender, EventArgs e)
        {
            HideComponents();
            NameLabel.Visible = true;
            MajorNametextBox.Visible = true;
            CollegeLabel.Visible = true;
            CollegetextBox.Visible = true;
            SubmitButton.Visible = true;
           
        }

        private void SubmitButton_Click(object sender, EventArgs e)   
        {   /// insert
            if (MajorNametextBox.Text != string.Empty || CollegetextBox.Text != string.Empty)
            {
                Major newmajor = new Major
                {
                    Name = MajorNametextBox.Text,
                    College = CollegetextBox.Text
                };

                MajorEntities.Majors.Add(newmajor);
                MajorEntities.SaveChanges();

                UpdateTable();
                Clear();
            }
        }

        //**************************** DELETE *****************************
        private void RemoveButton_Click(object sender, EventArgs e) //remove button for majors
        {  
            HideComponents();

            MajorListBox.Visible = true;
            DeleteButton.Visible = true;
            DeleteInfoLabel.Visible = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var selectedMajor = MajorListBox.SelectedItem as Major;
            if (selectedMajor != null)
            {
                if (selectedMajor.Students.Count > 0)
                {
                    MessageBox.Show("You can't delete a Major that has students");
                }
                else
                {
                    MajorEntities.Majors.Remove(selectedMajor);
                    MajorEntities.SaveChanges();
                }
            }
        }

        //***************** UPDATE ******************************
        private void UpdateButton_Click(object sender, EventArgs e)
        { // Option button 
            HideComponents();
            MajorIDLabel.Visible = true;
            MajorIDtextBox.Visible = true;
            NameLabel.Visible = true;
            MajorNametextBox.Visible = true;
            CollegeLabel.Visible = true;
            CollegetextBox.Visible = true;
            UpdateDataButton.Visible = true;

        }


        private void UpdateDataButton_Click(object sender, EventArgs e)
        { // save changes to update

            if (MajorIDtextBox.Text != string.Empty)
            {
                int majorId = Convert.ToInt32(MajorIDtextBox.Text);

                var UpdateQuery = (from Major major in MajorEntities.Majors
                                   where major.Id == majorId
                                   select major).ToList();

                foreach (var majors in UpdateQuery)
                {

                    if (MajorNametextBox.Text != string.Empty)
                    {
                        majors.Name = MajorNametextBox.Text;
                    } else
                    {
                        MessageBox.Show("Major name field is empty. Please try again");
                    }

                    if (CollegetextBox.Text != string.Empty)
                    {
                        majors.College = CollegetextBox.Text;
                    }
                    else
                    {
                        MessageBox.Show("Major College field is empty. Please try again");
                    }

                }

                MajorEntities.SaveChanges();
                UpdateTable();
                Clear();

            } else
            {
                MessageBox.Show("Pleaes enter the Major ID you want to change attributes to.");
            }
        }
        // ****************************** VIEW DATA******************************
        private void ViewButton_Click(object sender, EventArgs e)
        { // Only shows data

            HideComponents();

            MajorListBox.Visible = true;

        }

         //************ Form Switch ************************ PLEASE ADD 
        private void Switch_to_Enrollment_Button_Click(object sender, EventArgs e)
        {
            EnrollmentForm enrollment = new EnrollmentForm();
            enrollment.Show();
            this.Hide();
        }

        private void Switch_To_Course_Button_Click(object sender, EventArgs e)
        {
            var course = new CourseForm();
            course.Show();
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
    }
}
