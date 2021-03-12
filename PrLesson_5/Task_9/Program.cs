using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
/// Напишите программу, которая будет вычислять сумму цифр числа N. 
/// Число N пользователь должен вводить с клавиатуры. При решении этой задачи 
/// нельзя использовать строки, списки, массивы (ну и циклы, разумеется). 
/// (Использовать рекурсию)
/// </summary>

namespace Task_9
{   
    class Program
    {
        public const string ex = "Введенное значение не целочисленное.";
        public const string mess = "Введите целочисленное значение: ";     
        public static int sum;
        

        static void Main(string[] args)
        {
            Console.Write(mess);
            if (int.TryParse(Console.ReadLine(), out int n))
            {
               Console.WriteLine($"Сумма всех цифр числа {n} равна {GetSumm(n)}");
            }
            else
            {
                Console.WriteLine(ex);
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Вычислить сумму всех цифр аргумента
        /// </summary>
        /// <param name="number">Аргумент</param>
        /// <returns>Сумма всех цифр числа</returns>
        public static int GetSumm(int number)
        {
            if (number == 0)
            {
                return sum;
            }
            else
            {
                sum += number % 10;
                number = (number - (number % 10))/10;
                return GetSumm(number);
            }
        }

    }
}
