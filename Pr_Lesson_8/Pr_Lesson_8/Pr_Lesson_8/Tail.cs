using System;
/// <summary>
/// Cоздайте класс хвост, который содержит в себе поля длину хвоста типа int и 
/// вид хвоста типа string, создать свойства доступа и конструктор пользовательский класса. 
/// </summary>

namespace Task_1
{
    /// <summary>
    /// Класс хвост содержит в себе поля длину хвоста типа int и вид хвоста типа string
    /// </summary>
    public class Tail
    {
        // Длина хвоста
        public int TailLength { get; protected set; }
        // Вид хвоста
        public string TailType { get; protected set; }

        public Tail(int tailLength, string tailType)
        {
            TailLength = tailLength;
            TailType = tailType;
        }
    }
}
