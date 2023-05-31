﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bursa.Backend.Models
{
    [Serializable]

    public class Tesla : Stock
    {
        public override Image GetPicture()
        {
            return Bursa.Properties.Resources.tesla;
        }

        public Tesla(int quantity)
           : base("Tesla", quantity, 200)
        {

        }
    }
}
