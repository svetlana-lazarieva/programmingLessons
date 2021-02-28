using System;

/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.
/// Напишите программу, которая поможет первокласнику Пети, у которого  
/// m рублей .Мороженое стоит k рублей. Петя решил наесться досыта мороженого, 
/// для этого он покупал по одному мороженому и съедал его до тех пор, пока 
/// ему хватало денег. Как Пете узнать, сколько денег останется у него в 
/// конце концов? учтите, что петя делить еще не умеет, а умеет только 
/// вычитать и складывать. сколько мороженых он может съесть?.
/// </summary>

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько у Пети денег? ");
            if (double.TryParse(Console.ReadLine(), out var money))
            {
                Console.Write("Сколько стоит мороженное? ");
                if (double.TryParse(Console.ReadLine(), out var price))
                {
                    int i = 0;
                    if (money >= price)
                    {
                        while (money >= price)
                        {
                            money = money - price;
                            i++;
                        }
                        Console.WriteLine($"После всех {i} седенных мороженных, у ребенка " +
                                          $"будет ангина и {money} грн");
                    }
                    else
                    {
                        Console.WriteLine("Пете не хватит даже на одно мороженное, " +
                                         $"но все его {money} грн останутся при нем.");
                    }
                }
                else
                {
                    Console.WriteLine("Мороженное не может столько стоить. Это даже не число!");
                }
            }
            else
            {
                Console.WriteLine("Зачем так обижать Петю? Это не похоже на деньги.");   
            }
            Console.ReadKey();
        }
    }
}
