using System;
/// <summary>
/// Создайте программу, в которой создайте статический класс StringExtension 
/// (длина строки), в теле класса создайте расширяющий метод StrCount который 
/// будет осуществлять подсчёт количество элементов в строке. 
/// Возвращаемое значение метода должно быть типа int, на вход необходимо 
/// принимать два аргумента, 1-й сама строка, 2-й символ начиная с которого 
/// будет производится расчет.
/// </summary>

namespace Task_3
{
    /// <summary>
    /// Длина строки
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// Осуществляет подсчёт количество элементов в строке
        /// </summary>
        /// <param name="str">Строка</param>
        /// <param name="startPosition">Начальная позиция в строке</param>
        /// <returns></returns>
        public static int StrCount(this string str, int startPosition)
        {
            int strCount = 0;
            for (int i = 0; i <= str.Length - startPosition; i++)
            {
                strCount = i;
            }
            return strCount + 1;
        }
    }
}
