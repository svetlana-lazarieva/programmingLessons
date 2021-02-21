using System;

namespace Task_3
{
    //Используя Visual Studio, создайте проект по шаблону 
    //Console Application. Создать программу для определения 
    //гипотенузы прямоугольного треугольника, используя 
    //формулу с=√(a^2+ b^2), где с – гипотенуза, а b и a 
    //катеты прямоугольного треугольника.Ввод катетов должен 
    //осуществлять пользователь.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение катета №1: ");
            double.TryParse(Console.ReadLine(), out var leg1);
            Console.Write("Введите значение катета №2: ");
            double.TryParse(Console.ReadLine(), out var leg2);
            double hypotenuse = Math.Sqrt(Math.Pow(leg1, 2) * Math.Pow(leg2, 2));
            Console.WriteLine("Гипотенуза прямоугольного треугольника,");
            Console.WriteLine($"при заданных катетах, равна {hypotenuse}");
            Console.ReadKey();
        }
    }
}
