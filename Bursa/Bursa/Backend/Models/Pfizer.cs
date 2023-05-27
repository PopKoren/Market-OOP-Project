using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bursa.Backend.Models
{
    [Serializable]

    public class Pfizer : Stock
    {
        public Pfizer(int quantity)
           : base("Pfizer", quantity, 40)
        {

        }
    }
}
