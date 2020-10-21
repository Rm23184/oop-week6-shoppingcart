using System;
using System.Collections;
using System.Collections.Generic;

namespace oop_week6_shoppingcart
{
    class Program
    {
        static void Main(string[] args)
        {
            Till till = new Till();
            till.AddItem(new Item("Apple", 0.60));
            till.AddItem(new Item("Orange", 0.25));
            Console.WriteLine(till.CheckList("Apple, Apple, Orange, Apple"));
        }
    }
}
