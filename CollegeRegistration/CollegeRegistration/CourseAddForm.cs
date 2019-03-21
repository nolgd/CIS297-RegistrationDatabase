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

        private void button1_Click(object sender, EventArgs e)
        {
            Course newCourse = new Course
            {
                Name = textBox1.Text,
                Number = textBox2.Text,
                Credits = Convert.ToInt32(textBox3.Text),
                Department = textBox4.Text
            };
            RegistrationEntities.Courses.Add(newCourse);
            RegistrationEntities.SaveChanges();
            this.Close();
        }
    }
}
