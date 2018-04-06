using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_3
{
    public class Arrs
    {
        // поле
        private Random rnd = new Random();

        // статический метод
        public int[] CreateOneDimAr(int[] a)
        {
            
            for (int i = 0; i < a.GetLength(0); i++)
            {
                a[i] = rnd.Next(0, 10);
            }
            return a;
        }

        public void PrintArr(string name, int[] arr)
        {
            Console.Write(name + " = { ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine("}");
        }

        //~~~~~~~~~ Задание 2. Многомерные массивы ~~~~~~~~~~~~~~~~~~~~~~~~
        public int[,] CreateArr(int[,] f)
        {
            for (int i = 0; i < f.GetLength(0); i++)
            {
                for (int j = 0; j < f.GetLength(0); j++)
                {
                   // Console.Write("mas[" + i + "," + j + "]: ");
                    f[i, j] = rnd.Next(0, 10);
                }
            }
            return  f ;
        }
        public void PrintArr2(string name, int[,] arr)
        {
            Console.WriteLine(name + " = { ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write("       (");
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    Console.Write(arr[i,j] + ", ");
                }
                Console.WriteLine(")");
            }
            Console.WriteLine("       }");
        }
        // умножение матриц
        public int[,] MultArr(int[,] a, int[,] b, int[,] c)
        {
            //int n = a.Length / a.GetLength(0);
            //int[,] f = new int[n, n];
            // если 1 из матриц квадратная и длины матриц =
            if ((a.GetLength(0) == a.Length / a.GetLength(0)) && (a.GetLength(0) == b.GetLength(0)))
            {
                for (int i = 0; i < c.GetLength(0); i++)
                {
                    for (int j = 0; j < c.GetLength(0); j++)
                    {
                        c[i, j] = a[i, j] * b[i, j];
                    }
                }
            }
            return c;
        }
        // Задание 3. Массивы массивов. 
        public void PrintArr3(string name, int[][] arr)
        {
            Console.WriteLine(name + " = { ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("       (");
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + ", ");
                }
                Console.WriteLine(")");
            }
            Console.WriteLine("       }");
        }        
        public int[][] CreateArr2(int[][] f)
        {
            for (int i = 0; i < f.Length; i++)
            {
                for (int j = 0; j < f[i].Length; j++)
                {
                    // Console.Write("mas[" + i + "," + j + "]: ");
                    f[i][j] = rnd.Next(0, 10);
                }
            }
            return f;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Лабораторная работа №3. Работа с массивами в C#
            // Задание 1. Объявление и инициализация одномерных массивов.
            Arrs temp = new Arrs();

            int[] A = new int[5], B = new int[5], C = new int[5];
            temp.CreateOneDimAr(A);
            temp.PrintArr("A", A);

            temp.CreateOneDimAr(B);
            temp.PrintArr("B", B);

            // Вводим массив  C = A + B;
            for (int i = 0; i < B.Length; i++)
            {
                C[i] = A[i] + B[i];
            }

            PrintArray("C", C);

            int[] X = { 5, 5, 6, 6, 7, 7 };
            PrintArray("X", X);

            int[] U, V;
            U = new int[3] { 1, 2, 3 };
            PrintArray("U", U);
            // V = { 1, 2, 3 };
            //PrintArray("V", V);
            V = new int[3];
            V = U;
            V[0] = 9;
            PrintArray("U2", U);

            Console.WriteLine("Введите размерность массива:");
            int size = int.Parse(Console.ReadLine());
            int[] D = new int[size];
            temp.CreateOneDimAr(D);
            temp.PrintArr("D", D);

            // Задание 2. Многомерные массивы
            Console.WriteLine("\nЗадание 2. Многомерные массивы\n");

            int[,] A2 = new int[3, 3], B2 = new int[3, 3], C2 = new int[3, 3];
            temp.CreateArr(A2);
            temp.PrintArr2("A2", A2);

            temp.CreateArr(B2);
            temp.PrintArr2("B2", B2);

            temp.MultArr(A2, B2, C2);
            temp.PrintArr2("C2", C2);

            // Задание 3. Массивы массивов. 
            Console.WriteLine("\nЗадание 3. Массивы массивов. \n");
            int n = 1;
            int[][] R = {//10[]
                new int[n++],new int[n++],new int[n++],new int[n++],new int[n++],new int[n++],new int[n++],new int[n++],new int[n++],new int[n]
            };
            temp.CreateArr2(R);
            temp.PrintArr3("R", R);

            Console.ReadLine();
        }

        // печать массива
        static public void PrintArray(string name, int[] arr)
        {
            Console.Write(name + " = { ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine("}");
        }
    }
}
