using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace big_sister_base
{
    public class BigSister
    {
        public bool OnAddedProduct(object source, AddingProductEventArgs e)
        {
            Console.WriteLine("\nBig sister is watching from afar...\n");
            Thread.Sleep(2000);

            List<string> checkCart = new List<string>();
            List<string> checkList = new List<string>();
            foreach (Product p1 in e.Cart.Products)
            {
                checkCart.Add(p1.Name);
                //Console.WriteLine(p1.Name);
            }
            foreach (Product p2 in e.ShopList)
            {
                checkList.Add(p2.Name);
                //Console.WriteLine(p2.Name);
            }

            bool productInList = true;
            foreach (string p in checkCart)
            {
                if (checkList.Contains(p) == true)
                {
                    checkList.Remove(p);
                }
                else
                {
                    productInList = false;
                    Console.WriteLine("\nBig sister approaches...\n");
                    Thread.Sleep(1500);
                    Console.WriteLine("\n'That's not necessary, put it back where it belongs to.'\n");
                    break;
                }
            }


            Thread.Sleep(2000);
            return productInList;
        }
    }
}
