using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bursa.Backend.Models
{
    [Serializable]

    public class Apple : Stock
    {
        public Apple(int quantity)
          : base("Apple", quantity, 175)
        {

        }
    }
}
