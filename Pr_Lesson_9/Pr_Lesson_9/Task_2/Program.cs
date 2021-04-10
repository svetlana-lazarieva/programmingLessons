using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.
/// Создайте программу, в которой создайте два интерфейса IPlayable и IRecodable. 
/// В каждом из интерфейсов создайте по 3 метода void Play() / void Pause() / void Stop() 
/// и void Record() / void Pause() / void Stop() соответственно. 
/// Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable. 
/// Написать программу, которая выполняет проигрывание и запись.
/// </summary>

namespace Task_2
{
    class Program
    {
        static Player player = new Player();

        static void Main(string[] args)
        {
            Console.WriteLine(" Привет! Я - плеер.");
            QustionLoop();
            Console.ReadKey();
        }

        public static void QustionLoop()
        {
            int decision;
            do
            {
                Console.WriteLine(" Что тебе нужно? \n\n" +
                                  " 1 - Я хочу послушать музыку. \n" +
                                  " 2 - Я хочу записать песню. \n" +
                                  " Другая кнопка - Ой, я не хочу трогать говорящий плеер!");

                if (int.TryParse(Console.ReadLine(), out decision))
                {
                    if (decision == 1)
                    {
                        Playing();
                    }
                    else if (decision == 2)
                    {
                        Recording();
                    }
                    else
                    {
                        Console.WriteLine("Ну и не трогай.");
                    }
                }
                else
                {
                    Console.WriteLine("Ну и не трогай.");
                }
            } 
            while (decision == 1 || decision == 2);
            
        }

        /// <summary>
        /// Определить что делать,пока играет музыка
        /// </summary>
        /// <param name="action">Действие</param>
        public static void SpeakAndPlay(out int action)
        {
            Console.WriteLine("\nЗдорово! Правда? \nЯ могу сиграть, остановится на паузу " +
                              "или выключится, если тебе надоело.\n\n" +
                              " 1 - Сиграй!\n" +
                              " 2 - Давай немного отдохнем.\n" +
                              " Другая кнопка - Все, хватит!");
            action = GetAction();
        }

        /// <summary>
        /// Выбрать действие
        /// </summary>
        /// <returns>Действие</returns>
        private static int GetAction()
        {
            int action;
            if (!int.TryParse(Console.ReadLine(), out int decision))
            {
                action = 3;
            }
            else
            {
                if (decision == 1)
                {
                    action = 1;
                }
                else if(decision == 2)
                {
                    action = 2;
                }
                else
                {
                    action = 3;
                }
            }

            return action;
        }

        /// <summary>
        /// Выполняет проигрывание
        /// </summary>
        public static void Playing()
        {
            int action = 0;

            do
            {
                IPlayable playerPlaying = player;
                SpeakAndPlay(out action);
                SetPlayingActions(playerPlaying, action);
            }
            while (action != 3);
        }

        /// <summary>
        /// Установить действия плеера в режиме проигрывания музики
        /// </summary>
        /// <param name="playerPlaying">Режим проигрывания музики</param>
        /// <param name="action"> Действие</param>
        private static void SetPlayingActions(IPlayable playerPlaying, int action)
        {
            switch (action)
            {
                case 1:
                    {
                        playerPlaying.Play();                       
                        break;
                    }
                case 2:
                    {
                        playerPlaying.Pause();
                        break;
                    }
                default:
                    {
                        playerPlaying.Stop();
                        break;
                    }
            }
        }

        /// <summary>
        /// Определить что делать, пока записывается песня
        /// </summary>
        /// <param name="action">Действие</param>
        public static void SpeakAndRecord(out int action)
        {
            Console.WriteLine("\nЗдорово! Правда? \nЯ могу записать песню, " +
                              "остановится на паузу или выключится, если тебе надоело.\n\n" +
                              " 1 - Давай!\n" +
                              " 2 - Давай немного отдохнем.\n" +
                              " Другая кнопка - Спасибо. Больше не надо.");
            action = GetAction();
        }
        /// <summary>
        /// Выполняет запись
        /// </summary>
        public static void Recording()
        {
            int action;
            do
            {
                IRecodable playerRecording = player;
                SpeakAndRecord(out action);
                SetRecordingActions(playerRecording, action);
            } 
            while (action != 3);
            
        }

        /// <summary>
        /// Установить действия плеера в режиме записи песен
        /// </summary>
        /// <param name="playerRecording"> Режим записи песен </param>
        /// <param name="action"> Действие </param>
        private static void SetRecordingActions(IRecodable playerRecording, int action)
        {
            switch (action)
            {
                case 1:
                    {
                        playerRecording.Record();
                        break;
                    }
                case 2:
                    {
                        playerRecording.Pause();
                        break;
                    }
                default:
                    {
                        playerRecording.Stop();
                        break;
                    }
            }
        }
    }
}
