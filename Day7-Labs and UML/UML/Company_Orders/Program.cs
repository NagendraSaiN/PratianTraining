using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Item item1 = new Item();
            item1.desc = "Poco M2 pro";
            item1.rate = 12000;

            Item item2 = new Item();
            item2.desc = "College Bag";
            item2.rate = 999;

            Customer customer;
            Console.WriteLine("Do you want to subscribe? \n Select 1 for yes and 0 for no");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
                customer = new RegCustomer(10);
            else
                customer = new Customer();

            Order order = new Order();

            Console.WriteLine("\n1. " + item1.desc + ", Rate = " + item1.rate);
            Console.WriteLine("2. " + item2.desc + ", Rate = " + item2.rate);
            Console.WriteLine("\nPlease select item from above ");
            int selected = Convert.ToInt32(Console.ReadLine());


            if (selected == 1)
            {
                Console.WriteLine("Enter required quantity : ");
                int qty = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    item1.rate -= (item1.rate * 10) / 100;
                }
                item1.orderedItem.qty = qty;
                order.items.Add(item1);
                customer.orderList.Add(order);
            }

            else if (selected == 2)
            {
                Console.WriteLine("Enter required quantity : ");
                int qty = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    item2.rate -= (item2.rate * 10) / 100;
                }
                item2.orderedItem.qty = qty;
                order.items.Add(item2);
                customer.orderList.Add(order);
            }


            Company c = new Company();
            Console.WriteLine("Total Ordered worth = " + c.getTotalWorthOfOrderPlaced(customer.orderList));

            Console.ReadLine();
        }
    }
}