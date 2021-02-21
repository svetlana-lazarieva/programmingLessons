using System;

namespace Lesson2
{
    //Используя Visual Studio, создайте проект по 
    //шаблону Console Application.
    //Создайте программу для перевода метров в сантиметры 
    //(1м = 100см), ввод метров должен осуществлять пользователь.

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение в метрах: "); 
            double.TryParse(Console.ReadLine(), out var meters);// метры
            double centimeters = meters * 100; // сантиметры
            Console.WriteLine($"В {meters} метрах {centimeters} сантиметров.");
            Console.ReadKey();
        }
    }
}
