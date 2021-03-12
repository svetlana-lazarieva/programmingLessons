using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
/// Напишите программу для конвертирования валюты. Пользователь должен иметь 
/// возможность ввести курс валюты, в которую он хочет конвертировать, сумму 
/// которую он хочет конвертировать.  Программа должна вывести сумму денег в 
/// соответствующей валюте.
/// </summary>

namespace Task_5
{
    class Program
    {
        public const string ex = "Введенное значение не числовое.";
        public const string mess1 = "Введите курс валюты: ";
        public const string mess2 = "Введите сумму, которую хотите конвертировать: ";
        
        static void Main(string[] args)
        {
            double rate, amountOfMoney;
            ReadValue(out rate, mess1);
            ReadValue(out amountOfMoney, mess2);
            ConvertMoney(rate, amountOfMoney);               
            Console.ReadKey();
        }

        /// <summary>
        /// Считать значение
        /// </summary>
        /// <param name="val">Значение</param>
        /// <param name="mess">Сообщение</param>
        private static void ReadValue(out double val, string mess)
        {
            Console.Write(mess);
            if (!double.TryParse(Console.ReadLine(), out val))
            {
                Console.WriteLine(ex);
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Конвертирует валюту по заданному курсу
        /// </summary>
        /// <param name="rate">Курс валюты</param>
        /// <param name="amountOfMoney">Сумма денег для конвертации</param>
        public static void ConvertMoney(double rate, double amountOfMoney)
        {       
            if (rate != 0)
            {
                Console.WriteLine($"Результат конвертации: {amountOfMoney / rate}");
            }
            else
            {
                Console.WriteLine("Это сомнительный курс.");
            }
        }
    }
}
