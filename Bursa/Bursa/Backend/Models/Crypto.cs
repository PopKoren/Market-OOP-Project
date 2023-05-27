using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bursa.Backend.Models
{
    [Serializable]

    public abstract class Crypto : Item
    {
        public bool IsMinable { get; set; }

        public bool IsStableCoin { get; set; }


        public Crypto(string name, int quantity, int price, bool mineable, bool stable)
            : base(name, quantity, price)
        {
            IsMinable = mineable;
            IsStableCoin = stable;
        }
    }
}
