using System;

namespace Task_9
{
    //Используя Visual Studio, создайте проект по шаблону 
    //Console Application.Напишите программу расчета 
    //объема - V и площади поверхности -S цилиндра. 
    //Объем V цилиндра радиусом – R и высотой – h, 
    //вычисляется по формуле:  V= πr ^ 2 h.Площадь S 
    //поверхности цилиндра вычисляется по формуле: S = 2πR(R+h). 
    //Результаты расчетов выведите на экран.Пользователь должен 
    //иметь возможность вводит r – радиус цилиндра и h – высоту цилинда.
    class Program
    {
        static void Main(string[] args)
        {          
            // радиус цилиндра
            Console.Write("Введите радиус цилиндра: ");
            double.TryParse(Console.ReadLine(), out var r);
            // высота цилинда
            Console.Write("Введите высоту цилинда: ");
            double.TryParse(Console.ReadLine(), out var h);

            // объем цилиндра
            double v = Math.PI * Math.Pow(r, 2) * h;
            // площадь цилиндра
            double s = 2 * Math.PI * r*(r+h);

            Console.WriteLine($"Объем цилиндра равен {v}");
            Console.WriteLine($"Площадь поверхности цилиндра равен {s}");
            Console.ReadKey();
        }
    }
}
