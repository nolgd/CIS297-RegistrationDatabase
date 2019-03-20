using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeRegistration//still need to create this object in main form, and a button to call this form in main form.
{
    public partial class SectionAddForm : Form
    {
        public RegistrationEntities RegistrationEntities;
        public SectionAddForm()
        {
            InitializeComponent();
        }

        public SectionAddForm(RegistrationEntities d)
        {
            InitializeComponent();
            RegistrationEntities = d;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Section newSection = new Section
            {
                CourseID = Convert.ToInt32(textBox1.Text),
                FacultyID = Convert.ToInt32(textBox4.Text),
                Day = textBox2.Text,
                Time = textBox5.Text,
                Semester = textBox3.Text

            };
            RegistrationEntities.Sections.Add(newSection);
            RegistrationEntities.SaveChanges();
            this.Close();
        }
    }
}
