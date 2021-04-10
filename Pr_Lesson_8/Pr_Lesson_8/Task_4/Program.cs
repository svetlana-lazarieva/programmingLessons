using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.
/// Создайте программу, в которой создайте базовый класс Person (человек), 
/// в классе создайте поле типа int с именем BirthYear (год рождения), 
/// поле типа string с именем Name и поле типа string  с именем Surname.
/// 
/// Далее создайте классы Student (студент), Teacher(преподаватель).
/// 
/// В классе Student добавьте поле типа string[] с именем 
/// Study Courses (изучаемые курсы), свойство(не авто свойство) для 
/// добавления(set) и получения(get) изучаемых курсов и метод 
/// DisplayStudyСourses() с возвращаемым значением void который будет выводить 
/// на консоль все предметы, максимальное количество изучаемых курсов = 3. 
/// 
/// В классе преподаватель создать поле типа Student[] с именем StudentsArray, 
/// и свойство (не авто свойство) для добавления(set) и получения(get) студентов.
/// 
/// Создайте 5 экземпляров класса типа Student и инициализируйте их произвольными 
/// значениями, и 2 экземпляра класса типа Teacher, инициализируйте их произвольными 
/// значениями (для инициализации поля StudentsArray используйте уже созданные 
/// экземпляры Student). 
/// 
/// Далее создайте класс PeopleInfo, в нем создайте поле типа Person[] с именем 
/// PeopleArray и свойство (не авто свойство) для добавления(set) и получения(get) 
/// людей и метод который будет выводить всех людей который есть в поле PeopleInfo 
/// в порядке возрастания возраста.
/// </summary>

namespace Task_4
{
    class Program
    {
        // Предметы
        const string course1 = "Мат. Анализ";
        const string course2 = "Дискретная математика";
        const string course3 = "Линейная алгебра";
        const string course4 = "ММДО";

        static void Main(string[] args)
        {
            // Студенты
            Student student1 = new Student(1992, "Александр", "Ельчанинов");
            Student student2 = new Student(1999, "Елизавета", "Степанова");
            Student student3 = new Student(1997, "Николай", "Баранкин");
            Student student4 = new Student(2000, "Екатерина", "Овчаренко");
            Student student5 = new Student(2005, "Ольга", "Жукина");
            // Предметы студентов
            student1.StudyCourses = new string[] { course1, course2, course4 };
            student2.StudyCourses = new string[] { course1, course2, course3 };
            student3.StudyCourses = new string[] { course2, course3, course4 };
            student4.StudyCourses = new string[] { course2, course3 };
            student5.StudyCourses = new string[] { course1, course4 };
            // Преподаватели
            Teacher teacher1 = new Teacher(1979, "Петр", "Жданов");
            Teacher teacher2 = new Teacher(1967, "Елена", "Муха");
            // Студенты преподавателей
            teacher1.StudentsArray = new Student[] { student1, student2, student3 };
            teacher2.StudentsArray = new Student[] { student4, student5 };

            // Люди
            PeopleInfo info = new PeopleInfo();
            info.PeopleArray = new Person[]
            { student1, student2, student3, student4, student5, teacher1, teacher2};

            info.ShowAllPeopleInfo();
        }
    }
}
