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
            return Bursa.Properties.Resources.hit;

        }

        public HIT(int quantity)
            : base("HIT", quantity, 1, false, true)
        {

        }
    }
}
