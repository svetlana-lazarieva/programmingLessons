using System;
/// <summary>
/// Интерфейс Printable содержит метод void print()
/// </summary>

namespace Task_1
{
    public interface IPrintable
    {
        string Name { get; set; }
        void Print();
    }
    
}
