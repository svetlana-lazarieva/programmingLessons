using System;
/// <summary>
/// Создайте программу, в которой создайте статический класс Convector (конвектор). 
/// В теле класса Convector создайте два статических метода, первый CelsiusToFahrenheit 
/// (string temperatureCelsius) , который конвертирует значение температуры в Цельсиях 
/// в Фаренгейты, и второй FahrenheitToCelsius (string temperatureFahrenheit), который 
/// конвертирует значение температуры в Фаренгейтах в значение температуры в Цельсиях.
/// </summary>

namespace Task_2
{
    static class Convertor
    {
        /// <summary>
        /// Kонвертирует значение температуры в Цельсиях в Фаренгейты
        /// </summary>
        /// <param name="temperatureCelsius">Температура в Цельсиях</param>
        private static void CelsiusToFahrenheit(string temperatureCelsius)
        {
            double temperatureCelsiusVal = GetValue(temperatureCelsius);
            Console.WriteLine($" {temperatureCelsius} в Цельсиях это " +
                              $"{temperatureCelsiusVal * 1.8d - 32} в Фаренгейтах");
            Console.ReadKey();
        }

        /// <summary>
        /// Kонвертирует значение температуры в Фаренгейтах в Цельсиях
        /// </summary>
        /// <param name="temperatureCelsius">Температура в Фаренгейтах</param>
        private static void FahrenheitToCelsius(string temperatureFahrenheit)
        {
            double temperatureFahrenheitVal = GetValue(temperatureFahrenheit);
            Console.WriteLine($" {temperatureFahrenheit} в Фаренгейтах это " +
                              $"{(temperatureFahrenheitVal - 32)/1.8d} в Цельсиях");
            Console.ReadKey();
        }

        /// <summary>
        /// Перевести строковое значение в числовое
        /// </summary>
        /// <returns>Числовое значение</returns>
        private static double GetValue(string strVal)
        {
            if (!double.TryParse(strVal, out double doubleVal))
            {
                Console.WriteLine(" Введенное значение не числовое.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            return doubleVal;
        }

        /// <summary>
        /// Определить что во что конвертируем
        /// </summary>
        public static void GetAction()
        {
            Console.WriteLine(" Что Вы хотите преобразовать? \n" +
                              " 1 - Градусы Цельсиях в значение в Фаренгейты\n" +
                              " 2 - Градусы в Фаренгейтах в значение в Цельсиях\n");
            if (int.TryParse(Console.ReadLine(), out int action))
            {
                SetAction(action);
            }
            else
            {
                ErorrorOfOperstionProcessing();
            }
        }

        /// <summary>
        /// Конвертируем фарингейты в цельсии или наоборот в зависимости от
        /// значения признака конвертации action
        /// </summary>
        /// <param name="action">Признак конвертации</param>
        private static void SetAction(int action)
        {
            if (action == 1)
            {
                Console.Write("\n Введите числовое значение: ");
                CelsiusToFahrenheit(Console.ReadLine());
            }
            else if (action == 2)
            {
                Console.Write("\n Введите числовое значение: ");
                FahrenheitToCelsius(Console.ReadLine());
            }
            else
            {
                ErorrorOfOperstionProcessing();
            }
        }
        
        /// <summary>
        /// Обработка ошибки операции
        /// </summary>
        private static void ErorrorOfOperstionProcessing()
        {
            Console.WriteLine(" Вы что-то не то накняпали.\n");
            Console.ReadKey();
            GetAction();
        }

    }
}
