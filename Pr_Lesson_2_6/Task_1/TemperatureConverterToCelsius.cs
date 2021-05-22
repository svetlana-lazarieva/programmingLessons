
using System;

namespace Task_1
{
    /// <summary>
    /// Kонвертировать градусы Фаренгейта в градусы Цельсия
    /// </summary>
    public class TemperatureConverterToCelsius : ITemperatureConverter
    {
        /// <summary>
        /// Kонвертировать градусы Фаренгейта в градусы Цельсия
        /// </summary>
        /// <param name="temperatureValue">Градусы Фаренгейта</param>
        /// <returns>Градусы Цельсия</returns>
        public double Converter(double temperatureValue)
        {
            try
            {
                double valCelsius = (temperatureValue - 32) / 1.8;
                return valCelsius;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }  
        }
    }
}
