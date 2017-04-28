﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prototype
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Grade Sheet", "Grade Sheet", 
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Attendance Sheet", "Attendance Sheet", 
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form schedule = new Schedule();
            schedule.Show();
            this.Hide();

            //MessageBox.Show("This is Schedule Sheet", "Schedule Sheet", 
                //MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Lectures", "Lectures", 
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Student Demographics", "Student Demographics", 
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Academic History", "Academic History", 
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
