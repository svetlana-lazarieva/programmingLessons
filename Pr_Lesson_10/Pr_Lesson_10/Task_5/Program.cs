using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.
/// 
/// Создайте класс, который будет описывать точку в трехмерной системе координат (X, Y, Z).  
/// В теле класса переопределите операторы сложения (+), вычитания(-), умножения(*), 
/// деления(/), декремента(++), инкремента(--), также переопределите метод ToString(), 
/// таким образом, чтоб он отображал полную информацию о точке (ее координаты), 
/// метод Equals  для сравнения 2-х точек, а также метод  GetHashCode. 
/// 
/// В методе Main() создайте 2 экземпляря класса точка, выполните для 2-х точек все 
/// переопределенные методы, результат выполнения операция вывидите на консоль.

/// </summary>

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Vertex vertexA = new Vertex("A", 10, 3, 4);
            Vertex vertexB = new Vertex("B", 1, 8, 7);
            Vertex vertexC = null;

            vertexC = vertexA + vertexB;
            Console.WriteLine($" {vertexA.Name}{vertexA} + {vertexB.Name}{vertexB} " +
                              $"= {vertexC.Name}{vertexC};");
            vertexC = vertexA - vertexB;
            Console.WriteLine($" {vertexA.Name}{vertexA} - {vertexB.Name}{vertexB} " +
                              $"= {vertexC.Name}{vertexC};");
            vertexC = vertexA * vertexB;
            Console.WriteLine($" {vertexA.Name}{vertexA} * {vertexB.Name}{vertexB} " +
                              $"= {vertexC.Name}{vertexC};");
            vertexC = vertexA / vertexB;
            Console.WriteLine($" {vertexA.Name}{vertexA} / {vertexB.Name}{vertexB} " +
                              $"= {vertexC.Name}{vertexC};");

            vertexC = new Vertex("C",vertexA++);
            Console.WriteLine($"\n {vertexA.Name}{vertexA}++ = {vertexC.Name}{vertexC};");

            vertexC = new Vertex("C", vertexA--);
            Console.WriteLine($" {vertexA.Name}{vertexA}-- = {vertexC.Name}{vertexC};");

            Console.WriteLine($"\n Результат отработки Equals(): {vertexA.Equals(vertexB)}");
            Console.WriteLine($"\n Результат отработки GetHashCode(): {vertexA.GetHashCode()}");
            Console.WriteLine($" Результат отработки GetHashCode(): {vertexB.GetHashCode()}");

            Console.ReadKey();
        }
    }
}
