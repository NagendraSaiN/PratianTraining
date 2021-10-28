using System;

namespace Customer_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Customer name ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Customer Id ");
            string id = Console.ReadLine();

            Console.WriteLine("Enter Customer address 1 ");
            string addr1 = Console.ReadLine();

            Console.WriteLine("Enter Customer address 2 ");
            string addr2 = Console.ReadLine();

            Console.WriteLine("Enter Customer City ");
            string city = Console.ReadLine();

            Console.WriteLine("Enter Pincode ");
            int pincode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter fees ");
            double fees = Convert.ToDouble(Console.ReadLine());
            Address address = new Address();
            address.addr1 = addr1;
            address.addr2 = addr2;
            address.city = city;
            address.pin = pincode;

            RegCustomer cust1 = new RegCustomer(id, name, address, fees);

            Console.WriteLine("\n");
            cust1.Display();

            Console.Read();
        }
    }
}
