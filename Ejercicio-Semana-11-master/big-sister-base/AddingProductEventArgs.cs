using System;
using System.Collections.Generic;
using System.Text;

namespace big_sister_base
{
    public class AddingProductEventArgs
    {
        public List<string> CartProducts { get; set; }
        public List<string> ListProducts { get; set; }
    }
}
