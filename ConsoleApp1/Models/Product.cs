using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Product
    {
        public string Name;
        public int Count;
        public double Price;

        public Product(string name, int count, double price)
        {
            Name = name;
            Count = count;
            Price = price;
        }

        public override string ToString()
        {
            return $"Product: {Name} - {Price} AZN - {Count} Eded";
        }
    }
}
