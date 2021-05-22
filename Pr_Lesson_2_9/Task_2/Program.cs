using System;
using System.Collections.Generic;

namespace Task_2
{
    /// <summary>
    /// Используя Visual Studio, создайте проект по шаблону Console Application. 
    /// Создайте программу в которой создайте пользовательский атрибут AccessLevelAttribute, 
    /// позволяющий определить уровень доступа пользователя к системе.
    /// Сформируйте состав сотрудников некоторой фирмы в виде набора классов, 
    /// например, Manager, Programmer, Director.
    /// При помощи атрибута AccessLevelAttribute распределите уровни доступа персонала и 
    /// отобразите на экране реакцию системы на попытку каждого сотрудника получить доступ в 
    /// защищенную секцию.

    /// </summary>
    class Program
    {
        static List<Employee> employees = new List<Employee>();
        static void Main(string[] args)
        {
            Director director = new Director();
            director.Name = "Bob";
            Programmer programmer = new Programmer();
            programmer.Name = "Denis";
            Manager manager = new Manager();
            manager.Name = "Polly";

            employees.Add(director);
            employees.Add(programmer);
            employees.Add(manager);
            GetDBAccess();

        }

        /// <summary>
        /// Подключится к БД
        /// </summary>
        public static void GetDBAccess()
        {
            DataBase dataBase = new DataBase(employees);
            dataBase.CheckAccess();
            Console.ReadKey();
        }
    }
}
