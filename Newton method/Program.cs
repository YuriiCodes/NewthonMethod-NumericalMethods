using System;

namespace Newton_method
{
    internal class Program
    {
        private static double F(double x) => Math.Pow(x, 3) - 7 * Math.Pow(x, 2) + 7 * x + 15;
        private static double Df(double x) => 3 * Math.Pow(x, 2) - 14 * x + 7; 
        public static void Main(string[] args)
        {
            Console.WriteLine("F(x) => Math.Pow(x, 3) - 7 * Math.Pow(x, 2) + 7 * x + 15");
            double eps = 1e-3;
            Console.WriteLine("Please enter epsilon:");
            eps = Convert.ToDouble(Console.ReadLine());
            double a = -5;
            Console.WriteLine($"a = {a}");
            double b = 0;
            Console.WriteLine($"b = {b}");
            double x = a;
            Console.WriteLine($"1-th iteration: {x} {F(x)}");
            for (int i = 0; Math.Abs(F(x)) > eps; ++i)
            {
                x -= F(x) / Df(x);
                Console.WriteLine($"{i + 2}-th iteration: {x} {F(x)}");
            }
            Console.WriteLine("End result:");
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"f({x}) = {F(x)}");
        }
    }
}