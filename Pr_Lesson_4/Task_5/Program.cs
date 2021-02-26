using System;

/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.
/// Напишите программу, где пользователь вводит любое целое положительное число. 
/// А программа суммирует все числа от 1 до введенного пользователем числа.
/// </summary>

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите любое целое положительное число: ");
            if (UInt32.TryParse(Console.ReadLine(), out var value1))
            {
                int i = 0;
                int j = 0;
                while (i < value1)
                {
                    i++;
                    Console.WriteLine($"{j} + {i} = {j + i}");
                    j = j + i;
                                        
                }
            }
            else
            {
                Console.WriteLine("Введеное значение не является целым положительным числом.");
            }
            Console.ReadKey();
        }
    }
}
