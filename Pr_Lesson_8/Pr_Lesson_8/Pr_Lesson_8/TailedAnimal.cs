using System;
/// <summary>
/// Создать класс хвостатое животное, содержащий хвост, цвет(строка), возраст. 
/// </summary>

namespace Task_1
{
    /// <summary>
    /// Класс хвостатое животное содержит хвост, цвет(строка), возраст
    /// </summary>
    public class TailedAnimal
    {
        // Возраст
        public int Age { get; private set; }
        // Цвет
        public string Color { get; private set; }
        // Хвост
        public Tail Tail { get; protected set; }

        public TailedAnimal(int age, string color, int tailLength, string tailType)
        {
            Age = age;
            Color = color;
            Tail = new Tail(tailLength, tailType);
        }

    }
}
