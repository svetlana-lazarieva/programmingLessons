using System;

namespace Task_1
{
    [Serializable]
    /// <summary>
    /// Кот
    /// </summary>
    public class Cat
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Цвет
        /// </summary>
        public string Color { get; set; }
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
