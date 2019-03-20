using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeRegistration
{
    public partial class CourseAddForm : Form
    {
        public RegistrationEntities RegistrationEntities;
        public CourseAddForm()
        {
            InitializeComponent();
        }
        public CourseAddForm(RegistrationEntities d)
        {
            InitializeComponent();
            RegistrationEntities = d;
        }

    }
}
