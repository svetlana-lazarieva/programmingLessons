using System;
/// <summary>
/// Cоздайте базовый класс Shape (фигура), который содержит в себе поле типа double 
/// c именем Volume и метод типа double  GetVolume()  который должен вернуть объём фигуры. 
/// </summary>

namespace Task_2
{
    /// <summary>
    /// Класс содержит в себе поле Volume типа double и метод типа double  GetVolume(),
    /// возвращающий объём фигуры.
    /// </summary>
    public abstract class Shape
    {
        // Oбъём фигуры
        public double Volume { get; protected set; }
        // Название фигуры
        protected string ShapeName { get; set; }
       

        /// <summary>
        /// Расчитывает объём фигуры
        /// </summary>
        /// <returns> Объём фигуры</returns>        
        public abstract double GetVolume();

        /// <summary>
        /// Отображаем информацию о созданной вигуре
        /// </summary>        
        public void ShowShapeInfo()
        {
            Console.WriteLine($"Мы создали фигуру {ShapeName} объёмом {Volume}");
        }

    }
}
