using System;

/// <summary>
/// Используя Visual Studio, создайте проект по шаблону 
/// Console Application. Напишите программу, в которой 
/// пользователь вводит целое число. Программа в свою 
/// очередь должна ответить, четным или нечетным является 
/// это число, делится ли оно на 3 и делится ли оно на 6.
/// </summary>
namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string messege1 = "четное, которое ";
            string messege2 = "делится на 3 без остатка от деления и ";
            string messege3 = "делится на 6 без остатка от деления. ";

            Console.Write("Введите целое число: ");
            if (Int32.TryParse(Console.ReadLine(), out var min))
            {
                string messege = $"Число {min} - ";
                // четное 
                messege = min % 2 == 0 ? messege + messege1 : messege + "не " + messege1;
                // делится на 3
                messege = min % 3 == 0 ? messege + messege2 : messege + "не " + messege2;
                // делится на 6
                messege = min % 6 == 0 ? messege + messege3 : messege + "не " + messege3;

                Console.WriteLine(messege);
            }
            else
            {
                Console.WriteLine("Значение min должно быть целочисленным значением.");
            }

            Console.ReadKey();
        }
    }
}
