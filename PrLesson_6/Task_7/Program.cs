using System;


namespace Task_7
{
    /// <summary>
    /// Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
    /// Создайте программу, в которой создает метод, который в качестве аргументов 
    /// принимает: 
    /// 1)целочисленный массив(int[] array), 
    /// 2)целочисленный индекс(int index), 
    /// 3)количество элементов(int count), возвращает целочисленный массив элементов
    /// (int[] subArray). 
    /// Метод возвращает часть полученного в качестве аргумента массива, начиная 
    /// с позиции указанной в аргументе index, размерностью, которая соответствует 
    /// значению аргумента count.
    /// </summary>
    class Program
    {
        public const string ex = "Введенное значение должно быть целочисленным.";
        public const string mess1 = "Введите количество элементов входного массива: ";
        public const string mess2 = "Введите количество элементов входного массива: ";
        // Диапазон случайных значений
        public const int MinRandomValue = 0;
        public const int MaxRandomValue = 10;

        static void Main(string[] args)
        {
            int n, count;

            ReadValue(out n, mess1);
            int[] array = CreateArray(n);
            OutputDataFromArray(array);
            Console.Write("Введите начальную позицию: ");
            if (int.TryParse(Console.ReadLine(), out int index) &&
                index < n)
            {
                ReadValue(out count, mess2);
                int[] subArray = GetArray(array, index, count);
                OutputDataFromArray(subArray);
            }
            else
            {
                Console.WriteLine("Введенное значение должно быть целочисленным\n " +
                                  "и меньшим общего колличества элементов входного массива.");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Считать значение
        /// </summary>
        /// <param name="val">Значение</param>
        private static void ReadValue(out int val, string mess)
        {
            Console.Write(mess);
            if (!int.TryParse(Console.ReadLine(), out val))
            {
                Console.WriteLine(ex);
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Создать массив  размерностью, которая соответствует значению аргумента count.
        /// </summary>
        /// <param name="array">Исходный массив</param>
        /// <param name="index">Начальная позиция исходного массива</param>
        /// <param name="count">Размерность результирующего массива</param>
        /// <returns>Результирующий массив</returns>
        public static int[] GetArray(int[] array, int index, int count)
        {
            int[] subArray = new int[count];
            for (int i = 0; i < subArray.Length; i++)
            {
                subArray[i] = index < array.Length ? array[index] : 0;
                index++;
            }
            return subArray;
        }

        /// <summary>
        /// Создать и заполнить массив случайных чисел заданной размерности
        /// </summary>
        /// <param name="n"> Размерность массива</param>
        /// <returns>Массив случайных чисел</returns>
        public static int[] CreateArray(int n)
        {
            int[] arr = new int[n];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(MinRandomValue, MaxRandomValue);
            }
            return arr;
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

    }
}
