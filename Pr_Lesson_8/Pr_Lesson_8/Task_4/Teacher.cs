using System;
/// <summary>
/// В классе Teacher (преподаватель) создать поле типа Student[] с именем StudentsArray, 
/// и свойство (не авто свойство) для добавления(set) и получения(get) студентов.
/// </summary>

namespace Task_4
{
    public class Teacher : Person
    {
        // Студенты
        private Student[] _studentsArray;
        public Student[] StudentsArray
        {
            get
            {
                return _studentsArray;
            }
            set
            {
                _studentsArray = value;
            }
        }

        public Teacher(int birthYear, string name, string surname) : base(birthYear, name, surname)
        { }



    }
}
