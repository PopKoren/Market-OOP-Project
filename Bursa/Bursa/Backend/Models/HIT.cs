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

    public class HIT : Crypto
    {
        public override Image GetPicture()
        {   
            return Image.FromFile("C:\\Users\\lab102\\Desktop\\OOP-Project-main\\Bursa\\Bursa\\Resources\\hit.png");

            
        }

        public HIT(int quanity)
            : base("HIT", quanity, 1, false, true)
        {

        }
    }
}
