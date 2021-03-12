using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
/// Написать программу, в которой создайте один метод, который будет вычислять 
/// площадь и периметр прямоугольника. Сторони прямоугольника пользователь 
/// должен иметь возможность вводит с клавиатуры. 
/// </summary>

namespace Task_7
{
    class Program
    {
        public const string ex = "Введенное значение не числовое.";
        public const string mess = "Введите значение стороны прямоугольника: ";

        static void Main(string[] args)
        {
            double perimeterOfRectangle, areaOfRectangle;
            double rectangleSide1, rectangleSide2;

            ReadSideLength(out rectangleSide1);
            ReadSideLength(out rectangleSide2);

            ProcessingRectangle(rectangleSide1, rectangleSide2,
                                out perimeterOfRectangle, out areaOfRectangle);
            Console.WriteLine($"Периметр прямоугольника: {perimeterOfRectangle}");
            Console.WriteLine($"Площадь прямоугольника: {areaOfRectangle}");
            Console.ReadKey();
        }

        /// <summary>
        /// Считать длину стороны
        /// </summary>
        /// <param name="sideLength">Длина стороны</param>
        private static void ReadSideLength(out double sideLength)
        {
            Console.Write(mess);
            if (!double.TryParse(Console.ReadLine(), out sideLength))
            {
                Console.WriteLine(ex);
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Вычислить площадь и периметр прямоугольника.
        /// </summary>
        /// <param name="rectangleSide1">Сторона прямоугольника</param>
        /// <param name="rectangleSide2">Сторона прямоугольника</param>
        /// <param name="perimeterOfRectangle">Периметр прямоугольника</param>
        /// <param name="areaOfRectangle">Площадь прямоугольника</param>
        public static void ProcessingRectangle(double rectangleSide1, double rectangleSide2,
                                               out double perimeterOfRectangle,
                                               out double areaOfRectangle)
        {
            perimeterOfRectangle = (rectangleSide1 + rectangleSide2) * 2;
            areaOfRectangle = rectangleSide1 * rectangleSide2;
        }

    }
}
