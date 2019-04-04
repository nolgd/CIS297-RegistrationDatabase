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
    public partial class MajorAddForm : Form
    {
        public RegistrationEntities RegistrationEntities;
        public MajorAddForm()
        {
            InitializeComponent();
        }
        public MajorAddForm(RegistrationEntities d)
        {
            InitializeComponent();
            RegistrationEntities = d;
        }

       
        private void button1_Click_1(object sender, EventArgs e)
        {
            Major newMajor = new Major
            {
                Name = textBox2.Text,
                College = textBox2.Text

            };
            RegistrationEntities.Majors.Add(newMajor);
            RegistrationEntities.SaveChanges();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idd = Convert.ToInt32(textBox3.Text);
            Major major = RegistrationEntities.Majors.Where(b => (b.Id == idd)).First();
            RegistrationEntities.Majors.Remove(major);
            RegistrationEntities.SaveChanges();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idd = Convert.ToInt32(textBox3.Text);
            Major major = RegistrationEntities.Majors.Where(b => (b.Id == idd)).First();
            if (textBox1.Modified)
            {
                major.Name = textBox1.Text;
            }
            if (textBox2.Modified)
            {
                major.College = textBox2.Text;
            }


            RegistrationEntities.SaveChanges();
            this.Close();
        }
    }
}
