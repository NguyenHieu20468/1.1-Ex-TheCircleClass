using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Simplified_Circle_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            SimplifedCircle SC = new SimplifedCircle();
            Console.WriteLine(SC.ToString());

            SimplifedCircle SC1 = new SimplifedCircle(10);
            Console.WriteLine(SC1.ToString() + " and circle area is {0}", SC1.GetAre() + " and circle get circumference is "+ SC1.GetCircumference());
        }
    }
}
