using System;
using System.IO;
using System.Text;

namespace Task_2
{
    /// <summary>
    /// Используя Visual Studio, создайте проект по шаблону Console Application.
    /// Создайте программу, в которой создайте файл, запишите в него произвольные 
    /// данные и закройте файл.Затем снова откройте этот файл, прочитайте из него 
    /// данные и выведете их на консоль.
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            string FileName = @"MyFile.txt";
            try
            {
                CreateToWrite(FileName);
                OpenToRtead(FileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Чтение
        /// </summary>
        /// <param name="FileName">Файл</param>
        private static void OpenToRtead(string FileName)
        {
            using (StreamReader sr = File.OpenText(FileName))
            {
                string s =string.Empty;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
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
    }
}
