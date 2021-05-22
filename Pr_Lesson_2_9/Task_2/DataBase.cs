using System;
using System.Collections.Generic;
using System.Reflection;

namespace Task_2
{
    public class DataBase
    {
        private List<Employee> _employees = new List<Employee>();

        public DataBase(List<Employee> employees)
        {
            this._employees = employees;
        }

        /// <summary>
        ///  Проверка уровня доступа
        /// </summary>
        public void CheckAccess()
        {
            foreach (var employee in _employees)
            {
                Type empT = employee.GetType();
                Type attrT = typeof(AccessLevelAttribute);
                AccessLevelAttribute attribute = (AccessLevelAttribute)empT.GetCustomAttribute(attrT);
                
                Console.WriteLine($"My name is {employee.Name}. I am {empT.Name} here.");

                switch (attribute.LevelType)
                {
                    case (AccessLevelType)0:
                        {                           
                            ReadDB();
                            WriteDB();
                            DropDB();
                            break;
                        }
                    case (AccessLevelType)1:
                        {
                            ReadDB();
                            WriteDB();                          
                            break;
                        }
                    case (AccessLevelType)2:
                        {
                            ReadDB();
                            break;
                        }
                }
            }
        }

        /// <summary>
        /// Вычитывать данные из БД
        /// </summary>
        public void ReadDB()
        {
            Console.WriteLine("I can read.");
        }

        /// <summary>
        /// Записывать данные в БД
        /// </summary>
        public void WriteDB()
        {
            Console.WriteLine("I can write.");
        }

        /// <summary>
        /// Удалять в БД
        /// </summary>
        public void DropDB()
        {
            Console.WriteLine("I can drop.");
        }
    }
}
