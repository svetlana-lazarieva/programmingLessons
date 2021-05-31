
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;


namespace Task_3
{
    public class Model1 : DbContext
    {
        // Контекст настроен для использования строки подключения "Model1" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "Task_3.Model1" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "Model1" 
        // в файле конфигурации приложения.
        public Model1()
            : base("name=Model1")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Person> Persons { get; set; }
         public virtual DbSet<Clothes> Clothes { get; set; }
    }

    /// <summary>
    /// Люди
    /// </summary>
    [Table("Persons")]
    public class Person
    {
        [Key]
        public int Person_Id { get; set; }
        public string Name { get; set; }
        public string Second_name { get; set; }
        public int Age { get; set; }
    }

    /// <summary>
    /// Вещи
    /// </summary>
    [Table("Clothes")]
    public class Clothes
    {
        [Key]
        public int Clothe_Id { get; set; }
        [ForeignKey("Person")]
        public int Person_Id { get; set; }
        public string Clothe_Name { get; set; }
        public string Clothe_Color { get; set; }
        public int Clothe_Size { get; set; }

        public Person Person { get; set; }
    }
}