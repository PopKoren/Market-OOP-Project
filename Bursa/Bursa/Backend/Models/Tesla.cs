using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bursa.Backend.Models
{
    public class Tesla : Stock
    {
        public Tesla(int quantity, int price)
           : base("Tesla", quantity, price)
        {

        }
    }
}
