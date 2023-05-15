using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bursa.Backend.Models
{
    public abstract class Crypto : Item
    {
        public bool IsMinable { get; set; }

        public bool IsStableCoin { get; set; }

        public int TotalSupply { get; set; }

        protected Crypto(string name, int price, bool mineable, bool stable, int totalsup)
            : base(name, price)
        {
            IsMinable = mineable;
            IsStableCoin = stable;
            TotalSupply = totalsup;
        }
    }
}
