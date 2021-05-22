using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application 
/// Создайте программу, в которой, используя динамические и анонимные типы данных, 
/// создайте Англо-Русский словарь на 10 слов и выведите на экран его содержание. 
/// </summary>
namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic vocabulary = new[]
            {
                new { ruWord = "малина",   enWord = "raspberry"},
                new { ruWord = "яблоко",   enWord = "apple"},
                new { ruWord = "груша",    enWord = "pear"},
                new { ruWord = "слива",    enWord = "plum"},
                new { ruWord = "апельсин", enWord = "orange"},
                new { ruWord = "аннанас",  enWord = "pineapple"},
                new { ruWord = "клубника", enWord = "strawberry"},
                new { ruWord = "вишня",    enWord = "cherry"},
                new { ruWord = "черешня",  enWord = "sweet cherry"},
                new { ruWord = "ежевика",  enWord = "blackberry"}
            };

            foreach (var item in vocabulary)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();



        }
    }
}
