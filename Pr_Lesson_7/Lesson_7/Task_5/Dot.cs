using System;
/// <summary>
/// Создайте программу, в которой создайте класс «Точка» – для описания координат  
/// точки на координатной прямой рис №1. 
/// В теле класса создайте следующие закрытые поля: 
/// целочисленное поле для описания координаты точки X и 
/// целочисленное поле для описания координаты точки Y, 
/// а также строковое поле для имени точки. 
/// Создать три свойства с методами доступа get и set, а также конструктор класса, 
/// который будет инициализировать данные поля значениями аргументов.
/// </summary>

namespace Task_5
{
    public class Dot
    {
        private int _dotCoordinatesX;
        private int _dotCoordinatesY;
        private string _dotName;

        public int DotCoordinatesX
        {
            get
            {
                return _dotCoordinatesX;
            }
            set
            {
                _dotCoordinatesX = value;
            }
        }
        public int DotCoordinatesY
        {
            get
            {
                return _dotCoordinatesY;
            }
            set
            {
                _dotCoordinatesY = value;
            }
        }
        public string DotName 
        {
            get 
            { 
                return _dotName; 
            }
            set 
            { 
                _dotName = value; 
            }
        }

        public Dot(int DotCoordinatesX, int DotCoordinatesY, string DotName)
        {
            _dotCoordinatesX = DotCoordinatesX;
            _dotCoordinatesY = DotCoordinatesY;
            _dotName = DotName;
        }


    }
}
