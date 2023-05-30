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

    public class Etherium : Crypto
    {

        public Etherium(int quantity)
             : base("Etherium", quantity, MainForm.ethprice, false, false)
        {
           
        }
        public override Image GetPicture()
        {
            return Image.FromFile("C:\\Users\\lab102\\Desktop\\OOP-Project-main\\Bursa\\Bursa\\Resources\\eth.jpg");

        }
    }
}
