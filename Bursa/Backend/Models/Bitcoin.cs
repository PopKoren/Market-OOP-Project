using Bursa.Frontend.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bursa.Backend.Models
{
    [Serializable]

    public class Bitcoin : Crypto
    {
        public override Image GetPicture()
        {
            return Bursa.Properties.Resources.bitcoin;


        }

        public Bitcoin(int quantity)
             : base("Bitcoin", quantity, MainForm.btcprice, true, false)
        {

        }
       
    }
}
