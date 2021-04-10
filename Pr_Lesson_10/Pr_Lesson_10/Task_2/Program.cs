using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.                                            
/// Создайте программу, в которой создайте статический класс Convector (конвектор). 
/// В теле класса Convector создайте два статических метода, первый CelsiusToFahrenheit 
/// (string temperatureCelsius) , который конвертирует значение температуры в Цельсиях 
/// в Фаренгейты, и второй FahrenheitToCelsius (string temperatureFahrenheit), который 
/// конвертирует значение температуры в Фаренгейтах в значение температуры в Цельсиях. 
/// Организуйте возможность взаимодействия пользователя с программой. 
/// </summary>

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Convertor.GetAction();
        }
    }
}
