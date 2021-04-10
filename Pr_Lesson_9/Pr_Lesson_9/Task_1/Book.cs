using System;
/// <summary>
/// Создать метод printBooks(Printable[] printable) в классе Book, который 
/// выводит на консоль названия только книг.
/// </summary>

namespace Task_1
{
    public class Book : IPrintable
    {
        public string Name { get; set; }

        public Book(string name)
        {
            Name = name;
        }
        public void Print()
        {
            Console.WriteLine(Name);
        }

        /// <summary>
        /// Выводит на консоль названия только книг
        /// </summary>
        /// <param name="printable">Массив</param>
        public static void PrintBook(IPrintable[] printable)
        {
            Console.WriteLine("\nAll Books");
            for (int i = 0; i < printable.Length; i++)
            {
                if (printable[i] is Book)
                {
                    printable[i].Print();
                }
            }
        }
    }
}
