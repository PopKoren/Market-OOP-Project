using Bursa.Backend;
using Bursa.Backend.Models;
using Bursa.Frontend.UserControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bursa.Frontend.Forms
{
    public partial class RegisterLogin : Form
    {
        public RegisterLogin()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
            this.Close();
            //MainForm mainf = new MainForm(true);
            //mainf.Show();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            
            if (IsValidForm())
            {
                string Username = usernamebox_reg.Text;
                string Password = passwordbox_reg.Text;
                DateTime dateofbirth = dateTimePicker.Value;
                string email = emailbox.Text;

                User newuser = new User(Username, Password, dateofbirth, email);
                UserManager.AddUser(newuser);
                this.Close();
            }

            //MessageBox.Show("Wrong input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private bool IsValidForm()
        {
            DateTime dateOfBirth = dateTimePicker.Value;

            TimeSpan age = DateTime.Now - dateOfBirth;

            // Check if the age is greater than or equal to 18 years
            if (age.TotalDays >= 365.25 * 18)
            {
                return true;
            }
            else
            {
                MessageBox.Show("You must be at least 18 years old.", "Age Verification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            
        }
    }
}
