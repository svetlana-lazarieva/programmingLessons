using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
/// Напишите программу, в которой создайте метод, который выведет все числа 
/// от 1 до N. N – число которое пользователь вводит с клавиатуры. 
/// (Использовать рекурсию)
/// </summary>

namespace Task_8
{
    class Program
    {
        public const string ex = "Введенное значение не целочисленное.";
        public const string mess = "Введите целочисленное значение: ";
        public static int n;

        static void Main(string[] args)
        {
            Console.Write(mess);
            if (int.TryParse(Console.ReadLine(), out n))
            {
                ShowNumber(0);
            }
            else
            {
                Console.WriteLine(ex);
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Вывести все числа от 1 до значения аргумента.
        /// </summary>
        /// <param name="number">Аргумент</param>
        public static void ShowNumber(int number)
        {
            if (number >= n)
            {
                return;
            }
            else
            {                               
                Console.Write($"{++number} ");
                ShowNumber(number);
            }
        }
    }
}
