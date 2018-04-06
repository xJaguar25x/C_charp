using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexClass
{
    public class Complex
    {
        double r, i;

        public Complex(double r, double i)
        {
            this.r = r;
            this.i = i;
        }
        public Complex()
        {
            this.r = 0;
            this.i = 0;
        }

        // сумма
        //public static Complex Sum(Complex C1, Complex C2)
        //{
        //    return new Complex (C1.re + C2.re, C1.im + C2.im);
        //}
        public Complex Sum(Complex a, Complex b)
        {
            Complex res = new Complex();
            res.r = a.r + b.r;
            res.i = a.i + b.i;
            return res;
        }
        //public ….. ….. ToString()
        //{
        //    ….. "" + re + "  " + im;
        //}

        // печать
        public void Print_Complex(Complex a)
        {
            Console.WriteLine("Экземпляр {0} + i{1}", a.r, a.i);
        }
        public void Print(Complex a)
        {
            Console.Write("{0} + i{1}", a.r, a.i);
        }

        // умножение
        public Complex Multiplication(Complex a, Complex b)
        {
            Complex res = new Complex(r, i);
            res.r = a.r * b.r;
            res.i = a.i * b.i;
            return res;
        }

        // вычитание
        public Complex Subtract(Complex a, Complex b)
        {
            Complex res = new Complex(r, i);
            res.r = a.r - b.r;
            res.i = a.i - b.i;
            return res;
        }
    }
}
