using System;

namespace Task_1
{
    /// <summary>
    /// Kонвертировать градусы Цельсия в градусы Фаренгейта
    /// </summary>
    class TemperatureConverterToFyringate : ITemperatureConverter
    {
        /// <summary>
        /// Kонвертировать градусы Цельсия в градусы Фаренгейта
        /// </summary>
        /// <param name="temperatureValue">Градусы Цельсия</param>
        /// <returns>Градусы Фаренгейта</returns>
        public double Converter(double temperatureValue)
        {
            try
            {
                double valCelsius = temperatureValue * 1.8 + 32;
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
