using System;

namespace Task_6
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону 
        //Console Application. Написать программу для расчета 
        //скидки за покупку, скидку и цену товара должен 
        //осуществлять пользователь.

        static void Main(string[] args)
        {
            // Если заданна скидка в процентах
            #region FirstWayOfImplementation 
            {
                Console.WriteLine("Если заданна скидка в процентах");
                Console.Write("Введите цену товара(грн): ");
                double.TryParse(Console.ReadLine(), out var price);
                Console.Write("Введите значение скидки(%): ");
                double.TryParse(Console.ReadLine(), out var discountPercent);
                // Считаем деньги
                double discountMoney = price * discountPercent / 100;
                Console.WriteLine($"Скидка в деньгах получается {discountMoney}грн");
                Console.WriteLine(string.Empty);
                Console.ReadKey();
            }
            #endregion
            // Если заданна скидка в деньгах
            #region SecondWayOfImplementation
            {
                Console.WriteLine("Если заданна скидка в деньгах");
                Console.Write("Введите цену товара(грн): ");
                double.TryParse(Console.ReadLine(), out var price);
                Console.Write("Введите значение скидки(грн): ");
                double.TryParse(Console.ReadLine(), out var discountMoney);
                // Считаем деньги
                double discountPercent = discountMoney * 100 / price;
                Console.WriteLine($"Скидка в процентах получается {discountPercent}%");
                Console.ReadKey();
            }
            #endregion
        }
    }
}
