using System;

/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.
/// Напишите программу, которая будет выводить  на экран числа от 1 до 5.  
/// Написать три варианта реализации (while, do...while, for).
/// </summary>
namespace Pr_Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine($"{++i}");               
            }
            Console.WriteLine();

            //do...while
            i = 0;
            do
            {
                Console.WriteLine($"{++i}");
            }
            while (i < 5);
            Console.WriteLine();

            //for
            for (int j = 1; j <= 5; j++)
            {
                Console.WriteLine($"{j}");
            }
            Console.ReadKey();
        }
    }
}
