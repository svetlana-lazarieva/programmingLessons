﻿using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.
/// Создайте программу, в которой создайте базовый класс Shape (фигура), 
/// который содержит в себе поле типа double c именем Volume и метод типа 
/// double  GetVolume()  который должен вернуть объём фигуры.  
/// Далее создайте классы: Pyramid(пирамида), Cylinder(цилиндр), Ball(шар), 
/// которые будут наследоваться от класса  Shape, реализуйте в каждом из них 
/// метод для нахождения объёма. 
/// Создайте класс Box (ящик) – он является контейнером, может содержать в 
/// себе другие фигуры.В классе Box создайте поле типа  double  с именем 
/// DrawerVolume (Объем ящика), поле должно хранить в себе объём ящика.  
/// Далее в классе Box  создайте метод Аdd(), который принимает на вход 
/// объекты типа Shape, и возвращает значение типа boll. В классе Box 
/// реализуйте логику для добавления новых фигуры до тех пор, пока для них 
/// хватает места в Box (будем считать только объём, игнорируя форму, например, 
/// мы переливаем жидкость). Если места для добавления новой фигуры не хватает, 
/// то метод должен вернуть false. 
/// </summary>

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Box magicBox = new Box();
            magicBox.TryToAdd();
        }
    }
}
