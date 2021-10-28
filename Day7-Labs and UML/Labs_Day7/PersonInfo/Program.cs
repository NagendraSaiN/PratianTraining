using System;

namespace PersonInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter details of person 1 ");
            Person p1 = new Person();
            Console.WriteLine("Enter name : ");
            p1.name = Console.ReadLine();
            Console.WriteLine("Enter age :");
            p1.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter sex : ");
            p1.sex = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter details of person 2 ");
            Person p2 = new Person();
            Console.WriteLine("Enter name : ");
            p2.name = Console.ReadLine();
            Console.WriteLine("Enter age :");
            p2.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter sex : ");
            p2.sex = Convert.ToChar(Console.ReadLine());

            if (Program.equals(p1, p2)==1)
                Console.WriteLine("Both the instances matched.Persons Equal");
            else
                Console.WriteLine("Both the instances does not match.Persons Not Equal");

            Console.ReadLine();
        }

        static int equals(Person p1, Person p2)
        {
            if ((p1.name.Equals(p2.name)) && (p2.age.Equals(p1.age)) && (p1.sex == p2.sex))
                return 1;
            return 0;
        }
    }
}
