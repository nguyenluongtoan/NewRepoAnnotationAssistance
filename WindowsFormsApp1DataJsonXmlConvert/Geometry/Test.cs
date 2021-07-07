using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1DataJsonXmlConvert.Geometry
{

    class Test
    {
        public double x;
        public double y;
        public static double k;
       // public static Point[] P = new Point[100];
        public static int i1;
        public static int i2;
        public static double GitriDiem(Point A, Point B, Point M)
        {
            k = (M.x - A.x) * (B.y - A.y) - (M.y - A.y) * (B.x - A.x);
            return k;
        }
        public static bool KhacPhia(Point A, Point B, Point C, Point D)
        {
            Point[] P = new Point[100];
            Point[] Q = new Point[100];
            for(int i = 0; i < 100; i++)
            {
                P[i] = new Point();
                Q[i] = new Point();
            }

            double a = GitriDiem(P[0], P[1], P[2]);
            
            for (int i = 0; i <= 3; i++)
            {
                Q[i] = new Point();
                i1 = (i + 1) % 4;
                i2 = (i + 2) % 4;
                if (a * GitriDiem(Q[i], Q[i1], Q[i2]) <= 0)
                {
                    return false;
                }
            }
            return true;
        }
        public void InPut()
        {
            Console.WriteLine("Nhap Toa Do Diem.");
            Point A = new Point();
            A.x = Convert.ToSingle(Console.ReadLine());
            A.y = Convert.ToSingle(Console.ReadLine());
        }
        public static void r1()
        {
            Point A = new Point(0, 1);
            Point B = new Point(1, 0);
            Point C = new Point(1, 1);
            Point D = new Point(0, 0);

            //if (KhacPhia(A, B, C, D) && KhacPhia(C, D, A, B))
            if (KhacPhia(A, C, B, D) && KhacPhia(B, D, A, C))
            {
                Console.Write("Hai Duong Thang Cat nhau.");
            }
            else
            {
                Console.Write("Hai Duong Thang Khong Cat Nhau.");
            }
            Console.ReadLine();
        }
        public static bool Run()
        {
            Point A = new Point(0, 2);
            Point B = new Point(2, 0);
            Point C = new Point(2, 2);
            Point D = new Point(0, 0);

            Line lineAB = new Line(A, B);
            Line lineCD = new Line(C, D);

            Point E = lineAB.CutPoint(lineCD);

            double EA = E.distance(A);
            double EB = E.distance(B);
            double AB = A.distance(B);
            double EC = E.distance(C);
            double ED = E.distance(D);
            double CD = C.distance(D);


            if ( 
                    (
                        EA < AB && EB < AB &&
                        EA+EB <= AB
                    )
                    &&
                    (
                        EC < CD && ED < CD &&
                        EC+ED <= CD
                    )
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static BoolString IsCut(Point A, Point B, Point C, Point D)
        {
           
            BoolString bs = new BoolString();
            Line lineAB = new Line(A, B);
            Line lineCD = new Line(C, D);

            Point E = lineAB.CutPoint(lineCD);
            if (!E.isPoint())
            {
                bs.b = false;
            }
            else
            {
                bs.s = "giao diem la " + E.x + "-" + E.y;
                double EA = E.distance(A);
                double EB = E.distance(B);
                double AB = A.distance(B);
                double EC = E.distance(C);
                double ED = E.distance(D);
                double CD = C.distance(D);

                if  (
                        (
                            EA < AB && EB < AB &&
                            EA + EB  <= AB + 0.5
                        )
                        &&
                        (
                            EC < CD && ED < CD &&
                            EC + ED <= CD + 0.5
                        )
                    )
                {
                    bs.b = true;
                }
                else
                {
                    bs.b = false;
                }
            }
            
            return bs;
        }

    }

}
