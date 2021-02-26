using System;

/// <summary>
/// Используя Visual Studio, создайте проект по шаблону 
/// Console Application. Напишите программу,  которая 
/// определяет, является ли год високосным. Пользователь 
/// вводит год. Программа должна вывести на экран ответ, 
/// является ли год високосным. Подсказка. Обычно каждый год, 
/// который делится на 4, — это високосный год, кроме лет 
/// столетий (делящихся на 100). Но среди последних год, 
/// делящийся на 400, также считается високосным.
/// </summary>
namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите год(ГГГГ): ");
            if (Int32.TryParse(Console.ReadLine(),out var year) &&
                year.ToString().Length == 4)
            {
                // Определяем, высокосный ли год
                string message = (((year % 4 == 0) && (year % 100 != 0)) || 
                                  ((year % 100 == 0) && (year % 400 == 0))) ?
                                  $"{year} - высокосный год." : $"{year} - не высокосный год.";
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("Год должен быть числом, состоящим из четытех знаков.");
            }
            Console.ReadKey();
        }
    }
}
