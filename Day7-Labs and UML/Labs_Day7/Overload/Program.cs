using System;

namespace Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Addition addition = new Addition();
            Console.WriteLine("Addition of 2 intergers ");
            Console.WriteLine("Enter 2 integers : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum of 2 integers = " + Addition.add(num1, num2));

            Console.WriteLine("\nAddition of 2 doubles ");
            Console.WriteLine("Enter 2 double numbers : ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sum of 2 doubles = " + Addition.add(n1, n2));


            Console.WriteLine("\nConcatination  of 2 strings ");
            Console.WriteLine("Enter 2 strings : ");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            Console.WriteLine("Concatenation of 2 strings = " + Addition.add(str1, str2));

            Console.ReadLine();
        }
    }
}
