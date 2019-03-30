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
    public partial class FacultyForm : Form
    {
        RegistrationEntities FacultyRegistration;

    public FacultyForm()
        {
           
            InitializeComponent();
            FacultyRegistration = new RegistrationEntities();
            FacultyRegistration.Faculties.Load();
           
       
            updateTable();

            MakeHidden();
           
        }
        private void MakeHidden()
        {
            // Make Labels Hidden
            
            
            FacultyName_Label.Visible = false;
            FacultyID_Label.Visible = false;
            FacultyPhoneNum_Label.Visible = false;

            // Make TextBox Hidden
            FacultyID_textbox.Visible = false;
            FacultyName_textbox.Visible = false;
            FacultyPhone_textbox.Visible = false;

            // Make action Button Hidden
            Remove_Button.Visible = false;
            Update_Button.Visible = false;
            Add_Button.Visible = false;

            // make listbox invisible
            

            Faculty_Data.Visible = false;

        }
        private void clear_textbox()
        {
            FacultyID_textbox.Text = String.Empty;
            FacultyName_textbox.Text = String.Empty;
            FacultyPhone_textbox.Text = String.Empty;
        }

        private void Remove_Button_Click(object sender, EventArgs e)
        {
            var tempVar = Convert.ToInt32(FacultyID_textbox.Text);
            var RemoveQuery = from Faculty faculty in FacultyRegistration.Faculties
                              where faculty.Id == tempVar
                              select faculty;
            
            foreach (var variable in RemoveQuery)
            {
                FacultyRegistration.Faculties.Remove(variable);
                

            }
            FacultyRegistration.SaveChanges();
       
            updateTable();
            clear_textbox();
            MakeHidden();
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            var temp = Convert.ToInt32(FacultyID_textbox.Text);


            var UpdateQuery = (from Faculty faculty in FacultyRegistration.Faculties
                              where faculty.Id == temp
                              select faculty).ToList();


            foreach (var element in UpdateQuery)
             {
                var phone = element.PhoneNumber;
                    var name = element.Name;
                
                if (FacultyName_textbox.Text != String.Empty)
                {
                    element.Name = FacultyName_textbox.Text;
                   
                }
               

                if (FacultyPhone_textbox.Text != String.Empty)
                {
                    element.PhoneNumber = FacultyPhone_textbox.Text;
                }
                
            }

            FacultyRegistration.SaveChanges();
        
     
            updateTable();
            clear_textbox();
            MakeHidden();

        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            Faculty newFacultyMember = new Faculty
            {
                Name = FacultyName_textbox.Text,
                PhoneNumber = FacultyPhone_textbox.Text
            };
            FacultyRegistration.Faculties.Add(newFacultyMember);
            FacultyRegistration.SaveChanges();

            updateTable();
            clear_textbox();
            MakeHidden();
        }


         /* *********************  OPTIONS**********************************/
        private void AddFaculty_Button_Click(object sender, EventArgs e)
        {
           MakeHidden();
            Add_Button.Visible = true;

            FacultyName_textbox.Visible = true;
            FacultyPhone_textbox.Visible = true;

            FacultyName_Label.Visible = true;
            FacultyPhoneNum_Label.Visible = true;
        }

        private void RemoveFaculty_Button_Click(object sender, EventArgs e)
        {
            MakeHidden();
            Remove_Button.Visible = true;

            FacultyID_textbox.Visible = true;
            FacultyName_textbox.Visible = true;

            FacultyName_Label.Visible = true;
            FacultyID_Label.Visible = true;

        }

        private void UpdateFaculty_Button_Click(object sender, EventArgs e)
        {
            MakeHidden();
            Update_Button.Visible = true;

            FacultyName_textbox.Visible = true;
            FacultyPhone_textbox.Visible = true;
            FacultyID_textbox.Visible = true;

            FacultyID_Label.Visible = true;
            FacultyPhoneNum_Label.Visible = true;
            FacultyName_Label.Visible = true;

            

        }

        private void FacultyData_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
       
        private void updateTable()
        {
            Faculty_Data.AutoGenerateColumns = false;
            Faculty_Data.RowHeadersVisible = false;
            Faculty_Data.DataSource = FacultyRegistration.Faculties.ToList<Faculty>();
        }

        private void viewData_button_Click(object sender, EventArgs e)
        {
            
            MakeHidden();
         
            Faculty_Data.Visible = true;
        }

        private void FacultyForm_Load(object sender, EventArgs e)
        {

        }
        /***************SWITCH TO OTHER FORMS****************/
        private void SwitchTo_Student_Click(object sender, EventArgs e)
        {
            var student = new StudentForm();
            student.Show();
            this.Hide();
        }

        private void SwitchTo_Major_Click(object sender, EventArgs e)
        {

        }

        private void SwitchTo_Section_Click(object sender, EventArgs e)
        {

        }

        private void SwitchTo_Course_Click(object sender, EventArgs e)
        {

        }

        private void SwitchTo_Enrollment_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Program_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
