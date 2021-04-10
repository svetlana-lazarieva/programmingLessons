using System;
using System.Collections.Generic;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.
/// Создайте программу, в которой создайте класс AbstractHandler. 
/// В теле класса создать методы void Open(), void Create(), void Chenge(), void Save(). 
/// Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса 
/// AbstractHandler. 
/// 
/// Написать логику, которая будет выполнять определение документа и 
/// для каждого формата должны быть методы открытия, создания, редактирования, сохранения 
/// определенного формата документа. 
/// </summary>

namespace Task_4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<AbstractHandler> handlers = new List<AbstractHandler>()
            {
                new DOCHandler(),
                new TXTHandler(),
                new XMLHandler(),
            };

            var doc = AbstractHandler.GetInstance<DOCHandler>(handlers);
            doc.Open();
            doc.Create();
            doc.Change();
            doc.Save();

            var txt = AbstractHandler.GetInstance<TXTHandler>(handlers);
            txt.Open();
            txt.Create();
            txt.Change();
            txt.Save();

            var xml = AbstractHandler.GetInstance<XMLHandler>(handlers);
            xml.Open();
            xml.Create();
            xml.Change();
            xml.Save();

            Console.ReadLine();
        }

        
    }
}
