using System;
using System.Windows.Forms;

namespace Prototype
{
    public partial class ScheduleSheet : Form
    {
        public ScheduleSheet()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}