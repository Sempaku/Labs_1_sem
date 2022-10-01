namespace Laba5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность системы: ");

            double s = 0;
            int n = int.Parse(Console.ReadLine());
            double[,] matrix = new double[n, n];
            double[] b = new double[n];
            double[] x = new double[n];

            for (int i = 0; i < n; i++)
                x[i] = 0;

            Console.WriteLine("\nВведите построчно коэффициенты системы:\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Введите кф. A[{0}][{1}]: ", i + 1, j + 1);
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nВведите свободные коэффициенты:\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите кф. B[{0}]: ", i + 1);
                b[i] = double.Parse(Console.ReadLine());
            }

            for (int k = 0; k < n - 1; k++)
            {
                for (int i = k + 1; i < n; i++)
                {
                    for (int j = k + 1; j < n; j++)
                    {
                        matrix[i, j] = matrix[i, j] - matrix[k, j] * (matrix[i, k] / matrix[k, k]);
                    }
                    b[i] = b[i] - b[k] * matrix[i, k] / matrix[k, k];
                }
            }
            for (int k = n - 1; k >= 0; k--)
            {
                s = 0;
                for (int j = k + 1; j < n; j++)
                    s = s + matrix[k, j] * x[j];
                x[k] = (b[k] - s) / matrix[k, k];
            }

            Console.WriteLine("\nКорни:");
            for (int i = 0; i < x.Length; i++)            
                Console.WriteLine("x{0} = {1}", i + 1, Math.Round(x[i], 4));
            
            Console.ReadKey(true);
        }
    }
}
