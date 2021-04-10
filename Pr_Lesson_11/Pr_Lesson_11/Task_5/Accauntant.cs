using System;
/// <summary>
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
    public class Accauntant
    {
        private enum Post
        {
            Position1 = 7,
            Position2 = 35,
            Position3 = 45
        }

        public void ProcessingAccauntant()
        {            
            foreach (var item in Enum.GetValues(typeof(Post)))
            {
                GetInfo(out int hours);
                bool isBonus = AskForBonus((Post)item, hours);
                Console.WriteLine($"{(Post)item} - {isBonus}");
            }           
        }

        /// <summary>
        /// Положена ли премия сотруднику
        /// </summary>
        /// <param name="worker">Сотрудники</param>
        /// <param name="hours">Отработанные часы</param>
        /// <returns></returns>
        private bool AskForBonus(Post worker, int hours)
        {
            bool isBonus = true;
            if (hours > (int)worker)
            {
                isBonus = true;
            }
            else
            {
                isBonus = false; ;
            }          
            return isBonus;
        }

        /// <summary>
        /// Получить инфрмацию о фактическом времени(в часах), отработанном сотрудником
        /// </summary>
        /// <param name="houres">Время в часах</param>
        private void GetInfo(out int houres)
        {
            Console.Write("Сколько часов отработал сотрудник: ");
            if (!int.TryParse(Console.ReadLine(),out houres) )
            {
                Console.WriteLine("Ошибочка при вводе.");
                GetInfo(out houres);
            }
        }

    }
}
