using System;

/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.
/// Напишите программу, в которой создайте две целочисленные переменные и 
/// задайте им некоторые значения. Применяя технику вложенных циклов, 
/// нарисуйте прямоугольник из звездочек. Используйте значения ранее созданных 
/// переменных для указания высоты и ширины прямоугольника
/// </summary>

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение длины одной стороны прямоугольника: ");
            if (UInt32.TryParse(Console.ReadLine(), out var value1))
            {
                Console.Write("Введите значение длины другой стороны прямоугольника: ");
                if (UInt32.TryParse(Console.ReadLine(), out var value2))
                {
                    string line = string.Empty;
                    for (int i = 1; i <= value1; i++)
                    {                     
                        for (int j = 1; j <= value2; j++)
                        {
                            line = line + "*";
                        }
                        Console.WriteLine(line);
                        line = string.Empty;
                    }
                }
                else
                {
                    Console.WriteLine("Введенное значение должно быть целочисельным.");
                }
            }
            else
            {
                Console.WriteLine("Введенное значение должно быть целочисельным.");
            }
            Console.ReadKey();
        }
    }
}
