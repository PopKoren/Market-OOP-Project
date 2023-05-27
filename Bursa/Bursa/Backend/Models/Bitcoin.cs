﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bursa.Backend.Models
{
    [Serializable]

    public class Bitcoin : Crypto
    {
       
        public Bitcoin(int quanity)
             : base("Bitcoin", quanity, MainForm.btcprice, true, false)
        {

        }
    }
}
