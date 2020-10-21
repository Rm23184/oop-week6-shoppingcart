using System;
using System.Collections.Generic;
using System.Text;

namespace oop_week6_shoppingcart
{
    class Item
    {
        string name;
        double price;
        public string Name { get { return name; } }
        public double Price { get { return price; } }
        public Item(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
