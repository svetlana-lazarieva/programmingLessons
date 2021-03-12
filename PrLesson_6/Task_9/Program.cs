using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону ConsoleApplication.                                       
/// Создайте программу, в которой создайте массив целых чисел размерности 10х10 
/// и заполните его случайными элементами. Выведете на консоль полученный массив. 
/// Найдите суммы элементов каждой строки, произведения элементов каждого столбца, 
/// и максимальный элемент главной диагонали (подсказка: все элементы, для которых 
/// номер строки совпадает с номером столбца). 
/// </summary>

namespace Task_9
{
    class Program
    {
        // Размер массива
        public const int LengthOfArray = 10;
        public const int WidthOfArray = 10;
        // Диапазон случайных значений
        public const int MinRandomValue = 0;
        public const int MaxRandomValue = 10;
        // Массив целых чисел 
        public static int[,] arr = new int[LengthOfArray, WidthOfArray];

        static void Main(string[] args)
        {
            InputRandomDataToArray();
            ShowArray();
            ShowSumm();
            ShowWorks();
            ShowMaximumDiagonalElement(GetArrayOfDiagonalElements());
            Console.ReadKey();
        }

        /// <summary>
        /// Заполнить двумерный массив случайными числами
        /// </summary>
        public static void InputRandomDataToArray()
        {           
            Random rand = new Random();
            for (int i = 0; i < LengthOfArray; i++)
            {
                for (int j = 0; j < WidthOfArray; j++)
                {
                    arr[i, j] = rand.Next(MinRandomValue, MaxRandomValue);
                }               
            }           
        }

        /// <summary>
        /// Вывести двумерный массив
        /// </summary>
        public static void ShowArray()
        {
            for (int i = 0; i < LengthOfArray; i++)
            {
                string arrStr = string.Empty;
                for (int j = 0; j < WidthOfArray; j++)
                {
                   arrStr = arrStr + $"{arr[i, j]} ";                 
                }
                Console.WriteLine(arrStr);
            }
        }

        /// <summary>
        /// Вывести суммы элементов каждой строки массива
        /// </summary>
        public static void ShowSumm()
        {
            Console.WriteLine();
            Console.WriteLine("Суммы элементов каждой строки массива");

            for (int i = 0; i < LengthOfArray; i++)
            {
                int summ = 0;
                for (int j = 0; j < WidthOfArray; j++)
                {
                    summ += arr[i, j];
                }
               
                Console.Write($"{summ} ");
            }
        }

        /// <summary>
        /// Вывести произведения элементов каждого столбца массива
        /// </summary>
        public static void ShowWorks()
        {
            Console.WriteLine();
            Console.WriteLine("Произведения элементов каждого столбца массива");

            for (int j = 0; j < LengthOfArray; j++)
            {
                int multiply = 1;
                for (int i = 0; i < WidthOfArray; i++)
                {
                    multiply *= arr[i, j];
                }

                Console.Write($"{multiply} ");
            }

        }

        /// <summary>
        /// Получить массив элементов главной диагонали исходного массива
        /// </summary>
        /// <returns>Массив элементов главной диагонали исходного массива</returns>
        public static int[] GetArrayOfDiagonalElements()
        {
            int[] arrOfDiagonalElements = new int[LengthOfArray];

            for (int i = 0; i < LengthOfArray; i++)
            {
                for (int j = 0; j < WidthOfArray; j++)
                {
                    if (i == j)
                    {
                        arrOfDiagonalElements[i] = arr[i, j];
                    }
                }
            }
            return arrOfDiagonalElements;
        }

        /// <summary>
        /// Вывести максимальный элемент главной диагонали массива
        /// </summary>
        public static void ShowMaximumDiagonalElement(int[] arrOfDiagonalElements)
        {
            int maxVal = arrOfDiagonalElements[0];

            for (int i = 0; i < arrOfDiagonalElements.Length; i++)
            {
                if (arrOfDiagonalElements[i] >= maxVal)
                {
                    maxVal = arrOfDiagonalElements[i];
                }
            }
            Console.WriteLine();
            Console.Write($"Максимальный элемент главной диагонали: {maxVal}");
        }
    }
}
