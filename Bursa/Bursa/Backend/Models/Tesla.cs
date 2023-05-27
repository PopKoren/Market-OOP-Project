using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bursa.Backend.Models
{
    [Serializable]

    public class Tesla : Stock
    {
        public Tesla(int quantity)
           : base("Tesla", quantity, 200)
        {

        }
    }
}
