
namespace TemperstureConverterLibrary
{
    /// <summary>
    /// Конвертор температуры
    /// </summary>
    interface ITemperatureConverter
    {
        /// <summary>
        /// Конвертировать температуру
        /// </summary>
        /// <param name="TemperatureValue">Конвертируемое значение температуры</param>
        /// <returns>Конвертированное значение температуры</returns>
        double Converter(double temperatureValue);
    }
}
