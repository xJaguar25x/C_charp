// использования пространство имен системы
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// пространство имен данный программы
namespace Laba_1
{
    // основной класс программы
    class Program
    {
        // enum - перечисления
        enum gradus : int
        {
            min = 0,
            krit = 72,
            max = 100,
        }
        static void Main()
        {
            Console.WriteLine("минимальная температура=" + gradus.min);
            Console.WriteLine("критическая температура=" + (int)gradus.krit);
            Console.WriteLine("максимальная температура=" + (int)gradus.max);

            int i = 3, j = 4;
            Console.WriteLine("{0} {1}", i, j);
            Console.WriteLine("{0} {1} {2}", j, i, j);

           // 2)	Управление размером поля вывода:
            double x = Math.E;
            // {n, m} – где n определяет номер идентификатора из списка аргументов метода WriteLine, а m – количество позиций 
            Console.WriteLine("E={0,20}", x);
            Console.WriteLine("E={0,10}", x);
           // 3)	Управление размещением вещественных данных:
            Console.WriteLine("E={0:##.###}", x);
            Console.WriteLine("E={0:.####}", x);

           // 4)	Управление форматом числовых данных:
            Console.WriteLine("C Format:{0,14:C} \t{0:C2}", 12345.678);
            Console.WriteLine("D Format:{0,14:D} \t{0:D6}", 123);
            Console.WriteLine("E Format:{0,14:E} \t{0:E8}", 12345.6789);
            Console.WriteLine("G Format:{0,14:G} \t{0:G10}", 12345.6789);
            Console.WriteLine("N Format:{0,14:N} \t{0:N4}", 12345.6789);
            Console.WriteLine("X Format:{0,14:X} ", 1234);
            Console.WriteLine("P Format:{0,14:P} ", 0.9);

            /*~~~~~~~~~~~~~~~~~ Ввод данных ~~~~~~~~~~~~~~~~~~~~~*/

            //string s = Console.ReadLine();
            //Console.WriteLine(s);
            //int xe = int.Parse(s); //преобразование строки в число
            //Console.WriteLine(xe);

            // #1
            //Console.WriteLine("ВВедите а=");
            //string s1 = Console.ReadLine();
            //Console.WriteLine("ВВедите b=");
            //string s2 = Console.ReadLine();
            //Console.WriteLine("a= {0} \nb= {1} \n{0}+{1}={1}+{0}",s1,s2);

            // #4
            Console.WriteLine("ВВедите а=");
            float f1 = float.Parse(Console.ReadLine());
            Console.WriteLine("ВВедите b=");
            float f2 = float.Parse(Console.ReadLine());
            Console.WriteLine("a= {0} \nb= {1} \n{0:.#}+{1:.#} = {2:.#}", f1, f2, f1+f2);
        }

    }
}
