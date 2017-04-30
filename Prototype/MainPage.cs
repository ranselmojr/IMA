using System;
using System.Windows.Forms;

namespace Prototype
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            Form attendance = new Attendance();
            attendance.Show();
        }

        private void btnDemographics_Click(object sender, EventArgs e)
        {
            Form demographics = new Demographics();
            demographics.Show();
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            Form grades = new Grades();
            grades.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Academic History", "Academic History",
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void btnLectures_Click(object sender, EventArgs e)
        {
            Form lectures = new LecturePrep();
            lectures.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Form profile = new UserProfile();
            profile.Show();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Schedule Sheet", "Schedule Sheet",
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
