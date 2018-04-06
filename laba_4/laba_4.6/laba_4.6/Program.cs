using System;

namespace laba_4._6
{
    class Vector_class
    {
        private Random rnd = new Random();

        public void create_Arr(string name, int[] arr, int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                arr[i] = rnd.Next(0, 99);
            }
        }

        public void show_Arr(string name, int[] arr)
        {
            Console.Write(name + ": ");
            foreach (int val in arr)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();
        }

        public void show_Arr2(string name, int[] arr, int start)
        {
            if (start < arr.GetLength(0))
            {
                for (int i = start; i < arr.GetLength(0); i++)
                {
                    Console.Write(arr[i] + "; ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        public void sum_Arr(int[] arr1, int[] arr2)
        {
            int[] res = new int[arr2.GetLength(0)];
            int n = 0;
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(0); j++)
                {
                    if ((i == j) && (arr1[i] != 0) && (arr2[j] != 0))
                    {
                        res[n] = arr1[i] + arr2[j];
                        n++;
                    }
                }
            }
            show_Arr("result Sum", res);
        }

        public void sub_Arr(int[] arr1, int[] arr2)
        {
            int[] res = new int[arr2.GetLength(0)];
            int n = 0;
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(0); j++)
                {
                    if ((i == j) && (arr1[i] != 0) && (arr2[j] != 0))
                    {
                        res[n] = arr1[i] - arr2[j];
                        n++;
                    }
                }
            }
            show_Arr("result Subtraction", res);
        }

        public void mult_Arr(int[] arr1, int numb)
        {
            int[] res = new int[arr1.GetLength(0)];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                res[i] = arr1[i] * numb;
            }
            show_Arr("result Multiplication", res);
        }

        public void div_Arr(int[] arr1, int numb)
        {
            int[] res = new int[arr1.GetLength(0)];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                res[i] = arr1[i] / numb;
            }
            show_Arr("result Division", res);
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Vector_class temp = new Vector_class();

            int len1 = 10, len2 = 15,   begin1 = 2, begin2 = 3,   end1 = 9, end2 = 7;


            int[] array1 = new int[len1], array2 = new int[len2];

            // создание
            temp.create_Arr ("arr1", array1, begin1, end1);
            temp.create_Arr ("arr2", array2, begin2, end2);
            // вывод
            temp.show_Arr("arr1", array1);
            temp.show_Arr("arr2", array2);
            // сумма
            temp.sum_Arr(array1, array2);
            temp.sub_Arr(array1, array2);
            // умножение/ деление
            temp.mult_Arr(array1, 6);
            temp.div_Arr(array1, 3);

            temp.show_Arr2("arr", array2, 5);

            Console.ReadLine();
        }
    }
}
