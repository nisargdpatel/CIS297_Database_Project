using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeRegistration
{
    public partial class Student
    {
        public string BetterDisplay => $"{Name} {Major.Name} {Major.College}";
    }

    public partial class Major
    {
        public string IDAndNameAndCollege => $" {Id} {Name} {College}";
    }

    public partial class Enrollment
    {
        public string CourseName_CourseNumber_FacultName_SectionID_StudentID_Grade => $"Enrollment ID {Id} Course: {Section.Course.Name} {Section.Course.Number}  Faculty Name: {Section.Faculty.Name}  Section ID: {Section.Id}  Student ID: {Student.Id} Grade: {Grade} ";
        public string Semester_StudentID_Grade_CourseName_CourseNumber_SectionID => $" {Section.Semester} Student ID: {Student.Id} {Grade}  Course: {Section.Course.Name} {Section.Course.Number} Section ID: {Section.Id} ";
    }
}
