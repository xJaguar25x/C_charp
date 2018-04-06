using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    class Student
    {
        private
            string name;
        int age;
        Random rnd = new Random();
        public void SetValue(string name)
        {
            this.name = name;
            this.age = rnd.Next(0, 99);
        }

        public new void ToString()
        {
            Console.WriteLine("name: " + this.name);
            Console.WriteLine("age: " + this.age);
        }

        public static Student[] InitAr(Student[] stud)
        {
            for (int i = 0; i < stud.Length; i++) stud[i] = new Student();
            return stud;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student[] stud = new Student[3];
            Student.InitAr(stud);
            stud[0].SetValue("viktor");
            stud[0].ToString();

            Console.ReadLine();
        }
    }
}
