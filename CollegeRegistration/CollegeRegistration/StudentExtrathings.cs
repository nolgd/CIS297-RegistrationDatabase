using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeRegistration
{
    public partial class Student
    {

        public string ToStringy => $"{Name} {Major.Name} {Major.College}";
    }

    public partial class Major
    {
        public string ToStringy => $"{Name} {College}";
    }

    public partial class Section
    {
        public string ToStringy => $"{CourseID} {FacultyID} {Day} {Time} {Semester}";
    }

    public partial class Faculty
    {
        public string ToStringy => $"{Name} {PhoneNumber}";
    }

    public partial class Course
    {
        public string ToStringy => $"{Name} {Number} {Credits} {Department}";
    }

    public partial class Enrollment
    {
        public string ToStringy => $"{SectionID} {StudentID} {Grade}";
    }

}
