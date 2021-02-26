using System;

/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.
/// Напишите программу, в которой даны натуральные числа от 20 до 50. 
/// Вывести на консоль те из них, которые делятся на 3, но не делятся на 5.
/// </summary>

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 20;
            while (i <= 50)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine($"{i}");
                }
                i++;
            }
            Console.ReadLine();
        }
    }
}
