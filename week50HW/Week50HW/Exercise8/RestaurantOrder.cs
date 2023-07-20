using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.Exercise3
{

    public class QMenu
    {
        public string Name { get; set; }
        public double Price { get; }
        public int Quantity { get; set; }

        public QMenu(string name, double price)
        {
            Name = name;
            Price = price;
            Quantity = 1;
        }
    }


    public class RestaurantOrder
    {
        public int TableNumber { get; set; }
        public List<QMenu> OrderItems { get; }

        public RestaurantOrder(int tableNumber)
        {
            TableNumber = tableNumber;
            OrderItems = new List<QMenu>();
        }

        public void AddItem(string itemName, double itemPrice)
        {
            QMenu itemExist = null;
            foreach (QMenu menuItem in OrderItems)
            {
                if (menuItem.Name == itemName)
                {
                    itemExist = menuItem;
                    break;
                }
            }
            if (itemExist == null)
            {
                OrderItems.Add(new QMenu(itemName, itemPrice));
            }
            else
            {
                itemExist.Quantity++;
            }
        }

        public void RemoveItem(string item)
        {
            QMenu itemRemove = null;
            foreach (QMenu menuItem in OrderItems)
            {
                if (menuItem.Name == item)
                {
                    itemRemove = menuItem;
                    break;
                }
            }
            if (itemRemove != null)
            {
                OrderItems.Remove(itemRemove);
            }
        }

        public double CalculateTotal()
        {
            double TotalReceipt = 0;
            foreach (QMenu menuItem in OrderItems)
            {
                TotalReceipt += menuItem.Price * menuItem.Quantity;
            }
            return TotalReceipt;
        }

        public void PrintOrder()
        {
            Console.WriteLine($"The table with the number {TableNumber} have ordered :");
            foreach (QMenu menuItem in OrderItems)
            {
                Console.WriteLine($"* {menuItem.Name} with the quantity of {menuItem.Quantity}");
            }
            Console.WriteLine($"The charge for table {TableNumber} is {CalculateTotal()}");
        }

    }



}
