using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bursa.Backend.Models
{
    [Serializable]

    public class Apple : Stock
    {
        public override Image GetPicture()
        {
            return Image.FromFile("C:\\Users\\lab102\\Desktop\\OOP-Project-main\\Bursa\\Bursa\\Resources\\bitcoin.png");
        }

        public Apple(int quantity)
          : base("Apple", quantity, 175)
        {

        }
    }
}
