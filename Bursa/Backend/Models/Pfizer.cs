using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bursa.Backend.Models
{
    [Serializable]

    public class Pfizer : Stock
    {
        public override Image GetPicture()
        {
            return Bursa.Properties.Resources.pfizer;
        }

        public Pfizer(int quantity)
           : base("Pfizer", quantity, 40)
        {

        }
    }
}
