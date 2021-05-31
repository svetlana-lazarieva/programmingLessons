using System;
using System.Linq;

namespace Task_5
{
    /// <summary>
    /// Используя Visual Studio, создайте проект по шаблону Console Application. 
    /// Создайте программу, в которой используя подход Code First создайте две 
    /// сущности с произвольными именами.Свяжите две сущности связью один ко многим.
    /// Заполните сущности данными.
    /// Используйте методы First() / FirstOrDefault(), OrderBy(), Count() , Min(), 
    /// Max() и Average(). Выведите данные в консоль
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            MyModel model = new MyModel();
            //Database.SetInitializer(new DropCreateDatabaseAlways<MyModel>());
            //// Заполняем таблички
            //AddDataIntoEmployees(model);
            //AddDataIntoPositions(model);
            //model.SaveChanges();

            
            var group = model.Employees.OrderBy(t => t.Positions_Id);
            foreach (var item in group)
            {
                Console.WriteLine($" id должности: {item.Positions_Id}  Имя работника: {item.Employees_Name} ");
            }
            
            var sed = model.Positions.First(t => t.Salary < 20000);
            Console.WriteLine("\n Должности с зарплатами меньше 20000");
            Console.WriteLine($" Должность: {sed.Position}  Зарплата: {sed.Salary} ");


            Console.WriteLine($"\n Количество работников: {model.Employees.Count()}");
            Console.WriteLine($" Максимальнаяи зарплата: {model.Positions.Max(t => t.Salary)}");
            Console.WriteLine($" Минимальная зарплата: {model.Positions.Min(t => t.Salary)}");
            Console.WriteLine($" Средняя зарплата: {model.Positions.Average(t => t.Salary)}");

            Console.ReadKey();
        }

        /// <summary>
        /// Заполнить таблицу Employees
        /// </summary>
        /// <param name="model"></param>
        private static void AddDataIntoEmployees(MyModel model)
        {
            model.Employees.Add(new Employees()
            {
                Employees_Id = 1,
                Employees_Name = "Саша",
                Positions_Id = 1
            });
            model.Employees.Add(new Employees()
            {
                Employees_Id = 2,
                Employees_Name = "Маша",
                Positions_Id = 1
            });
            model.Employees.Add(new Employees()
            {
                Employees_Id = 3,
                Employees_Name = "Паша",
                Positions_Id = 1
            });
            model.Employees.Add(new Employees()
            {
                Employees_Id = 4,
                Employees_Name = "Даша",
                Positions_Id = 2
            });
        }

        /// <summary>
        /// Заполнить таблицу Positions
        /// </summary>
        /// <param name="model"></param>
        private static void AddDataIntoPositions(MyModel model)
        {
            model.Positions.Add(new Positions()
            {
                Positions_Id = 1,
                Position = "Дворник",
                Salary = 1500
            });
            model.Positions.Add(new Positions()
            {
                Positions_Id = 2,
                Position = "Главный дворник",
                Salary = 2000
            });
        }
    }
}
