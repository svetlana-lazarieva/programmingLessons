using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application. 
/// Создайте перечисление, в котором будут содержаться должности сотрудников 
/// как имена констант.  
/// Присвойте каждой константе значение, задающее количество часов, которые 
/// должен отработать сотрудник за месяц. Создайте класс Accauntant с методом 
/// bool AskForBonus(Post worker, int hours), отражающее давать или нет 
/// сотруднику премию. 
/// Если сотрудник отработал больше положеных часов в месяц, то ему положена 
/// премия.
/// </summary>

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Accauntant accauntant = new Accauntant();
            accauntant.ProcessingAccauntant();
            Console.ReadKey();
        }
    }
}
