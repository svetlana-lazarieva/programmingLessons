using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.        
/// Создайте статический класс с методом void Print (string stroka, int color), 
/// который выводит на экран строку заданным цветом. Используя перечисление, 
/// создайте набор цветов, доступных пользователю. 
/// Ввод строки и выбор цвета предоставьте пользователю.
/// </summary>

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer.ProcessingPrinter();

        }
    }
}
