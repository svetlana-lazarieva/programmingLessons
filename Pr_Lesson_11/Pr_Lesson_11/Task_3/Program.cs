using System;
/// <summary>
///Используя Visual Studio, создайте проект по шаблону Console Application.
///Создайте класс MyClass и структуру MyStruct, которые содержат в себе поля 
///public string change. 
///В классе Program создайте два метода: 
///- static void ClassTaker(MyClass myClass), который присваивает полю change 
///экземпляра myClass значение «изменено». 
///- static void StruktTaker(MyStruct myStruct), который присваивает полю change 
///экземпляра myStruct значение «изменено». 
///Продемонстрируйте разницу в использовании классов и структур, создав в 
///методе Main() экземпляры структуры и класса. 
///Измените, значения полей экземпляров на «не изменено», а затем вызовите методы 
///ClassTaker и StruktTaker. Выведите на экран значения полей экземпляров. 
///Проанализируйте полученные результаты.

/// </summary>

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.Change = "не изменено";
            MyStruct myStruct = new MyStruct();
            myStruct.Change = "не изменено";

            Console.WriteLine($"myClass: {myClass.Change}");
            Console.WriteLine($"myStruct: {myStruct.Change}");
            ClassTaker(myClass);
            StruktTaker(myStruct);
            Console.WriteLine($"myClass: {myClass.Change}");
            Console.WriteLine($"myStruct: {myStruct.Change}");
            Console.ReadKey();
        }

        static void ClassTaker(MyClass myClass)
        {
            myClass.Change = "изменено";
        }

        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.Change = "изменено";
        }
    }

    public class MyClass
    {
        public string Change { get; set; }
    }

    public struct MyStruct
    {
        public string Change { get; set; }
    }
}
