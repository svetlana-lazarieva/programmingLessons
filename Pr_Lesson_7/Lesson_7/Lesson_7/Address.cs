using System;
/// <summary>
/// Cоздайте класс «Адрес». 
/// В теле класса создайте следующие поля: страна, город, улица, дом, квартира, индекс.
/// Для каждого поля, создать свойство с двумя методами доступа. 
/// Также в классе необходимо создать метод для отображения информации про адрес. 
/// </summary>

namespace Task_1
{
    /// <summary>
    /// Класс «Адрес». 
    /// Поля: страна, город, улица, дом, квартира, индекс. 
    /// </summary>
    public class Address
    {
        // Страна
        private string _country;
        // Город
        private string _city;
        // Улица
        private string _street;
        // Дом
        private string _house;
        // Квартира
        private int _apartment;
        // Индекс
        private string _zipCode;

        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }
        public string City 
        {
            get { return _city; }
            set { _city = value; }
        }
        public string Street 
        {
            get { return _street; }
            set { _street = value; }
        }
        public string House 
        {
            get { return _house; }
            set { _house = value; }
        }
        public int Apartment 
        {
            get { return _apartment; }
            set { _apartment = value; } 
        }
        public string ZipCode 
        {
            get { return _zipCode; }
            set { _zipCode = value; } 
        }

        /// <summary>
        /// Вывести адрес на консоль
        /// </summary>
        public void ShowAddress()
        {
            Console.WriteLine($"Страна: {_country}, \nГород: {_city}, \n" +
                              $"Улица: {_street}, \nДом: {_house}, \n" +
                              $"Квартира: {_apartment}, \nИндекс: {_zipCode}");
        }
    }
}
