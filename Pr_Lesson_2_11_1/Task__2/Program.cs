using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Task__2
{
    class Program
    {
        static Random random = new Random(Guid.NewGuid().GetHashCode());
        static List<Chain> chains = new List<Chain>();

        static void Main(string[] args)
        {
            Chain chain = CreateChain();
            MoveChain(chain); 

            //Console.ReadKey();
        }

        /// <summary>
        /// Создать цепочку символов
        /// </summary>
        /// <returns></returns>
        public static Chain CreateChain()
        {
            int cainLength = random.Next(3, 7);
            int posX = random.Next(0, Console.WindowHeight);
            int posY = 0;
            string text = RandomString(cainLength);
            Chain chain = new Chain(posX, posY, cainLength, text);
            return chain;
        }
       
        /// <summary>
        /// Получаем случайный символ
        /// </summary>
        /// <returns>Случайный символ</returns>
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        /// <summary>
        /// Вывести цепочку символов на консоль
        /// </summary>
        /// <param name="chain">Цепочка символов</param>
        /// <param name="startY">Позиция начала цепочки по вертикали</param>
        /// <param name="lestY">Позиция конца цепочки по вертикали</param>
        public static void DrowChain(Chain chain, int startY)
        {
            int elPos = 0;

            for (int i = startY; i < chain.Length + startY; i++)
            {
                if (startY > 0)
                {
                    DelSimbol(chain, startY);
                }

                chain.PosY = i;
                chain.SetConsoleColor(elPos, chain.Length-1);
                Console.SetCursorPosition(chain.PosX, chain.PosY);
                Console.WriteLine((chain.ChainText).Substring(elPos, 1));
                elPos++;
            } 
        }

        /// <summary>
        /// Удалить отображаемый символ цепочки
        /// </summary>
        /// <param name="chain">Цепочка символов</param>
        /// <param name="startY">Номер символа, предшествующиц этому символу, удаляем</param>
        private static void DelSimbol(Chain chain, int startY)
        {
            Console.SetCursorPosition(chain.PosX, startY - 1);
            Console.WriteLine(" ");
        }

        /// <summary>
        /// Опускаем цепочку символов
        /// </summary>
        /// <param name="chain">Цепочка символов</param>
        public static void MoveChain(Chain chain)
        {
            int PosY = 0;

            // Цепочка не дошла до низа 
            while (PosY - chain.Length < Console.WindowHeight - 1)
            {
                chain = RemackeChain(chain, false);
                DrowChain(chain, PosY);
                PosY++;
                Console.ReadKey();
            }
            // Цепочка дошла до низа 
            //if (startY + chain.Length >= Console.WindowHeight)
            //{
            //    while (chain.Length > 0)
            //    {
            //        chain = RemackeChain(chain, true);
            //        DrowChain(chain, startY);
            //        startY++;
            //        Console.ReadKey();
            //    }
            //    if (chain.Length == 0)
            //    {
            //        DelSimbol(chain, startY);
            //        Console.ReadKey();
            //    }
            //}


        }

        /// <summary>
        ///  Переделать цепочку
        /// </summary>
        /// <param name="chain">Исходная цепочка</param>
        /// <returns>Результируюцая цепочка</returns>
        public static Chain RemackeChain(Chain chain, bool IsDown)
        {
            int cainLength = chain.Length;
            int posX = chain.PosX;
            int posY = chain.PosY;

            if (IsDown)            
            {
                cainLength = chain.Length-1;
                posX = chain.PosX;
                posY = chain.PosY;
                
            }

            string text = RandomString(cainLength);
            chain = new Chain(posX, posY, cainLength, text);
            return chain;
        }



    }
}
