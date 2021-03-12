using System;
/// <summary>
/// Далее создайте класс «Фигура». 
/// В теле класса фигура создайте одно поле типа масив «Точек» и 
/// одно строкове поле для имени фигуры 
/// и 2 конструктора, которые принимают 3 (треугольника) и 4 аргумента(четырехугольника).
/// В теле класса «Фигура» создайте два метода: 
/// 1 - й для расчета длины стороны фигуры, метод должен принимать 2 аргумента типа «Точка» 
/// и возвращать длину стороны, формула для расчета d=√(〖(x_2-x_1)〗^2 + 〖(y_2 - y_1)〗^2 )  
/// 2 - йметод для расчета периметра фигуры 
/// (подсказка – в методе циклом перебирать массив «Точек», пока в нем будут элементы, 
/// и рассчитывать длину стороны).
/// </summary>
namespace Task_5
{
    public class Figure
    {
        private Dot[] _dots;
        private string _figureName;

        public string FigureName
        {
            get
            {
                return _figureName;
            }
            set
            {
                _figureName = value;
            }
        }


        /// <summary>
        /// Треугольник
        /// </summary>
        /// <param name="dot1">Точка вершины 1</param>
        /// <param name="dot2">Точка вершины 2</param>
        /// <param name="dot3">Точка вершины 3</param>
        public Figure(Dot dot1, Dot dot2, Dot dot3)
        {
            _dots = new Dot[3];
            _dots[0] = dot1;
            _dots[1] = dot2;
            _dots[2] = dot3;
        }

        /// <summary>
        /// Четырехугольник
        /// </summary>
        /// <param name="dot1">Точка вершины 1</param>
        /// <param name="dot2">Точка вершины 2</param>
        /// <param name="dot3">Точка вершины 3</param>
        /// <param name="dot4">Точка вершины 4</param>
        public Figure(Dot dot1, Dot dot2, Dot dot3, Dot dot4)
        {
            _dots = new Dot[4];
            _dots[0] = dot1;
            _dots[1] = dot2;
            _dots[2] = dot3;
            _dots[3] = dot4;
        }

        /// <summary>
        /// Расчитать длины стороны фигуры.
        /// </summary>
        /// <param name="dot1">Точка начала стороны фигуры</param>
        /// <param name="dot2">Точка конца стороны фигуры</param>
        /// <returns></returns>
        public double SideLengthOfFigure(Dot dot1, Dot dot2)
        {
            double x = Math.Pow((dot2.DotCoordinatesX - dot1.DotCoordinatesX), 2);
            double y = Math.Pow((dot2.DotCoordinatesY - dot1.DotCoordinatesY), 2);
            double sideLength = Math.Sqrt(x + y);
            return sideLength;
        }

        /// <summary>
        /// Расчитать периметр фигуры
        /// </summary>
        /// <returns></returns>
        public double PerimeterOfFigure()
        {
            double perimeter = 0;
            for(int i = 0; i < _dots.Length;i++)
            {
                int nextElementIndex = i < _dots.Length - 1 ? i + 1 : 0;
                perimeter += SideLengthOfFigure(_dots[i], _dots[nextElementIndex]);
            }
            return perimeter;
        }

    }
}
