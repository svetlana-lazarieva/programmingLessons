using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application. 
/// Создайте программу в которой используя класс SortedList, создайте небольшую 
/// коллекцию и выведите на экран значения пар «ключ- значение» сначала в 
/// алфавитном порядке, а затем в обратном
/// </summary>
namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedListCollection sortedList = new SortedListCollection();
            sortedList.GetList();
        }
    }
}
