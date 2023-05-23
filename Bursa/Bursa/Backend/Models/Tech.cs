using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bursa.Backend.Models
{
    public class Tech : Stock
    {
        public Tech(int quantity, int price, string name)
           : base(name, price, quantity)
        {

        }
    }
}
