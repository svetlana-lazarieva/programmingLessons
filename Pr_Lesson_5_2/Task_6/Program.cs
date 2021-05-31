using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    /// <summary>
    /// Используя Visual Studio, создайте проект по шаблону Console Application. 
    /// Создайте программу, в которой используя подход Code First создайте две 
    /// сущности с произвольными именами.Свяжите две сущности связью один ко многим.
    /// Заполните сущности данными.
    /// Выполните операцию Include(), Select(), Find() к данным.
    /// Выведите данные в консоль.

    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            MyModel1 model = new MyModel1();
            Database.SetInitializer(new DropCreateDatabaseAlways<MyModel1>());
            // Заполняем таблички
            AddDataIntoChildren(model);
            AddDataIntoToys(model);
            model.SaveChanges();


            var childNames = model.Toys.Include(x => x.Children).ToList();
            PrintItems(childNames.Select(x => x.Toy_Name).ToList());
            var children = model.Children.Find(3);
            Console.WriteLine($"Found child: {children.Child_Name}");
            Console.ReadLine();

        }

        private static void PrintItems(List<string> items)
        {
            foreach (string item in items)
            {
                Console.WriteLine($"Item : {item}");
            }
        }


        /// <summary>
        /// Заполнить таблицу Children
        /// </summary>
        /// <param name="model"></param>
        private static void AddDataIntoChildren(MyModel1 model)
        {
            model.Children.Add(new Children()
            {
                Child_Id = 1,
                Child_Name = "Максим",
                Child_Age = 9
            });
            model.Children.Add(new Children()
            {
                Child_Id = 2,
                Child_Name = "Аня",
                Child_Age = 5
            });
            model.Children.Add(new Children()
            {
                Child_Id = 3,
                Child_Name = "Толик",
                Child_Age = 3
            });
        }

        /// <summary>
        /// Заполнить таблицу Toys
        /// </summary>
        /// <param name="model"></param>
        private static void AddDataIntoToys(MyModel1 model)
        {
            model.Toys.Add(new Toys()
            {
                Toy_Id = 1,
                Child_Id = 3,
                Toy_Name = "Мяч",
                Color = "Красный"
            });          
            model.Toys.Add(new Toys()
            {
                Toy_Id = 2,
                Child_Id = 1,
                Toy_Name = "Слон",
                Color = "Оранжевый"
            });
            model.Toys.Add(new Toys()
            {
                Toy_Id = 3,
                Child_Id = 2,
                Toy_Name = "Каракатица",
                Color = "Розовый"
            });
            model.Toys.Add(new Toys()
            {
                Toy_Id = 4,
                Child_Id = 3,
                Toy_Name = "Попугай",
                Color = "Зеленый"
            });
        }

    }
}
