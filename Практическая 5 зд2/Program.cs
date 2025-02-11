using System;
namespace Списивцева_Варвара_Практическая_5_зд_1;
public class MatrixGenerator
{
    public static void Main(string[] args)
    {
        Console.Write("Введите порядок матрицы n: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            int[,] matrix = GenerateMatrix(n);

            Console.WriteLine("Сформированная матрица:");
            PrintMatrix(matrix);
        }
        else
        {
            Console.WriteLine(" Введите натуральное число больше 0.");
        }

        Console.ReadKey();
    }

    public static int[,] GenerateMatrix(int n)
    {
        int[,] matrix = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == 0 || i == n - 1 || j == 0 || j == n - 1)
                {
                    matrix[i, j] = 1;
                }
                else
                {
                    matrix[i, j] = 0;
                }
            }
        }

        return matrix;
    }

    public static void PrintMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}


