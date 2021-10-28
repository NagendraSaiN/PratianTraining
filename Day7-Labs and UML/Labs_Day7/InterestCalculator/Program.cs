using System;

namespace InterestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //7th Question
            Console.WriteLine("Enter the Principle Amount");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Time in Years");
            int t = Convert.ToInt32(Console.ReadLine());
            InterestCalculator ic = new InterestCalculator(t, p);
        }
    }
}
