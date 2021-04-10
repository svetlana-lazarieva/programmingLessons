using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.
/// 
/// Создайте в программу, в которой создайте статический класс, в теле которого 
/// создайте расширяющий метод, который будет сортировать элементы целочисленного 
/// массива по возрастанию. Также в теле класса создайте метод, который будет 
/// создавать массив целочисленных элементов, и заполнять его случайными значениями 
/// элементов, длина массива – параметр метода. 
/// 
/// В методе Main() с помощью метода описанного выше создайте массив целочисленных 
/// элементов размерностью 10 элементов,  выведите значение всех элементов массива 
/// на консоль, далее с помощью расширяющего  метода отсортируйте массив, и 
/// отсортированный массив снова выведите на консоль.  
/// </summary>

namespace Task_4
{
    class Program
    {
        // Количество элементов массива
        public const int NumberOfArrayElements = 10;

        static void Main(string[] args)
        {
            int[] array = Extention.CreateArray(NumberOfArrayElements);
            Console.WriteLine("Исходный массив: ");
            ShowArray(array);           
            array.SortArray();
            Console.WriteLine("\nРезультирующий массив: ");
            ShowArray(array);
            Console.ReadKey();
        }

        /// <summary>
        /// Вывести на консоль все элементы массива
        /// </summary>
        /// <param name="array">Массив</param>
        public static void ShowArray(int[] array)
        {           
            foreach (int item in array)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
