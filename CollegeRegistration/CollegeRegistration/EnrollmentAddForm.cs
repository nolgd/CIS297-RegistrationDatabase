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
    }
}
