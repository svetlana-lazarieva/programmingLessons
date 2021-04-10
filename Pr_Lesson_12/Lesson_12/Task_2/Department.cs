using System;
/// <summary>
/// 1) ввод с клавиатуры данных в массив, состоящий из пяти элементов типа Worker 
/// (записи должны быть упорядочены по алфавиту); 
/// 2) если значение года введено не в соответствующем формате выдает исключение; 
/// 3) вывод на экран фамилии работника, стаж работы которого превышает введенное 
/// значение. 
/// </summary>

namespace Task_2
{
    /// <summary>
    /// Pаботничек
    /// </summary>
    public struct Worker : IComparable<Worker>
    {
        /// <summary>
        /// Фамилия и инициалы работника
        /// </summary>
        public string InitialsOfEmployee { get; set; }

        /// <summary>
        /// Название занимаемой должности
        /// </summary>
        public string Positions { get; set; }

        /// <summary>
        /// Год поступления на работу
        /// </summary>
        public int YearOfJoining { get; set; }

        int IComparable<Worker>.CompareTo(Worker other)
        {
            return String.Compare(InitialsOfEmployee, other.InitialsOfEmployee);
        }
    }

    /// <summary>
    /// Отдел работничков
    /// </summary>
    public class Department
    {
        private Worker[] _workers = new Worker[2];
        private const string InitialsOfEmployeeInfoType = "фамилию и инициалы работника";
        private const string PositionsInfoType = "название занимаемой должности";
        private const string YearOfJoiningInfoType = "год поступления на работу";
        private const int MinYear = 1900;

        /// <summary>
        /// Показать массив работничков
        /// </summary>
        public void ShowWorkersArray()
        {
            FillWorkersArray();

            Console.WriteLine();
            foreach (var item in _workers)
            {
                Console.WriteLine($"{item.InitialsOfEmployee} {item.Positions} {item.YearOfJoining}");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Заполнить массив работничков
        /// </summary>
        /// <param name="workers">Массив работничков</param>
        private void FillWorkersArray()
        {
            for (int i = 0; i < _workers.Length; i++)
            {
                SetWorkerInfo(out string initialsOfEmployee, out string positions, out int yearOfJoining);
                _workers[i].InitialsOfEmployee = initialsOfEmployee;
                _workers[i].Positions = positions;
                _workers[i].YearOfJoining = yearOfJoining;
            }
            Array.Sort(_workers, (x, y) => string.Compare(x.InitialsOfEmployee, y.InitialsOfEmployee));
        }

        /// <summary>
        /// Задать информацию о работничке
        /// </summary>
        /// <param name="initialsOfEmployee">Фамилия и инициалы работника</param>
        /// <param name="positions">Название занимаемой должности</param>
        /// <param name="yearOfJoining">Год поступления на работу</param>
        private void SetWorkerInfo(out string initialsOfEmployee, out string positions, out int yearOfJoining)
        {
            GetInfo(out initialsOfEmployee, InitialsOfEmployeeInfoType);
            GetInfo(out positions, PositionsInfoType);
            GetInfo(out yearOfJoining, YearOfJoiningInfoType);
        }

        /// <summary>
        /// Считать информацию о сотруднике с консоли
        /// </summary>
        /// <param name="info">Информация о сотруднике</param>
        /// <param name="typeOfInfo">Вид информации</param>
        private void GetInfo(out string info, string typeOfInfo)
        {
            Console.Write($"Введите {typeOfInfo} работника: ");
            info = Console.ReadLine();
        }

        /// <summary>
        /// Считать информацию о сотруднике с консоли
        /// </summary>
        /// <param name="info">Информация о сотруднике</param>
        /// <param name="typeOfInfo">Вид информации</param>
        private void GetInfo(out int info, string typeOfInfo)
        {
            Console.Write($"Введите {typeOfInfo} работника: ");

            try
            {
                info = int.Parse(Console.ReadLine());
                if (!IsYear(info))
                {
                    throw new Exception($"Число не является годом. Или работник слишком стар, " +
                                        $"\nесли присоеденился к команде до {MinYear} года");

                    //Console.WriteLine($"Число не является годом. Или работник слишком стар, " +
                    //                  $"\nесли присоеденился к команде до {MinYear} года");
                    //GetInfo(out info, typeOfInfo);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                GetInfo(out info, typeOfInfo);
            }                        
        }

        /// <summary>
        /// Является ли число годом
        /// </summary>
        /// <param name="val">Число</param>
        /// <returns>true - год или false - не год</returns>
        private bool IsYear(int val)
        {
            bool isYear = false;
            if (val >= MinYear && val <= DateTime.Now.Year)
            {
                isYear = true;
            }
            return isYear;
        }


    }
}
