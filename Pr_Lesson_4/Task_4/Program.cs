using System;

/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.
/// Напишите программу, которая будет рассчитывать сумму вклада  в банк. 
/// Процентную ставку, сумму и срок на которой положили вклад, должен вводить 
/// пользователь с клавиатуры. 
/// </summary>

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите процентную ставку: ");
            if (double.TryParse(Console.ReadLine(), out var interestRate))
            {
                Console.Write("Введите сумму вклада:");
                if (double.TryParse(Console.ReadLine(), out var depositAmount))
                {
                    Console.Write("Введите срок на которой положили вклад(в годах):");
                    if (Int32.TryParse(Console.ReadLine(), out var termOfDeposit))
                    {
                        double money = depositAmount;

                        for (int i = 0; i < termOfDeposit; i++)
                        {
                            double interestInMoney = money * interestRate / 100d;
                            money = money + interestInMoney;
                        }
                        Console.WriteLine($"Вкладчик заработает {money- depositAmount}грн " +
                                          $"за {termOfDeposit} лет.\n" +
                                          $"Всего у него будет {money}грн");
                    }
                    else
                    {
                        Console.WriteLine("Срок на которой положили вклад должен " +
                                          "быть числовым значением.");
                    }
                }
                else
                {
                    Console.WriteLine("Сумма вклада должна быть числовым значением.");
                }
            }
            else
            {
                Console.WriteLine("Процентная ставка должна быть числовым значением.");
            }
            Console.ReadKey();
        }
    }
}
