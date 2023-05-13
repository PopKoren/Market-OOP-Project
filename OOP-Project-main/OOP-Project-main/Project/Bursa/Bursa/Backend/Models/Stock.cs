using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bursa.Backend.Models
{
    public abstract class Stock : Item
    {
        protected Stock(string name, int price)
           : base(name, price)
        {
          
        }
    }
}
