﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World test!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello test!");
            //add in feature
            //add in feature 2
            MessageBox.Show("!");
        }
    }
}
