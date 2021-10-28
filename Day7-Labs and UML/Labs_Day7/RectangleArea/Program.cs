using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the rectangle");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the breadth of the rectangle");
            double b = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(l, b);
            Console.WriteLine("Area of Rectangle : "+ rectangle.Area());
        }
    }
}
