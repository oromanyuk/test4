using System;

namespace ConsoleApp9
{
    class calc
    {
        public static void Kvurav(double a, double b, double c)
        {
            double d = b * b - 2 * a * c;
            if (d >= 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else
            {
                Console.WriteLine("Корней нет!");
            }
        }
    }
    class calc2 : calc
    {
    }
    class Program
    {
        static void Main(string[] args)
        {
            calc2.Kvurav(2, 4, 5);
        }
    }
}
