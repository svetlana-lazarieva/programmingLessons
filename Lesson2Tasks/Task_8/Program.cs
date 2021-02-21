using System;

namespace Task_8
{
    //Используя Visual Studio, создайте проект по шаблону 
    //Console Application.Имеется 3 переменные типа 
    //int x = 10, y = 12, и z = 3; Выполните и рассчитайте 
    //результат следующих операций для этих переменных: 
    //x += y - x++ * z;
    //z = --x – y* 5; 
    //y /= x + 5 % z; 
    //z = x++ + y* 5; 
    //x = y - x++ * z;

    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 12,  z = 3;
            //x += y - x++ * z 
            #region Operation1
            Console.WriteLine($" Исходные данные: x = {x}, y = {y}, z = {z}");
            x += y - x++ * z;             
            Console.WriteLine(" После отработки: x += y - x++ * z");         
            Console.WriteLine($" x = {x}, y = {y}, z = {z}");
            Console.WriteLine($"{string.Empty}");
            #endregion
            //z = --x - y * 5
            #region Operation2
            x = 10; 
            y = 12;  
            z = 3;
            Console.WriteLine($" Исходные данные: x = {x}, y = {y}, z = {z}");
            z = --x - y * 5;
            Console.WriteLine($" После отработки z = --x - y * 5 ");
            Console.WriteLine($" x = {x}, y = {y}, z = {z}");
            Console.WriteLine($"{string.Empty}");
            #endregion
            //y /= x + 5 % z
            #region Operation3
            x = 10;
            y = 12;
            z = 3;
            Console.WriteLine($" Исходные данные: x = {x}, y = {y}, z = {z}");
            y /= x + 5 % z;
            Console.WriteLine($" После отработки: y /= x + 5 % z ");
            Console.WriteLine($" x = {x}, y = {y}, z = {z}");
            Console.WriteLine($"{string.Empty}");
            #endregion
            //z = x++ + y * 5
            #region Operation4
            x = 10;
            y = 12;
            z = 3;
            Console.WriteLine($" Исходные данные: x = {x}, y = {y}, z = {z}");
            z = x++ + y * 5;
            Console.WriteLine($" После отработки z = x++ + y * 5 ");
            Console.WriteLine($" x = {x}, y = {y}, z = {z}");
            Console.WriteLine($"{string.Empty}");
            #endregion
            //x = y - x++ * z
            #region Operation5
            x = 10;
            y = 12;
            z = 3;
            Console.WriteLine($" Исходные данные: x = {x}, y = {y}, z = {z}");
            x = y - x++ * z;
            Console.WriteLine($" После отработки x = y - x++ * z ");
            Console.WriteLine($" x = {x}, y = {y}, z = {z}");
            Console.WriteLine($"{string.Empty}");
            #endregion
            Console.ReadKey();
        }
    }
}
