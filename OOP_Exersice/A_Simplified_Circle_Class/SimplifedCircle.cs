using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Simplified_Circle_Class
{
    public class SimplifedCircle
    {
        private double radius;

        public SimplifedCircle()
        {
            radius = 1.0;
        }

        public SimplifedCircle( double r)
        {
            radius = r;
        }


        public double GetRadius()
        {
            return radius;
        }
        public double Radius(double radius)
        {
            return this.radius;
        }

        public double GetAre()
        {
            return radius * radius * Math.PI;
        }

        public double GetCircumference()
        {
            return 2*radius*Math.PI;
        }

        //overload
        public override string ToString()
        {
            return String.Format("The circle has radius of {0}",radius);
        }
    }
}
