using System;
namespace KVADRATNOE_URAVNENIE
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            while (true)
            {
                try
                {
                    Console.Write("Input a: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Input b: ");
                    b = double.Parse(Console.ReadLine());
                    Console.Write("Input c: ");
                    c = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Можно вводить только целые числа!");
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine("Вы ввели слишком большое число!");
                }
            }
            if (a != 0 && b != 0 && c != 0)
            {
                double D = (b * b) - 4 * a * c;
                if (D < 0)
                {
                    Console.WriteLine("Нет корней.");
                    Console.ReadKey(true);
                }
                else if (D == 0)
                {
                    double x = (-b) / (2 * a);
                    Console.WriteLine("x = {0}", x);
                    Console.ReadKey(true);
                }
                else if (D > 0)
                {
                    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine("x1 = {0} and x2 = {1}", x1, x2);
                    Console.ReadKey(true);
                }
            }
            else
            {
                if (a == 0)
                {
                    Console.WriteLine("Программа не может выполняться при данных условиях.");
                    Console.ReadKey(true);
                }
                else
                {
                    if (b == 0 && c == 0)
                    {
                        double x = 0;
                        Console.WriteLine("x = {0}", x);
                        Console.ReadKey(true);
                    }
                    else
                    {
                        if (b == 0 && c != 0)
                        {
                            if ((-c / a) > 0)
                            {
                                double x = Math.Sqrt(-c / a);

                                Console.WriteLine("x1 = -{0} and x2 = {1}", x, x);
                                Console.ReadKey(true);
                            }
                            else
                            {
                                Console.WriteLine("Нет Корней.");
                                Console.ReadKey(true);
                            }
                        }
                        if (c == 0 && b != 0)
                        {
                            double x1 = 0;
                            double x2 = -b / a;
                            Console.WriteLine("x1 = {0} and x2 = {1}", x1, x2);
                            Console.ReadKey(true);
                        }

                    }
                }
            }
        }
    }
}






