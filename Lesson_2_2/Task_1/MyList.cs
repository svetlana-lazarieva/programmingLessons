/// <summary>
/// Далее создайте обобщенный класс MyList<T> (экземпляр которой и будет 
/// использоватся аналогично экземпляру List<T>.), в котором реализуйте интерфейс 
/// IMyList<T> также в теле класса создайте закрытий массив элементов типа 
/// Т - private T[] array и конструктор класса public MyList() в котором 
/// инициализируйте массив элементов.
/// </summary>

namespace Task_1
{
    public class MyList<T> : IMyList<T>
    {      
        private const int NumberOfArrayElements = 5;

        /// <summary>
        /// Массив
        /// </summary>
        private T[] _array = null;

        /// <summary>
        /// Колличество заполненных элементов массива
        /// </summary>
        private int _numberOfArrayElements = 0;


        /// <summary>
        /// Колличество элементов массива
        /// </summary>
        public int Count => _numberOfArrayElements - 1;

        private int ArrayCount
        {
            get
            {
                if (_array != null && _array.Length > 0)
                {
                    return _array.Length;
                }
                else return 1;
            }
        }


        /// <summary>
        /// Элемент массива из коллекции по индексу
        /// </summary>
        /// <param name="index">Индекс</param>
        /// <returns></returns>
        public T this[int index]
        {
            get
            {
                return _array[index];
            }
        }

        /// <summary>
        /// Инициалицация массива
        /// </summary>
        public MyList()
        {           
            _array = new T[ArrayCount];
            _numberOfArrayElements = 1;
        }

        /// <summary>
        /// Добавить элемент в коллекцию
        /// </summary>
        /// <param name="a">Элемент</param>
        public void Add(T a)
        {

            if (ArrayCount >= _numberOfArrayElements)
            {
                _array[_numberOfArrayElements - 1] = a;
            }
            else
            {
                CreateNewArray(a);
            }

            _numberOfArrayElements++;
        }

        /// <summary>
        /// Пересоздать массив и добавить в него новый элемент
        /// </summary>
        /// <param name="a">Новый элемент</param>
        private void CreateNewArray(T a)
        {
            T[] newArray = new T[ArrayCount + NumberOfArrayElements];
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }

            int index = _numberOfArrayElements-1; 
            newArray[index] = a;
            _array = newArray;
        }

        /// <summary>
        /// Удалить из коллекции все элементы
        /// </summary>
        public void Clear()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = default;
                _numberOfArrayElements = 0;
            }
        }

        /// <summary>
        /// Определить содержится ли элемент в коллекции
        /// </summary>
        /// <param name="item">Элеменнт</param>
        /// <returns></returns>
        public bool Contains(T item)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if ((dynamic)_array[i] == (dynamic)item)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
