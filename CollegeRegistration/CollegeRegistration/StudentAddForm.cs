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
    public partial class StudentAddForm : Form
    {
        //charnesky suggested doing new forms to be the thing that adds new entries.
        //doing that here, this is a form that just has 2 boxes to add a new student.
        //enter data hit add, it adds and then closes itself

        public RegistrationEntities RegistrationEntities;
        public StudentAddForm()
        {
            InitializeComponent();

            RegistrationEntities = new RegistrationEntities();
        }

        public StudentAddForm(RegistrationEntities entities)
        {
            InitializeComponent();

            RegistrationEntities = entities;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student
            {
                Name = textBox1.Text,
                MajorID = Convert.ToInt32(textBox4.Text)
            };
            RegistrationEntities.Students.Add(newStudent);
            RegistrationEntities.SaveChanges();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)//delete button
        {
            int idd = Convert.ToInt32(textBox5.Text);
            Student student = RegistrationEntities.Students.Where(b => (b.Id == idd)).First();
            RegistrationEntities.Students.Remove(student);
            RegistrationEntities.SaveChanges();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idd = Convert.ToInt32(textBox5.Text);
            Student student = RegistrationEntities.Students.Where(b => (b.Id == idd)).First();
            if (textBox1.Modified)
            {
                student.Name = textBox1.Text;
            }
            if (textBox4.Modified)
            {
                student.MajorID = Convert.ToInt32(textBox4.Text);
            }


            RegistrationEntities.SaveChanges();
            this.Close();
        }
    }
}
