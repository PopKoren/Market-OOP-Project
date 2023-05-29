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
        readonly User targetUser = UserManager.users.FirstOrDefault(user => user.Username == RegisterLogin.loggedusername);


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

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            User targetUser = UserManager.users.FirstOrDefault(user => user.Username == RegisterLogin.loggedusername);
            if (targetUser != null)
            {
                var columns = UserProfileView.Columns;

                if (comboBox1.SelectedItem.ToString() == "Cryptocurrency")
                {
                    UserProfileView.DataSource = targetUser.GetCrypto();

                    columns[2].DisplayIndex = 0;
                    columns[3].DisplayIndex = 1;
                    columns[4].DisplayIndex = 2;
                    columns[0].HeaderText = "Minable Coin: ";
                    columns[1].HeaderText = "Stable Coin: ";
                  


                }
                else if (comboBox1.SelectedItem.ToString() == "Stocks")
                {
                    UserProfileView.DataSource = targetUser.GetStocks();
                

                }

                UserProfileView.Font = new Font(UserProfileView.Font.FontFamily, 12, FontStyle.Regular);



            }
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            HelloLabel.Text = "Hello " + RegisterLogin.loggedusername + "!";
        }

        private void DeleteAcc_Click(object sender, EventArgs e)
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
