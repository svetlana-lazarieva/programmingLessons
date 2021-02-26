using System;

namespace Pr_Lesson_3
{
    /// <summary>
    /// Используя Visual Studio, создайте проект по 
    /// шаблону Console Application.                                                
    /// Напишите программу, в которой создайте переменную a. 
    /// Значение переменной, а должен задавать пользователь. 
    /// Если а < 10 то выведите 'Верно', иначе (a>10) 
    /// выведите 'Неверно'.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Получаем А
            Console.Write("Введите значение А: ");

            // Проверяем А
            if (Int32.TryParse(Console.ReadLine(), out var a))
            {
                if (a > 10)
                {
                    Console.WriteLine("Неверно");
                }
                else if (a < 10)
                {
                    Console.WriteLine("Верно");
                }
                else
                {
                    Console.WriteLine("a = 10");
                }
            }
            else
            {
                Console.WriteLine("a - не число");
            }
                Console.ReadKey();
        }
    }
}
