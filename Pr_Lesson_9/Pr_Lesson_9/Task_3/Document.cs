using System;
/// <summary>
/// Реализуйте конкретный класс, который наследуется 
/// от производного класса Document, в теле класса реализуйте все методы 
/// абстрактного класса. 
/// (Реализация может заключатся в простом выводе информации о том какая 
/// это часть документа.) 
/// </summary>
namespace Task_3
{
    public class Document : DocumentBase
    {
        public override void DocumentСontent()
        {
            Console.WriteLine("DocumentСontent");
        }

        public override void Footer()
        {
            Console.WriteLine("Footer");
            Console.ReadKey();
        }

        public override void Headline()
        {
            Console.WriteLine("Headline");
        }
    }
}
