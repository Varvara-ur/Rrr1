using System;

namespace Списивцева_Варвара_Практическая_5_зд_3;
public class MatrixOperations
{
    public static void Main(string[] args)
    {
        Console.Write("Введите размерность квадратной матрицы n: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine(" Введите натуральное число больше 0.");
            return;
        }
        int[,] matrix = new int[n, n];
        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = random.Next(1, 101); 
            }
        }
        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        Console.Write("Введите номер строки M для обмена (от 1 до " + n + "): ");
        if (!int.TryParse(Console.ReadLine(), out int m) || m < 1 || m > n)
        {
            Console.WriteLine("Ошибка!");
            return;
        }
        int maxDiagonalRowIndex = FindMaxDiagonalRowIndex(matrix);
        SwapRows(matrix, maxDiagonalRowIndex, m - 1);
        Console.WriteLine("Матрица после обмена строк:");
        PrintMatrix(matrix);

        Console.ReadKey();
    }
    public static int FindMaxDiagonalRowIndex(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int maxIndex = 0;
        int maxValue = matrix[0, 0];

        for (int i = 1; i < n; i++)
        {
            if (matrix[i, i] > maxValue)
            {
                maxValue = matrix[i, i];
                maxIndex = i;
            }
        }
        return maxIndex;
    }
    public static void SwapRows(int[,] matrix, int rowIndex1, int rowIndex2)
    {
        int n = matrix.GetLength(0);
        int temp;
        for (int j = 0; j < n; j++)
        {
            temp = matrix[rowIndex1, j];
            matrix[rowIndex1, j] = matrix[rowIndex2, j];
            matrix[rowIndex2, j] = temp;
        }
    }
    public static void PrintMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "\t"); 
            }
            Console.WriteLine();
        }
    }
}