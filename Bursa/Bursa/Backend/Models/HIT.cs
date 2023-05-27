using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bursa.Backend.Models
{
    [Serializable]

    public class HIT : Crypto
    {
        public HIT(int quanity)
            : base("HIT", quanity, 1, false, true)
        {

        }
    }
}
