using System;
/// <summary>
/// Создайте программу, в которой создайте класс «Треугольник». 
/// В теле класса создайте три закрытых поля для описания сторон треугольника 
/// и три свойства для чтения и записи. Также в теле класса создайте 3 метода: 
/// 1 - й для расчета площади треугольника, формула для расчета 
/// S=√(p*(p-a)*(p - b) * (p - c) ), где p - полупериметр треугольника 
/// p=(a+b+c)/ 2, a, b, c – длины сторон треугольника, 
/// 2-й для расчета периметра треугольника, формула для расчета p=(a+b+c)/ 2 и 
/// 3 - й для вывода информации о площади и периметре треугольника. 
/// Создайте конструктор, который в качестве аргументов приминимает стороны 
/// треугольника и инициализирует поля класса.  
/// </summary>

namespace Task_4
{
    /// <summary>
    /// Kласс «Треугольник». 
    /// </summary>
    public class Triangle
    {
        // Стороны треугольника
        private double _sideOfTriangle1;
        private double _sideOfTriangle2;
        private double _sideOfTriangle3;

        public double SideOfTriangle1 { get; set; }
        public double SideOfTriangle2 { get; set; }
        public double SideOfTriangle3 { get; set; }



        /// <summary>
        /// Задает значения сторонам треугольника
        /// </summary>
        /// <param name="sideOfTriangle1"> Сторона треугольника </param>
        /// <param name="sideOfTriangle2"> Сторона треугольника </param>
        /// <param name="sideOfTriangle3"> Сторона треугольника </param>
        public Triangle(double sideOfTriangle1, double sideOfTriangle2, double sideOfTriangle3)
        {
            _sideOfTriangle1 = sideOfTriangle1;
            _sideOfTriangle2 = sideOfTriangle2;
            _sideOfTriangle3 = sideOfTriangle3;
        }

        /// <summary>
        /// Расчитать площадь треугольника
        /// </summary>
        public double CalculatingAreaOfTriangle()
        {
            // Полупериметр треугольника
            double halfPerimeter = _sideOfTriangle1 + _sideOfTriangle2 + _sideOfTriangle3 / 2d;
            double val1 = halfPerimeter - _sideOfTriangle1;
            double val2 = halfPerimeter - _sideOfTriangle2;
            double val3 = halfPerimeter - _sideOfTriangle3;
            // Площадь треугольника
            double areaOfTriangle = Math.Sqrt(halfPerimeter * val1 * val2 * val3);
            return areaOfTriangle;
        }

        /// <summary>
        /// Расчитать периметр треугольника 
        /// </summary>
        public double CalculatingPerimeterOfTriangle()
        {
            double perimeterOfTriangle = _sideOfTriangle1 + _sideOfTriangle2 + _sideOfTriangle3;
            return perimeterOfTriangle;
        }

        /// <summary>
        /// Вывести на консоль площадь и периметр треугольника
        /// </summary>
        /// <param name="areaOfTriangle">Площадь треугольника</param>
        /// <param name="perimeterOfTriangle">Периметр треугольника</param>
        public void ShowAreaAndPerimeterOfTriangle(double areaOfTriangle, 
                                                   double perimeterOfTriangle)
        {
            Console.WriteLine($"Площадь треугольника: {areaOfTriangle}");
            Console.WriteLine($"Периметр треугольника: {perimeterOfTriangle}");
        }

    }
}
