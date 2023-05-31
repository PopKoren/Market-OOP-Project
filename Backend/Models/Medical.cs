using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bursa.Backend.Models
{
    public class Medical : Stock
    {
        public Medical(int quantity, int price, string name)
           : base(name, quantity, price)
        {

        }
    }
}
