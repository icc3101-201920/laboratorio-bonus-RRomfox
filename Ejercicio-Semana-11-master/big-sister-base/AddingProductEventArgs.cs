using System;
using System.Collections.Generic;
using System.Text;

namespace big_sister_base
{
    public class AddingProductEventArgs:EventArgs
    {
        public Cart Cart { get; set; }
    }
}
