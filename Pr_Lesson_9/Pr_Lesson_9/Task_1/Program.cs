using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.
/// Создайте программу, в которой создайте интерфейс Printable, содержащий 
/// метод void print().
/// 
/// Далее создайте класс Book, класс Journal (журнал), класс Magazine, 
/// реализующий интерфейс Printable.  
/// 
/// После создайте массив типа Printable, который будет 
/// содержать книги и журналы и в цикле пройти по массиву и вызвать метод print() 
/// для каждого объекта. 
/// 
/// Создать метод printMagazines(Printable[] printable) в 
/// классе Magazine, который выводит на консоль названия только журналов.  
/// Создать метод printBooks(Printable[] printable) в классе Book, который 
/// выводит на консоль названия только книг.
/// </summary>

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {          
            IPrintable[] printable = new IPrintable[] { 
                new Book("ABSALOM, ABSALOM! BY WILLIAM FAULKNER"), 
                new Book("A TIME TO KILL BY JOHN GRISHAM"), 
                new Magazine("Reader's Digest"),
                new Magazine("School Magazine"),
                new Journal("Acta Astronomica"),
                new Journal("Advances in Space Research"),
                new Magazine("Popular Science"),
                new Magazine("Southern Living"),
                new Journal("AIP Conference Proceedings"),
                new Journal("Astrobiology"),
                new Book("THE HOUSE OF MIRTH BY EDITH WHARTON"),
                new Book("EAST OF EDEN BY JOHN STEINBECK"),
            };

            for (int i = 0; i < printable.Length; i++)
            {
                printable[i].Print();
            }

            Magazine.PrintMagazines(printable);
            Book.PrintBook(printable);

            Console.ReadKey();
        }
    }
}
