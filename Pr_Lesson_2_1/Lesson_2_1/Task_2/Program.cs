using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.                                            
/// Создайте программу в которой создайте класс MyClass<T>, содержащий 
/// статический фабричный метод - T FacrotyMethod(), который будет порождать 
/// экземпляры типа, указанного в качестве параметра типа 
/// (указателя места заполнения типом – Т). 
/// </summary>

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = MyClass<int>.FactoryMethod();
        }
    }
}
