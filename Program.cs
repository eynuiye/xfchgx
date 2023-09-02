namespace mdk_0301_lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while (number != 9)
            {
                Console.WriteLine("Задача 1 - 1");
                Console.WriteLine("Задача 2 - 2");
                Console.WriteLine("Задача 3 - 3");
                Console.WriteLine("Выход из программы - 9");
                Console.WriteLine("Выберите задачу: ");
                number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                }
            }
        }

        static void Task1()
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] A = FillMatrix_l(n);
            PrintMatrix(A);
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (A[i, j] >= 0)
                        count = count + 1;
                }
            }
            Console.WriteLine("Всего положительных чисел " + count);
        }

        static double[,] FillMatrix_l(int n)
        {
            double[,] matrix = new double[n, n];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Math.Sin((Math.Pow(i, 2) - Math.Pow(j, 2)) / n);
                }
            }
            return matrix;
        }

        static void Task2()
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] A = FillMatrixRandom(n);
            PrintMatrix(A);
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                count = 0;
                for (int j = 0; j < n; j++)
                {
                    if ((A[i, j] % 2) == 0)
                        count = count + 1;
                }
                if (count == n)
                {
                    Console.WriteLine("Строка под номером " + (i + 1) + " содержит все чётные числа");
                }
            }
        }

        static int[,] FillMatrixRandom(int n)
        {
            int[,] matrix = new int[n, n];
            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next() * 5;
                }
            }
            return matrix;
        }

        static void Task3()
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] A = FillMatrixRandom_a(n);
            PrintMatrix(A);
            int[] x = new int[n];
            for (int i = 1; i < n; i = i + 2)
            {
                for (int j = 0; j < n; j++)
                {
                    x[j] = A[i, j];
                    A[i, j] = A[i - 1, j];
                    A[i - 1, j] = x[j];
                }
            }
            Console.WriteLine("Новая матрица: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int[,] FillMatrixRandom_a(int n)
        {
            int[,] matrix = new int[n, n];
            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next() * 10;
                }
            }
            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        static void PrintMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}