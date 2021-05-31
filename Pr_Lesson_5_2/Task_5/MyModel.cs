using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Task_5
{
    public class MyModel : DbContext
    {
        // Контекст настроен для использования строки подключения "MyModel" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "Task_5.MyModel" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "MyModel" 
        // в файле конфигурации приложения.
        public MyModel()
            : base("name=MyModel")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Employees> Employees { get; set; }
         public virtual DbSet<Positions> Positions { get; set; }
    }

    /// <summary>
    /// Работники
    /// </summary>
    [Table("Employees")]
    public class Employees
    {
        [Key]
        public int Employees_Id { get; set; }
        public string Employees_Name { get; set; }
        [ForeignKey("Positions")]
        public int Positions_Id { get; set; }

        public Positions Positions { get; set; }
    }

    /// <summary>
    /// Должности
    /// </summary>
    [Table("Positions")]
    public class Positions
    {
        [Key]
        public int Positions_Id { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }

        
    }
}