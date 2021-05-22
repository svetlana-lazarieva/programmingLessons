using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Task_1;

namespace Task_3
{
    /// <summary>
    /// Используя Visual Studio, создайте проект по шаблону Console Application. 
    /// Создайте программу, в которой выполните десериализацию объекта из предыдущего
    /// примера.Отобразите состояние объекта на экране
    /// </summary>
    
    class Program
    {
        static Cat francisk = new Cat();
        static XmlSerializer serializer = new XmlSerializer(typeof(Cat));
        static void Main(string[] args)
        {
            DeserializeXML();
            Console.ReadKey();
        }

        /// <summary>
        /// Десериализация из файла xml
        /// </summary>
        public static void DeserializeXML()
        {
            string fName = "XMLSerialization.xml";
            try
            {
                if (File.Exists(fName))
                {
                    FileStream stream = new FileStream(fName,
                                                       FileMode.Open,
                                                       FileAccess.Read,
                                                       FileShare.Read);
                    francisk = serializer.Deserialize(stream) as Cat;
                    stream.Close();
                    Console.WriteLine($"\n{francisk.Name} is deserialized.");
                }
                Console.WriteLine("\nAfter deserialization.");
                Console.WriteLine($"Name: {francisk.Name}\nColor: {francisk.Color}\nEyeColor: {francisk.EyeColor}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
