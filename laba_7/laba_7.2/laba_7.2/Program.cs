using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_7._2
{
    class Rational
    {
        // 7-2
        private int m = 0, n = 0;

        public Rational(int a, int b)
        {
            if (b == 0) { m = 0; n = 1; }
            else
            {
                // приведение знака
                if (b < 0) { b = -b; a = -a; }
                // приведение к несократимой дроби
                int d = nod(a, b);
                m = a / d; n = b / d;
            }
        }

        int nod(int m, int n)
        {
            int p = 0;
            m = Math.Abs(m); n = Math.Abs(n);
            if (n > m)
            {
                p = m; m = n; n = p;
            }
            do
            {
                p = m % n; m = n; n = p;
            } while (n != 0);

            return (m);
        }

        public override string ToString()
        {
            return m + "/" + n;
        }

        public void PrintRational(string name)
        {
            Console.WriteLine("{0} = {1}", name, ToString());
        }
        // 7-2 end

        // 7-3
        public Rational Plus(Rational a)
        {
            int u, v;
            u = m * a.n + n * a.m;
            v = n * a.n;
            return (new Rational(u, v));
        } 
        // Plus
        public static Rational operator +(Rational r1, Rational r2)
        {
            return (r1.Plus(r2));
        }

        public Rational Minus(Rational a)
        {
            int u, v;
            u = m * a.n - n * a.m;
            v = n * a.n;
            return (new Rational(u, v));
        } 
        // Minus
        public static Rational operator -(Rational r1, Rational r2)
        {
            return (r1.Minus(r2));
        }

        public Rational Mult(Rational a)
        {
            int u, v;
            u = m * a.m;
            v = n * a.n;
            return (new Rational(u, v));
        } 
        // Mult
        public static Rational operator *(Rational r1, Rational r2)
        {
            return (r1.Mult(r2));
        }

        public Rational Divide(Rational a)
        {
            int u, v;
            u = m * a.n;
            v = n * a.m;
            return (new Rational(u, v));
        } 
        // Divide
        public static Rational operator /(Rational r1, Rational r2)
        {
            return (r1.Divide(r2));
        }
        // 7-3 end

        // 7-4
        private Rational(int a, int b, string t)
        {
            m = a; n = b;
        }
        //Константы класса 0 и 1 - Zero и One
        public static readonly Rational Zero, One;

        static Rational()
        {
            Console.WriteLine("         static constructor Rational");
            Zero = new Rational(0, 1, "private");
            One = new Rational(1, 1, "private");
        } 
        // Статический конструктор
        public static bool operator ==(Rational r1, Rational r2)
        {
            return ((r1.m == r2.m) && (r1.n == r2.n));
        }

        public static bool operator !=(Rational r1, Rational r2)
        {
            return ((r1.m != r2.m) || (r1.n != r2.n));
        }

        public static bool operator <(Rational r1, Rational r2)
        {
            return (r1.m * r2.n < r2.m * r1.n);
        }

        public static bool operator >(Rational r1, Rational r2)
        {
            return (r1.m * r2.n > r2.m * r1.n);
        }

        public static bool operator <(Rational r1, double r2)
        {
            return ((double)r1.m / (double)r1.n < r2);
        }

        public static bool operator >(Rational r1, double r2)
        {
            return ((double)r1.m / (double)r1.n > r2);
        }
        // 7-4 end

        public void Test_Rational()
        {
            Rational r1 = new Rational(2, 8);
            Rational r2 = new Rational(2, 5);
            Rational r3 = new Rational(4, 10);
            Rational r4 = new Rational(3, 7);
            Rational r5 = Rational.Zero;
            Rational r6 = Rational.Zero;
            if ((r1 != Rational.Zero) && (r2 == r3)) r5 = (r3 + Rational.One) * r4;
            r6 = Rational.One + Rational.One;
            r1.PrintRational("r1 = (2,8)");
            r2.PrintRational("r2 = (2,5)");
            r3.PrintRational("r3 = (4,10)");
            r4.PrintRational("r4 = (3,7)");
            r5.PrintRational("r5 = ((r3 +1)*r4)");
            r6.PrintRational("r6 = (1+1)");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Rational rr1 = new Rational(0, 0), rr2 = new Rational(1, 1), rr3 = new Rational(10, 8);
            Rational rr4 = new Rational(2, 6), rr5 = new Rational(4, -12), rr6 = new Rational(-12, -14);
            rr1.PrintRational("rr1 = (0,0)");
            rr2.PrintRational("rr2 = (1,1)");
            rr3.PrintRational("rr3 = (10,8)");
            rr4.PrintRational("rr4 = (2,6)");
            rr5.PrintRational("rr5 = (4,-12)");
            rr6.PrintRational("rr6 = (-12,-14)");

            Console.WriteLine("\n");

            Rational r1 = new Rational(1, 2), r2 = new Rational(1, 3);
            Rational r3, r4, r5, r6;
            r3 = r1 - r2;
            r4 = r1 * r2;
            r5 = r1 / r2;
            r6 = r3 + r4 * r5;
            r1.PrintRational("r1 = (1,2)");
            r2.PrintRational("r2 = (1,3)");
            r3.PrintRational("r3 = (r1-r2)");
            r4.PrintRational("r4 = (r1*r2)");
            r5.PrintRational("r5 = (r1/r2)");
            r6.PrintRational("r6 = (r3+r4*r5)");

            Console.WriteLine("\n");

            r1.Test_Rational();

            Console.ReadLine();
        }
    }
}
