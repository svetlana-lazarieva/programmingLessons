using System;

namespace Lesson_6
{
    /// <summary>
    /// Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
    /// Создайте программу, в которой создайте массив размерностью в 5 элементов, 
    /// выведите на экран все элементы массива.
    /// </summary>
    class Program
    {
        public static int[] array = new int[5];
        static void Main(string[] args)
        {
            InputDataToArray();
            OutputDataFromArray();
            Console.ReadKey();
        }

        /// <summary>
        /// Заполнит массив
        /// </summary>
        public static void InputDataToArray()
        {
            int i = 0;
            while (i < array.Length)
            {
                array[i] = i+1;
                i++;
            }
        }
        /// <summary>
        /// Вывести элементы массива на консоль
        /// </summary>
        public static void OutputDataFromArray()
        {
            int i = 0;
            while (i < array.Length)
            {
                Console.Write($"{array[i]} ");
                i++;
            }
        }
    }

    

}
