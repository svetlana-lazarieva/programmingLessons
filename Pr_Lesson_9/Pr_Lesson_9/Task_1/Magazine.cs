using System;
/// <summary>
/// Создать метод printMagazines(Printable[] printable), 
/// который выводит на консоль названия только журналов.
/// </summary>

namespace Task_1
{
    public class Magazine: IPrintable
    {
        public string Name { get; set; }

        public Magazine(string name)
        {
            Name = name;
        }

        public void Print()
        {
            Console.WriteLine(Name);
        }

        /// <summary>
        /// Выводит на консоль названия только журналов
        /// </summary>
        /// <param name="printable">Массив</param>
        public static void PrintMagazines(IPrintable[] printable)
        {
            Console.WriteLine("\nAll Magazines");
            for (int i = 0; i < printable.Length; i++)
            {
                if (printable[i] is Magazine)
                {
                    printable[i].Print();
                }
            }
        }


    }
}
