﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vecozo_sprint_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void BtnMan_Click(object sender, EventArgs e)
        {
            Manager Man = new Manager();
            this.Hide();
            Man.Show();
        }

        private void BtnMed_Click(object sender, EventArgs e)
        {
            Medewerker Med = new Medewerker();
            this.Hide();
            Med.Show();
        }
    }
}