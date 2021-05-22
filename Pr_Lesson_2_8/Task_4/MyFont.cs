using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task_4
{
    [Serializable]
    public class MyFont
    {
        /// <summary>
        /// Название шрифта
        /// </summary>
        public string Name{ get; set; }
        /// <summary>
        /// Размер шрифта
        /// </summary>
        public float EmSize { get; set; }
        /// <summary>
        /// Стиль шрифта
        /// </summary>
        public FontStyle Style { get; set; }
    }
}
