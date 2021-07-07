using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1DataJsonXmlConvert.Geometry
{
    class Polygon
    {
        List<Point> points;

        public Polygon(List<Point> _points)
        {
            points = _points;
        }

        public bool IsComplex()
        {
            for (int k = 0; k < points.Count - 2; k++)
            {
                for (int m = k + 2; m < points.Count - 1; m++)
                {
                    BoolString isCut = Test.IsCut(points[k], points[k + 1], points[m], points[m + 1]);
                    if (isCut.b)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public List<Point> Points
        {
            get { return points; }
        }

        public string ToString()
        {
            string listpoint = "";
            for (int i = 0; i < Points.Count; i++)
            {
                listpoint += Points[i].ToString()+" ";
                break;
            }
            return listpoint;
        }
    }
}
