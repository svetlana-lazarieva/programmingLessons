using System.Xml;

namespace Task_1
{
    /// <summary>
    /// Используя Visual Studio, создайте проект по шаблону Console Application.
    /// Создайте программу в которой создайте XML файл, который соответствовал бы следующим требованиям:
    /// 1. имя файла: TelephoneBook.xml
    /// 2.  корневой элемент: “MyContacts”
    /// 3. тег “Contact”, и в нем должно быть записано имя контакта и атрибут “TelephoneNumber”
    /// со значением номера телефона.
    /// (* использовать программное создание XML файла)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            XmlTextWriter xmlWriter = new XmlTextWriter("..//..//TelephoneBook.xml", null);

            xmlWriter.Formatting = Formatting.Indented;
            xmlWriter.Indentation = 1;

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("MyContacts");

            xmlWriter.WriteStartElement("Contact");
            // Имя контакта
            xmlWriter.WriteStartAttribute("ContactName");
            xmlWriter.WriteString("Someone");
            // Номер телефона контакта
            xmlWriter.WriteStartAttribute("TelephoneNumber");
            xmlWriter.WriteString("111-11-11");

            xmlWriter.WriteEndAttribute();
            xmlWriter.WriteEndElement();

            xmlWriter.Close();
            
        }
    }
}
