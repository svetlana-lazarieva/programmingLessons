using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application 
/// Создайте программу в которой создайте последовательность, которая содержит 
/// сведения о клиентах фитнес-центра. Каждый элемент последовательности включает 
/// следующие целочисленные поля: 
/// «Код клиента», «Год», «Номер месяца», «Продолжительность занятий (в часах)». 
/// Найти элемент последовательности с минимальной продолжительностью занятий. 
/// Вывести эту продолжительность, а также соответствующие ей год и номер месяца 
/// (в указанном порядке на той же строке). Если имеется несколько элементов с 
/// минимальной продолжительностью, то вывести данные того из них, который 
/// является последним в исходной последовательности.
/// </summary>

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Список клиентов
            List<FitnessCenterClients> clients = FillClients();
            int idOfLastMinVal = clients.FindLastIndex(x => x.DurationOfClasses == 
                                 clients.Min(y => y.DurationOfClasses));
            var result = clients[idOfLastMinVal];

            Console.WriteLine($"\nКод клиента: {result.ClientCode}\nГод: {result.Year}" +
                              $"\nНомер месяца: {result.MonthNumber}" +
                              $"\nПродолжительность занятий(в часах):{result.DurationOfClasses}");
            Console.ReadKey();
        }

        /// <summary>
        /// Заполнить список клиентов
        /// </summary>
        /// <returns> Список клиентов</returns>
        public static List<FitnessCenterClients> FillClients()
        {
            return new List<FitnessCenterClients>
            {
                new FitnessCenterClients
                {
                    ClientCode = "12345",
                    Year = 2000,
                    MonthNumber = 10,
                    DurationOfClasses = 90
                },
                new FitnessCenterClients
                {
                    ClientCode = "23456",
                    Year = 2008,
                    MonthNumber = 1,
                    DurationOfClasses = 789
                },
                new FitnessCenterClients
                {
                    ClientCode = "34567",
                    Year = 2015,
                    MonthNumber = 12,
                    DurationOfClasses = 90
                },
                new FitnessCenterClients
                {
                    ClientCode = "45678",
                    Year = 2020,
                    MonthNumber = 4,
                    DurationOfClasses = 907
                }
            };
        }
    }
}
