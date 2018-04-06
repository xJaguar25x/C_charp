using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComplexClass;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex t1 = new Complex(1.0, 1.0);
            Complex t2 = new Complex(2.2, 3.3);
            Complex t3 = new Complex();

            t3.Sum(t1, t2);
            t1.Print_Complex(t1);
            t2.Print_Complex(t2);
            t3.Print_Complex(t3);
            //Console.WriteLine(t1);
            // Console.WriteLine(t2);
            //Console.WriteLine(t3);
            Console.ReadLine();
        }
    }
}
