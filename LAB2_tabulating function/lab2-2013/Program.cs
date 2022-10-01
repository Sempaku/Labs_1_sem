using System;

namespace Func_Tab
{
    class Program
    {
        static void Main()
        {
            int iter = 1;

            Console.Write("Введите шаг (Правильно = 3.2 ; Не правильно = 3,2): ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите ограничение через пробел [n1 ; n2]: ");
            string N = Console.ReadLine();
            string[] n = N.Split(' ');
            double n1 = Convert.ToDouble(n[0]);
            double n2 = Convert.ToDouble(n[1]);

            Console.WriteLine("Step         X         Y");
            while (n1 <= n2)
            {
                // Заменить функцию
                double y = Math.Sin(n1) + Math.Cos(n1);

                Console.WriteLine("{0}            {1}         {2}",
                    iter, Math.Round(n1, 2), Math.Round(y, 2));
                
                // Добавления шага
                n1 += x; 
                iter++;
            }
            Console.ReadKey(true);
        }
    }
}



