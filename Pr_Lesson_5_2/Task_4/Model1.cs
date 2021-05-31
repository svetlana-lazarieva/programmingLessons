using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Task_4
{
    public class Model1 : DbContext
    {
        // Контекст настроен для использования строки подключения "Model1" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "Task_4.Model1" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "Model1" 
        // в файле конфигурации приложения.
        public Model1()
            : base("name=Model1")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Table_1> Table_1 { get; set; }
        public virtual DbSet<Table_2> Table_2 { get; set; }
        public virtual DbSet<Table_3> Table_3 { get; set; }
    }

    [Table("Table_1")]
    public class Table_1
    {
        [Key]
        public int Table_1_Id { get; set; }
        public string Val_1 { get; set; }
        public int Val_2 { get; set; }
    }

    [Table("Table_2")]
    public class Table_2
    {
        [Key]
        public int Table_2_Id { get; set; }
        public string Val_1 { get; set; }
        public int Val_2 { get; set; }
    }

    [Table("Table_3")]
    public class Table_3
    {
        [Key]
        public int Table_3_Id { get; set; }
        public string Val_1 { get; set; }
        [ForeignKey("Table_1")]
        public int Table_1_Id { get; set; }
        [ForeignKey("Table_2")]
        public int Table_2_Id { get; set; }

        public Table_1 Table_1 { get; set; }
        public Table_2 Table_2 { get; set; }
    }
}