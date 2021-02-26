using System;

/// <summary>
/// Используя Visual Studio, создайте проект по шаблону 
/// Console Application. Напишите программу,  которая 
/// решает квадратное уравнение. Пользователь должен 
/// ввести коэффициенты а, b и с квадратного уравнения 
/// ах2 + bх + с = 0. После чего программа должна вывести 
/// на экран все корни этого уравнения или сообщение о том, 
/// что их нет. Рассмотреть случаи когда дискриминант (D) 
/// квадратного уравнения > 0, когда D < 0 и когда D = 0.
/// </summary>
namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите коэффициент a: ");
            if (double.TryParse(Console.ReadLine(), out var a) && a != 0)
            {
                Console.Write("Введите коэффициент b: ");
                if (double.TryParse(Console.ReadLine(), out var b))
                {
                    Console.Write("Введите коэффициент c: ");
                    if (double.TryParse(Console.ReadLine(), out var c))
                    {
                        Console.WriteLine(string.Empty);
                        Console.WriteLine($"Kвадратное уравнение: {a}*Pow(х,2) + {b}*х + {c} = 0;");
                        Console.WriteLine(string.Empty);
                        Console.WriteLine("Находим дискреминант.");
                        Console.WriteLine($"Формула:      D = Pow(a,2) - 4*a*c;");
                        Console.WriteLine($"Дискриминант: D = Pow({b},2) - 4*{a}*{c};");
                        
                        // Находим дискриминант
                        double discriminant = Math.Pow(b, 2) - 4 * a * c;
                        Console.WriteLine($"Дискриминант: D = {discriminant}");
                        Console.WriteLine(string.Empty);

                        // Находим корни, если они есть
                        if (discriminant == 0)
                        {
                            Console.WriteLine("По скольку D = 0, есть ровно один корень.");
                            Console.WriteLine(string.Empty);
                            Console.WriteLine("Формула: x = (-b + sqrt(D))/2a;");
                            Console.WriteLine(string.Empty);
                            Console.WriteLine($"Значит:  x = (-{b} + sqrt({discriminant}))/2{a};");
                            Console.WriteLine($"         x = {(b*(-1) + Math.Sqrt(discriminant))/(2*a)};");
                        }
                        else if (discriminant > 0)
                        {
                            Console.WriteLine("По скольку D > 0, корней будет два.");
                            Console.WriteLine(string.Empty);
                            Console.WriteLine("Формула: x1 = (-b + sqrt(D))/2a;");
                            Console.WriteLine("         x2 = (-b - sqrt(D))/2a;");
                            Console.WriteLine(string.Empty);

                            Console.WriteLine($"Значит:  x1 = (-1*{b} + sqrt({discriminant}))/2{a};");
                            Console.WriteLine($"         x2 = (-1*{b} - sqrt({discriminant}))/2{a};");
                            Console.WriteLine($"         x1 = {(b * (-1) + Math.Sqrt(discriminant)) / (2 * a)};");
                            Console.WriteLine($"         x2 = {(b * (-1) - Math.Sqrt(discriminant)) / (2 * a)};");
                        }
                        else
                        {
                            Console.WriteLine("По скольку D < 0, корней нет.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Значение c должно быть числовым.");
                    }
                }
                else
                {
                    Console.WriteLine("Значение b должно быть числовым.");
                }
            }
            else
            {
                Console.WriteLine("Значение a должно быть числовым  и не равным нулю.");      
            }
            Console.ReadKey();
        }
    }
}
