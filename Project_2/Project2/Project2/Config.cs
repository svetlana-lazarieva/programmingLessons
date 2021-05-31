using System;
using System.Collections.Generic;
using System.Drawing;

namespace Project2
{
    public class SingleUserConfig
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

        public SingleUserConfig()
        {
            BackColor = new MyColor();
            FontColor = new MyColor();
            MyFont = new MyFont();
        }
    }
    [Serializable]
    public static class Config
    {
        public static Dictionary<int, SingleUserConfig> UserSettings { get; set; }

        static Config()
        {
            UserSettings = new Dictionary<int, SingleUserConfig>();
        }
    }
}
