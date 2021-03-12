using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
/// Напишите программу в которой создайте метод, который в качестве аргументов 
/// принимает 2 числа и возвращает меньшее из них.
/// </summary>

namespace Task_2
{
    class Program
    {
        public const string ex = "Введенное значение не числовое.";
        public const string mess = "Введите числовое значение: ";

        static void Main(string[] args)
        {
            double val1, val2;
            ReadValue(out val1);
            ReadValue(out val2);
            Console.WriteLine($"Mеньшее значение из двух аргументов: {GetMin(val1, val2)}");              
            Console.ReadKey();
        }

        /// <summary>
        /// Считать значение
        /// </summary>
        /// <param name="val">Значение</param>
        private static void ReadValue(out double val)
        {
            Console.Write(mess);
            if (!double.TryParse(Console.ReadLine(), out val))
            {
                Console.WriteLine(ex);
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Возвращает меньшее значение из двух аргументов
        /// </summary>
        /// <param name="val1">Аргумент 1</param>
        /// <param name="val2">Аргумент 2</param>
        /// <returns>Меньшее значение из двух аргументов</returns>
        public static double GetMin(double val1, double val2)
        {
            double minVal = val1;
            if (val1 >= val2)
            {
                minVal = val2;
            }
            return minVal;
        }
    }
}
