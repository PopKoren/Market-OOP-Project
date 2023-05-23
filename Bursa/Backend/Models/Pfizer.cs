using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bursa.Backend.Models
{
    public class Pfizer : Stock
    {
        public Pfizer(int quantity, int price)
           : base("Pfizer", quantity, price)
        {

        }
    }
}
