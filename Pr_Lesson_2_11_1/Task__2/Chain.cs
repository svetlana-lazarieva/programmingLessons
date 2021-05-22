using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task__2
{
    /// <summary>
    /// Цепочка символов
    /// </summary>
    public class Chain
    {
        /// <summary>
        /// Позиция по X
        /// </summary>
        public int PosX { get; set; }

        /// <summary>
        /// Позиция по Y
        /// </summary>
        public int PosY { get; set; }

        /// <summary>
        /// Длина цепочки
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// Набор смиврлов цепочки
        /// </summary>
        public string ChainText { get; set; }

        public Chain(int x, int y, int length, string text)
        {
            PosX = x;
            PosY = y;
            Length = length;
            ChainText = text;
        }

        /// <summary>
        /// Устанавливаем цвет элемента цепочки
        /// </summary>
        /// <param name="i">Порядковцй номер элемента</param>
        /// <param name="maxNum">Количество элементов в цепочке</param>
        public void SetConsoleColor(int i, int maxNum)
        {

            if (i == maxNum)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (i == maxNum - 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }


        }

       

       

      
    }
}
