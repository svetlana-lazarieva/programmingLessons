using System;

/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.
/// Напишите программу, которая выводит на экран столько элементов ряда Фибоначчи, 
/// сколько указал пользователь. Например, если на ввод поступило число 6, 
/// то вывод должен содержать шесть первых чисел ряда Фибоначчи: 1 2 3 5 8 13. 
/// (Числа Фибоначчи -  элементы числовой последовательности,  в которой первые 
/// два числа равны либо 1 и 1, либо 0 и 1, а каждое последующее число равно сумме 
/// двух предыдущих чисел, например 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89).
/// </summary>
namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество выводимых элементов: ");
            if (Int32.TryParse(Console.ReadLine(), out var value))
            {
                int result = 0, prev = 0, prevPrev = 0;

                for (int i = 0; i <= value; i++)
                {
                    if(i == 1)
                    {
                        prevPrev = 0;
                        prev = i;
                    }

                    result = prev + prevPrev ;
                    Console.Write($"{result} ");
                    prevPrev = prev;
                    prev = result;
                }
            }
            else
            {
                Console.WriteLine("Введенное значение должно быть целочисельным.");
            }
            Console.ReadKey();
        }
    }
}
