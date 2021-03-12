using System;
/// <summary>
/// Создайте программу в которой создайте класс «Котенок». 
/// В теле класса создайте следующие поля: имя, возраст, цвет шерсти, цвет глаз. 
/// Для каждого поля, создать свойство с двумя методами доступа. 
/// Также в теле класса создайте метод, который будет выводить на консоль «Мяу», 
/// метод должен принимать один аргумент – количество «Мяу» котенка, выводить «Мяу» 
/// соответствующее количество раз. В методе Main() создайте экземпляр класса 
/// «Котенок», присвойте всем полям значение через свойства доступа, а также 
/// вызовите метод с помощью которого котенок говорит «Мяу», в качестве аргумента 
/// метода передайте 3.
/// </summary>

namespace Task_2
{
    /// <summary>
    /// Класс «Котенок».
    /// Поля: имя, возраст, цвет шерсти, цвет глаз котенка.
    /// </summary>
    public class Kitten
    {
        //Имя
        private string _name;
        //Возраст
        private int _age;
        //Цвет шерсти
        private string _coatColor;
        //Цвет глаз
        private string _eyeColor;

        public string Name { get; set; }
        public int Age { get; set; }
        public string CoatColor { get; set; }
        public string EyeColor { get; set; }

        /// <summary>
        /// Котенок мявкает
        /// </summary>
        /// <param name="quantityOfMeow">Количество мявков ))</param>
        public void Meow(int quantityOfMeow)
        {
            string str = string.Empty;

            for (int i = 0; i < quantityOfMeow; i++)
            {
                str += "Мяу ";
            }
            Console.WriteLine(str);
        }
    }
}
