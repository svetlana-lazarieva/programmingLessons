using System;
/// <summary>
/// Создайте программу, в которой создайте статический класс Calculator (калькулятор).  
/// В классе создайте методы для выполнения основных арифметических операций. 
/// </summary>

namespace Task_1
{
    static class Calculator
    {
        /// <summary>
        /// Результат математической операции над числом1 и числом2
        /// </summary>
        public static double Res { get; private set; }

        static Calculator()
        {
            Res = 0;
        }

        /// <summary>
        /// Сумма
        /// </summary>
        /// <param name="val1">Число1</param>
        /// <param name="val2">Число2</param>
        /// <returns>Результат суммы числа1 и числа2</returns>
        private static double Sum(double val1, double val2)
        {
            return val1 + val2;
        }
        /// <summary>
        /// Разница
        /// </summary>
        /// <param name="val1">Число1</param>
        /// <param name="val2">Число2</param>
        /// <returns>Результат разници между числом1 и числом2</returns>
        private static double Difference(double val1, double val2)
        {
            return val1 - val2;
        }
        /// <summary>
        /// Произведение
        /// </summary>
        /// <param name="val1">Число1</param>
        /// <param name="val2">Число2</param>
        /// <returns>Результат умножения числа1 на число2</returns>
        private static double Product(double val1, double val2)
        {
            return val1 * val2;
        }
        /// <summary>
        /// Деление
        /// </summary>
        /// <param name="val1">Число1</param>
        /// <param name="val2">Число2</param>
        /// <returns>Результат деления числа1 на число2</returns>
        private static double Division(double val1, double val2)
        {
            return val1 / val2;
        }

        /// <summary>
        /// Проверка адекватности введенного значения для математической операции
        /// </summary>
        /// <param name="val">Значение</param>
        /// <param name="operation">Математическая операция</param>
        /// <param name="ValidVal">Адекватность значения</param>
        private static void ValidationValue(ref double val, string operation, ref bool validVal)
        {
            if (double.TryParse(Console.ReadLine(), out val))
            {
                validVal = true;
                if (operation == "/" && val == 0)
                {
                    validVal = false;
                }
            }
            else
            {
                validVal = false;
            }
        }

        /// <summary>
        /// Выполнить математическую операцию
        /// </summary>
        public static void Calculate()
        {
            Console.WriteLine(" Какую мат.операцию Вы хотите выполнить?\n" +
                              " 1 - сумма двух чисел\n" +
                              " 2 - разница двух чисел\n" +
                              " 3 - умножение двух чисел\n" +
                              " 4 - деление двух чисел");
            string mathOperation = GetMathOperation();
            SetMathOperation(mathOperation);

            Console.ReadKey();
        }

        /// <summary>
        /// Задать математическую операцию
        /// </summary>
        private static void SetMathOperation(string mathOperation)
        {
            if (!string.IsNullOrEmpty(mathOperation))
            {
                double val1 = GetVal(mathOperation);
                double val2 = GetVal(mathOperation);
                if (mathOperation == "+")
                {
                    Res = Sum(val1, val2);
                    Console.WriteLine($"\n{val1} + {val2} = {Res}");
                }
                else if (mathOperation == "-")
                {
                    Res = Difference(val1, val2);
                    Console.WriteLine($"\n{val1} - {val2} = {Res}");
                }
                else if (mathOperation == "*")
                {
                    Res = Product(val1, val2);
                    Console.WriteLine($"\n{val1} * {val2} = {Res}");
                }
                else
                {
                    Res = Division(val1, val2);
                    Console.WriteLine($"\n{val1} / {val2} = {Res}");
                }
            }
            else
            {
                Console.WriteLine("Введенное значение мат.операции не корректно.");
                Console.ReadKey();
                Calculate();
            }
        }

        /// <summary>
        /// Получить значение числа
        /// </summary>
        /// <param name="mathOperation"> Математическая операция</param>
        /// <returns>Значение числа</returns>
        private static double GetVal(string mathOperation)
        {
            double val = 0;
            bool validVal = true;
            Console.WriteLine("Введите значение:");
            ValidationValue(ref val, mathOperation, ref validVal);
            if (!validVal)
            {
                Console.WriteLine("Значение не корректно.");
                Console.ReadKey();
                GetVal(mathOperation);
            }
            return val;
        }

        /// <summary>
        /// Определить математическую операцию
        /// </summary>
        /// <returns>ОМатематическая операция</returns>
        private static string GetMathOperation()
        {
            string mathOperation = string.Empty;
            mathOperation = Console.ReadLine();
            switch (mathOperation)
            {
                case "1":
                    {
                        mathOperation = "+";
                        return mathOperation;
                    }
                case "2":
                    {
                        mathOperation = "-";
                        return mathOperation;
                    }
                case "3":
                    {
                        mathOperation = "*";
                        return mathOperation;
                    }
                case "4":
                    {
                        mathOperation = "/";
                        return mathOperation;
                    }
                default:
                    {
                        mathOperation = string.Empty;
                        return mathOperation;
                    }
            }
        }

    }
}
