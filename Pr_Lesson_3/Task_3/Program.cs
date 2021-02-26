using System;

/// <summary>
/// Используя Visual Studio, создайте проект по шаблону 
/// Console Application.                                                    
/// Напишите программу, в которой создайте переменную min. 
/// Значение переменной должен задавать пользователь, 
/// интервал допустимых значений 0 до 59, необходимо 
/// организовать проверку на ввод допустимого интервала. 
/// Определите в какую четверть часа попадает значение 
/// переменной (в первую, вторую, третью или четвертую).
/// </summary>

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение min: ");
            if (double.TryParse(Console.ReadLine(), out var min))
            {
                if (min >= 0 && min < 15)
                {
                    Console.WriteLine("Первая четверть часа.");  
                }
                else if (min >=15 && min < 30)
                {
                    Console.WriteLine("Вторая четверть часа.");
                }
                else if (min >= 30 && min < 45)
                {
                    Console.WriteLine("Третяя четверть часа.");
                }
                else if (min >= 45 && min < 59)
                {
                    Console.WriteLine("Четвертая четверть часа.");
                }
                else
                {
                    Console.WriteLine("Значение min вне диапазона.");
                }         
            }
            else
            {
                Console.WriteLine("Значение min должно быть числовым.");
            }
            Console.ReadKey();
        }

    }
}
