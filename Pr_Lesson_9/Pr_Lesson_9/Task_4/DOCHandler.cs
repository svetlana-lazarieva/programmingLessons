using System;
/// <summary>
/// Создать производные классы DOCHandler от базового класса 
/// AbstractHandler. Написать логику, которая будет выполнять определение документа и 
/// для каждого формата должны быть методы открытия, создания, редактирования, сохранения 
/// определенного формата документа.
/// </summary>

namespace Task_4
{
    public class DOCHandler: AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Chenge DOCHandler");
        }

        public override void Create()
        {
            Console.WriteLine("Create DOCHandler");
        }

        public override void Open()
        {
            Console.WriteLine("Open DOCHandler");
        }

        public override void Save()
        {
            Console.WriteLine("Save DOCHandler");
        }
    }
}
