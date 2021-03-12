using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
/// Напишите программу, в которой создайте метод, который принимает в качестве 
/// параметров три целочисленных значения и возвращает значение каждого 
/// аргумента, умноженного на 10.(Использовать out и ref)
/// </summary>

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int val1 = 0, val2 = 0, val3;
            string res = ProcessingArguments(ref val1, ref val2, out val3);
            ShowResult(val1, val2, val3, res);
            Console.ReadKey();
        }

        /// <summary>
        /// Умножает аргументы на 10
        /// </summary>
        /// <param name="val1">Аргумент 1</param>
        /// <param name="val2">Аргумент 2</param>
        /// <param name="val3">Аргумент 3</param>
        public static string ProcessingArguments(ref int val1, ref int val2, out int val3)
        {
            string res = string.Empty;
            res += GetValues(out val1);
            res += GetValues(out val2);
            res += GetValues(out val3);

            if (res == string.Empty)
            {
                val1 *= 10;
                val2 *= 10;
                val3 *= 10;
            }
            return res;
        }

        /// <summary>
        /// Получает значения для аргументов
        /// </summary>
        /// <param name="val">Аргумент 1</param>
        /// <returns>Ошибки при инициализации аргументов</returns>
        public static string GetValues(out int val)
        {
            string res = string.Empty;
            Console.Write("Введите целочисленное значение: ");
            if (int.TryParse(Console.ReadLine(), out val))
            {
                res = string.Empty;
            }
            else
            {
                val = 0;
                res = "exeption";
                Console.WriteLine("Введенное значение не целочисленное.");
            }
            return res;
        }


        /// <summary>
        /// Выводит результат отработки на экран
        /// </summary>
        /// <param name="val1">Аргумент 1</param>
        /// <param name="val2">Аргумент 2</param>
        /// <param name="val3">Аргумент 3</param>
        public static void ShowResult(int val1, int val2,int val3, string res)
        {
            if (res == string.Empty)
            {
                Console.WriteLine($"Результат отработки:  {val1}, {val2}, {val3}");
            }            
        }

    }
}
