using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.
/// Создайте программу, в которой создайте статический класс StringExtension 
/// (длина строки), в теле класса создайте расширяющий метод StrCount который 
/// будет осуществлять подсчёт количество элементов в строке. 
/// Возвращаемое значение метода должно быть типа int, на вход необходимо 
/// принимать два аргумента, 1-й сама строка, 2-й символ начиная с которого 
/// будет производится расчет. 
/// </summary>

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            GetPosition(out int startPosition, str.Length);

            int strCount = str.StrCount(startPosition);
            Console.WriteLine($"В строке {str} {strCount} символов, " +
                              $"начиная с {startPosition}-го символа");
            Console.ReadKey();
        }

        public static void GetPosition(out int startPosition, int strLength)
        {
            Console.WriteLine("\nВведите значение позиции для начала подсчета: ");
            if (!int.TryParse(Console.ReadLine(),out startPosition))          
            {
                Console.WriteLine("Введенное значение не целочисельное.");
                GetPosition(out startPosition, strLength);
            }
            else if(strLength < startPosition)
            {
                Console.WriteLine("Введенное значение больше длины всей строки.");
                GetPosition(out startPosition, strLength);
            }
        }

        
    }
}
