using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
/// Создайте программу, в которой пользователь вводит прибыль фирмы за 
/// 12 месяцев. После чего пользователь вводит диапазон (например, 3 и 
/// 6 – поиск между 3-м и 6-м месяцем). Необходимо определить месяц, в 
/// котором прибыль была максимальна и месяц, в котором прибыль была 
/// минимальна с учетом выбранного диапазона.
/// </summary>
namespace Task_5
{
    class Program
    {       
        public const int AllProfitPeriod = 12;
         static void Main(string[] args)
        {
            double[] array = InputDataToArray();

            Console.Write($"Введите начало периода: ");
            if (int.TryParse(Console.ReadLine(), out int startMonth) &&
                startMonth <= AllProfitPeriod && startMonth >= 1)
            {
                Console.Write($"Введите конец периода: ");
                if (int.TryParse(Console.ReadLine(), out int stopMonth) &&
                    stopMonth <= AllProfitPeriod && stopMonth >= 1)
                {
                    GetBeginAndAndOfPeriod(ref startMonth, ref stopMonth);
                    GetMin(array, startMonth, stopMonth);
                    GetMax(array, startMonth, stopMonth);
                }
                else
                {
                    Console.WriteLine($"Введенное значение не целое число, лежащее между 1 и {AllProfitPeriod}.");
                }
            }
            else
            {
                Console.WriteLine($"Введенное значение не целочительное, лежащее между 1 и {AllProfitPeriod}.");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Заполнить массив вручную
        /// </summary>
        /// <returns>Массив</returns>
        public static double[] InputDataToArray()
        {            
            double[] arr = new double[AllProfitPeriod];
            string ex = "Введенное значение не числовое.";
            for (int i = 1; i <= AllProfitPeriod; i++)
            {
                Console.Write($"Прибыль за {i}-й месяц: ");
                if (!double.TryParse(Console.ReadLine(),out arr[i - 1]))
                {
                    Console.WriteLine(ex);
                    throw new Exception(ex);
                }
            }
            return arr;
        }

        /// <summary>
        /// Проверить правильность порядка ввода начала и конца периода
        /// </summary>
        /// <param name="startMonth">Начало периода</param>
        /// <param name="stopMonth">Конец периода</param>
        public static void GetBeginAndAndOfPeriod(ref int startMonth, ref int stopMonth)
        {
            int maxVal = stopMonth;
            int minVal = startMonth;

            if (minVal > maxVal)
            {
                maxVal = minVal;
                minVal = stopMonth;
            }
            startMonth = minVal;
            stopMonth = maxVal;
        }

        /// <summary>
        /// Получить минимальное значение массива
        /// </summary>
        /// <param name="arr">Массив</param>
        public static void GetMin(double[] arr, int startMonth, int stopMonth)
        {
            double minVal = arr[0];
            int month = 0;

            for (int i = startMonth-1; i <= stopMonth-1; i++)
            {
                if (arr[i] <= minVal)
                {
                    minVal = arr[i];
                    month = i + 1;
                }
            }
            string monthVal = GetAllMonthes(month, arr, startMonth, stopMonth, minVal);
            Console.WriteLine($"Минимальное значение прибыли было {minVal} грн в {month}-м месяце.");
        }

        /// <summary>
        /// Получить максимальное значение массива
        /// </summary>
        /// <param name="arr">Массив</param>
        public static void GetMax(double[] arr, int startMonth, int stopMonth)
        {
            double maxVal = arr[0];
            int month = 0;
             
            for (int i = startMonth - 1; i <= stopMonth - 1; i++)
            {
                if (arr[i] >= maxVal)
                {
                    maxVal = arr[i];
                    month = i + 1;
                }
            }
            string monthVal = GetAllMonthes(month, arr, startMonth, stopMonth, maxVal);
            Console.WriteLine($"Максимальное значение прибыли было {maxVal} грн в {monthVal} месяце.");
        }

        /// <summary>
        /// Получить все месяца с одинаковой заданной прибылью
        /// </summary>
        /// <param name="month">Месяц прибыли для сравнения</param>
        /// <param name="arr">Массив прибыли</param>
        /// <param name="startMonth">Начало периода</param>
        /// <param name="stopMonth">Конец периода</param>
        /// <param name="val">Прибыль для сравнения</param>
        /// <returns></returns>
        public static string GetAllMonthes(int month, double[] arr, int startMonth, 
                                           int stopMonth, double val)
        {
            string monthVal = string.Empty;
            monthVal = month.ToString() + "-м,";

            for (int i = startMonth - 1; i <= stopMonth - 1; i++)
            {
                if (val == arr[i] && month != (i + 1))
                {
                    monthVal = monthVal + $" {i + 1}-м,";
                }
            }
            monthVal = monthVal.Substring(0, monthVal.Length - 1);
            return monthVal;
        }
    }
}
