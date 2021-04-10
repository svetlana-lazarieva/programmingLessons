using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.
/// Создайте программу в которой создайте класс калькулятор (Calculator). 
/// Класс Calculator должен содержать два универсальных параметра типа 
/// T1, T2 (Calculator<T1, T2>). 
/// В теле класса создайте методы для сложения, вычитания и умножения, которые 
/// в качестве аргументов должны принимать T1, T2, и возвращать тип double 
/// (можно использовать класс Convert или приведение типов)
/// </summary>

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int val1 = 5;
            double val2 = 10;

            Calculator<int, double> calculator = new Calculator<int, double>();
            
            Console.WriteLine($"{val1} + {val2} = {calculator.Addition(val1, val2)}");
            Console.WriteLine($"{val1} - {val2} = {calculator.Subtraction(val1, val2)}");
            Console.WriteLine($"{val1} * {val2} = {calculator.Multiplication(val1, val2)}");

            Console.ReadKey();
        }
    }
}
