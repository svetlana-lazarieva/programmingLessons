using System;

/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.
/// Напишите программу определения, попадает ли указанное пользователем число 
/// от 0 до 100 в числовой промежуток [0 - 14] [15 - 35] [36 - 50][50 - 100]. 
/// Если да, то укажите, в какой именно промежуток. Если пользователь указывает 
/// число не входящее ни в один из имеющихся числовых промежутков, то выводится 
/// соответствующее сообщение.
/// </summary>

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            const double Value1 = 0;
            const double Value2 = 14;
            const double Value3 = 15;
            const double Value4 = 35;
            const double Value5 = 36;
            const double Value6 = 50;
            const double Value7 = 51;
            const double Value8 = 100;
            const string Mess = "Число попало в числовой промежуток ";


            Console.Write("Введите число  от 0 до 100: ");
            if (double.TryParse(Console.ReadLine(), out var value) &&
                value >= 0 && value <= 100)
            {
                // [0 - 14] [15 - 35] [36 - 50][51 - 100]
                string message = (value >= Value1 && value <= Value2) ? $"{Mess}[{Value1} - {Value2}]" :
                                 ((value >= Value3 && value <= Value4) ? $"{Mess}[{Value3} - {Value4}]" :
                                  (value >= Value5 && value <= Value6) ? $"{Mess}[{Value5} - {Value6}]" :
                                  $"{Mess}[{Value7} - {Value8}]");
                Console.WriteLine("Для условия: [0 - 14] [15 - 35] [36 - 50][51 - 100]");
                Console.WriteLine(message);
                Console.WriteLine();

                if (value == 50)
                {
                    // [0 - 14] [15 - 35] [36 - 50] [50 - 100]
                    message = (value >= Value1 && value <= Value2) ? $"{Mess}[{Value1} - {Value2}]" :
                              ((value >= Value3 && value <= Value4) ? $"{Mess}[{Value3} - {Value4}]" :
                               $"{Mess}[{Value5} - {Value6}] и [{Value6} - {Value8}]");
                    Console.WriteLine("Для условия: [0 - 14] [15 - 35] [36 - 50][50 - 100]");
                    Console.WriteLine(message);
                }

            }
            else
            {
                Console.WriteLine("Заданное значение не является числом от 0 до 100.");
            }
            Console.ReadLine();
        }
    }
}
