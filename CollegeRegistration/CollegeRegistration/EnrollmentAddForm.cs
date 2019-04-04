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
    public partial class EnrollmentAddForm : Form
    {
        public RegistrationEntities RegistrationEntities;
        public EnrollmentAddForm()
        {
            InitializeComponent();
        }

        public EnrollmentAddForm(RegistrationEntities d)
        {
            InitializeComponent();
            RegistrationEntities = d;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enrollment newEnrollment = new Enrollment
            {
                SectionID = Convert.ToInt32(textBox1.Text),
                StudentID = Convert.ToInt32(textBox2.Text),
                Grade = textBox3.Text
            };
            RegistrationEntities.Enrollments.Add(newEnrollment);
            RegistrationEntities.SaveChanges();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idd = Convert.ToInt32(textBox4.Text);
            Enrollment enrollment = RegistrationEntities.Enrollments.Where(b => (b.Id == idd)).First();
            RegistrationEntities.Enrollments.Remove(enrollment);
            RegistrationEntities.SaveChanges();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idd = Convert.ToInt32(textBox4.Text);
            Enrollment enrollment = RegistrationEntities.Enrollments.Where(b => (b.Id == idd)).First();
            if (textBox1.Modified)
            {
                enrollment.SectionID = Convert.ToInt32(textBox1.Text);
            }
            if (textBox2.Modified)
            {
                enrollment.StudentID = Convert.ToInt32(textBox2.Text);
            }
            if (textBox3.Modified)
            {
                enrollment.Grade = textBox3.Text;
            }


            RegistrationEntities.SaveChanges();
            this.Close();
        }
    }
}
