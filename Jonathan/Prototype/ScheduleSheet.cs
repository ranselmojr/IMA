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

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved", "Saved",
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}