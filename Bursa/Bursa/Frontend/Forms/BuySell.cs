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
    public partial class BuySell : Form
    {
        public BuySell()
        {
            InitializeComponent();
        }

        private void Back_to_main_button_Click(object sender, EventArgs e)
        {
           
            this.Close();
            
        }
    }
}
