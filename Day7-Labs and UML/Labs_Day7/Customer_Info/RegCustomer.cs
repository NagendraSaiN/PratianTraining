using System;
using System.Collections.Generic;
using System.Text;

namespace Customer_Info
{
    class RegCustomer:Customer
    {
        protected double fees { get; set; }
        public RegCustomer(string cust_id, string Name, Address addr, double fee) : base(cust_id, Name, addr)
        {
            this.custID = cust_id;
            this.name = Name;
            this.address = addr;
            this.fees = fee;
        }
        public void Display()
        {
            Console.WriteLine("********************************");
            Console.WriteLine("\nCustomer Id : " + this.custID);
            Console.WriteLine("Customer Name : " + this.name);
            Console.WriteLine("Customer Address 1 : " + this.address.addr1 + "\nCustomer Address 2 : " + this.address.addr2 + "\nCustomer city : " + this.address.city + ", Pincode : " + this.address.pin);
            Console.WriteLine("Fees : " + this.fees);
            Console.WriteLine("********************************");

        }
    }
}
