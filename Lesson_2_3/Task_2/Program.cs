using System;

/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application
/// Создайте программу, в которой создайте четыре лямбда оператора для выполнения 
/// арифметических действий, первый лямбда оператор для сложения, второй для 
/// вычитания, третий для умножения и четвертый для деления 
/// (лямбда оператор для деления должен выполнять проверку деления на ноль). 
/// Каждый лямбда оператор должен принимать два аргумента и возвращать 
/// соответственный результат вычисления.  В программе организуйте логику, которая 
/// будет выполнять арифметическую операцию указанную пользователем.
/// </summary>

namespace Task_2
{
    class Program
    {
        public static Calculator<double> calculator = new Calculator<double>();
        static void Main(string[] args)
        {
            calculator.Add += Addition;
            calculator.Subtr += Subtraction;
            calculator.Div += Division;
            calculator.Multiplicate += Multiplication;

            GetInfo(out double val1, out double val2);
            SetOperation(val1, val2);
        }

        /// <summary>
        /// Сложение
        /// </summary>
        /// <param name="val1">Значение 1</param>
        /// <param name="val2">Значение 2</param>
        /// <returns>Результат операции</returns>
        public static double Addition(double val1, double val2)
        {
            return val1 + val2;
        }

        /// <summary>
        /// Вычитание
        /// </summary>
        /// <param name="val1">Значение 1</param>
        /// <param name="val2">Значение 2</param>
        /// <returns>Результат операци</returns>
        public static double Subtraction(double val1, double val2)
        {
            return val1 - val2;
        }

        /// <summary>
        /// Умножение
        /// </summary>
        /// <param name="val1">Значение 1</param>
        /// <param name="val2">Значение 2</param>
        /// <returns>Результат операци</returns>
        public static double Multiplication(double val1, double val2)
        {
            return val1 * val2;
        }

        /// <summary>
        /// Деление
        /// </summary>
        /// <param name="val1">Значение 1</param>
        /// <param name="val2">Значение 2</param>
        /// <returns>Результат операци</returns>
        public static double Division(double val1, double val2)
        {
            if (val2 == 0)
            {
                Console.WriteLine("На ноль делить нельзя.");
                GetVal(out val2);
                Division(val1, val2);
            }
            return val1 / val2;
        }

        /// <summary>
        /// Получить два числовых значения
        /// </summary>
        /// <param name="val1">Значение 1</param>
        /// <param name="val2">Значение 2</param>
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

        /// <summary>
        /// Определить операцию
        /// </summary>
        private static int GetOperation()
        {
            Console.WriteLine("Введите номер операции: \n1 - сложение \n2 - вычитание \n3 - умножение \n4 - деление");
            if (!int.TryParse(Console.ReadLine(), out int operation) ||
                (operation < 1 && operation > 4))
            {
                Console.WriteLine("Введенное значение не закреплено за знаком операции.");
                GetOperation();
            }

            return operation;
        }

        /// <summary>
        /// Вывести результат операции на консоль
        /// </summary>
        /// <param name="val1">Значение 1</param>
        /// <param name="val2">Значение 2</param>
        /// <param name="operSimb">Знак операции</param>
        /// <param name="result">Результат операции</param>
        public static void ProcessOperation(double val1, double val2, string operSimb, double result)
        {
            Console.WriteLine($"{val1} {operSimb} {val2} = {result}");
            Console.ReadKey();
        }

        /// <summary>
        /// Выполнить заданную операцию
        /// </summary>
        public static void SetOperation(double val1, double val2)
        {
            int operation = GetOperation();
            double result = 0;
            switch (operation)
            {
                case 1:
                    result = calculator.Add.Invoke(val1, val2);
                    ProcessOperation(val1, val2, "+", result);
                    break; 
                case 2:
                    result = calculator.Subtr.Invoke(val1, val2);
                    ProcessOperation(val1, val2, "-", result);
                    break; 
                case 3:
                    result = calculator.Multiplicate.Invoke(val1, val2);
                    ProcessOperation(val1, val2, "*", result);
                    break; 
                case 4:
                    result = calculator.Div.Invoke(val1, val2);
                    ProcessOperation(val1, val2, "/", result);
                    break; 
            }
        }

    }
}
