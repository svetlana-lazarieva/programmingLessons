using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
/// Напишите программу в которой создайте метод, который принимает в качестве 
/// параметров три целочисленных аргумента и выводит на экран среднее 
/// арифметическое значений аргументов.
/// </summary>

namespace Task_1
{
    class Program
    {
        public const string ex = "Введенное значение не целочисленное.";
        public const string mess = "Введите целочисленное значение: ";

        static void Main(string[] args)
        {
            int val1, val2, val3;
            ReadValue(out val1);
            ReadValue(out val2);
            ReadValue(out val3);
            ShowAverage(val1, val2, val3);                    
            Console.ReadKey();
        }

        /// <summary>
        /// Считать значение
        /// </summary>
        /// <param name="val">Значение</param>
        private static void ReadValue(out int val)
        {
            Console.Write(mess);
            if (!int.TryParse(Console.ReadLine(), out val))
            {
                Console.WriteLine(ex);
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Выводит на экран среднее арифметическое значений аргументов.
        /// </summary>
        /// <param name="val1">Аргумент 1</param>
        /// <param name="val2">Аргумент 2</param>
        /// <param name="val3">Аргумент 3</param>
        public static void ShowAverage(int val1, int val2, int val3)
        {
            double average = (val1 + val2 + val3) / 3d;
            Console.WriteLine($"Среднее арифметическое значений: {average}");
        }
    }
}
