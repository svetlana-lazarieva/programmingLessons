using System;
/// <summary>
/// Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable. 
/// Написать программу, которая выполняет проигрывание и запись.
/// </summary>

namespace Task_2
{
    public class Player: IPlayable, IRecodable
    {
        /// <summary>
        /// Играть
        /// </summary>
        public void Play()
        {
            Console.WriteLine(" \nУра!!! Я сиграю для тебя!");
            Console.WriteLine(" Playing: Ля-ля-ляяяяяяя!");
        }
        /// <summary>
        /// Пауза
        /// </summary>
        void IPlayable.Pause()
        {
            Console.WriteLine(" Pause(playing): ... ");
        }
        /// <summary>
        /// Останавливаться
        /// </summary>
        void IPlayable.Stop()
        {
            Console.WriteLine(" Stop playing: Ну, и ладно!");
        }

        /// <summary>
        /// Записывать
        /// </summary>
        public void Record()
        {
            Console.WriteLine(" \nХорошо. Это я могу.");
            Console.WriteLine(" Recording: Не могу сказать, что разделяю,\n" +
                              " твои музикальные предпочтения, но ладно.\n" +
                              " вжжж...жжж вжж...ж \n Все!");
        }
        /// <summary>
        /// Пауза
        /// </summary>
        void IRecodable.Pause()
        {
            Console.WriteLine(" Pause(recording): ... ");
        }
        /// <summary>
        /// Останавливаться
        /// </summary>
        void IRecodable.Stop()
        {
            Console.WriteLine(" Stop recording: Пока!");
        }

    }
}
