using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    public abstract class Shape
    {
        public abstract void CalculateArea();

        public void Display()
        {
            // define some basic info about Shape
        }


    }
    public class Circle : Shape
    {
        private int radius;
        private double result;
        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override void CalculateArea()
        {
            result = 3.14 * radius * radius;
        }
        public string Print()
        {
            return $"Area of circle is {result}";
        }
    }
    public class Rectangle : Shape
    {
        private int length;
        private int breadth;
        private double result;
        public Rectangle(int length ,int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        public override void CalculateArea()
        {
            result =  length * breadth;
        }
        public string Print()
        {
            return $"Area of Rectangle is {result}";
        }
    }
}
