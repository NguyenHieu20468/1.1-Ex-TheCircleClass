using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Circle_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCircle circle = new MyCircle();
            Console.WriteLine("The circle has radius of {0} and get arra is {1} ", circle.GetRadius(), circle.GetAre());

            MyCircle circle1 = new MyCircle(5);
            Console.WriteLine("The circle has radius of {0} and get arra is {1} ", circle1.GetRadius(), circle1.GetAre());

            MyCircle circle2 = new MyCircle(2, "Orange");
            Console.WriteLine("The circle has radius of {0} and get arra is {1} and set color is {2} ", circle2.GetRadius(), circle2.GetAre(),circle2.Color());
            Console.WriteLine(circle2.ToString());
        }
    }
}
