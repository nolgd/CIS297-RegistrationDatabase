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

        public RegistrationEntities RegistrationEntities { get; set; }//this like has all the info from the db and communicates or something idk.
        public Form1()
        {
            InitializeComponent();
            RegistrationEntities = new RegistrationEntities();

            TableSelector.Items.Add("Students");
            TableSelector.Items.Add("Sections");
            TableSelector.Items.Add("Majors");
            TableSelector.Items.Add("Faculty");
            TableSelector.Items.Add("Enrollments");
            TableSelector.Items.Add("Courses");
            /*
            updateStudentsList();
            updateMajorsList();

            var erics = RegistrationEntities.Students.Where(s => s.Name.StartsWith("E")).ToList();
            erics = erics.Where(s => s.Major.College == "CECS").ToList();
            foreach( var eric in erics )
            {
                ericsClassesLabel.Text += $"{eric.Name} - {eric.Major.Name} - {eric.Major.College}{Environment.NewLine}";
            }

            // linq to ojbects without lambda extensions syntax
            
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

        private void addStudentButton_Click(object sender, EventArgs e)//this is the show stuff button
        {
            if (TableSelector.Text == "Students")
            {
                var tempStudents = RegistrationEntities.Students.ToList();
                studentsList.DataSource = tempStudents;
                studentsList.DisplayMember = "ToStringy";

            }else if (TableSelector.Text == "Courses")
            {
                var tempCourses = RegistrationEntities.Courses.ToList();
                studentsList.DataSource = tempCourses;
            }
            else if (TableSelector.Text == "Enrollments")
            {
                var tempEnrollments = RegistrationEntities.Enrollments.ToList();
                studentsList.DataSource = tempEnrollments;
            }
            else if (TableSelector.Text == "Faculty")
            {
                var temp = RegistrationEntities.Faculties.ToList();
                studentsList.DataSource = temp;
            }
            else if (TableSelector.Text == "Majors")
            {
                var temp = RegistrationEntities.Majors.ToList();
                studentsList.DataSource = temp;
            }
            else if (TableSelector.Text == "Sections")
            {
                var temp = RegistrationEntities.Sections.ToList();
                studentsList.DataSource = temp;
            }


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

        private void button4_Click(object sender, EventArgs e)//this is the refresh button
        {
            updateStudentsList();
            updateMajorsList();
        }

        //here all the buttons to create the individual table forms.
        //These are always new forms currently and close when you add a thing which maybe I need to change.
        private void button3_Click(object sender, EventArgs e)//Student form button
        {
            StudentAddForm studentAddForm = new StudentAddForm(RegistrationEntities);
            studentAddForm.Show();
        }

        

        private void button5_Click(object sender, EventArgs e)//section form buton
        {
            SectionAddForm sectionAddForm = new SectionAddForm(RegistrationEntities);
            sectionAddForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)//major form button
        {
            MajorAddForm MajorAddForm = new MajorAddForm(RegistrationEntities);
            MajorAddForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)//faculty
        {
            FacultyAddForm FacultyAddForm = new FacultyAddForm(RegistrationEntities);
            FacultyAddForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)//enrollment
        {
            EnrollmentAddForm EnrollmentAddForm = new EnrollmentAddForm(RegistrationEntities);
            EnrollmentAddForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CourseAddForm CourseAddForm = new CourseAddForm(RegistrationEntities);
            CourseAddForm.Show();
        }

    }
}
