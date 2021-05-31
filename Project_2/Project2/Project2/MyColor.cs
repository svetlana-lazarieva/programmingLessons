using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    [Serializable]
    public class MyColor
    {
        /// <summary>
        /// Красный
        /// </summary>
        public byte R { get; set; }
        /// <summary>
        /// Зеленый
        /// </summary>
        public byte G { get; set; }
        /// <summary>
        /// Синий
        /// </summary>
        public byte B { get; set; }
        /// <summary>
        /// Название цвета
        /// </summary>
        public string Name { get; set; }
    }
}
