using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace oop_week6_shoppingcart
{
    class Till
    {
        private List<Item> items = new List<Item>();
        public void AddItem(Item item)
        {
            items.Add(item);
        }
        private double Checkout(string input)
        {
            double output=0;
            int rank = 0;
            while (rank<items.Count)
            {
                if(input == items[rank].Name)
                {
                    break;
                }
                rank++;
            }
            if(rank >= items.Count)
            {
                Console.WriteLine("Item "+input + " not found.");
            }
            else
            {
                output = items[rank].Price;
            }
            return output;
        }
        public double CheckList(string cart)
        {
            double totalcost = 0;
            string[] cartlist = cart.Split(", ");
            foreach (string singleitem in cartlist)
            {
                totalcost += Checkout(singleitem);
            }
            return totalcost;
        }
    }
}
