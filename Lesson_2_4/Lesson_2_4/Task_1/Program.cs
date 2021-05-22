using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application. 
/// Создайте программу в которой создайте класс Calculator, методы которого 
/// принимают аргументы и возвращают значения типа dynamic. 
/// </summary>

namespace Task_1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            GetInfo(out double val1, out double val2);
            Operation<double> operation = new Operation<double>(val1, val2);
            dynamic res = operation.SetOperation(out string oper);
            Console.WriteLine($"{val1} {oper} {val2} = {res}");
            Console.ReadKey();
        }

        public static void GetInfo(out double val1, out double val2)
        {
            GetVal(out val1);
            GetVal(out val2);
        }

        /// <summary>
        /// Считать числовое значение с консоли
        /// </summary>
        /// <param name="val">Числовое значение</param>
        public static void GetVal(out double val)
        {
            Console.Write("Введите числовое значение: ");
            if (!double.TryParse(Console.ReadLine(), out val))
            {
                Console.WriteLine("Введенное значение не числовое");
                GetVal(out val);
            }
        }
    }
}
