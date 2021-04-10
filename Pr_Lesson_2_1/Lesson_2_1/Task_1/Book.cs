using System;
/// <summary>
/// Класс Book должен содержать универсальный параметра типа T (Book <T>). 
/// В теле класса создайте два закрытых поля: 
/// Name – имя книги(private string Name) и 
/// Price – (обобщенныйтип) цена книги(private T Price). 
/// Также создайте свойства для доступа к выше описанным полям. 
/// После чего создайте метод Show() который будет вывод название книги и ее цену.
/// </summary>

namespace Task_1
{
    /// <summary>
    /// Книга
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Book<T>
    {
        private string _name;
        private T _price;

        /// <summary>
        /// Название книги
        /// </summary>
        public string Name 
        {
            get
            {
                return  _name;
            }
            set 
            {
                _name = value;
            }
        }
        /// <summary>
        /// Цена книги
        /// </summary>
        public T Price 
        { 
            get
            {
                return _price;
            }
          set
            {
                _price = value;
            }
        }

        /// <summary>
        /// Вывод на консоль
        /// </summary>
        public void Show()
        {
            Console.WriteLine($"Название книги: {Name} \nЦена книги: {Price}");
            Console.ReadKey();
        }
    }
}
