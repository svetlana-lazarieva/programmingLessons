using System;

/// <summary>
/// Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
/// Создайте программу, в которой создайте метод, который в качестве параметра 
/// принимает слово, а возвращает тоже слово, но с измененным порядком букв в 
/// слове на обратный.
/// </summary>
namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите слово: ");
            ReverseWordToArray(Console.ReadLine());
            Console.ReadKey();
        }

      /// <summary>
      /// Получить слово наоборот из слова
      /// </summary>
      /// <param name="word">Слово</param>
        public static void ReverseWordToArray(string word)
        {
            int wordLength = word.Length;           
            string str = string.Empty;
            int i = wordLength - 1;

            while (i >= 0)
            {    
                str = word[wordLength - (i + 1)] + str;
                i--;
            }
            Console.WriteLine($"Слово наоборот: {str}");           
        }  
    }
}
