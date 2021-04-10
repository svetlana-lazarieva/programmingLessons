using System;
/// <summary>
/// Создайте 3 метода void Record() / void Pause() / void Stop()
/// </summary>

namespace Task_2
{
    public interface IRecodable
    {
        /// <summary>
        /// Записывать
        /// </summary>
        void Record();
        /// <summary>
        /// Пауза
        /// </summary>
        void Pause();
        /// <summary>
        /// Останавливаться
        /// </summary>
        void Stop();

    }
}
