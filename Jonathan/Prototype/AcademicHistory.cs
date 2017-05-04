using System;
using System.Windows.Forms;

namespace Prototype
{
    public partial class AcademicHistory : Form
    {
        public AcademicHistory()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}