using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace big_sister_base
{
    public class BigSister
    {
        public bool OnAddedProduct(object source, GeneralEventArgs e)
        {
            Console.WriteLine("\nBig sister is watching from afar...\n");
            Thread.Sleep(2000);

            List<string> checkCart = new List<string>();
            List<string> checkList = new List<string>();
            foreach (Product p1 in e.Cart.Products)
            {
                checkCart.Add(p1.Name);
            }
            foreach (Product p2 in e.ShopList)
            {
                checkList.Add(p2.Name);
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

        public bool OnPayChance(object source, GeneralEventArgs e)
        {
            Console.WriteLine("\nBig sister is watching from afar...\n");
            Thread.Sleep(2000);

            List<string> checkCart = new List<string>();
            List<string> checkList = new List<string>();
            foreach (Product p1 in e.Cart.Products)
            {
                checkCart.Add(p1.Name);
            }
            foreach (Product p2 in e.ShopList)
            {
                checkList.Add(p2.Name);
            }

            foreach (string p in checkCart)
            {
                if (checkList.Contains(p) == true)
                {
                    checkList.Remove(p);
                }
            }


            bool departure = false;
            if (checkList.Count == 0)
            {
                departure = true;
                Console.WriteLine("\nGood work! Let's go home.\n");
            }
            if (checkList.Count != 0)
            {
                Console.WriteLine("\nWait! You have not gathered all the ingredients...\n");
                Thread.Sleep(1000);
                Console.WriteLine("\nTake another walk to see what it missing.\n");
            }

            Thread.Sleep(2000);
            return departure;
        }
    }
}
