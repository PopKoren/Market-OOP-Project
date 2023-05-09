using Bursa.Frontend.UserControls;
using System;
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
            MainForm mainf = new MainForm();
            mainf.Show();
            Welcome welco = new Welcome();
            welco.Visible = true;
        }

     
    }
}
