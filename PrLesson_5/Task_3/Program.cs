using System;

/// <summary>
/// Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
/// Создайте программу, в которой создайте метод, который принимает в 
/// качестве аргумента год рождения пользователя и возвращает его полный возраст.
/// </summary>
namespace Task_3
{
    class Program
    {
        public const string ex = "Введенное значение не целочисленное.";
        public const string mess = "Введите год: ";
        static void Main(string[] args)
        {
            Console.Write(mess);
            if (int.TryParse(Console.ReadLine(), out int year))
            {
                Console.WriteLine($"Возраст: {GetAge(year)}");              
            }
            else
            {
                Console.WriteLine(ex);
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Определяет возраст
        /// </summary>
        /// <param name="year">Год рождения пользователя</param>
        /// <returns>Возраст</returns>
        public static int GetAge(int year)
        {           
            int thisYear = DateTime.Now.Year;
            int age = thisYear - year;
            return age;
        }
    }
}
