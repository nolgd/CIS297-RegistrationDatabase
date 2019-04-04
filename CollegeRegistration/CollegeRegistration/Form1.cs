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

        RegistrationEntities RegistrationEntities; //{ get; set; }//this like has all the info from the db and communicates or something idk.
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

            TableSelector2.Items.Add("Students");
            TableSelector2.Items.Add("Sections");
            TableSelector2.Items.Add("Majors");
            TableSelector2.Items.Add("Faculty");
            TableSelector2.Items.Add("Enrollments");
            TableSelector2.Items.Add("Courses");

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
                studentsList.DisplayMember = "ToStringy";
            }
            else if (TableSelector.Text == "Enrollments")
            {
                var tempEnrollments = RegistrationEntities.Enrollments.ToList();
                studentsList.DataSource = tempEnrollments;
                studentsList.DisplayMember = "ToStringy";
            }
            else if (TableSelector.Text == "Faculty")
            {
                var temp = RegistrationEntities.Faculties.ToList();
                studentsList.DataSource = temp;
                studentsList.DisplayMember = "ToStringy";
            }
            else if (TableSelector.Text == "Majors")
            {
                var temp = RegistrationEntities.Majors.ToList();
                studentsList.DataSource = temp;
                studentsList.DisplayMember = "ToStringy";
            }
            else if (TableSelector.Text == "Sections")
            {
                var temp = RegistrationEntities.Sections.ToList();
                studentsList.DataSource = temp;
                studentsList.DisplayMember = "ToStringy";
            }


        }

        private void updateStudentsList()
        {
            foreach( var student in RegistrationEntities.Students )
            {
                studentsList.Text += $"{student.Name} {student.Major.Name} {student.Major.College}";
            }
            
        }

       

        private void button2_Click(object sender, EventArgs e)//this is the weirdly placed add student
        {
            var sectionsForm = new Sections();
            sectionsForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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


        private void TableSelector2_SelectedIndexChanged(object sender, EventArgs e)//THIS EVENT UPDATES THE INFORMATION IN ENTRY SELECTOR
        {
            if (TableSelector2.Text == "Students")
            {
                var tempStudents = RegistrationEntities.Students.ToList();
                EntrySelector2.DataSource = tempStudents;
                EntrySelector2.DisplayMember = "ToStringy";

            }
            else if (TableSelector2.Text == "Courses")
            {
                var tempCourses = RegistrationEntities.Courses.ToList();
                EntrySelector2.DataSource = tempCourses;
                EntrySelector2.DisplayMember = "ToStringy";
            }
            else if (TableSelector2.Text == "Enrollments")
            {
                var tempEnrollments = RegistrationEntities.Enrollments.ToList();
                EntrySelector2.DataSource = tempEnrollments;
                EntrySelector2.DisplayMember = "ToStringy";
            }
            else if (TableSelector2.Text == "Faculty")
            {
                var temp = RegistrationEntities.Faculties.ToList();
                EntrySelector2.DataSource = temp;
                EntrySelector2.DisplayMember = "ToStringy";
            }
            else if (TableSelector2.Text == "Majors")
            {
                var temp = RegistrationEntities.Majors.ToList();
                EntrySelector2.DataSource = temp;
                EntrySelector2.DisplayMember = "ToStringy";
            }
            else if (TableSelector2.Text == "Sections")
            {
                var temp = RegistrationEntities.Sections.ToList();
                EntrySelector2.DataSource = temp;
                EntrySelector2.DisplayMember = "ToStringy";
            }

        }
        private void EntrySelector_SelectedIndexChanged(object sender, EventArgs e)//THEY SELECT THIS, AND IT SHOULD update SORTEDLISTBOX
        {
            
            if (TableSelector2.Text == "Students")
            {
                var tempStudents = RegistrationEntities.Students.ToList();


                sortedListBox.DataSource = tempStudents[EntrySelector2.SelectedIndex].Enrollments.ToList();
                sortedListBox.DisplayMember = "ToString";

            }
            else if (TableSelector2.Text == "Courses")
            {
                var tempCourses = RegistrationEntities.Courses.ToList();
            }
            else if (TableSelector2.Text == "Enrollments")
            {
                var tempEnrollments = RegistrationEntities.Enrollments.ToList();
            }
            else if (TableSelector2.Text == "Faculty")
            {
                var temp = RegistrationEntities.Faculties.ToList();
            }
            else if (TableSelector2.Text == "Majors")
            {
                var temp = RegistrationEntities.Majors.ToList();
            }
            else if (TableSelector2.Text == "Sections")
            {
                var temp = RegistrationEntities.Sections.ToList();
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //uh
            if (TableSelector2.Text == "Students")
            {
                
                var tempStudents = RegistrationEntities.Students.ToList();/*
                EntrySelector.DataSource = tempStudents;
                EntrySelector.DisplayMember = "ToStringy";
                */

                sortedListBox.DataSource = tempStudents[EntrySelector.SelectedIndex].Enrollments.ToList();
                sortedListBox.DisplayMember = "ToString";

            }
            else if (TableSelector2.Text == "Courses")
            {
                var tempCourses = RegistrationEntities.Courses.ToList();
                EntrySelector.DataSource = tempCourses;
                EntrySelector.DisplayMember = "ToStringy";
            }
            else if (TableSelector2.Text == "Enrollments")
            {
                var tempEnrollments = RegistrationEntities.Enrollments.ToList();
                EntrySelector.DataSource = tempEnrollments;
                EntrySelector.DisplayMember = "ToStringy";
            }
            else if (TableSelector2.Text == "Faculty")
            {
                var temp = RegistrationEntities.Faculties.ToList();
                EntrySelector.DataSource = temp;
                EntrySelector.DisplayMember = "ToStringy";
            }
            else if (TableSelector2.Text == "Majors")
            {
                var temp = RegistrationEntities.Majors.ToList();
                EntrySelector.DataSource = temp;
                EntrySelector.DisplayMember = "ToStringy";
            }
            else if (TableSelector2.Text == "Sections")
            {
                var temp = RegistrationEntities.Sections.ToList();
                EntrySelector.DataSource = temp;
                EntrySelector.DisplayMember = "ToStringy";
            }
        }
    }
}

/*
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
    private void button4_Click(object sender, EventArgs e)//this is the refresh button
        {
            updateStudentsList();
            updateMajorsList();
        }
*/
