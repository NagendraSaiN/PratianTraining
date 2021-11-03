using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Program
    {
        int id=0,pincode;
        string Name,Gender,Address;
        static void Main(string[] args)
        {
            Employee Emp = new Employee();

            StoreData(Emp);

            ShowData(Emp);
        }

        static void StoreData(Employee Emp)
        {
            Console.WriteLine("Employee Id : ");
            Emp.id = CustomConsole.ReadInt();
            Console.WriteLine("Employee Name : ");
            Emp.Name = CustomConsole.ReadString();
            Console.WriteLine("Employee Gender : ");
            Emp.Gender=CustomConsole.ReadString();
            Console.WriteLine("Employee Address : --------------");
            Console.WriteLine("Address 1 : ");
            Emp.Address1=CustomConsole.ReadString();
            Console.WriteLine("Address 2 : ");
            Emp.Address2=CustomConsole.ReadString();
            Console.WriteLine("City : ");
            Emp.City=CustomConsole.ReadString();
            Console.WriteLine("PinCode : ");
            Emp.Pincode=CustomConsole.ReadInt();
            Console.WriteLine("----------------------------------");
        }

        static void ShowData(Employee Emp)
        {
            Console.WriteLine("Employee Id : "+ Emp.id);
            Console.WriteLine("Employee Name : "+Emp.Name);
            Console.WriteLine("Employee Gender : "+Emp.Gender);

            Console.WriteLine("Employee Address : --------------");
            Console.WriteLine("Address 1 : "+Emp.Address1);
            Console.WriteLine("Address 2 : "+Emp.Address2);
            Console.WriteLine("City : "+Emp.City);
            Console.WriteLine("PinCode : "+Emp.Pincode);
            Console.WriteLine("----------------------------------");

        }
    }
}
