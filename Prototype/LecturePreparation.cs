using System;
using System.Windows.Forms;

namespace Prototype
{
    public partial class LecturePreparation : Form
    {
        public LecturePreparation()
        {
            InitializeComponent();
        }

        private void LecturePreparation_Load(object sender, EventArgs e)
        {
            cmbMonday.Items.Add("Lecture 20");
            cmbMonday.Items.Add("Example 20");
            cmbMonday.Items.Add("Supplement 20");
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
