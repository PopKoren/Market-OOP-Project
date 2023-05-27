using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bursa.Backend.Models
{
    [Serializable]

    public abstract class Item
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        
        public Item(string name, int quantity, int price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }


    }
}
