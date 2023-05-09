using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bursa.Backend.Models
{
   public abstract class Item
    {
        public string Name { get; set; }
        public int Price { get; set; }
          
        protected Item(string name, int price)
        {
            Name = name;
            Price = price;
        }


    }
}
