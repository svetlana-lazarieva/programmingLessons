using System;
/// <summary>
/// Создайте статический класс с методом void Print (string stroka, int color), 
/// который выводит на экран строку заданным цветом. Используя перечисление, 
/// создайте набор цветов, доступных пользователю. 
/// Ввод строки и выбор цвета предоставьте пользователю.
/// </summary>

namespace Task_4
{
    /// <summary>
    /// Принтер
    /// </summary>
    public static class Printer
    {     
        /// <summary>
        /// Доступные цвета
        /// </summary>
        private enum Colors
        {
            Black = 0,
            DarkBlue = 1,
            DarkGreen = 2,
            DarkCyan = 3,
            DarkRed = 4,
            DarkMagenta = 5,
            DarkYellow = 6,
            Gray = 7,
            DarkGray = 8,
            Blue = 9,
            Green = 10,
            Cyan = 11,
            Red = 12,
            Magenta = 13,
            Yellow = 14,
            White = 15
        }

        /// <summary>
        /// Количество доступных цветов
        /// </summary>
        private static int countEnum = Enum.GetNames(typeof(Colors)).Length - 1;

        /// <summary>
        /// Сделать работу принтера
        /// </summary>
        public static void ProcessingPrinter()
        {
            GetInfo(out string str, out int color);
            Print(str, color);
        }

        /// <summary>
        /// Печатать строку цыетом
        /// </summary>
        /// <param name="stroka">Строка</param>
        /// <param name="color">Цвет</param>
        private static void Print(string stroka, int color)
        {
            SetColor(color);
            Console.WriteLine(stroka);
            Console.ResetColor();
            Console.ReadKey();
        }

        /// <summary>
        /// Установить цвет вывода на консоль
        /// </summary>
        /// <param name="color">Номер цвета</param>
        private static void SetColor(int color)
        {
            string colorName = ((Colors)color).ToString();
            for (int i = 0; i <= Enum.GetNames(typeof(ConsoleColor)).Length; i++)
            {
                string consoleColorName = ((ConsoleColor)i).ToString();
                if (consoleColorName == colorName)
                {
                    Console.ForegroundColor = (ConsoleColor)i;
                }
            }
        }

        /// <summary>
        /// Получить исходную информацию
        /// </summary>
        /// <param name="str">Строка</param>
        /// <param name="color">Номер цвета</param>
        private static void GetInfo(out string str, out int color)
        {
            GetStr(out  str);
            GetColor(out  color);
          
        }

        /// <summary>
        /// Получить строку
        /// </summary>
        /// <param name="str">Строка</param>
        private static void GetStr(out string str)
        {
            Console.Write("Введите строку: ");
            str = Console.ReadLine();        
        }

        /// <summary>
        /// Получить номер цвета
        /// </summary>
        /// <param name="color">Номер цвета</param>
        private static void GetColor(out int color)
        {           
            Console.Write($"Введите номер цвета от 0 до {countEnum}: ");
            if (!int.TryParse(Console.ReadLine(), out color) ||
                color > countEnum || color < 0)
            {
                Console.WriteLine("Номер цвета не правильный.");
                GetColor(out color);
            }
        }
    }
}
