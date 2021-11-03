using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab7
{
    class ResultFinder
    {
     
        public int Marks1 { get; set; }
	    public int Marks2 { get; set; }
	    public int Marks3 { get; set; }
        
   
        public void DisplayMarks()
        {
	        Console.WriteLine("Marks 1 : " + Marks1);
            Console.WriteLine("Marks 2 : " + Marks2);
            Console.WriteLine("Marks 3 : " + Marks3);
        }

 
        public int GetTotal()
        {
            return (Marks1+Marks2+Marks3);
        }

   
        public double GetAverage()
        {
            return ((Marks1+Marks2+Marks3)/3);
        }

 
        public string GetResult()
        {
            if(Marks1>35 && Marks2>35 &&Marks3>35)
                return "Passed";
            else 
                return "Failed";
        }
    }
}
