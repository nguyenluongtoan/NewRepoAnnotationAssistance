using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1DataJsonXmlConvert.Geometry
{
    class Point
    {
        public double x;
        public double y;
        public Point()
        {

        }
        public Point(double a, double b)
        {
            x = a;
            y = b;
            if (a == 0) x = 1;if (b == 0) y = 1;
            Console.WriteLine("diem co toa do x=" + x);
            Console.WriteLine("diem co toa do y=" + y);
        }

        public bool isPoint()
        {
            if(double.IsNaN(x) || double.IsNaN(y))
            {
                return false;
            }
            return true;
        }

        public double distance(Point other)
        {
            double d = other.y;
            double c = other.x;
            double square = (d - y) * (d - y) + (c - x) * (c - x);
            if(square == double.NaN)
            {
                return 999999;
            }
            
            return System.Math.Sqrt(square);
        }
        public string ToString()
        {
            return "["+x + "," + y+"]";
        }

    }
}
