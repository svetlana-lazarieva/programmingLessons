using System;

/// <summary>
/// Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
/// Напишите программу русско-английский переводчик. Программа знает 10 слов 
/// о погоде. Требуется, чтобы пользователь вводил слово на русском языке, 
/// а программа давала ему перевод этого слова на английском языке. Если 
/// пользователь ввел слово, для которого отсутствует перевод, то следует 
/// вывести сообщение, что такого слова нет. 
/// </summary>
namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // weather погода, rain дождь, snow снег, sun солнце, wind ветер
            // fog туман, snowstorm метель, windstorm буря, rainbow радуга, thaw оттепель

            const string Dictionary = "погода weather," +
                                      "дождь rain," +
                                      "снег snow," +
                                      "солнце sun," +
                                      "ветер wind," +
                                      "туман fog," +
                                      "метель snowstorm," +
                                      "буря windstorm," +
                                      "радуга rainbow," +
                                      "оттепель thaw";
            
            Console.Write("Напишите слово на русском языке о погоде: ");
            string word = Console.ReadLine();
            if (Dictionary.Contains(word))
            {
                // Начало английского слова
                int sartPosition = Dictionary.IndexOf(word) + word.Length + 1;
                // Конец английского слова
                int endPosition = Dictionary.IndexOf(",", sartPosition);
                // Получаем английское слово
                string translstion = Dictionary.Substring(sartPosition, endPosition - sartPosition);
                Console.WriteLine($"Перевод: {translstion}");
            }
            else 
            {
                Console.WriteLine("Я не знаю это слово.");
            }
            Console.ReadKey();
        }
    }
}
