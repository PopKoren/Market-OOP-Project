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
            MainForm.welc.Visible = true;
            MainForm.welc.BringToFront();
            MainForm.reglog.Visible = false;

            this.Close();
           
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            
            if (IsValidForm() && IsValidBirthDate())
            {
                string Username = usernamebox_reg.Text;
                string Password = passwordbox_reg.Text;
                DateTime dateofbirth = dateTimePicker.Value;
                string email = emailbox.Text;


                User newuser = new User(Username, Password, dateofbirth, email);
                UserManager.AddUser(newuser);

                MainForm.welc.Visible = true;
                MainForm.welc.BringToFront();
                MainForm.reglog.Visible = false;


                this.Close();
            }

        }

        private bool IsValidForm()
        {
    
            if (string.IsNullOrEmpty(usernamebox_reg.Text) || string.IsNullOrEmpty(passwordbox_reg.Text) ||
                string.IsNullOrEmpty(emailbox.Text)) {
          
                MessageBox.Show("Please fill in all the fields.", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!(emailbox.Text.Contains("@")) || !(emailbox.Text.Contains(".")))
            {
                MessageBox.Show("Please correct your email adress.", "Incomplete email adress.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
                
            }
            
            return true;
        }

        private bool IsValidBirthDate()
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
