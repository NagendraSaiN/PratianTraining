using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number1 = 100;
            int Number2 = 200;

            DisplayValues("Before Swapping...", Number1, Number2);

            SwapValues(ref Number1, ref Number2);

            DisplayValues("After Swapping...", Number1, Number2);

            Console.ReadLine();
        }

    
        private static void SwapValues(ref int Number1, ref int Number2)
        {
            int Temp;
            Temp = Number1;
            Number1=Number2;
            Number2 = Temp;
            
        }

 
        private static void DisplayValues(string Str, int Number1, int Number2) 
        {
		    Console.WriteLine(Str);
		    Console.WriteLine("Number 1 = " + Number1);
            Console.WriteLine("Number 2 = " + Number2);
	    }
    }
}
