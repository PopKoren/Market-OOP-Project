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
    public partial class PictureForm : Form
    {
        public PictureForm(Image picture)
        {
            InitializeComponent();
            pictureBoxBuy.Image = picture;

        }
    }
}
