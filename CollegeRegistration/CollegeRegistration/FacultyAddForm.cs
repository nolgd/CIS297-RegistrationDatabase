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
    public partial class FacultyAddForm : Form
    {
        public RegistrationEntities RegistrationEntities;
        public FacultyAddForm()
        {
            InitializeComponent();
        }
        public FacultyAddForm(RegistrationEntities d)
        {
            InitializeComponent();
            RegistrationEntities = d;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Faculty newFaculty = new Faculty
            {
                Name = textBox1.Text,
                PhoneNumber = textBox2.Text
            };
            RegistrationEntities.Faculties.Add(newFaculty);
            RegistrationEntities.SaveChanges();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idd = Convert.ToInt32(textBox3.Text);
            Faculty faculty = RegistrationEntities.Faculties.Where(b => (b.Id == idd)).First();
            RegistrationEntities.Faculties.Remove(faculty);
            RegistrationEntities.SaveChanges();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idd = Convert.ToInt32(textBox3.Text);
            Faculty faculty = RegistrationEntities.Faculties.Where(b => (b.Id == idd)).First();
            if (textBox1.Modified)
            {
                faculty.Name = textBox1.Text;
            }
            if (textBox2.Modified)
            {
                faculty.PhoneNumber = textBox2.Text;
            }


            RegistrationEntities.SaveChanges();
            this.Close();
        }
    }
}
