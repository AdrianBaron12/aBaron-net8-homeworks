using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week40.Product1
{
    public class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string GetName()
        {
            return Name;
        }
        public double GetPrice()
        {
            return Price;
        }
        public int GetQuantity()
        {
            return Quantity;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetPrice(double price)
        {
            Price = price;
        }

        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }

    }
}
