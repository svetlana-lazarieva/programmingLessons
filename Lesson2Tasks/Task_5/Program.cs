using System;

namespace Task_5
{
    //Используя Visual Studio, создайте проект по шаблону 
    //Console Application. Создайте две целочисленные переменные 
    //и выведите на экран результаты всех арифметических операций 
    //над этими двумя переменными.

    class Program
    {
        static void Main(string[] args)
        {
            // Результат арифметических операций
            double result = 0; 

            Console.WriteLine("Введите значение целочисленной переменной value1: ");
            Int32.TryParse(Console.ReadLine(), out var value1);
            Console.WriteLine("Введите значение целочисленной переменной value2: ");
            Int32.TryParse(Console.ReadLine(), out var value2);
            int value3 = value1;
            int value4 = value2;

            // Сложение
            result = value1 + value2;
            Console.WriteLine($"  {value1} + {value2} = {result};");          
            
            // Вычитание
            result = value1 - value2;
            Console.WriteLine($"  {value1} - {value2} = {result};"); 
            
            // Произвидение
            result = value1 * value2;
            Console.WriteLine($"  {value1} * {value2} = {result};");          
            
            // Деление
            result = value1 / (double)value2;
            Console.WriteLine($"  {value1} / (double){value2} = {result};");

            // Целая часть от деления
            result = value1 / value2;
            Console.WriteLine($"  {value1} / {value2} = {result};");
            
            // Остаток от деления
            result = value1 % value2;
            Console.WriteLine($"  {value1} % {value2} = {result};");

            // Инкремент
            value1 = value3;
            value2 = value4;  
            result = value1++;
            Console.WriteLine($"  {value3}++ = {result};");
            result = ++value2;
            Console.WriteLine($"  ++{value4} = {result};");

            // Дектимент
            value1 = value3;
            value2 = value4;
            result = value1--;
            Console.WriteLine($"  {value3}-- = {result};");
            result = --value2;
            Console.WriteLine($"  --{value4} = {result};");

            Console.ReadKey();
        }
    }
}
