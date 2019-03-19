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
    }
}
