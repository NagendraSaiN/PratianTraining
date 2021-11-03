using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4
{
    class Cache
    {
        static int flag=0;
        private static int MAX_CAPACITY = 0;
        public static int GetMaxCapacity() 
        {
            if(flag==1)
            {
                Console.WriteLine("Enter the MAX_Capacity");
                MAX_CAPACITY = CustomConsole.ReadInt();
            }
            flag++;
            //Console.WriteLine("Returning Max Capacity");
		    return MAX_CAPACITY;
	    }
    }
}
