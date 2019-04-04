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

        private void button2_Click(object sender, EventArgs e)
        {
            int idd = Convert.ToInt32(textBox6.Text);
            Section section = RegistrationEntities.Sections.Where(b => (b.Id == idd)).First();
            RegistrationEntities.Sections.Remove(section);
            RegistrationEntities.SaveChanges();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idd = Convert.ToInt32(textBox6.Text);
            Section section = RegistrationEntities.Sections.Where(b => (b.Id == idd)).First();
            if (textBox1.Modified)
            {
                section.CourseID = Convert.ToInt32(textBox1.Text);
            }
            if (textBox4.Modified)
            {
                section.FacultyID = Convert.ToInt32(textBox4.Text);
            }
            if (textBox3.Modified)
            {
                section.Day = textBox3.Text;
            }
            if (textBox5.Modified)
            {
                section.Time = textBox5.Text;
            }
            if (textBox2.Modified)
            {
                section.Semester = textBox2.Text;
            }


            RegistrationEntities.SaveChanges();
            this.Close();
        }
    }
}
