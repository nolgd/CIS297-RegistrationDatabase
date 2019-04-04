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

        private void button1_Click(object sender, EventArgs e)//add
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

        private void button2_Click(object sender, EventArgs e)//delete
        {
            int credits = Convert.ToInt32(textBox3.Text);
            Course course = RegistrationEntities.Courses.Where(b => (b.Name == textBox2.Text) && (b.Number == textBox2.Text)&&(b.Credits==credits)&&(b.Department==textBox4.Text)).First();
            RegistrationEntities.Courses.Remove(course);
            RegistrationEntities.SaveChanges();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)//update 
        {
            int idd = Convert.ToInt32(textBox5.Text);
            Course course = RegistrationEntities.Courses.Where(b=>(b.Id==idd)).First();
            if (textBox1.Modified)
            {
                course.Name = textBox1.Text;
            }
            if (textBox2.Modified)
            {
                course.Number = textBox2.Text;
            }
            if (textBox3.Modified)
            {
                course.Credits = Convert.ToInt32(textBox1.Text);
            }
            if (textBox4.Modified)
            {
                course.Department = textBox4.Text;
            }


            RegistrationEntities.SaveChanges();
            this.Close();
        }
    }
}
