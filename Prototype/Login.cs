using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace Prototype
{
    public partial class Login : Form
    {
        // define constants
        private const int MINIMUM_LENGTH = 6;
        private const string userId = "12345@unsunguni.edu";
        private const string password = "12345";

        // simulate I18N translation ability by using defined strings
        private static string msgForgottenPassword = "Your password is " + password + ".";
        private static string msgInvalidLogin = "One or both of User ID and password is invalid; please correct.";
        private static string msgInvalidUserid = "User ID is not a valid email address; please correct.";
        private static string msgRegisteredUser = "Your new User ID is " + userId + " and your password is " + password;

        public Login()
        {
            InitializeComponent();
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtUserid.Clear();
            txtPassword.Clear();
            Form registration = new Registration();
            registration.ShowDialog();
            MessageBox.Show(msgRegisteredUser);
        }

        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtUserid.Text.Length < MINIMUM_LENGTH)
                MessageBox.Show(msgInvalidUserid);
            else
                MessageBox.Show(msgForgottenPassword);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // validate user id
            try
            {
                string address = new MailAddress(txtUserid.Text).Address;
            }
            catch (Exception ex) when (ex is ArgumentException || ex is FormatException)
            {
                MessageBox.Show(msgInvalidUserid);
                return;
            }

            // perform authorization on user id
            if (!txtUserid.Text.ToLower().Equals(userId) || !txtPassword.Text.Equals(password))
            {
                MessageBox.Show(msgInvalidLogin);
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