
using System;

namespace Task_4
{
    /// <summary>
    /// Клиентах фитнес-центра
    /// </summary>
    public class FitnessCenterClients
    {
        /// <summary>
        /// Код клиента
        /// </summary>
        public string ClientCode { get; set; }
        /// <summary>
        /// Год
        /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// Номер месяца
        /// </summary>
        public int MonthNumber { get; set; }
        /// <summary>
        /// Продолжительность занятий (в часах)
        /// </summary>
        public int DurationOfClasses { get; set; }
    }
}
