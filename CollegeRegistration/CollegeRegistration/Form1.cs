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
    public partial class Form1 : Form
    {

        public RegistrationEntities RegistrationEntities { get; set; }
        public Form1()
        {
            InitializeComponent();
            RegistrationEntities = new RegistrationEntities();
            updateStudentsList();
            updateMajorsList();

            var erics = RegistrationEntities.Students.Where(s => s.Name.StartsWith("E")).ToList();
            erics = erics.Where(s => s.Major.College == "CECS").ToList();
            foreach( var eric in erics )
            {
                ericsClassesLabel.Text += $"{eric.Name} - {eric.Major.Name} - {eric.Major.College}{Environment.NewLine}";
            }

            // linq to ojbects without lambda extensions syntax
            /*
            var query = from Student student in RegistrationEntities.Students
                        where student.Name == "Eric"
                        select student;

           foreach( var result in query )
            {
                result.
            }
            */

            //RegistrationEntities.Students.Remove()
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student
            {
                Name = textBox1.Text,
                MajorID = 1
            };
            RegistrationEntities.Students.Add(newStudent);
            RegistrationEntities.SaveChanges();
            updateStudentsList();

        }

        private void updateStudentsList()
        {
            foreach( var student in RegistrationEntities.Students )
            {
                studentsList.Text += $"{student.Name} {student.Major.Name} {student.Major.College}";
            }
            
        }

        private void updateMajorsList()
        {
            foreach (var major in RegistrationEntities.Majors)
            {
                majorsListBox.Text += $"{major.Name}";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Major newMajor = new Major()
            {
                Name = majorNameTextBox.Text,
                College = "CECS"
            };
            RegistrationEntities.Majors.Add(newMajor);
            RegistrationEntities.SaveChanges();
            updateMajorsList();
        }

        private void button2_Click(object sender, EventArgs e)//this is the weirdly placed add student
        {
            var sectionsForm = new Sections();
            sectionsForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentAddForm studentAddForm = new StudentAddForm(RegistrationEntities);
            studentAddForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)//this is the refresh button
        {
            updateStudentsList();
            updateMajorsList();
        }
    }
}
