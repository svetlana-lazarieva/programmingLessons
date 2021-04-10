using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
   public class Year
    {
        public MonthData[] monthDatas = new MonthData[12];
        public Year()
        {
            for (int i = 0; i < 12; i++)
            {
                monthDatas[i] = new MonthData();
                monthDatas[i].Month = i+1;
            }
        }

        public MonthData GetMonthData(int month)
        {
            return monthDatas[month-1];
        }

    }
}
