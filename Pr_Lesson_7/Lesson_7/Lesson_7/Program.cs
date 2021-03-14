using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.
/// Создайте программу в которой создайте класс «Адрес». В теле класса создайте 
/// следующие поля: страна, город, улица, дом, квартира, индекс.
/// Для каждого поля, создать свойство с двумя методами доступа. 
/// Также в классе необходимо создать метод для отображения информации про адрес. 
/// В методе Main() создайте экземпляр класса «Адрес», присвойте всем полям значение 
/// через свойства доступа, а также на экземпляр класса вызовите метод, который 
/// выводит информацию про адрес.
/// </summary>

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Country = "someCountry";
            address.City = "someCity";
            address.Street = "someStreet";
            address.House = "someHouse";
            address.Apartment = 1;
            address.ZipCode = "someZipCode";
            address.ShowAddress();
            Console.ReadKey();
        }
    }
}
