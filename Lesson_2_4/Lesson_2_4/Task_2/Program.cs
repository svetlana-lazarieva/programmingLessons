using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application 
/// Создайте программу для автостанции, в которой вам необходимо создать простую 
/// коллекцию автомобилей со следующими данными: 
/// Марка автомобиля, модель, год выпуска, цвет. 
/// А также вторую коллекцию с моделью автомобиля, именем покупателя и его номером телефона. 
/// Используя простейший LINQ запрос, выведите на экран информацию о покупателе одного 
/// из автомобилей и полную характеристику приобретенной ними модели. 
/// </summary>

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Список машин
            List<Car> cars = FillCars();

            // Список покупателей
            List<Buyer> buyers = FillBuyers();

            // Список покупателей и купленных ими машин
            var buyersOfCars = from b in buyers
                               join c in cars on b.CarModel equals c.Model
                               select new
                               {
                                   b.CarModel,
                                   b.Name,
                                   b.PhoneNumber,
                                   c.Color,
                                   c.CarMake,
                                   c.YearOfManufacture
                               };

            var buyerResult = buyersOfCars.Where(b => b.Name == "Покупатель_2");
            foreach (var item in buyerResult)
                Console.WriteLine("\nИмя: {0}    \nТел.: {1}   \nМарка: {2} " +
                                  "\nМодель: {3} \nГод: {4}    \nЦвет: {5}",
                                  item.Name, item.PhoneNumber, item.CarModel,
                                  item.CarMake, item.YearOfManufacture, item.Color);
            Console.ReadKey();

        }

        /// <summary>
        /// Заполнить список покупателей
        /// </summary>
        /// <returns>Список покупателей</returns>
        public static List<Buyer> FillBuyers()
        {
            return new List<Buyer>
            {
                new Buyer
                {
                    CarModel ="Модель_3",
                    Name="Покупатель_1",
                    PhoneNumber="111-11-11"
                },
                new Buyer
                {
                    CarModel ="Модель_1",
                    Name="Покупатель_2",
                    PhoneNumber="222-22-22"
                },
                new Buyer
                {
                    CarModel ="Модель_2",
                    Name="Покупатель_3",
                    PhoneNumber="333-33-33"
                }
            };
        }

        /// <summary>
        /// Заполнить список машин
        /// </summary>
        /// <returns>Список машин</returns>
        public static List<Car> FillCars()
        {          
            return new List<Car>
            {
                new Car
                {
                     CarMake = "Марка_1",
                     Model = "Модель_1",
                     YearOfManufacture = "2002",
                     Color = "Четный"
                },
                new Car
                {
                     CarMake = "Марка_2",
                     Model = "Модель_2",
                     YearOfManufacture = "2002",
                     Color = "Синий"
                },
                new Car
                {
                     CarMake = "Марка_1",
                     Model = "Модель_2",
                     YearOfManufacture = "2012",
                     Color = "Красный"
                },
                new Car
                {
                     CarMake = "Марка_3",
                     Model = "Модель_1",
                     YearOfManufacture = "2020",
                     Color = "Зеленый"
                },
                new Car
                {
                     CarMake = "Марка_2",
                     Model = "Модель_3",
                     YearOfManufacture = "2021",
                     Color = "Белый"
                }
            };
        }
    }
}
