using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bursa.Backend.Models
{
    public class HIT : Crypto
    {
        public HIT(int quanity, int price)
            : base("HIT", quanity, price, false, true)
        {

        }
    }
}
