using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bursa.Backend.Models
{
    public class Etherium : Crypto
    {
        public Etherium(int quanity, int price)
             : base("Etherium", quanity, price, false, false)
        {
           
        }
    }
}
