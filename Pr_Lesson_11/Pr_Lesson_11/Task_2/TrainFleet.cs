using System;
using System.Linq;
/// <summary>
/// Создайте программу, в которой создайте структуру именем Train (Поезд) ), 
/// структура должна содержать следующие поля: название пункта назначения, 
/// номер поезда, время отправления. 
/// В программе необходимо реализовать следующую логику: 
/// Пользователь должен с клавиатуры вводить данные с клавиатуры в массив, 
/// который содержит упорядоченные номера поездов, количество поездов сделать 
/// равным 5 шт.  
/// После чего пользователь должен иметь возможность вывести информацию о поезде 
/// по номеру поезда.
/// </summary>
namespace Task_2
{
    /// <summary>
    /// Поезд
    /// </summary>
    struct Train
    {
        /// <summary>
        /// Название пункта назначения
        /// </summary>
        public string DestinationName { get; set; }
        /// <summary>
        /// Номер поезда
        /// </summary>
        public string TrainNumber { get; set; }
        /// <summary>
        /// Время отправления
        /// </summary>
        public string DepartureTime { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"{DestinationName} {TrainNumber} {DepartureTime}");
        }

    }

    /// <summary>
    /// Парк поездов
    /// </summary>
    public class TrainFleet
    {
        Train[] trains = new Train[5];
        private const string DestinationNameInfoType = "название пункта назначения";
        private const string TrainNumberInfoType = "номер поезда";
        private const string DepartureTimeInfoType = "время отправления";

        public void ProcessingTrainFleet()
        {
            FillArray();
            ShowArray();
            GetTrainInfo();
        }

        /// <summary>
        /// Показать массив
        /// </summary>
        private void ShowArray()
        {
            foreach (var item in trains)
            {
                Console.WriteLine($"{item.DestinationName} {item.TrainNumber} {item.DepartureTime}");
            }
            Console.ReadKey();
        }
       
        /// <summary>
        /// Заполнить массив
        /// </summary>
        private void FillArray()
        {
            for (int i = 0; i < trains.Length; i++)
            {
                trains[i].DestinationName = GetVal(DestinationNameInfoType);
                trains[i].TrainNumber = GetVal(TrainNumberInfoType);
                trains[i].DepartureTime = GetVal(DepartureTimeInfoType);
            }
        }

        /// <summary>
        /// Считать значение с консоли
        /// </summary>
        /// <param name="infoType">Желаемый тип значения</param>
        /// <returns>Значение считанное с консоли</returns>
        private string GetVal(string infoType) 
        {
            Console.Write($"Введите {infoType}: ");
            return Console.ReadLine();
        }


        /// <summary>
        /// Получить информацию о поезде по его номеру
        /// </summary>
        private void GetTrainInfo()
        {
            string trNum = GetVal(TrainNumberInfoType);
            var trainInfo = trains.FirstOrDefault(x => x.TrainNumber == trNum);
            trainInfo.ShowInfo();
            Console.ReadKey();
        }


    }
}
