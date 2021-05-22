using System;
using System.Threading.Tasks;

namespace Task_1
{
    /// <summary>
    /// Используя Visual Studio, создайте проект по шаблону Console Application. 
    /// Напишите программу, в которой метод будет вызываться рекурсивною.
    /// Каждый новый вызов метода выполняется в отдельном потоке.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            CreateThread(i);
            Console.ReadKey();
        }

        private static void CreateThread(int i)
        {
            Task.Run(() =>
            {
                Console.WriteLine(i);
                i++;
                if (i <= 10)
                {
                    CreateThread(i);
                }
                else
                {
                    return;
                }

            });
        }


    }
}
