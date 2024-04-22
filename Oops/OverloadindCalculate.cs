using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class OverloadindCalculate

    {
        public void Calculate(double length ,double breadth)
        {
            Console.WriteLine("Area of rectangle = "+( length*breadth));
        }
        public void Calculate(double side)
        {
            Console.WriteLine("Area of Square = " + (side * side));
        }
        public void Calculate(float baselength, float hieght)
        {
            Console.WriteLine("Area of tringle = " +( 0.5*baselength * hieght));
        }
        public void Calculate(float r)
        {
            Console.WriteLine("Area of Circle = " +(3.14 *r * r));
        }

    }
}
