using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// Создайте программу в которой используя класс SortedList, 
/// создайте небольшую коллекцию и выведите на экран значения 
/// пар «ключ- значение» сначала в алфавитном порядке, а затем 
/// в обратном.
/// </summary>
namespace Task_3
{
    public class SortedListCollection
    {
        SortedList<string, string> _dictionary = new SortedList<string, string>();

        /// <summary>
        /// Получить dictionaty
        /// </summary>
        public void GetList()
        {
            FillList();                       
            ShowList();
        }

        /// <summary>
        /// Заполнить dictionaty
        /// </summary>
        private void FillList()
        {
            _dictionary["d"] = "1";
            _dictionary["b"] = "2";
            _dictionary["e"] = "3";
            _dictionary["a"] = "4";
            _dictionary["c"] = "5";
        }

        /// <summary>
        /// Показать dictionaty
        /// </summary>
        private void ShowList()
        {
            var newList = _dictionary.OrderBy(x => x.Key);
            Console.WriteLine("В алфавитном порядке");
            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }

            newList = _dictionary.OrderByDescending(x => x.Key);
            Console.WriteLine("В обратном порядке");
            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
