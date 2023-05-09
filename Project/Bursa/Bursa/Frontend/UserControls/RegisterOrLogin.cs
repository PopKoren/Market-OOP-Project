using Bursa.Frontend.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bursa.Frontend.UserControls
{
    public partial class RegisterOrLogin : UserControl
    {
        public RegisterOrLogin()
        {
            InitializeComponent();
        }


        private void WelcomeLabel_Click(object sender, EventArgs e)
        {
            RegisterLogin registerLoginForm = new RegisterLogin();
            registerLoginForm.Show();
            this.Hide();
        }
    }
}
