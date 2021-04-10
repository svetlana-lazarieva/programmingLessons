using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    public class MonthData
    {
        public int Month { get; set; }
        public List<ComponentDataPerDay> ComponentData { get; set; }

        public MonthData()
        {
            Month = 1;
            ComponentData = new List<ComponentDataPerDay>();
        }
    }
}
