using System;

/// <summary>
/// Используя Visual Studio, создайте проект по шаблону 
/// Console Application. Напишите программу - консольный 
/// калькулятор. Создайте две переменные с именами 
/// operand1 и operand2. Задайте переменным некоторые 
/// произвольные значения. Предложите пользователю 
/// ввести знак арифметической операции. Примите значение 
/// введенное пользователем и поместите его в строковую 
/// переменную sign. Для организации выбора алгоритма 
/// вычислительного процесса, используйте переключатель 
/// switch. Выведите на экран результат выполнения 
/// арифметической операции. В случае использования 
/// операции деления, организуйте проверку попытки 
/// деления на ноль. И если таковая имеется, то отмените 
/// выполнение арифметической операции и уведомите об ошибке 
/// пользователя.
/// </summary>

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = string.Empty;

            Console.Write("Введите значение operand1: ");
            if (double.TryParse(Console.ReadLine(),out var operand1))
            {
                Console.Write("Введите значение operand2: ");
                if (double.TryParse(Console.ReadLine(), out var operand2))
                {
                    Console.Write("Введите знак арифметической операции: ");
                    string arephmeticOperationSimbol = Console.ReadLine();

                    switch (arephmeticOperationSimbol)
                    {
                        case "+":
                            Console.WriteLine($"{operand1} {arephmeticOperationSimbol} {operand2} = " +
                                              $"{operand1 + operand2};");
                            break;
                        case "-":
                            Console.WriteLine($"{operand1} {arephmeticOperationSimbol} {operand2} = " +
                                              $"{operand1 - operand2};");
                            break;
                        case "*":
                            Console.WriteLine($"{operand1} {arephmeticOperationSimbol} {operand2} = " +
                                              $"{operand1 * operand2};");
                            break;
                        case "/":
                            message = operand2 != 0 ?
                                      $"{operand1} {arephmeticOperationSimbol} {operand2} = " +
                                      $"{operand1 / operand2};" : "На ноль дeлить нельзя.";
                            Console.WriteLine(message);
                            break;
                        case "%":
                            message = operand2 != 0 ?
                                       $"{operand1} {arephmeticOperationSimbol} {operand2} = " +
                                        $"{operand1 % operand2};" : "На ноль дeлить нельзя.";
                            Console.WriteLine(message);
                            break;
                        default:
                            Console.WriteLine("Введеннон значение не является знаком арифметической операции.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Значение operand2 должно быть числовым.");
                }
            }
            else
            {
                Console.WriteLine("Значение operand1 должно быть числовым.");
            }
            Console.ReadKey();
        }
    }
}
