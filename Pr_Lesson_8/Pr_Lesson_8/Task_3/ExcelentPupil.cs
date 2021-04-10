using System;
/// <summary>
/// Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса 
/// базового класса Pupil и переопределите каждый из методов, в зависимости от 
/// успеваемости ученика.
/// </summary>

namespace Task_3
{
    public class ExcelentPupil:Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Studying is excelent");
        }
        public override void Read()
        {
            Console.WriteLine("Reading is excelent");
        }
        public override void Write()
        {
            Console.WriteLine("Writing is excelent");
        }
        public override void Relax()
        {
            Console.WriteLine("Relaxing is excelent");
        }
    }
}
