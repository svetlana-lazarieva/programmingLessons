using System;

/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.
/// Напишите программу, которая будет выводить на экран таблицу умножения на 3.
/// </summary>
namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Value = 3;
            int value1 = 1;
            while (value1 <= 10)
            {
                Console.WriteLine($"{value1} * {Value} = {value1 * Value}");
                value1++;
            }
            Console.ReadLine();
        }
    }
}
