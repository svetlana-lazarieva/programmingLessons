using System;
/// <summary>
/// Определить public - производный класс собака, имеющий дополнительный 
/// параметр-кличку (строка). В классе собака создать метод для отображения 
/// полной информации о собаке.
/// </summary>

namespace Task_1
{
    /// <summary>
    /// Класс Собака содержит параметр-кличку (строка)
    /// </summary>
    public class Dog: TailedAnimal
    {
        // Кличка
        public string DogName { get; set; }
        public Dog(string dogName, int age, string color, int tailLength, string tailType)
               :base(age,color,tailLength,tailType)
        {
            DogName = dogName;
        }

        /// <summary>
        /// Отобразить полную информацию о собаке
        /// </summary>
        public void ShowDogInfo()
        {
            Console.WriteLine($" Имя собаки: {DogName} \n Длина хвоста собаки: {Tail.TailLength} см\n" +
                              $" Вид хвоста собаки: {Tail.TailType} \n Цвет собаки: {Color}\n" +
                              $" Возраст собаки: {this.Age} лет");
            Console.ReadKey();
        }
    }
}
