using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bursa.Frontend.Forms;
using Bursa.Frontend.UserControls;

namespace Bursa
{
    public partial class MainForm : Form
    {
        public MainForm(bool logged = false)
        {
            InitializeComponent();

            if (logged)
            {
                _ = new Welcome
                {
                    Visible = true
                };
            }
            else
            {
                _ = new RegisterOrLogin
                {
                    Visible = true
                };
            }
        }

   
    }
}
