using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1;
/// <summary>
/// Используя Visual Studio, создайте проэкт по шаблону Console Application. 
/// Создайте расширяющий метод: public static T[] GetArray<T>(this MyList<T> list) 
/// Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в 
/// домашнем задании 1 для данного урока. Выведите на экран значения элементов 
/// массива, который вернул расширяющий метод GetArray()
/// </summary>

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            for (int i = 0; i < 20; i++)
            {
                list.Add(i);
            }

            var array = list.GetArray();

            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }

            Console.ReadKey();
        }

    }
}
