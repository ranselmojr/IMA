using System;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;

namespace Prototype
{
    public partial class frmLogin : Form
    {
        private static string userId = "12345@unsunguni.edu";
        private static string password = "12345";
        private static string msgInvalid = "One or both of User ID and password is invalid; please correct.";
        private static string msgPassword = "Your password is 12345.";
        private static string msgRegister = "Your new User ID is " + userId + " and\nyour password is " + password;
        private static string msgUserid = "User ID is not a valid email address; please correct.";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(msgPassword);
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(msgRegister);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // hack start
            if (txtUserid.Text.Equals("xx"))
            {
                Form mainMenu = new MainPage();
                mainMenu.Show();
                this.Hide();
                return;
            }
            // hack end
            try
            {
                string address = new MailAddress(txtUserid.Text).Address;
            }
            catch (Exception ex) when (ex is ArgumentException || ex is FormatException)
            {
                MessageBox.Show(msgUserid);
                return;
            }
            if (!txtUserid.Text.ToLower().Equals(userId) || !txtPassword.Text.Equals(password))
            {
                MessageBox.Show(msgInvalid);
                return;
            }
            else
            {
                Form mainMenu = new MainPage();
                mainMenu.Show();
                this.Hide();
            }
        }
    }
}
