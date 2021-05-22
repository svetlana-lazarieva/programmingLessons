using System;
using System.IO;

namespace Task_1
{
    /// <summary>
    /// Используя Visual Studio, создайте проект по шаблону Console Application.
    /// Создайте программу, в которой создайте на диске 50 директорий с именами 
    /// от Folder_0 до Folder_50, после чего вывести информацию на консоль о каждой 
    /// из директорий, затем удалите их.
    /// </summary>
    class Program
    {
        
        static void Main(string[] args)
        {
            for (int i = 0; i <= 50; i++)
            {
                string DirName = $@"Folder_{i}";
                DirectoryInfo dir = new DirectoryInfo(DirName);
                Directory.CreateDirectory(DirName);
                ShowDirInfo(dir);
                Directory.Delete(DirName, true);
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Показать информацию о директории
        /// </summary>
        /// <param name="dir">Директория</param>
        public static void ShowDirInfo(DirectoryInfo dir)
        {
            if (dir.Exists)
            {
                Console.WriteLine($"FullName      : {dir.FullName}");
                Console.WriteLine($"Name          : {dir.Name}");
                Console.WriteLine($"Parent        : {dir.Parent}");
                Console.WriteLine($"CreationTime  : {dir.CreationTime}");
                Console.WriteLine($"Attributes    : {dir.Attributes}");
                Console.WriteLine($"Root          : {dir.Root}");
                Console.WriteLine($"LastAccessTime: {dir.LastAccessTime}");
                Console.WriteLine($"LastWriteTime : {dir.LastWriteTime}\n");
            }
        }
    }
}
