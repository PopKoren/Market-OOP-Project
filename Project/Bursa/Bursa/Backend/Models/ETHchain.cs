using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bursa.Backend.Models
{
    public class ETHchain : Crypto
    {
        protected ETHchain(string name, int price, bool mineable, bool stable, int totalsup)
             : base(name, price, mineable, stable, totalsup)
        {
           
        }
    }
}
