using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;


namespace Task_1
{
    /// <summary>
    /// Используя Visual Studio, создайте проект по шаблону Console Application. 
    /// Создайте программу, в которой, создайте пользовательский тип(например, класс) 
    /// и выполните сериализацию объекта этого типа, всеми известными вас способами.
    /// </summary>
    class Program
    {
        static Cat francisk = new Cat();
        static XmlSerializer serializer = new XmlSerializer(typeof(Cat));
        static BinaryFormatter formatter = new BinaryFormatter();
        static SoapFormatter Soapformatter = new SoapFormatter();
        static void Main(string[] args)
        {
            francisk.Name = "Francisk";
            francisk.Color = "Red";
            francisk.EyeColor = "Green";

            SerializeXML();
            DeserializeXML();

            SerializeBinary();
            DeserializeBinary();

            SerializeSoap();
            DeserializeSoap();

            Console.ReadKey();
        }

        /// <summary>
        /// Сериализация в файл xml
        /// </summary>
        public static void SerializeXML()
        {
            Console.WriteLine("\nBefore serialization.");
            Console.WriteLine($"Name: {francisk.Name}\nColor: {francisk.Color}\nEyeColor: {francisk.EyeColor}");

            FileStream stream = new FileStream("XMLSerialization.xml",
                                               FileMode.Create, 
                                               FileAccess.Write, 
                                               FileShare.Read);
            serializer.Serialize(stream, francisk);            
            stream.Close();

            Console.WriteLine($"\n{francisk.Name} is serialized.");
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

        /// <summary>
        /// Бинарная сериализация
        /// </summary>
        public static void SerializeBinary()
        {
            Console.WriteLine("\nBefore serialization.");
            Console.WriteLine($"Name: {francisk.Name}\nColor: {francisk.Color}\nEyeColor: {francisk.EyeColor}");

            FileStream stream = File.Create("BinarySerialization.dat");
            formatter.Serialize(stream, francisk);           
            stream.Close();

            Console.WriteLine($"\n{francisk.Name} is serialized.");
        }

        /// <summary>
        /// Бинарная десериализация
        /// </summary>
        public static void DeserializeBinary()
        {
            string fName = "BinarySerialization.dat";
            if (File.Exists(fName))
            {
                FileStream stream = File.OpenRead(fName);
                francisk = formatter.Deserialize(stream) as Cat;
                stream.Close();
                Console.WriteLine($"\n{francisk.Name} is deserialized.");
            }

            Console.WriteLine("\nAfter deserialization.");
            Console.WriteLine($"Name: {francisk.Name}\nColor: {francisk.Color}\nEyeColor: {francisk.EyeColor}");
        }

        /// <summary>
        /// Soap сериализация
        /// </summary>
        public static void SerializeSoap()
        {
            Console.WriteLine("\nBefore serialization.");
            Console.WriteLine($"Name: {francisk.Name}\nColor: {francisk.Color}\nEyeColor: {francisk.EyeColor}");

            string fName = "SoapSerialization.xml";
            FileStream stream = File.Create(fName);
            formatter.Serialize(stream, francisk);
            stream.Close();

            Console.WriteLine($"\n{francisk.Name} is serialized.");
        }

        /// <summary>
        /// Soap десериализация
        /// </summary>
        public static void DeserializeSoap()
        {
            string fName = "SoapSerialization.xml";
            if (File.Exists(fName))
            {
                FileStream stream = File.OpenRead(fName);
                francisk = formatter.Deserialize(stream) as Cat;
                stream.Close();
                Console.WriteLine($"\n{francisk.Name} is deserialized.");
            }
            
            Console.WriteLine("\nAfter deserialization.");
            Console.WriteLine($"Name: {francisk.Name}\nColor: {francisk.Color}\nEyeColor: {francisk.EyeColor}");
        }

    }
}
