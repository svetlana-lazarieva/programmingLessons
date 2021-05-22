using System;
using System.Reflection;

/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.
/// Создайте программу, в которой предоставьте пользователю доступ к сборке из Задания 1. 
/// Реализуйте использование метода конвертации значения температуры из шкалы Цельсия в 
/// шкалу Фаренгейта. Выполняя задание используйте только рефлексию.
/// </summary>
namespace Task_2
{
    class Program
    {
        public const string MessCelsius = "Цельсия";
        public const string MessFyringate = "Фарингейта";

        static void Main(string[] args)
        {
            ConvertToCelsius();
            ConvertToFyringate();
            Console.ReadKey();
        }

        /// <summary>
        /// Kонвертировать градусы Фаренгейта в градусы Цельсия
        /// </summary>
        private static void ConvertToCelsius()
        {
            Type converterToCelsiusType = typeof(TemperstureConverterLibrary.TemperatureConverterToCelsius);
            Object objconverterToCelsius = Activator.CreateInstance(converterToCelsiusType);
            MethodInfo ConverterMethodInfo = converterToCelsiusType.GetMethod("Converter",
                                                                              BindingFlags.Instance |
                                                                              BindingFlags.Public);
            GetValue(MessCelsius, out double tempValCelsius);
            double tempVal = (double)ConverterMethodInfo.Invoke(objconverterToCelsius, new object[] { tempValCelsius });
            Console.WriteLine($"Конвертируемое значение (в градусах {MessCelsius}): {tempValCelsius}\n" +
                              $"Конвертированное значение (в градусах {MessFyringate}): {tempVal}\n");
        }

        /// <summary>
        /// Kонвертировать градусы Цельсия в градусы Фаренгейта
        /// </summary>
        private static void ConvertToFyringate()
        {
            Type converterToFyringateType = typeof(TemperstureConverterLibrary.TemperatureConverterToFyringate);
            Object objconverterToFyringate = Activator.CreateInstance(converterToFyringateType);
            MethodInfo ConverterMethodInfo = converterToFyringateType.GetMethod("Converter",
                                                                              BindingFlags.Instance |
                                                                              BindingFlags.Public);
            GetValue(MessFyringate, out double tempValFyringate);
            double tempVal = (double)ConverterMethodInfo.Invoke(objconverterToFyringate, new object[] { tempValFyringate });
            Console.WriteLine($"Конвертируемое значение (в градусах {MessFyringate}): {tempValFyringate}\n" +
                              $"Конвертированное значение (в градусах {MessCelsius}): {tempVal}\n");
        }

        /// <summary>
        /// Считать с консоли конвертируемое значение температуры
        /// </summary>
        /// <param name="mess">Цельий или Фарингейт</param>
        /// <param name="tempVal">Конвертируемое значение температуры</param>
        public static void GetValue(string mess, out double tempVal)
        {
            Console.WriteLine($"Введите значение градусов {mess}");
            if(!double.TryParse(Console.ReadLine(),out tempVal))
            {
                Console.WriteLine("Введенное значение не корректно.");
                GetValue(mess, out tempVal);
            }
        }
    }
}
