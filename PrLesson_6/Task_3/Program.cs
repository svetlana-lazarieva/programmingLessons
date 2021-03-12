using System;

/// <summary>
/// Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
/// Создайте программу, в которой создайте два строковых массива с именами 
/// A и B (размерностью 4 элемента). Массив A заполняется в цикле 
/// пользователем. Получить результирующий массив B, обратный к исходному 
/// массиву A (элементы массива B идут в обратном порядке по отношению 
/// к массиву A).
/// </summary>
namespace Task_3
{
    class Program
    {
        public static string[] A = new string[4];
        public static string[] B = new string[4];
        static void Main(string[] args)
        {
            InputDataToArray();           
            ReverseArray(A).CopyTo(B, 0);
            OutputDataFromArray(A);
            OutputDataFromArray(B);
            Console.ReadKey();
        }

        /// <summary>
        /// Заполнит массив в ручную 
        /// </summary>
        public static void InputDataToArray()
        {
            int i = 0;
            while (i < A.Length)
            {
                Console.Write($"Заполните элемент №{i+1}: ");
                A[i] = Console.ReadLine();
                i++;
            }
            if (i == A.Length-1)
            {
                Console.WriteLine("Все элементы введены.");
            }
        }

        /// <summary>
        /// Инвертировать массив
        /// </summary>
        /// <param name="array"> Массив</param>
        /// <returns>Инвертированный массив</returns>
        public static string[] ReverseArray(string[] array)
        {
            int lengthOfArray = array.Length;
            string[] arr = new string[lengthOfArray];
            int i = lengthOfArray - 1;

            while (i >= 0)
            {
                arr[lengthOfArray - (i+1)] = array[i];
                i--;
            }

            return arr;
        }

        /// <summary>
        /// Вывести элементы массива на консоль
        /// </summary>
        public static void OutputDataFromArray(string [] array)
        {
            Console.WriteLine();
            int i = 0;
            while (i < array.Length)
            {
                Console.Write($"{array[i]} ");
                i++;
            }
        }
    }
}
