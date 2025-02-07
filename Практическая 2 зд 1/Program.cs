using System;
namespace Списивцева_варвара_проктическая_2_зд1;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите x");
        double x = Convert.ToDouble(Console.ReadLine());
        double y = 0;
        if (x < 3.2) y = Math.Pow(x, 4) + 9;
        else y = (54 * Math.Pow(x, 4)) / (-5 * Math.Pow(x, 2) + 7);
        Console.WriteLine("Для x = {0:f4} ", x); 
        Console.WriteLine("Результат = {0:f2}", y);
    }
}