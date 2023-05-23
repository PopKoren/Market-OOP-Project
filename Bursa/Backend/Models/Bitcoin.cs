using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bursa.Backend.Models
{
    public class Bitcoin : Crypto
    {
       
        public Bitcoin(int quanity, int price)
             : base("Bitcoin", quanity, price, true, false)
        {

        }
    }
}
