using System;
using System.Linq;
/// <summary>
/// Создайте класс PeopleInfo, в нем создайте поле типа Person[] с именем 
/// PeopleArray и свойство (не авто свойство) для добавления(set) и получения(get) 
/// людей и метод который будет выводить всех людей который есть в поле PeopleInfo 
/// в порядке возрастания возраста.
/// </summary>

namespace Task_4
{
    public class PeopleInfo
    {
        private Person[] _peopleArray;
        public Person[] PeopleArray
        {
            get 
            {
                return _peopleArray;
            }
            set
            {
                _peopleArray = value;
            }
        }
    
        private Person[] SortPeopleArray()
        {
            int lengthArray = PeopleArray.Length;
        
            for (int i = 0; i < lengthArray; i++)
            {
                for (int j = i; j < lengthArray; j++)
                {
                    if (PeopleArray[i].BirthYear < PeopleArray[j].BirthYear)
                    {
                        Person people = PeopleArray[i];
                        PeopleArray[i] = PeopleArray[j];
                        PeopleArray[j] = people;
                    }
                }             
            }

            return PeopleArray;
        }

        /// <summary>
        /// Выводить всех людей который есть в поле PeopleInfo 
        /// в порядке возрастания возраста
        /// </summary>
        public void ShowAllPeopleInfo()
        {
            //Person[] peopleArray = SortPeopleArray();
            Person[] peopleArray = _peopleArray.OrderByDescending(x=>x.BirthYear).ToArray();
            for (int i = 0; i < peopleArray.Length; i++)
            {
                string info = peopleArray[i].ToString();
                Console.WriteLine(info);
            }

            Console.ReadKey();
        }
    }
}
