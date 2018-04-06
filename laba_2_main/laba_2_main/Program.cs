using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_2_main
{
    class Program
    {
        static void Main(string[] args)
        {
            //Часть 2.Операции языка C#
            /*Console.WriteLine("~~~~~~~~~~~~~~~ Часть 2.Операции языка C# ~~~~~~~~~~~");

            int i = 3, j = 4;
            Console.WriteLine("{0} {1}", i, j);
            Console.WriteLine("{0} {1}", ++i, --j);
            Console.WriteLine("{0} {1}", i++, j--);
            Console.WriteLine("{0} {1}", i, j);


            //object z = new object();
            //int i = new int(); // то же самое, что и int i =0;

            //bool a = true, b = false;
            //Console.WriteLine("{0} {1}", -i, -j);
            //Console.WriteLine("{0} {1}", !a, !b);

            
            i = 100; j = 15;
            double a = 14.2, b = 3.5;
            Console.WriteLine("{0} {1} {2}", i* j, i/ j, i % j);
            Console.WriteLine("{0} {1} {2}", a* b, a / b, a % b);

            i = 15; j = 15;
            Console.WriteLine(i < j); //меньше
            Console.WriteLine(i <= j);  //меньше или равно
            Console.WriteLine(i > j);  //больше
            Console.WriteLine(i >= j); //больше или равно
            Console.WriteLine(i == j);  //равно
            Console.WriteLine(i != j);  //не равно

            Console.WriteLine("x     y     x и y    x или y");
            Console.WriteLine("{0} {1} {2} {3}", false, false, false && false, false || false);
            Console.WriteLine("{0} {1} {2} {3}", false, true, false && true, false || true);
            Console.WriteLine("{0} {1} {2} {3}", true, false, true && false, true || false);
            Console.WriteLine("{0} {1} {2} {3}", true, true, true && true, true || true);
            
            
            int i2 = -500;
            byte j2 = 4;
            int a2 = (int)j2;  //преобразование без потери точности
            byte b2 = (byte)i2; //преобразование с потерей точности
            Console.WriteLine("{0} {1}", a2, b2);
            

            int x = 5; int y = 10;
            int max = (x > y) ? x : y;
            Console.WriteLine(max);

            int a1 = 10, b1 = 3;
            int t = (a1++) - b1;
            b1 += t * a1;
            Console.WriteLine("t= {0} b= {1}", t, b1);


            // Часть 3. Операторы языка C#
            Console.WriteLine("~~~~~~~~~~~~~~~ Часть 3. Операторы языка C# ~~~~~~~~~~~");
            /*
            Console.Write("x = ");
            float x1 = float.Parse(Console.ReadLine());
            Console.Write("y =");
            float y1 = float.Parse(Console.ReadLine());
            if (x1 < y1) Console.WriteLine("min = " + x1);
            else Console.WriteLine("min = " + y1);
            */
            /*
            int Ball = 0;
            Console.Write("x = ");
            float x2 = float.Parse(Console.ReadLine());
            Console.Write("y = ");
            float y2 = float.Parse(Console.ReadLine());
            if (x2 * x2 + y2 * y2 <= 1) Ball = 10;  //окружность с радиусом 1
            else if (x2 * x2 + y2 * y2 <= 4) Ball = 5;  //окружность с радиусом 2
            else if (x2 * x2 + y2 * y2 <= 9) Ball = 1;  //окружность с радиусом 3
            else Ball = 0;
            Console.WriteLine("Ball = " + Ball);
            */

            /*
            Console.Write("N = ");
            // int n = int.Parse(Console.ReadLine());
            int n = 20;
            i = 1;
            while (n >= i)           //пока i меньше или равно n
                if (n % 2 != 0) Console.Write(" " + (n--)); //выводим i на экран, затем увеличиваем его на 1      
                else n--;
            */
            // Секция самостоятельной (домашней) работы
            Console.WriteLine("~~~~~~~~~~~~~~~ Секция самостоятельной (домашней) работы ~~~~~~~~~~~");

            // Домашнее задание №1. 
            /*Console.WriteLine("Домашнее задание №1.\n");

            byte n = 6, result;

            // Умножить на 2
            result = (byte)(n << 1);
            Console.WriteLine("{0} * 2 = {1}", n, result);
            Console.WriteLine("в двоичной сс {0} * {2} = {1}", Convert.ToString(n, 2), Convert.ToString(result, 2), Convert.ToString(2, 2));

            // Умножить на 4
            result = (byte)(n << 2);
            Console.WriteLine("{0} * 4 = {1}", n, result);
            Console.WriteLine("в двоичной сс {0} * {2} = {1}", Convert.ToString(n, 2), Convert.ToString(result, 2), Convert.ToString(4, 2));

            // Разделить на 2
            result = (byte)(n >> 1);
            Console.WriteLine("{0} / 2 = {1}", n, result);
            Console.WriteLine("в двоичной сс {0} / {2} = {1}", Convert.ToString(n, 2), Convert.ToString(result, 2), Convert.ToString(2, 2));
            */
            // Домашнее задание №2
            Console.WriteLine("Домашнее задание №2.\n");

            Console.Write("Размерность доски: ");
            int n = int.Parse(Console.ReadLine());
            // вывод кол-ва черных
            if (n % 2 == 0) Console.WriteLine("Черных: {0}", n / 2 * n);
            else Console.WriteLine("Черных: {0}", (n - 1) / 2 * (n - 1) + n);

            // определение цвета ячейки
            yach: Console.Write("\nk = ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());
            switch (colour(k, m, n))
            {
                case 0: Console.WriteLine("Ячейка {0}x{1} - черная", k, m); break;
                case 1: Console.WriteLine("Ячейка {0}x{1} - белая", k, m); break;
                case 2:
                    Console.WriteLine("Такой ячейки нет, попробуйте ввести другую");
                    goto yach;
            }
            // сравнивание двух ячеек
            Console.Write("\nk1 = ");
            int k1 = int.Parse(Console.ReadLine());
            Console.Write("m1 = ");
            int m1 = int.Parse(Console.ReadLine());

            yach2: if (!(k1 <= n && m1 <= n)) {
                Console.WriteLine("Такой ячейки нет, попробуйте ввести другую");
                goto yach2;
            }
            if (colour(k, m, n) == colour(k1, m1, n)) Console.WriteLine("Ячейки {0}x{1} и {2}x{3} одинаковые", k , m, k1, m1 );
            else Console.WriteLine("Ячейки {0}x{1} и {2}x{3} разные", k, m, k1, m1);

            // находится ли фигура под ударом; ячейка с фигурой (k,m), цель (k1,m1)
            // 1- пешка; 2 - слон; 3 - ладья; 4 - ферзь; 5 - конь.

            Console.Write("\nВведите номер фигуры согласно: 1- пешка; 2 - слон; 3 - ладья; 4 - ферзь; 5 - конь. ");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine("1- пешка");
                    // проверка 1- пешка;                    
                    if ((k - k1 == 1 || k1 - k == 1) || (m - m1 == 1 || m1 - m == 1))
                    {
                        Console.WriteLine(" пешка {0}x{1} бъет ячейку {2}x{3}", k, m, k1, m1);
                    }
                    else Console.WriteLine(" пешка {0}x{1} НЕ бъет ячейку {2}x{3}", k, m, k1, m1);
                    break;
                case 2:
                    Console.WriteLine("2 - слон");
                    // проверка 2 - слон;
                    // направления проверки лево вверх = право низ, право вверх = лево низ
                    if ((k - k1 == m - m1) || (k - k1 == m1 - m))
                    {
                        Console.WriteLine(" слон {0}x{1} бъет ячейку {2}x{3}", k, m, k1, m1);
                    }
                    else Console.WriteLine(" слон {0}x{1} НЕ бъет ячейку {2}x{3}", k, m, k1, m1);
                    break;
                case 3:
                    Console.WriteLine("3 - ладья");
                    // проверка 3 - ладья;
                    // направления проверки вертикаль или горизонталь
                    if ((m == m1) || (k == k1))
                    {
                        Console.WriteLine(" ладья {0}x{1} бъет ячейку {2}x{3}", k, m, k1, m1);
                    }
                    else Console.WriteLine(" ладья {0}x{1} НЕ бъет ячейку {2}x{3}", k, m, k1, m1);
                    break;
                case 4:
                    Console.WriteLine("4 - ферзь");
                    // проверка 4 - ферзь;
                    // направления проверки слон + ладья
                    if (((k - k1 == m - m1) || (k - k1 == m1 - m)) || ((m == m1) || (k == k1)))
                    {
                        Console.WriteLine(" ферзь {0}x{1} бъет ячейку {2}x{3}", k, m, k1, m1);
                    }
                    else Console.WriteLine(" ферзь {0}x{1} НЕ бъет ячейку {2}x{3}", k, m, k1, m1);  
                    break;
                case 5:
                    Console.WriteLine("5 - конь");
                    // проверка 5 - конь;
                    if ( ( (Math.Abs(k - k1) == 2) && (Math.Abs(m - m1) == 1) || ( (Math.Abs(k - k1) == 1) && (Math.Abs(m - m1) == 2)) ) )
                    {
                        Console.WriteLine(" конь {0}x{1} бъет ячейку {2}x{3}", k, m, k1, m1);
                    }
                    else Console.WriteLine(" конь {0}x{1} НЕ бъет ячейку {2}x{3}", k, m, k1, m1);
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

            Console.WriteLine("\nНажмите интер для выхода");
            Console.ReadLine();
            // ~~~~~~~~~~~~~~~~~~~ Конец основной программы ~~~~~~~~~~~~~~~~~~~

        }
        // функция определения цвета 0 - черный 1 - белая 2 - не существует
        static int colour(int k, int m, int n)
            {
            // если не выходит за границы
                if (k <= n && m <= n)
                {
                //есчи четные то 0
                    if ((k + m) % 2 == 0) return 0;
                    else return 1;
                }
                else return 2;
        }

          
    }
}
