using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1DataJsonXmlConvert.Math
{
    class _
    {
        public static int ucln(double da, double db)
        {
            if(da ==0 || db == 0 || da == 1 || db == 1)
            {
                return 1;
            }
            if (da < 0) da = -da;
            if (db < 0) db = -db;
            int a = (int)da;
            int b = (int)db;
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a; // or return b; a = b
        }
        public static int ucln(double da, double db, double dc)
        {
            double d = ucln(da, db);
            int e = ucln(d, dc);
            return e;
        }


    }
}
