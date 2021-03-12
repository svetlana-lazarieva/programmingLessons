using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
/// Создайте программу, в которой создайте массив размера N элементов 
/// (размер массива задет пользователь), заполнить его произвольными целыми 
/// значениями. Вывести на экран: наибольшее значение массива, наименьшее 
/// значение массива, общую сумму всех элементов, среднее арифметическое всех 
/// элементов, вывести все нечетные значения. 
/// </summary>
namespace Task_6
{
    class Program
    {
        // Диапазон случайных значений
        public const int MinRandomValue = 0;
        public const int MaxRandomValue = 10;
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            if (int.TryParse(Console.ReadLine(),out int N))
            {
                int[] arr = new int[N];
                arr = InputRandomData(arr);
                OutputDataFromArray(arr);
                GetMin(arr);
                GetMax(arr);
                GetSum(arr);
                GetAverage(arr);
            }
            else
            {
                Console.WriteLine("Введенное значение не целочисленное.");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Заполняет массив случацными целими числами.
        /// </summary>
        /// <param name="arr">Пустой массв</param>
        /// <returns>Заполненный массив</returns>
        public static int[]  InputRandomData(int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(MinRandomValue, MaxRandomValue);
            }                   
            return arr;
        }

        /// <summary>
        /// Получить минимальное значение массива
        /// </summary>
        /// <param name="arr">Массив</param>
        public static void GetMin(int[] arr)
        {
            int minVal = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] <= minVal)
                {
                    minVal = arr[i];
                }
            }
            Console.WriteLine($"Минимальное значение массива {minVal}");
        }

        /// <summary>
        /// Получить максимальное значение массива
        /// </summary>
        /// <param name="arr">Массив</param>
        public static void GetMax(int[] arr)
        {          
            int maxVal = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] >= maxVal)
                {
                    maxVal = arr[i];
                }
            }
            Console.WriteLine($"Максимальное значение массива {maxVal}");
        }

        /// <summary>
        /// Получить сумму значений элементов массива
        /// </summary>
        /// <param name="arr">Массив</param>
        public static void GetSum(int[] arr)
        {
            int sumVal = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sumVal = sumVal + arr[i];
            }
            Console.WriteLine($"Сумма значений массива {sumVal}");
        }

        /// <summary>
        /// Получить сумму значений элементов массива
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static void GetSum(int[] arr, out int sumVal)
        {
            sumVal = 0;           
            for (int i = 0; i < arr.Length; i++)
            {
                sumVal = sumVal + arr[i];
            }          
        }

        /// <summary>
        /// Получить среднее арифметическое значений массива
        /// </summary>
        /// <param name="arr">Массив</param>
        public static void GetAverage(int[] arr)
        {
            int sumVal = 0;
            GetSum(arr, out sumVal);
            double averageVal = sumVal / (double)arr.Length;
            Console.WriteLine($"Среднее арифметическое значений массива {averageVal}");
        }

        /// <summary>
        /// Вывести элементы массива на консоль
        /// </summary>
        public static void OutputDataFromArray(int[] arr)
        {
            int i = 0;
            while (i < arr.Length)
            {
                Console.Write($"{arr[i]} ");
                i++;
            }
            Console.WriteLine();
        }
    }
}
