using System;
using System.Linq;
namespace Списивцева_варвара_Практическая_5_зд_1;
public class CountingSortWithUserInput
{
    public static void Main(string[] args)
    {
        
        Console.Write("Введите количество элементов в массиве: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Ошибка: Введено некорректное количество элементов.");
            return;
        }
        int[] inputArray = new int[n];

        Console.WriteLine("Введите элементы массива (через пробел):");
        string inputLine = Console.ReadLine();
        string[] elements = inputLine.Split(' ');
       
        for (int i = 0; i < n; i++)
        {
            if (!int.TryParse(elements[i], out inputArray[i]))
            {
                Console.WriteLine($"Ошибка:'{elements[i]}' Введите целое число.");
                return;
            }
        }

        int[] sortedArray = CountingSortAndFill(inputArray);
        if (sortedArray != null) 
        {
            Console.WriteLine("Исходный массив: " + string.Join(", ", inputArray));
            Console.WriteLine("Отсортированный массив: " + string.Join(", ", sortedArray));
        }

        Console.ReadKey();
    }

    public static int[] CountingSortAndFill(int[] inputArray)
    {
        int n = inputArray.Length;

        int minVal = inputArray.Min();
        int maxVal = inputArray.Max();
        int range = maxVal - minVal + 1;

        int[] sortedArray = Enumerable.Repeat(-1, n).ToArray();

        for (int i = 0; i < n; i++)
        {
            int count = 0;
            for (int j = 0; j < n; j++)
            {
                if (inputArray[j] < inputArray[i])
                {
                    count++;
                }
            }
            while (sortedArray[count] != -1)
            {
                count++;
              
            }
            sortedArray[count] = inputArray[i];
        }
      
        int lastValue = -1;
        for (int i = 0; i < n; i++)
        {
            if (sortedArray[i] == -1)
            {
                sortedArray[i] = lastValue;
            }
            else
            {
                lastValue = sortedArray[i];
            }
        }

        return sortedArray;
    }
}