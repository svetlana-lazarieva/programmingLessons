using System;

/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.
/// Напишите программу,  в которой запросите пользователя ввести два числа 
/// A и B (A<B), если (A>B выведите соответствующее предупреждение) и выведите 
/// суму всех чисел расположенных между данными числами на экран. Дано два 
/// числа A и B (A<B) выведите все нечетные значения, расположенные 
/// между данными числами.                                                                                                                                                                          
/// </summary>

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Работаем толко с целыми числами, т.к в случае работы с дробями
            // возвращаемых значений для не четных чисел между А и В получается
            // слишком много даже для точности 0,01

            Console.Write("Введите число А: ");
            if (Int32.TryParse(Console.ReadLine(),out var a))
            {
               Console.Write("Введите число В (B > A): ");
                if (Int32.TryParse(Console.ReadLine(), out var b))
                {
                    Int32 sum = 0;
                    string str = string.Empty;

                    Console.Write($"A = {a}, B = {b}; ");

                    // Обработка значений
                    if (a > b)
                    {
                        Console.WriteLine("A > B");
                        while (b + 1 < a)
                        {
                            b++;
                            str = str + $"{b} ";
                            sum = sum + b;
                        }
                        Console.WriteLine($"Числа между А и В: " + str);
                        Console.WriteLine($"Сума всех чисел между А и В равна {sum}");
                    }
                    else if (a < b)
                    {
                        Console.WriteLine("A < B");
                        while (a + 1 < b)
                        {
                            a++;
                            str = a % 2 != 0 ? str + $"{a} " : str + string.Empty;
                        }
                        Console.Write("Bсе нечетные значения, расположенные между числами А и В: " + str);
                        //Console.WriteLine(str);
                    }
                    else
                    {
                        Console.WriteLine("A = B");
                    }
                }
                else
                {
                    Console.WriteLine("Введенное значение должно быть целочисельным.");
                }
            }
            else
            {
                Console.WriteLine("Введенное значение должно быть целочисельным.");
            }

            Console.ReadKey();
        }
    }
}
