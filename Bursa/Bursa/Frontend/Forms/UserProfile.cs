using Bursa.Backend;
using Bursa.Backend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bursa.Frontend.Forms
{
    public partial class UserProfile : Form
    {
        User targetUser = UserManager.users.FirstOrDefault(user => user.Username == RegisterLogin.loggedusername);


        public UserProfile()
        {
            
            InitializeComponent();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            MainForm.reglog.Visible = true;
            MainForm.reglog.BringToFront();
            MainForm.welc.Visible = false;

            this.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            User targetUser = UserManager.users.FirstOrDefault(user => user.Username == RegisterLogin.loggedusername);
            if (targetUser != null)
            {
                if (comboBox1.SelectedItem.ToString() == "Cryptocurrency")
                {
                    UserProfileView.DataSource = targetUser.GetCrypto();
                }
                else if (comboBox1.SelectedItem.ToString() == "Stocks")
                {
                    UserProfileView.DataSource = targetUser.GetStocks();
                }
            }
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            HelloLabel.Text = "Hello " + RegisterLogin.loggedusername + "!";
        }

        private void deleteAcc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Account Deleted!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            UserManager.DeleteUser(targetUser);
            MainForm.reglog.Visible = true;
            MainForm.reglog.BringToFront();
            MainForm.welc.Visible = false;
            this.Close();


        }
    }
}
