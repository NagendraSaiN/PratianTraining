using System;
using System.Collections.Generic;
using System.Text;

namespace Customer_Info
{
    class Customer
    {
        protected string custID { get; set; }
        protected string name { get; set; }
        protected Address address { get; set; } = new Address();
        public Customer(string Id, string Name, Address addr)
        {
            this.custID = Id;
            this.name = Name;
            this.address = addr;
        }
    }
}
