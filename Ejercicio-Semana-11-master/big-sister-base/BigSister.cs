using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace big_sister_base
{
    public class BigSister
    {
        public void OnAddedProduct(object source, AddingProductEventArgs e)
        {
            Console.WriteLine("\nBig sister is watching from afar...\n");

            foreach(Product p in e.Cart.Products)
            {
                Console.WriteLine(p.Name);
            }
            Thread.Sleep(3000);
        }
    }
}
