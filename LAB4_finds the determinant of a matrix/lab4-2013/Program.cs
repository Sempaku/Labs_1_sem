class Program
{

    public static void Main(string[] args)
    {
        Console.Write("Input [NxN]: ");

        int n = Convert.ToInt32(Console.ReadLine());
        double[,] matrix = new double[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("\nInput a[{0},{1}] = ", i + 1, j + 1);
                double input = Convert.ToDouble(Console.ReadLine());
                matrix[i, j] = input;
            }
        }

        double result = SearchDeterminant(matrix, n);
        Console.WriteLine("Determinant = {0}", result);

        Console.ReadKey(true);

    }
    public static void printMatrix(double[,] a, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(a[i, j]);
                if (j == (n - 1))
                    Console.Write("\n");
            }
        }
    }

    public static double SearchDeterminant(double[,] a, int n)
    {
        double determin = 1;
        for (int i = 1; i < n; i++)
            for (int k = i; k < n; k++)
                for (int j = n - 1; j >= 0; j--)
                    if (a[k, i - 1] != 0 && a[i - 1, i - 1] != 0 && a[i - 1, j] != 0)
                        a[k, j] -= (a[k, i - 1] / a[i - 1, i - 1] * a[i - 1, j]);


        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j)                
                    determin *= a[i, j];
                
            }
        }

        if (determin == -0)
            determin = 0;

        printMatrix(a, n);
        return determin;
    }
}