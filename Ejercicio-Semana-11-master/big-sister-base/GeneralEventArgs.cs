﻿using System;
using System.Collections.Generic;
using System.Text;

namespace big_sister_base
{
    public class GeneralEventArgs : EventArgs
    {
        public Cart Cart { get; set; }
        public List<Product> ShopList { get; set; }
    }
}
