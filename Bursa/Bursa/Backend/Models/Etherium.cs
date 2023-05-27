using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bursa.Backend.Models
{
    [Serializable]

    public class Etherium : Crypto
    {
        public Etherium(int quanity)
             : base("Etherium", quanity, MainForm.ethprice, false, false)
        {
           
        }
    }
}
