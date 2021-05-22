using System;

namespace Task_1
{
    /// <summary>
    /// Используя Visual Studio, создайте проект по шаблону Console Application. 
    /// Создайте программу в которой создайте класс и примените к его методам атрибут 
    /// Obsolete сначала в форме, просто выводящей предупреждение, а затем в форме, 
    /// препятствующей компиляции.Продемонстрируйте работу атрибута на примере вызова 
    /// данных методов.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass("MyString is");
            myClass.ShowStr1();
            myClass.ShowStr2();
            //myClass.ShowStr3();

            Console.ReadKey();
        }
    }
}
