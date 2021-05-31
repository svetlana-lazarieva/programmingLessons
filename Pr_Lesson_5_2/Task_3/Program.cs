using System;
using System.Data.Entity;

namespace Task_3
{
    /// <summary>
    /// Используя Visual Studio, создайте проект по шаблону Console Application. 
    /// Создайте программу, в которой используя подход Code First создайте две сущности с
    /// произвольными именами.Свяжите две сущности связью один ко многим.Заполните
    /// сущности данными.Выведите данные в консоль.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Model1 model = new Model1();
            Database.SetInitializer(new DropCreateDatabaseAlways<Model1>());

            // Заполняем таблички
            CreateNewPersons(model);
            CreateNewClothes(model);
            model.SaveChanges();

            ShowPerson(model);
            ShowClothes(model);
            Console.ReadKey();
        }

        /// <summary>
        /// Вывести на консоль таблицу Clothes
        /// </summary>
        /// <param name="model"></param>
        private static void ShowClothes(Model1 model)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nТаблица 'Вещи'");
            Console.ForegroundColor = ConsoleColor.Gray;
            foreach (var item in model.Clothes)
            {
                Console.WriteLine($"\nНазвание вещи: {item.Clothe_Name} " +
                                  $"Цвет вещи: {item.Clothe_Color} " +
                                  $"Размер вещи: {item.Clothe_Size} " +
                                  $"Id вещи: {item.Clothe_Id} ");
            }
        }

        /// <summary>
        /// Вывести на консоль таблицу Person
        /// </summary>
        /// <param name="model"></param>
        private static void ShowPerson(Model1 model)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nТаблица 'Люди'");
            Console.ForegroundColor = ConsoleColor.Gray;
            foreach (var item in model.Persons)
            {
                Console.WriteLine($"\nИмя: {item.Name} " +
                                  $"Фамилия: {item.Second_name} " +
                                  $"Возраст: {item.Age} " +
                                  $"Id челввека: {item.Person_Id} ");
            }
        }

        /// <summary>
        /// Заполнить таблицу Persons
        /// </summary>
        /// <param name="model"></param>
        private static void CreateNewPersons(Model1 model)
        {
            model.Persons.Add(new Person()
            {
                Person_Id = 1,
                Name = "Name1",
                Second_name = "SecondName1",
                Age = 3
            });
            model.Persons.Add(new Person()
            {
                Person_Id = 2,
                Name = "Name2",
                Second_name = "SecondName2",
                Age = 7
            });
            model.Persons.Add(new Person()
            {
                Person_Id = 3,
                Name = "Name3",
                Second_name = "SecondName2",
                Age = 9
            });
        }

        /// <summary>
        /// Заполнить таблицу Clothes
        /// </summary>
        /// <param name="model"></param>
        private static void CreateNewClothes(Model1 model)
        {
            model.Clothes.Add(new Clothes()
            {
                Clothe_Id = 1,
                Person_Id = 1,
                Clothe_Name = "ClotheName1",
                Clothe_Color = "ClotheColor1",
                Clothe_Size = 32
            });
            model.Clothes.Add(new Clothes()
            {
                Clothe_Id = 2,
                Person_Id = 1,
                Clothe_Name = "ClotheName2",
                Clothe_Color = "ClotheColor1",
                Clothe_Size = 32
            });
            model.Clothes.Add(new Clothes()
            {
                Clothe_Id = 1,
                Person_Id = 2,
                Clothe_Name = "ClotheName1",
                Clothe_Color = "ClotheColor1",
                Clothe_Size = 28
            });
            model.Clothes.Add(new Clothes()
            {
                Clothe_Id = 2,
                Person_Id = 3,
                Clothe_Name = "ClotheName2",
                Clothe_Color = "ClotheColor1",
                Clothe_Size = 40
            });

        }
    }
}
