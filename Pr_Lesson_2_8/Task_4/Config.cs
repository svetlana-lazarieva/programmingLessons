using System;
using System.Drawing;

namespace Task_4
{
    [Serializable]
    public class Config
    {
        /// <summary>
        /// Цвет фона
        /// </summary>
        public MyColor BackColor { get; set; }
        /// <summary>
        /// Цыет текста
        /// </summary>
        public MyColor FontColor { get; set; }
        /// <summary>
        /// Шрифт текста
        /// </summary>
        public MyFont MyFont { get; set; }

        public Config()
        {
            BackColor = new MyColor();
            FontColor = new MyColor();
            MyFont = new MyFont();
        }
    }
}
