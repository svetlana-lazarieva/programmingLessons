using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.
/// Напишите программу, которая будет складывать, вычитать, умножать или делить 
/// два числа. Числа и знак операции вводятся пользователем. После выполнения 
/// вычисления программа не должна завершаться, а должна запрашивать новые 
/// данные для вычислений. Завершение программы должно выполняться при вводе 
/// символа '0' в качестве знака операции. Если пользователь вводит неверный 
/// знак (не '0', '+', '-', '*', '/'), то программа должна сообщать ему об ошибке 
/// и снова запрашивать знак операции. Также сообщать пользователю о невозможности 
/// деления на ноль, если он ввел 0 в качестве делителя.             
/// </summary>
namespace Task_10
{
    class Program
    {
        /// <summary>
        /// Делаем заданную операцию над числами a и b
        /// </summary>
        /// <param name="a"></param> число
        /// <param name="b"></param> число
        /// <param name="operation"></param> арефметическая операция
        /// <returns></returns>
        public static string GetResult(double a, double b, string operation)
        {
            string result = string.Empty;
            switch (operation)
            {
                case "+":
                    result = (a + b).ToString();
                    break;
                case "-":
                    result = (a - b).ToString();
                    break;
                case "*":
                    result = (a * b).ToString();
                    break;
                case "/":
                    result = (a / b).ToString();
                    break;
                default:
                    result = "Введенное значение не является знаком операции.";
                    Console.WriteLine(result);
                    break;
            }
            return result;
        }

        /// <summary>
        /// Выводим результат отработки заданй арефметической операции
        /// над числами a и b
        /// </summary>
        /// <param name="operation"></param> арефметическая операция
        public static string CheckOperation(double a, double b, string operation)
        {
            string message = string.Empty;
            var result = GetResult(a, b, operation);
            if (result == "Введенное значение не является знаком операции.") return result;

            if (operation != "/")
            {
                message = $"{a} {operation} {b} = {result};";
            }
            else if (operation == "/")
            {
                message = b != 0 ?
                          $"{a} {operation} {b} = {result};" :
                          "На ноль делить нельзя.";
            }
            Console.WriteLine(message);
            return message;
        }


        static void Main(string[] args)
        {
            string message = string.Empty;
            string operation = string.Empty;

            while (operation != "0")
            {
                Console.Write("Введите знак операции('0', '+', '-', '*', '/'): ");
                operation = Console.ReadLine();

                message = ProcessInput(message, operation);
            }
            Console.ReadKey();
        }

        private static string ProcessInput(string message, string operation)
        {
            // Проверяем, цифровые ли значения
            Console.Write("Введите значение числа А: ");
            if (double.TryParse(Console.ReadLine(), out var a))
            {
                Console.Write("Введите значение числа В: ");
                if (double.TryParse(Console.ReadLine(), out var b))
                {
                    message = CheckMessege(message, operation, a, b);
                }
                else
                {
                    Console.WriteLine("Введенное значение не является числовым.");
                }
            }
            else
            {
                Console.WriteLine("Введенное значение не является числовым.");
            }

            return message;
        }

        private static string CheckMessege(string message, string operation, double a, double b)
        {
            switch (message)
            {
                case "Ошибка значения A.":
                    {
                        message = ProcessA(operation, b);
                        break;
                    }
                case "Ошибка значения B.":
                case "На ноль делить нельзя.":
                    {
                        message = ProcessB(operation, a);
                        break;
                    }
                default:
                    message = ProcessDefault(operation, a, b);
                    break;
            }

            return message;
        }

        private static string ProcessDefault(string operation, double a, double b)
        {
            string message = CheckOperation(a, b, operation);
            if (message == "На ноль делить нельзя.")
            {
                CheckMessege(message, operation, a, b);
            }

            return message;
        }

        private static string ProcessB(string operation, double a)
        {
            string message;
            Console.Write("Введите другое значение числа В: ");
            if (double.TryParse(Console.ReadLine(), out var b1))
            {
                message = CheckOperation(a, b1, operation);
            }
            else
            {
                Console.WriteLine("Введенное значение не является числовым.");
                message = "Ошибка значения B.";
            }

            return message;
        }

        private static string ProcessA(string operation, double b)
        {
            string message;
            Console.Write("Введите другое значение числа А: ");
            if (double.TryParse(Console.ReadLine(), out var a1))
            {
                message = CheckOperation(a1, b, operation);
            }
            else
            {
                Console.WriteLine("Введенное значение не является числовым.");
                message = "Ошибка значения A.";
            }

            return message;
        }
    }
}
