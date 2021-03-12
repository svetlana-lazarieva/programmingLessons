using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
/// Напишите программу консольный калькулятор. В данной программе должны 
/// быть четыре метода, метод для сложения, вычитания, умножения и деления. 
/// Каждый из методов должен принимать 2 целочисленных аргумента и выполнять 
/// соответствующею действие. Метод для деления должен выполнять проверку 
/// деления на ноль. Также необходимо предоставить пользователю возможность 
/// вводить знак арифметической операции, в зависимости от знака вызывать 
/// соответствующий метод. Также пользователю необходимо предоставить 
/// возможность вводит значения аргументов.  
/// </summary>

namespace Task_4
{
    class Program
    {
        public const string ex = "Введенное значение не числовое.";
        public const string mess = "Введите числовое значение: ";
        static void Main(string[] args)
        {
            double val1, val2;
            ReadValue(out val1);
            ReadValue(out val2);
            Console.Write("Введите знак арифметической операции: ");
            CheckSign(Console.ReadLine(), val1, val2);
        }

        /// <summary>
        /// Считать значение
        /// </summary>
        /// <param name="val">Значение</param>
        private static void ReadValue(out double val)
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
        /// Получить сумму аргументов
        /// </summary>
        /// <param name="val1">Аргумент 1</param>
        /// <param name="val2">Аргумент 2</param>
        /// <returns>Сумма аргументов</returns>
        public static void GetSumm(double val1, double val2)
        {
            Console.WriteLine($"{val1} + {val2} = {val1 + val2}");
        }

        /// <summary>
        /// Получить разницу аргументов
        /// </summary>
        /// <param name="val1">Аргумент 1</param>
        /// <param name="val2">Аргумент 2</param>
        /// <returns>Разница аргументов</returns>
        public static void GetDifference(double val1, double val2)
        {
            Console.WriteLine($"{val1} - {val2} = {val1 - val2}");
        }

        /// <summary>
        /// Получить результат умножения аргументов
        /// </summary>
        /// <param name="val1">Аргумент 1</param>
        /// <param name="val2">Аргумент 2</param>
        /// <returns>Результат умножения аргументов</returns>
        public static void GetResultOfMultiplyingTheArguments(double val1, double val2)
        {
            Console.WriteLine($"{val1} * {val2} = {val1 * val2}");
        }

        /// <summary>
        /// Получить результат деления аргументов
        /// </summary>
        /// <param name="val1">Аргумент 1</param>
        /// <param name="val2">Аргумент 2</param>
        /// <returns>Результат деления аргументов</returns>
        public static void GetResultOfDividingTheArguments(double val1, double val2)
        {
            if (val2 != 0)
            {
                Console.WriteLine($"{val1} / {val2} = {val1 / val2}");
            }
            else
            {
                Console.WriteLine("На ноль делить нельзя.");
            }
            
        }

        /// <summary>
        /// Проверить и выбрать арефметическую операцию по знаку
        /// </summary>
        /// <param name="sign">Знак арефметической операции</param>
        /// <param name="val1">Аргумент 1</param>
        /// <param name="val2">Аргумент 2</param>
        public static void CheckSign(string sign, double val1, double val2)
        {
            switch (sign)
            {
                case "+":
                    {
                        GetSumm(val1, val2);
                        break;
                    }
                case "-":
                    {
                        GetDifference(val1, val2);
                        break;
                    }
                case "*":
                    {
                        GetResultOfMultiplyingTheArguments(val1, val2);
                        break;
                    }
                case "/":
                    {
                        GetResultOfDividingTheArguments(val1, val2);
                        break;
                    }
                default:
                    Console.WriteLine("Введенное значение не является знаком арефметической операции.");
                    break;
            }
        }
    }
}
