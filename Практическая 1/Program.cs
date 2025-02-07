using System;
using System.Runtime.CompilerServices;
namespace Списивцева_варварв_проктическая_1;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите x");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите y");
        double y = Convert.ToDouble(Console.ReadLine());
        double a = Math.Abs(x - (2 * x) / (1 + Math.Pow(x, 2) * Math.Pow(y, 2)));
        Console.WriteLine("Для x = {0:f4} и y = {1:f4} ", x, y); 
        Console.WriteLine("Результат = {0:f4}", a);
    }
}