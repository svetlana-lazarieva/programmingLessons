using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Task_6
{
    public class MyModel1 : DbContext
    {
        // Контекст настроен для использования строки подключения "MyModel1" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "Task_6.MyModel1" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "MyModel1" 
        // в файле конфигурации приложения.
        public MyModel1()
            : base("name=MyModel1")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Children> Children { get; set; }
         public virtual DbSet<Toys> Toys { get; set; }
    }

    [Table("Children")]
    public class Children
    {
        [Key]
        public int Child_Id { get; set; }
        public string Child_Name { get; set; }
        public int Child_Age { get; set; }

    }

    [Table("Toys")]
    public class Toys
    {
        [Key]
        public int Toy_Id { get; set; }
        [ForeignKey("Children")]
        public int Child_Id { get; set; }
        public string Toy_Name { get; set; }
        public string Color { get; set; }

        public Children Children { get; set; }
    }
}