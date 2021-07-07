using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1DataJsonXmlConvert.Geometry
{
    class Vab
    {
        public double x;
        public double y;
        public Vab()
        {

        }
        public Vab(float a, float b)
        {
            x = a;
            y = b;
        }

        public Vab(Point a, Point b)
        {
            x = b.x - a.x;
            y = b.y - a.y;
        }
    }
}
