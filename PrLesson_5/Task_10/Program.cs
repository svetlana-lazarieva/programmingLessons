using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
/// Напишите программу, в которой создайте метод, который в качестве аргумента 
/// принимает целое число и определяет количество разрядов данного числа. 
/// Пользователь должен иметь возможность вводит число с клавиатуры. 
/// </summary>

namespace Task_10
{
    class Program
    {
        public const string ex = "Введенное значение не целочисленное.";
        public const string mess = "Введите целочисленное значение: ";
        public static int res;
        static void Main(string[] args)
        {
            Console.Write(mess);
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine($"Количество разрядов числа {n}(рекурсия): {GetNumbLength(n)}");
                Console.WriteLine($"Количество разрядов числа {n}(строки): {GetNumbLength(n.ToString())}");
            }
            else
            {
                Console.WriteLine(ex);
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Oпределяет количество разрядов данного числа.
        /// </summary>
        /// <param name="number">Число</param>
        /// <returns>Количество разрядов числа</returns>
        public static int GetNumbLength(int number)
        {
            if (number == 0)
            {
                return res;
            }
            else
            {
                res++;
                number = (number - (number % 10)) / 10;
                return GetNumbLength(number);
            }
        }

        /// <summary>
        /// Oпределяет количество разрядов данного числа.
        /// </summary>
        /// <param name="number">Число</param>
        public static int GetNumbLength(string number)
        {
            return number.Length;
        }


    }
}
