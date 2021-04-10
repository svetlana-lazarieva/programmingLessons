using System;
/// <summary>
/// Создайте программу, в которой создайте базовый класс Person (человек), 
/// в классе создайте поле типа int с именем BirthYear (год рождения), 
/// поле типа string с именем Name и поле типа string  с именем Surname. 
/// </summary>

namespace Task_4
{
    public class Person
    {
        // Год рождения
        public int BirthYear { get; private set; }
        // Имя
        public string Name { get; private set; }
        // Фамилия
        public string Surname { get; private set; }

        protected Person(int birthYear, string name, string surname)
        {
            BirthYear = birthYear;
            Name = name;
            Surname = surname;
        }

        public override string ToString()
        {
            return $"{BirthYear}, {Name}, {Surname}";
        }
    }
}
