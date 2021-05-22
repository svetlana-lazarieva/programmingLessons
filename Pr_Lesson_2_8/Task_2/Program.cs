using System;
using System.IO;
using System.Xml;


namespace Task_2
{
    /// <summary>
    /// Используя Visual Studio, создайте проект по шаблону Console Application.
    /// Создайте программу, которая будет использовать XML файл из предыдущего 
    /// примера выводить всю информации о данном файле на консоль.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument document = new XmlDocument();
            string path = @"..//..//TelephoneBook.xml";

            if (File.Exists(path))
            {
                document.Load(path);
                Console.WriteLine(document.InnerText);
                Console.WriteLine(document.InnerXml);
            }
            else
            {
                Console.WriteLine($"Файл {path} не существует.");     
            }
            
            Console.ReadKey();
        }
    }
}
