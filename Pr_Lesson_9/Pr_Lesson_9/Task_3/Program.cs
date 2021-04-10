using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.
/// Создайте базовый абстрактный класс Document (документ), в котором создайте 
/// три метода void Headline (Заголовок), DocumentСontent(Содержимое документ), 
/// Footer(подвал документа).Реализуйте конкретный класс, который наследуется 
/// от производного класса Document, в теле класса реализуйте все методы 
/// абстрактного класса. 
/// (Реализация может заключатся в простом выводе информации о том какая 
/// это часть документа.) 
/// </summary>

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentBase document = new Document();
            document.Headline();
            document.DocumentСontent();           
            document.Footer();
        }
    }
}
