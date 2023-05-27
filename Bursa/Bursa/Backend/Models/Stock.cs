using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bursa.Backend.Models
{
    [Serializable]

    public abstract class Stock : Item
    {
        public Stock(string name, int quantity, int price)
           : base(name, quantity, price)
        {
          
        }
    }
}
