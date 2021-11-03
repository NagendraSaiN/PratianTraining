using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Marks for 1st Subject");
            int Marks1 = CustomConsole.ReadInt();
            Console.WriteLine("Enter Marks for 2nd Subject");
            int Marks2 = CustomConsole.ReadInt();
            Console.WriteLine("Enter Marks for 3rd Subject");
            int Marks3 = CustomConsole.ReadInt();

            ResultFinder Finder = new ResultFinder();
            Finder.Marks1 = Marks1;
            Finder.Marks2 = Marks2;
            Finder.Marks3 = Marks3;

            Console.WriteLine("Report Of marks Entered");
            Console.WriteLine("=======================");
            Console.WriteLine("Total : " + Finder.GetTotal()+"/300");
            Console.WriteLine("Average : " + Finder.GetAverage());
            Console.WriteLine("Result : " + Finder.GetResult());
            Console.ReadLine();
        }
    }
}
