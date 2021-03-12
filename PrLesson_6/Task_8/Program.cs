using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
/// Создайте программу, в которой создайте метод, который будет выполнять 
/// увеличение длины массива переданного в качестве аргумента, на 1 элемент. 
/// Метод, должен принимает два аргумента, первый аргумент - типа int[] array, 
/// второй аргумент - типа int value. В теле метода реализуйте возможность 
/// добавления второго аргумента метода в массив по индексу – 0, при этом 
/// длина нового массива, должна увеличиться на 1 элемент, а элементы 
/// получаемого массива в качестве первого аргумента должны скопироваться в 
/// новый массив начиная с индекса - 1.
/// </summary>
namespace Task_8
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] array = new int[1];

            do
            {
                Console.Write("Введите значение нового элемента массива: ");
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    array = CreateNewArray(array, value);
                    OutputDataFromArray(array);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Введенное значение не целочисельное.");
                }
                Console.WriteLine("Хотите добавить элемент в массив? (y/n)");
            }
            while (Console.ReadLine() == "y");
        }

        /// <summary>
        /// Вывести элементы массива на консоль
        /// </summary>
        public static void OutputDataFromArray(int[] array)
        {
            int i = 0;
            while (i < array.Length)
            {
                Console.Write($"{array[i]} ");
                i++;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Создать новый массив на один элемент больше изначального
        /// и добавить в первый его элемент значение параметра value 
        /// со здвигом в право
        /// </summary>
        /// <param name="array">Изначальный массив</param>
        /// <param name="value">Значение нового элемента массива</param>
        /// <returns></returns>
        public static int[] CreateNewArray(int[] array, int value)
        {
            int size = array.Length + 1;
            int[] arr = new int[size];
            arr[0] = value;
            array.CopyTo(arr, 1);
            return arr;
        }

    }
}
