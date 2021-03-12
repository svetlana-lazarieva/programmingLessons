using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.
/// Создайте программу, в которой создайте класс «Точка» – для описания координат  
/// точки на координатной прямой рис №1. 
/// В теле класса создайте следующие закрытые поля: 
/// целочисленное поле для описания координаты точки X и 
/// целочисленное поле для описания координаты точки Y, 
/// а также строковое поле для имени точки. 
/// Создать три свойства с методами доступа get и set, а также конструктор класса, 
/// который будет инициализировать данные поля значениями аргументов. 
/// 
/// Далее создайте класс «Фигура». 
/// В теле класса фигура создайте одно поле типа масив «Точек» 
/// и одно строкове поле для имени фигуры и 2 конструктора, которые принимают 3 (треугольника) 
/// и 4 аргумента(четырехугольника).
/// В теле класса «Фигура» создайте два метода: 
/// 1 - й для расчета длины стороны фигуры, метод должен принимать 2 аргумента типа «Точка» 
/// и возвращать длину стороны, формула для расчета d=√(〖(x_2-x_1)〗^2 + 〖(y_2 - y_1)〗^2 )  
/// и метод для расчета периметра фигуры 
/// (подсказка – в методе циклом перебирать массив «Точек», пока в нем будут элементы, 
/// и рассчитывать длину стороны). 
/// 
/// В методе Main() создать и рассчитать периметр треугольника, квадрата, прямоугольника, 
/// точки выбрать произвольные.
/// </summary>

namespace Task_5
{
    class Program
    {   
        static void Main(string[] args)
        {
            Dot dot1 = new Dot(0, 4, "A");
            Dot dot2 = new Dot(0, 0, "B");
            Dot dot3 = new Dot(4, 0, "C");
            Dot dot4 = new Dot(4, 4, "D");
            Dot dot5 = new Dot(7, 4, "E");
            Dot dot6 = new Dot(7, 0, "F");
            // Треугольник
            GetPerimeterOfTriangle(dot1, dot2, dot3);
            // Квадрат
            GetPerimeterOfQuadrangle(dot1, dot2, dot3, dot4);
            // Прямоугольник
            GetPerimeterOfQuadrangle(dot2, dot1, dot5, dot6);
            Console.ReadKey();
        }

        /// <summary>
        /// Получить периметр треугольника
        /// </summary>
        public static void GetPerimeterOfTriangle(Dot dot1, Dot dot2, Dot dot3)
        {           
            Figure triangle = new Figure(dot1, dot2, dot3);
            double perimeter = triangle.PerimeterOfFigure();
            triangle.FigureName = $"треугольник - '{dot1.DotName}{dot2.DotName}{dot3.DotName}'";
            ShowPerimeterOfFigure(perimeter, triangle);
        }

        /// <summary>
        /// Получить периметр четырехугольника
        /// </summary>
        public static void GetPerimeterOfQuadrangle(Dot dot1, Dot dot2, Dot dot3, Dot dot4)
        {
            Figure quadrangle = new Figure(dot1, dot2, dot3, dot4);
            double perimeter = quadrangle.PerimeterOfFigure();
            quadrangle.FigureName = $"четырехугольник - '{dot1.DotName}{dot2.DotName}{dot3.DotName}{ dot4.DotName}'";
            ShowPerimeterOfFigure(perimeter, quadrangle);
        }

        /// <summary>
        /// Вывести на консоль тип фигуры и ее периметр
        /// </summary>
        /// <param name="perimeter">Периметр фигуры</param>
        /// <param name="figure">Имя фигуры</param>
        public static void ShowPerimeterOfFigure(double perimeter, Figure figure)
        {
            string figureName = figure.FigureName;
            Console.WriteLine($"Периметр фигуры {figureName}: {perimeter}");
        }


    }
}
