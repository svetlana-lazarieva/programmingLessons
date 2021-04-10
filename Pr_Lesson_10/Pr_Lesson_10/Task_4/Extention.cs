using System;
/// <summary>
/// Создайте в программу, в которой создайте статический класс, в теле которого 
/// создайте расширяющий метод, который будет сортировать элементы целочисленного 
/// массива по возрастанию. Также в теле класса создайте метод, который будет 
/// создавать массив целочисленных элементов, и заполнять его случайными значениями 
/// элементов, длина массива – параметр метода.
/// </summary>

namespace Task_4
{
    public static class Extention
    {
        /// <summary>
        /// Создать массив случайных чисел типа int
        /// </summary>
        /// <param name="numberOfArrayElements">Количество элементов массива</param>
        public static int[] CreateArray(int numberOfArrayElements)
        {
            Random random = new Random();
            int[] array = new int[numberOfArrayElements];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0,10);
            }
            return array;
        }

        /// <summary>
        /// Сортировка пузырьком
        /// </summary>
        /// <param name="array">Массив</param>
        /// <returns>Отсортированный массив</returns>
        public static int[] SortArray(this int[] array)
        {
            var len = array.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
            return array;
        }

        /// <summary>
        /// Метод обмена элементов
        /// </summary>
        private static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }
    }
}
