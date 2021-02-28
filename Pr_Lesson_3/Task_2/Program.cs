using System;

/// <summary>
/// Используя Visual Studio, создайте проект по шаблону 
/// Console Application.                                              
/// Напишите программу, которая будет рассчитывать процент 
/// скидки в зависимости от количества купленного товара. 
/// Если куплено больше 3 единиц товара, тогда скидка должна 
/// быть 10 процентов от общей суммы, если же количество 
/// больше 3 и меньше 7, то 20процентов от общей суммы, 
/// иначе, если больше 7 то 25 процентов от общей суммы. 
/// Цену товара и купленное количество товара пользователь 
/// должен задавать вводом с консоли.                              
/// </summary>

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double discountPercent;
            Console.Write("Введите цену товара товаров(грн): ");

            if (double.TryParse(Console.ReadLine(), out var price))
            {

                Console.Write("Введите количество купленных товаров(шт): ");
                // Проверяем количество купленных товаров
                if (int.TryParse(Console.ReadLine(), out var saleCounter))
                {
                    if (saleCounter <= 3)
                    {
                        discountPercent = 10;
                    }
                    else if (saleCounter > 3 && saleCounter < 7)
                    {
                        discountPercent = 20;
                    }
                    else
                    {
                        discountPercent = 25;
                    }

                    Console.WriteLine($"Значение скидки(%): {discountPercent}%");
                    double discountPrice = price * saleCounter * discountPercent / 100;
                    Console.WriteLine($"Значение скидки(грн): {discountPrice}грн");


                }
                else
                {
                    Console.WriteLine("Введите количество купленных товаров" +
                                      "должно быть целочисленным значением.");
                }
            }
            else
            {
                Console.WriteLine("Ценa должна быть числом.");
            }
            Console.ReadKey();
        }

    }
}
