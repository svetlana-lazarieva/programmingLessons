using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    /// <summary>
    /// Используя Visual Studio, создайте проект по шаблону Console Application. 
    /// Создайте программу, в которой используя подход Code First создайте три 
    /// сущности с произвольными именами.Свяжите три сущности связью многие ко 
    /// многим.Заполните сущности данными.Выведите данные в консоль
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Model1 model = new Model1();
            Database.SetInitializer(new DropCreateDatabaseAlways<Model1>());

            // Заполняем таблички
            AddDataIntoTable_1(model);
            AddDataIntoTable_2(model);
            AddDataIntoTable_3(model);
            model.SaveChanges();

            ShowTable_1(model);
            ShowTable_2(model);
            ShowTable_3(model);

            Console.ReadKey();
        }

        /// <summary>
        /// Вывести на консоль Table_1
        /// </summary>
        /// <param name="model"></param>
        private static void ShowTable_1(Model1 model)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nТаблица 'Table_1'");
            Console.ForegroundColor = ConsoleColor.Gray;
            foreach (var item in model.Table_1)
            {
                Console.WriteLine($"\nVal_1: {item.Val_1} " +
                                  $"Val_2: {item.Val_2} " +                       
                                  $"Table_1_Id: {item.Table_1_Id} ");
            }
        }

        /// <summary>
        /// Вывести на консоль Table_2
        /// </summary>
        /// <param name="model"></param>
        private static void ShowTable_2(Model1 model)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nТаблица 'Table_2'");
            Console.ForegroundColor = ConsoleColor.Gray;
            foreach (var item in model.Table_2)
            {
                Console.WriteLine($"\nVal_1: {item.Val_1} " +
                                  $"Val_2: {item.Val_2} " +
                                  $"Table_2_Id: {item.Table_2_Id} ");
            }
        }

        /// <summary>
        /// Вывести на консоль Table_3
        /// </summary>
        /// <param name="model"></param>
        private static void ShowTable_3(Model1 model)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nТаблица 'Table_3'");
            Console.ForegroundColor = ConsoleColor.Gray;
            foreach (var item in model.Table_3)
            {
                Console.WriteLine($"\nVal_1: {item.Val_1} " +
                                  $"Table_1_Id: {item.Table_1_Id} " +
                                  $"Table_3_Id: {item.Table_3_Id} " +
                                  $"Table_2_Id: {item.Table_2_Id} ");
            }
        }

        /// <summary>
        /// Заполнить таблицу Table_1
        /// </summary>
        /// <param name="model"></param>
        private static void AddDataIntoTable_1(Model1 model)
        {
            model.Table_1.Add(new Table_1()
            {
                Table_1_Id = 1,
                Val_1 = "val1",
                Val_2 = 5
            });
            model.Table_1.Add(new Table_1()
            {
                Table_1_Id = 2,
                Val_1 = "val2",
                Val_2 = 51
            });
            model.Table_1.Add(new Table_1()
            {
                Table_1_Id = 3,
                Val_1 = "val2",
                Val_2 = 7
            });
        }

        /// <summary>
        /// Заполнить таблицу Table_2
        /// </summary>
        /// <param name="model"></param>
        private static void AddDataIntoTable_2(Model1 model)
        {
            model.Table_2.Add(new Table_2()
            {
                Table_2_Id = 1,
                Val_1 = "val1",
                Val_2 = 14
            });
            model.Table_2.Add(new Table_2()
            {
                Table_2_Id = 2,
                Val_1 = "val2",
                Val_2 = 15
            });
        }

        /// <summary>
        /// Заполнить таблицу Table_3
        /// </summary>
        /// <param name="model"></param>
        private static void AddDataIntoTable_3(Model1 model)
        {
            model.Table_3.Add(new Table_3()
            {
                Val_1 = "val",
                Table_3_Id = 1,
                Table_2_Id = 1,
                Table_1_Id = 1
            });
            model.Table_3.Add(new Table_3()
            {
                Val_1 = "vall",
                Table_3_Id = 2,
                Table_2_Id = 2,
                Table_1_Id = 2
            });
            model.Table_3.Add(new Table_3()
            {
                Val_1 = "valll",
                Table_3_Id = 3,
                Table_2_Id = 2,
                Table_1_Id = 1
            });


        }





    }
}
