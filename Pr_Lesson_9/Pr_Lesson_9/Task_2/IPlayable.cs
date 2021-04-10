using System;
/// <summary>
/// Cоздайте 3 метода void Play() / void Pause() / void Stop()
/// </summary>

namespace Task_2
{
    public interface IPlayable
    {
        /// <summary>
        /// Играть
        /// </summary>
        void Play();
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
