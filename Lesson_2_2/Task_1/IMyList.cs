/// <summary>
/// Для данной задачи создайте обобщенный интерфейс IMyList<T>, интерфейс должен 
/// содержать следующие методы и свойства:
/// 1)Метод void Add(T a); -для добавления элемента в коллекцию;
/// 2)T this[int index] { get; }
/// свойство – для получения элемента массива из коллекции по индексу;
/// 3)int Count { get; }
/// свойство которое возвращает количество элементов массива;
/// 4)Метод void Clear(); -удаляет из коллекции все элементы;
/// 5)Метод bool Contains(T item); -определяет содержится ли элемент в коллекции.
/// </summary>
namespace Task_1
{
    public interface IMyList<T>
    {
        /// <summary>
        /// Элемент массива из коллекции по индексу
        /// </summary>
        /// <param name="index">Индекс</param>
        /// <returns></returns>
        T this[int index] { get; }
        /// <summary>
        /// Количество элементов массива
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Добавить элемент в коллекцию
        /// </summary>
        /// <param name="a">Элемент</param>
        void Add(T a);
        
        /// <summary>
        /// Удалить из коллекции все элементы
        /// </summary>
        void Clear();

        /// <summary>
        /// Определить содержится ли элемент в коллекции
        /// </summary>
        /// <param name="item">Элеменнт</param>
        /// <returns></returns>
        bool Contains(T item);
    }
}
