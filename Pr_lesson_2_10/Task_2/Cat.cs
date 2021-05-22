using System;
using System.Xml.Serialization;

namespace Task_1
{
    [XmlRoot("Cat")]
    /// <summary>
    /// Кот
    /// </summary>
    public class Cat
    {
        [XmlAttribute]
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }
        [XmlAttribute]
        /// <summary>
        /// Цвет
        /// </summary>
        public string Color { get; set; }
        [XmlAttribute]
        /// <summary>
        /// Цвет глаз
        /// </summary>
        public string EyeColor { get; set; }

        /// <summary>
        /// Спать
        /// </summary>
        public void Sleep()
        {
            Console.WriteLine("I am sleeping now.");
        }
    }
}
