﻿using System;
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
    }
}
