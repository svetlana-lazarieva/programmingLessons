using System;
/// <summary>
/// Создать производные классы TXTHandler от базового класса 
/// AbstractHandler. Написать логику, которая будет выполнять определение документа и 
/// для каждого формата должны быть методы открытия, создания, редактирования, сохранения 
/// определенного формата документа.
/// </summary>

namespace Task_4
{
    public class TXTHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Chenge TXTHandler");
        }

        public override void Create()
        {
            Console.WriteLine("Create TXTHandler");
        }

        public override void Open()
        {
            Console.WriteLine("Open TXTHandler");
        }

        public override void Save()
        {
            Console.WriteLine("Save TXTHandler");
        }
    }
}
