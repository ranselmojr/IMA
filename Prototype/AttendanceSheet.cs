using System;
using System.Windows.Forms;

namespace Prototype
{
    public partial class AttendanceSheet : Form
    {
        public AttendanceSheet()
        {
            InitializeComponent();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            cmbMonday.Items.Add("Present");
            cmbMonday.Items.Add("Absent");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}