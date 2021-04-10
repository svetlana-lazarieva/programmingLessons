using System;
/// <summary>
/// В классе Student добавьте поле типа string[] с именем
/// Study Courses (изучаемые курсы), свойство(не авто свойство) для 
/// добавления(set) и получения(get) изучаемых курсов и метод 
/// DisplayStudyСourses() с возвращаемым значением void который будет выводить 
/// на консоль все предметы, максимальное количество изучаемых курсов = 3.
/// </summary>

namespace Task_4
{
    public class Student : Person
    {
        // Максимальное количество изучаемых курсов
        private const int MaxNumberOfCourse = 3;
        // Изучаемые курсы
        private string[] _studyCourses = new string[MaxNumberOfCourse];

        public string[] StudyCourses
        {
            get
            {
                return _studyCourses;
            }
            set
            {
                _studyCourses = value;
            }
        }

        public Student(int birthYear, string name, string surname) : base(birthYear, name, surname)
        { }

        /// <summary>
        /// Выводит на консоль все предметы
        /// </summary>
        public void DisplayStudyСourses()
        {
            for (int i = 0; i < _studyCourses.Length; i++)
            {
                Console.Write($"{_studyCourses[i]} ");
            }
        }

    }
}
