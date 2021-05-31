using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    /// <summary>
    /// Используя Visual Studio, создайте проект по шаблону Console Application
    /// Создайте программу, в которой создайте массив чисел размерностью в 
    /// 1 000 000 или более.Используя генератор случайных чисел, проинициализируйте 
    /// этот массив значениями. Создайте PLINQ запрос, который позволит получить 
    /// все нечетные числа из исходного массива.
    /// </summary>
    class Program
    {
        public const int NumberOfElements = 10000000;


        static void Main(string[] args)
        {
            Random random = new Random((int)DateTime.Now.Ticks);

            int[] array = new int[NumberOfElements];
            // Инициализация массива данных
            Parallel.For(0, NumberOfElements, (i) => array[i] = random.Next(-100,100));

            // Запрос PLINQ для поиска нечетных чисел.
            ParallelQuery<int> oddNumbers = from element in array.AsParallel()
                                           where element%2 != 0
                                           select element;

            Console.WriteLine("Нечетныечисла массива:");
            foreach (int element in oddNumbers)
            {
                Console.Write($"{element} ");
            }
            Console.ReadKey();

        }
    }
}
