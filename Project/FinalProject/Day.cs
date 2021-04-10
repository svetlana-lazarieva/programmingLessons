using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    /// <summary>
    /// День
    /// </summary>
    class Day
    {
        /// <summary>
        /// Дата
        /// </summary>
        public DateTime DayOfMonth { get; set; } 
        /// <summary>
        /// День недели
        /// </summary>
        public string DaysOfWeekName { get; set; }

       

        /// <summary>
        /// Определяет является ли день выходным по дате
        /// </summary>
        /// <param name="date">Дата</param>
        /// <returns>Выходной</returns>
        public bool Weekand(DateTime date)
        {
            bool weekand = false;
            int daysOfWeekId = (int)date.DayOfWeek;
            if (daysOfWeekId == 0 || daysOfWeekId == 6)
            {
                weekand = true;
            }
            return weekand;
        }

        /// <summary>
        /// Входит ли этот номер дня в данный месяц по дате
        /// </summary>
        /// <param name="date">Дата</param>
        /// <param name="lableText">Проверяемый день</param>
        /// <returns>Входит\Не входит</returns>
        public bool DayInMonth(DateTime date, string lableText)
        {
            bool dayInMonth = true;
            int numberOfDaysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
            int day = int.Parse(lableText.Substring(0, 2));

            if (day> numberOfDaysInMonth)
            {
                dayInMonth = false;
            }
            return dayInMonth;
        }

        /// <summary>
        /// Определить, прошел ли этот день по дате
        /// </summary>
        /// <param name="date">Дата</param>
        /// <returns>День прошел\Нет</returns>
        public bool LestDay(DateTime date)
        {
            bool lestDay = false;
            if (date< DateTime.Today)
            {
                lestDay = true;
            }
            return lestDay;
        }

        /// <summary>
        /// Расчитать загруженность
        /// </summary>
        /// <param name="date">Дата</param>
        /// <param name="workloadedDays">Количество загруженных дней в месяце</param>
        /// <param name="workloadedHourse">Колличество занятых рабочих часов</param>
        /// <param name="freeDays">Колличество свободных дней</param>
        /// <param name="freeHourse">Колличество свободных часод</param>
        public void CalculateWorkload(DateTime date, int workloadedDays,
                                      out int workloadedHourse, out int freeDays, out int freeHourse)
        {
            // Колличество дней в месяце всего
            int numberOfDaysInMonth = DateTime.DaysInMonth(date.Year, date.Month);

            // Колличество рабочих часов всего
            int allHourse = numberOfDaysInMonth * 8;
            // Колличество занятых рабочих часов
            workloadedHourse = workloadedDays * 8;

            // Колличество свободных дней
            freeDays = numberOfDaysInMonth - workloadedDays;
            // Колличество свободных часод
            freeHourse = freeDays - 8;
        }

        /// <summary>
        /// Расчитать загруженность
        /// </summary>
        /// <param name="date">Дата</param>
        /// <param name="workloadedDays">Количество загруженных дней в месяце</param>
        /// <param name="workloadedHourse">Колличество занятых рабочих часов</param>
        /// <param name="freeDays">Колличество свободных дней</param>
        /// <param name="freeHourse">Колличество свободных часод</param>
        public void CalculateWorkload(DateTime date, int workloadedDays, int workloadedHourse, 
                                      out int freeDays, out int freeHourse)
        {
            // Колличество дней в месяце всего
            int numberOfDaysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
            // Колличество рабочих часов всего
            int allHourse = numberOfDaysInMonth * 8;
            // Колличество свободных часод
            freeHourse = allHourse - workloadedHourse;
            // Колличество свободных дней
            freeDays = numberOfDaysInMonth - workloadedDays;
            
        }


    }
}
