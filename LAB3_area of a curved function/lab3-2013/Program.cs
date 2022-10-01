using System;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input A: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Input B: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter the accuracy[default = 10000]: ");
            double n = double.Parse(Console.ReadLine());

            double current = a;
            double s = 0;
            double h = (b - a) / n;

            while (current <= b)
            {
                s = s + (Func(current) * h);
                current += h;
            }

            Console.WriteLine("S = {0} = {1}", s, Math.Round(s, 2));
            Console.ReadKey(true);

        }
        public static double Func(double y)
        {
            return Math.Abs(Math.Cos(y)+ Math.Pow(y,3));
        }
    }
}
