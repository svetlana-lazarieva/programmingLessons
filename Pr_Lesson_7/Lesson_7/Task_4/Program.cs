﻿using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.
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
/// В методе Main() создайте экземпляр класса «Треугольник», задайте 
/// произвольное значение сторон треугольника и выведите на экран значение 
/// периметра и площади треугольника. 
/// </summary>

namespace Task_4
{
    class Program
    {
        public const double sideOfTriangle1 = 5;
        public const double sideOfTriangle2 = 5.8;
        public const double sideOfTriangle3 = 14;
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(sideOfTriangle1, sideOfTriangle2, sideOfTriangle3);
            double perimeterOfTriangle = triangle.CalculatingPerimeterOfTriangle();
            double areaOfTriangle = triangle.CalculatingAreaOfTriangle();
            triangle.ShowAreaAndPerimeterOfTriangle(areaOfTriangle, perimeterOfTriangle);
            Console.ReadKey();
        }
    }
}
