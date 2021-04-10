
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.
/// Создайте программу в которой создайте обобщенный класс книга (Book). 
/// Класс Book должен содержать универсальный параметра типа T (Book <T>). 
/// В теле класса создайте два закрытых поля: 
/// Name – имя книги(private string Name) и 
/// Price – (обобщенныйтип) цена книги(private T Price). 
/// Также создайте свойства для доступа к выше описанным полям. 
/// После чего создайте метод Show() который будет вывод название книги и ее цену. 
/// В методе Main() создайте экземпляры обобщенного типа, где Т это int и где Т это double
/// </summary>

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book<double> book = new Book<double>();
            book.Name = "Пригоди Тома Сойєра - Марк Твен";
            book.Price = 120;
            book.Show();
        }
    }
}
