using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1DataJsonXmlConvert.Geometry
{
    class Line
    {
        public double a;
        public double b;
        public double c;

        public Line()
        {

        }
        public Line(Point A, Point B)
        {
            Vab vectorAB = new Vab(A, B);
            Vab vectorN = new Vab();
            vectorN.x = -vectorAB.y;
            vectorN.y = vectorAB.x;
            a = vectorN.x;
            b = vectorN.y;
            c = -vectorN.x * A.x - vectorN.y * A.y;
            MinimizedParams();
        }
        public Point CutPoint(Line other)
        {
            double d = other.a;
            double e = other.b;
            double f = other.c;

            double y = (float)( (a * f - c * d) / (b * d - a * e)   );
            double x = (c + b * y) / (-a);
            return new Point(x, y);
        }

        public void MinimizedParams()
        {
            double u = Math._.ucln(a, b, c);
            a /= u;
            b /= u;
            c /= u;
        }
    }
}
