﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bursa.Frontend.Forms;

namespace Bursa.Frontend.UserControls
{
    public partial class Welcome : UserControl
    {
        public Welcome()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            UserProfile newprof = new UserProfile();
            newprof.ShowDialog();
        }
    }
}
