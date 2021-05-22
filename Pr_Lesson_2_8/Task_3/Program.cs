using System;
using System.IO;
using System.Xml;

namespace Task_3
{
    /// <summary>
    /// Используя Visual Studio, создайте проект по шаблону Console Application.
    /// Создайте программу, которая будет использовать XML файл из примера 1 и 
    /// будет выводить на консоль только номера телефонов.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        { 
            string path = @"..//..//TelephoneBook.xml";
            XmlTextReader reader = new XmlTextReader(path);

            if (File.Exists(path))
            {
                ReadTelephoneNumber(reader);
            }
            else
            {
                Console.WriteLine($"Файл {path} не существует.");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Считать и вывести на консоль только номера телефонов
        /// </summary>
        /// <param name="reader">XmlTextReader reader</param>
        private static void ReadTelephoneNumber(XmlTextReader reader)
        {
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.Name.Equals("Contact"))
                    {
                        Console.WriteLine(reader.GetAttribute("TelephoneNumber"));
                    }
                }
            }
        }
    }
}
