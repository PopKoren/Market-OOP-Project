using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bursa.Backend.Models
{
    public class BTCchain : Crypto
    {

        protected BTCchain(string name, int price, bool mineable, bool stable, int totalsup)
             : base(name, price, mineable, stable, totalsup)
        {

        }
    }
}
