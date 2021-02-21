using System;

namespace Task_4
{
    //Используя Visual Studio, создайте проект по шаблону 
    //Console Application. Создать программу для определения 
    //синуса угла, ввод угла должен осуществлять пользователь.

    class Program
    {
        static void Main(string[] args)
        {
            double rad = 0;
            double angleSin = 0;

            //Ограничения на размер угла не ставим т.к., в случае 
            //вращения круга, угол может быть больше 360 градусов
            //или меньше -360 градусов в зависимости от направления
            //вращения. По скольку rad= 180/Pi, ограничения количества
            //радиан так же не имеют смысла.

            // Для градусов
            #region DegreesOfAngle
            Console.Write("Введите значение угла в градусах (от -360 до 360): ");
            bool parseResult = double.TryParse(Console.ReadLine(), out var angle);

            if (parseResult)
            {               
                rad = angle * Math.PI / 180f; // Переводим в радианы
                angleSin = Math.Sin(rad);
                Console.WriteLine($"{angle} * {Math.PI} / 180 = {rad}");
                Console.WriteLine($"Sin({rad}) = {angleSin}");
                Console.WriteLine(string.Empty);
            }
            else 
            {
                Console.WriteLine($"То, что Вы ввели - не число.");
            }
            Console.ReadKey();
            #endregion

            // Для радиан
            #region RadiansOfAngle
            Console.Write("Введите значение угла в радианах: ");
            parseResult = double.TryParse(Console.ReadLine(), out rad);
            if (parseResult)
            {
                angleSin = Math.Sin(rad);
                Console.WriteLine($"Sin({rad}) = {angleSin}");
                Console.WriteLine(string.Empty); 
            }
            else
            {
                Console.WriteLine($"То, что Вы ввели - не число.");
            }
            Console.ReadKey();
            #endregion
        }
    }
}
