using System;
using System.Collections.Generic;
using System.Text;

namespace Tyd2L4
{
    class Program
    {
        static void Main(string[] args)

        {
            task1();
            task2();
            task3();
            task4();
            task5();
        }
        public static void task1()
        {
            string name;
            string surname;
            int age;
            char sex;
            double insuranceNo;
            double idNo;
        }
        public static void task2()
        {
            char a = 'a';
            char b = 'b';
            char c = 'c';
            Console.WriteLine("{0}, {1}, {2}", c, b, a);
            Console.ReadKey();
        }
        public static void task3()
        {
            Console.WriteLine("Please enter width of rectangle");
            double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter length of rectangle");
            double b = Double.Parse(Console.ReadLine());
            double c = Math.Sqrt(Math.Pow(a, a) + Math.Pow(b, b));
            Console.WriteLine("The diagonal of the rectangle is {0}", c);
            Console.ReadKey();
        }
        public static void task4()
        {
            int a;
            string b;
            double c;
            a = 10;
            b = "Szkoła Dotneta";
            c = 12.5;

        }
        public static void task5()
        {
            Console.WriteLine("Please, enter the name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please, enter the surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Please, enter your phone number: ");
            int phoneNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter your email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Please, enter your height in centimeters: ");
            int height = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter your weight in centimeters: ");
            double weight = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter your shoe size in euro measure: ");
            int size = Int32.Parse(Console.ReadLine());
        }
    }
}
