using System;

namespace Task_2
{
    //Используя Visual Studio, создайте проект по шаблону 
    //Console Application.Создайте константу с именем -pi 
    //(число π «пи»), создайте переменную радиус с именем – r.
    //Используя формулу πR 2 , вычислите площадь круга и 
    //выведите результат на экран.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус: ");
            double.TryParse(Console.ReadLine(), out var r);
            double square = Math.PI * Math.Pow(r,2);
            Console.WriteLine($"Площадь круга с радиусом {r} равна {square}");
            Console.ReadKey(); 
        }
    }
}
