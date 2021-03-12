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

        private string Country { get; set; }
        private string City { get; set; }
        private string Street { get; set; }
        private string House { get; set; }
        private int Apartment { get; set; }
        private string ZipCode { get; set; }


        /// <summary>
        /// Ввести адрес
        /// </summary>
        /// <param name="valCountry">Страна</param>
        /// <param name="valCity">Город</param>
        /// <param name="valStreet">Улица</param>
        /// <param name="valHouse">Дом</param>
        /// <param name="valApartment">Квартира</param>
        /// <param name="valZipCode">Индекс</param>
        public void SetAddress(string valCountry, string valCity, string valStreet,
                               string valHouse, int valApartment, string valZipCode)
        {
            _country = valCountry;
            _city = valCity;
            _street = valStreet;
            _house = valHouse;
            _apartment = valApartment;
            _zipCode = valZipCode;
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
