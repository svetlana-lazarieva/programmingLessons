using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Task_1;

namespace Task_2
{
    /// <summary>
    /// Используя Visual Studio, создайте проект по шаблону Console Application. 
    /// Создайте программу, в которой создайте класс, поддерживающий сериализацию.
    /// Выполните сериализацию объекта этого класса в формате XML.
    /// Сначала используйте формат по умолчанию, а затем измените его таким образом, 
    /// чтобы значения полей сохранились в виде атрибутов элементов XML.
    /// </summary>
    class Program
    {
        static Cat francisk = new Cat();
        static XmlSerializer serializer = new XmlSerializer(typeof(Cat));

        static void Main(string[] args)
        {
            francisk.Name = "Francisk";
            francisk.Color = "Red";
            francisk.EyeColor = "Green";

            SerializeXML();
            Console.ReadKey();
        }

        /// <summary>
        /// Сериализация в файл xml
        /// </summary>
        public static void SerializeXML()
        {
            Console.WriteLine("\nBefore serialization.");
            Console.WriteLine($"Name: {francisk.Name}\n" +
                              $"Color: {francisk.Color}\n" +
                              $"EyeColor: {francisk.EyeColor}");

            FileStream stream = new FileStream("XMLSerialization.xml",
                                               FileMode.Create,
                                               FileAccess.Write,
                                               FileShare.Read);
            serializer.Serialize(stream, francisk);
            stream.Close();

            Console.WriteLine($"\n{francisk.Name} is serialized.");
        }
    }
}
