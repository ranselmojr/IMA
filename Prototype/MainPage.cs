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

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            Form attendance = new AttendanceSheet();
            attendance.Show();
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            Form grades = new GradeSheet();
            grades.Show();
        }

        private void btnLectures_Click(object sender, EventArgs e)
        {
            Form lectures = new LecturePreparation();
            lectures.Show();
        }

        private void btnAttendance_Click_1(object sender, EventArgs e)
        {
            Form attendance = new AttendanceSheet();
            attendance.Show();
        }

        private void btnDemographics_Click(object sender, EventArgs e)
        {
            Form demographics = new StudentDemographics();
            demographics.Show();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            Form schedule = new ScheduleSheet();
            schedule.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            Form history = new AcademicHistory();
            history.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pctSettings_Click(object sender, EventArgs e)
        {
            Form userProfile = new UserProfile();
            userProfile.Show();
        }
    }
}