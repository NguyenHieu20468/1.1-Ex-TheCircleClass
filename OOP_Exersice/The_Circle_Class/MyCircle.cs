using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Circle_Class
{
    public class MyCircle
    {
        private double radius;
        private string color;

        public MyCircle()
        {
            radius = 1.0;
            color = "red";
        }

        public MyCircle( double r)
        {
            radius = r;
            color = "red";
        }

        public MyCircle(double r, string c )
        {
            radius = r;
            color = c;
        }

        public double GetRadius()
        {
            return radius;
        }
        public double GetAre()
        {
            return radius * radius * Math.PI;
        }

        public string GetColor()
        {
            return color;
        }

        public void SetRadius(double newRadius)
        {
            radius = newRadius;
        }

        public void SetColor(string newColor)
        {
            color = newColor;
        }
    }
}
