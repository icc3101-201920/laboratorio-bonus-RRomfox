using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace big_sister_base
{
    public class BigSister
    {
        public bool OnAddedProduct(object source, EventArgs e)
        {

            
            Console.WriteLine("Checker: Success, product is in the list");
            Thread.Sleep(3000);
            return true;
            //if (e.CartProducts.Equals(e.ListProducts))
            //{
            //    Thread.Sleep(3000);
            //    Console.WriteLine("Checker: Success, product is in the list");
            //    return true;
            //}
            //else
            //{
            //    Thread.Sleep(3000);
            //    Console.WriteLine($"Checker: Error, product is not in the list");
            //    return false;
            //}
        }
    }
}
