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

        private void label1_Click(object sender, EventArgs e)
        {
            
            
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
