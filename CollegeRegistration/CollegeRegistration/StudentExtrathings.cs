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

    public partial class Majors
    {
        public string ToStringy => $" ";
    }

}
