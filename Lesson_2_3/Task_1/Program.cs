using System;

/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application
/// Создайте программу в которой создайте класс делегат, который в качестве 
/// параметров принимает три целочисленных аргумента и возвращает 
/// целочисленный тип. 
/// Далее создайте анонимный метод, который также принимает три целочисленных 
/// аргумента и возвращает среднее арифметическое этих аргументов. Сообщите 
/// данный анонимный метод с экземпляром делегата, который был ранее создан
/// </summary>

namespace Task_1
{
    class Program
    {
        public delegate int MyDelegate(int val1, int val2, int val3);
        static MyDelegate myDelegate;
        static void Main(string[] args)
        {
            GetInfo(out int val1, out int val2, out int val3);

            myDelegate = delegate (int _val1, int _val2, int _val3)
            {
                return (_val1 + _val2 + _val3) / 3;
            };

            int res = myDelegate.Invoke(val1, val2, val3);
            Console.WriteLine(res);
            Console.ReadKey();
        }

        /// <summary>
        /// Получить три целочисельных значения
        /// </summary>
        /// <param name="val1">Значение 1</param>
        /// <param name="val2">Значение 2</param>
        /// <param name="val3">Значение 3</param>
        public static void GetInfo(out int val1, out int val2, out int val3)
        {
            GetVal(out val1);
            GetVal(out val2);
            GetVal(out val3);
        }

        /// <summary>
        /// Считать целочисельное значение с консоли
        /// </summary>
        /// <param name="val">Целочисельное значение</param>
        public static void GetVal(out int val)
        {
            Console.Write("Введите целочисельное значение: ");
            if (!int.TryParse(Console.ReadLine(), out val))
            {
                Console.WriteLine("Введенное значение не целочисельное");
                GetVal(out val);
            }
        }

        
    }
}
