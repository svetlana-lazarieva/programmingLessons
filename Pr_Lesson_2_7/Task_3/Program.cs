using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    /// <summary>
    /// Используя Visual Studio, создайте проект по шаблону Console Application.
    /// Напишите приложение для поиска заданного файла на диске. Добавьте код, 
    /// использующий класс FileStream и позволяющий просматривать файл в текстовом 
    /// окне. В заключение добавьте возможность сжатия найденного файла.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string FileName = @"MyFile.txt";
            string ArhName = @"MyArh.zip";

            if (!File.Exists(FileName))
            {
                CreateToWrite(FileName);
            }
            
            string path = Path.GetFullPath(FileName);
            OpenToRtead(path);
            Compress(path, ArhName);
            Console.ReadKey();
        }

        /// <summary>
        /// Архивация
        /// </summary>
        /// <param name="sourceFile">Архивируемый файл</param>
        /// <param name="compressedFile">Архив</param>
        public static void Compress(string sourceFile, string compressedFile)
        {
            using (FileStream sourceStream = new FileStream(sourceFile, FileMode.OpenOrCreate))
            {
                using (FileStream targetStream = File.Create(compressedFile))
                {
                    using (GZipStream compressionStream = new GZipStream(targetStream, CompressionMode.Compress))
                    {
                        sourceStream.CopyTo(compressionStream); 
                        Console.WriteLine($"Архивация файла {sourceFile} завершена");
                    }
                }
            }
        }

        /// <summary>
        /// Запись
        /// </summary>
        /// <param name="FileName">Файл</param>
        private static void CreateToWrite(string FileName)
        {
            using (FileStream fs = File.Create(FileName))
            {
                byte[] info = new UTF8Encoding(true).GetBytes("Info");
                fs.Write(info, 0, info.Length);
            }
        }

        /// <summary>
        /// Чтение
        /// </summary>
        /// <param name="FileName">Файл</param>
        private static void OpenToRtead(string FileName)
        {
            using (FileStream fstream = File.OpenRead(FileName))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                string textFromFile = Encoding.Default.GetString(array);
                Console.WriteLine($"Текст из файла:\n {textFromFile}");
            }
        }

    }
}
