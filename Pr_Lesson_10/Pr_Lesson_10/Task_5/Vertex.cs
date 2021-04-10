using System;
/// <summary>
/// Создайте класс, который будет описывать точку в трехмерной системе координат (X, Y, Z).  
/// В теле класса переопределите операторы сложения (+), вычитания(-), умножения(*), 
/// деления(/), декремента(++), инкремента(--), также переопределите метод ToString(), 
/// таким образом, чтоб он отображал полную информацию о точке (ее координаты), 
/// метод Equals  для сравнения 2-х точек, а также метод  GetHashCode. 
/// </summary>

namespace Task_5
{
    /// <summary>
    /// Точка
    /// </summary>
    public class Vertex
    {
        /// <summary>
        /// Координата точки по X
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// Координата точки по Y
        /// </summary>
        public int Y { get; set; }
        /// <summary>
        /// Координата точки по Z
        /// </summary>
        public int Z { get; set; }
        /// <summary>
        /// Имя точки
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Точка
        /// </summary>
        public Vertex(){}

        /// <summary>
        /// Точка
        /// </summary>
        /// <param name="x">Координата точки по X</param>
        /// <param name="y">Координата точки по Y</param>
        /// <param name="z">Координата точки по Z</param>
        public Vertex(string name,int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
            Name = name;
        }

        /// <summary>
        /// Точка
        /// </summary>
        /// <param name="vertex">Точка</param>
        public Vertex(string name, Vertex vertex)
        {
            X = vertex.X;
            Y = vertex.Y;
            Z = vertex.Z;
            Name = name;
        }
        /// <summary>
        /// Переопределение оператора +
        /// </summary>
        /// <param name="vertex1">Точка1</param>
        /// <param name="vertex2">Точка2</param>
        /// <returns>Результирующая точка</returns>
        public static Vertex operator + (Vertex vertex1, Vertex vertex2 )
        {
            return new Vertex($"{vertex1.Name}{vertex2.Name}",vertex1.X + vertex2.X, vertex1.Y + vertex2.Y, vertex1.Z + vertex2.Z); 
        }

        /// <summary>
        /// Переопределение оператора -
        /// </summary>
        /// <param name="vertex1">Точка1</param>
        /// <param name="vertex2">Точка2</param>
        /// <returns>Результирующая точка</returns>
        public static Vertex operator - (Vertex vertex1, Vertex vertex2)
        {
            return new Vertex($"{vertex1.Name}{vertex2.Name}", vertex1.X - vertex2.X, vertex1.Y - vertex2.Y, vertex1.Z - vertex2.Z);
        }

        /// <summary>
        /// Переопределение оператора *
        /// </summary>
        /// <param name="vertex1">Точка1</param>
        /// <param name="vertex2">Точка2</param>
        /// <returns>Результирующая точка</returns>
        public static Vertex operator * (Vertex vertex1, Vertex vertex2)
        {
            return new Vertex($"{vertex1.Name}{vertex2.Name}", vertex1.X * vertex2.X, vertex1.Y * vertex2.Y, vertex1.Z * vertex2.Z);
        }

        /// <summary>
        /// Переопределение оператора /
        /// </summary>
        /// <param name="vertex1">Точка1</param>
        /// <param name="vertex2">Точка2</param>
        /// <returns>Результирующая точка</returns>
        public static Vertex operator / (Vertex vertex1, Vertex vertex2)
        {
            if (vertex2.X != 0 && vertex2.Y != 0 && vertex2.Z != 0)
            {
                return new Vertex($"{vertex1.Name}{vertex2.Name}", vertex1.X / vertex2.X, vertex1.Y / vertex2.Y, vertex1.Z / vertex2.Z);
            }
            else
            {
                Console.WriteLine("На 0 делить нельзя.");
                return new Vertex($"{vertex1.Name}{vertex2.Name}", 0, 0, 0);
            }
        }

        /// <summary>
        /// Переопределение оператора ++
        /// </summary>
        /// <param name="vertex">Точка</param>
        /// <returns>Результирующая точка</returns>
        public static Vertex operator ++ (Vertex vertex)
        {
            return new Vertex($"{vertex.Name}", vertex.X++, vertex.Y++, vertex.Z++);
        }

        /// <summary>
        /// Переопределение оператора --
        /// </summary>
        /// <param name="vertex">Точка</param>
        /// <returns>Результирующая точка</returns>
        public static Vertex operator --(Vertex vertex)
        {
            return new Vertex($"{vertex.Name}", vertex.X--, vertex.Y--, vertex.Z--);
        }

        /// <summary>
        /// Переопредиление ToString()
        /// </summary>
        /// <returns>Полная информация о точке (ее координаты)</returns>
        public override string ToString()
        {
            return $"(X:{X},Y:{Y},Z:{Z})";
        }

        /// <summary>
        /// Переопредиление Equals()
        /// </summary>
        /// <param name="vertex">Точка</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                Vertex vertex = (Vertex)obj;
                return true ? X == vertex.X &&
                              Y == vertex.Y &&
                              Z == vertex.Z : false;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Переопределение GetHashCode()
        /// </summary>
        /// <returns>Значение</returns>
        public override int GetHashCode()
        {
            return X ^ Y ^ Z;
        }
    }
}
