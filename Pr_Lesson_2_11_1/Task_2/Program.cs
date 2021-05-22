using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Task_2
{
    /// <summary>
    /// Используя Visual Studio, создайте проект по шаблону Console Application. 
    /// Создайте программу, которая будет выводить на экран цепочки падающих символов.
    /// Длина каждой цепочки задается случайно.
    /// Первый символ цепочки – белый, 
    /// второй символ – светло-зеленый, 
    /// остальные символы темно-зеленые.
    /// Во время падения цепочки, на каждом шаге, все символы меняют свое значение.
    /// Дойдя до конца, цепочка исчезает и сверху формируется новая цепочка.
    /// Смотрите ниже снимок экрана, представленный как образец
    /// </summary>
    class Program
    {
        static Random random = new Random(Guid.NewGuid().GetHashCode());
        static List<ChainItem> chain = new List<ChainItem>();
        static bool isRunning = true;
        private static object _locker = new object();

        public class ChainItem
        {
            public int PosX { get; set; }
            public int PosY { get; set; }
            public string Chain { get; set; }

            public bool IsOutOfRange => PosY > Console.WindowHeight;

            public ChainItem(string chain, int x, int y)
            {
                PosX = x;
                PosY = y;
                Chain = chain;
            }

            public void DrawChain(int posX, int posY)
            {
                int pos = 0;
                PosX = posX;
                PosY = posY;
                UpdateChainLetters();

                for (int i = Chain.Length - 1; i > 0; i--)
                {
                    pos = PosY + i;
                    if (pos < 0 || pos > Console.WindowHeight - 1) break;
                    SetConsoleColor(i, Chain.Length - 1);
                    Console.SetCursorPosition(posX, pos);
                    Console.WriteLine(Chain[i]);
                }

                pos = CheckIfBottomReached(posX, pos);

                while (pos > PosY - 1 && (pos > 0 && PosY > 0))
                {
                    pos--;
                    Console.SetCursorPosition(posX, pos);
                    Console.WriteLine(" ");
                }
            }

            private int CheckIfBottomReached(int posX, int pos)
            {
                if (pos > Console.WindowHeight - 1)
                {
                    pos = PosY + 1;

                    int visibleLength = Console.WindowHeight - pos;
                    int dLength = visibleLength + 1;

                    for (int i = Console.WindowHeight - 1; i > Console.WindowHeight - 1 - visibleLength; i--)
                    {
                        dLength = (Chain.Length - 1 - dLength) < 1 ? --dLength : dLength;
                        SetConsoleColor(i - pos, dLength);
                        Console.SetCursorPosition(posX, i);
                        Console.WriteLine(Chain[i - pos]);
                    }
                }

                return pos;
            }

            /// <summary>
            /// Устанавливаем цвет элемента цепочки
            /// </summary>
            /// <param name="i">Порядковцй номер элемента</param>
            /// <param name="maxNum">Количество элементов в цепочке</param>
            private void SetConsoleColor(int i, int maxNum)
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

            protected void UpdateChainLetters()
            {
                Chain = RandomString(Chain.Length);
            }

        }

        static void Main(string[] args)
        {
            CreateСhain();
            Draw();
            Console.ReadKey();
        }

        /// <summary>
        /// Строим цепочку
        /// </summary>
        public static void CreateСhain()
        {
            int stringCount = 16;// Console.WindowWidth;
            int offset = 1;
            for (int i = 1; i <= stringCount; i++)
            {
                int lengthOfChain = random.Next(7, 10);
                chain.Add(new ChainItem(RandomString(lengthOfChain), offset, -lengthOfChain));
                offset += 7;
            }
        }

        private static void Draw()
        {
            for (int i = 0; i < chain.Count; i++)
            {
                CreateChainThread(i);
            }
        }

        private static void CreateChainThread(int i)
        {
            var t = new Thread(()=>
            {
                var currentChain = chain[i];
                while (isRunning)
                {
                    lock (_locker)
                    {
                        if (currentChain.PosY <= Console.WindowHeight - 1)
                        {
                            currentChain.DrawChain(currentChain.PosX, currentChain.PosY + 1);
                        }
                        else
                        {
                            currentChain.PosY = -currentChain.Chain.Length - 1;
                        }
                    }

                    //Thread.Sleep(100);
                }
            });

            t.Priority = ThreadPriority.Highest;
            Task.Delay(random.Next(0, 2000)).ContinueWith(task =>
            {
                t.Start();
            });

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
}
}
