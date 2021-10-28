using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleArea
{
    class Rectangle
    {
        public double length { get; set; }
        public double breadth { get; set; }
        public Rectangle(double l,double b)
        {
            this.length = l;
            this.breadth = b;
        }
        public double Area()
        {
            return (this.breadth * this.length);
        }
    }
}
