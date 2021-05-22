using System;
using System.Linq;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application 
/// Создайте программу в которой создайте целочисленную последовательность 
/// размерностью 30 элементов (последовательность заполнить случайными числами), 
/// содержащая как положительные, так и отрицательные числа. Вывести ее первый 
/// положительный элемент и последний отрицательный элемент
/// </summary>
namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[30];
            FillAndShowArray(numbers);
            Psrtitioning(numbers);

            // Выбираем первый положительный элемент массива
            int positiveElement = numbers.FirstOrDefault(x => x >= 0);
            Console.WriteLine($"\nПервый положительный элемент массива: {positiveElement}");

            // Выбираем последний отрицательный элемент массива
            int negativeElement = numbers.LastOrDefault(x => x < 0);
            Console.WriteLine($"Последний отрицательный элемент массива: {negativeElement}");

            Console.ReadKey();
        }

        /// <summary>
        /// Отделяем положительные числа от отрицательных
        /// </summary>
        /// <param name="numbers">Массив</param>
        private static void Psrtitioning(int[] numbers)
        {
            var query = from x in numbers
                        group x by x >= 0 into partition
                        select new {Group = partition};

            Console.WriteLine("\n\nПоложительные и отрицательныйе элементы массива:");
            foreach (var item in query)
            {
                foreach (var number in item.Group)
                {
                    Console.Write($"{number} ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Заполнить массив и вывести его на консоль
        /// </summary>
        /// <param name="numbers">Массив</param>
        private static void FillAndShowArray(int[] numbers)
        {
            Random random = new Random();
            Console.WriteLine("Исходный массива:");
            for (int i = 0; i < numbers.Count(); i++)
            {
                numbers[i] = random.Next(-10, 10);
            }
            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
