using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.
/// Создайте программу в которой создайте класс «Банковский Счет». 
/// В теле класса создайте следующие поля: 
/// дата открытия счета, процентная ставка по счету, сумма счета.  
/// В теле метода создайте следующие методы: 
/// Метод, который рассчитывает количество дней, начиная с даты открытия счета; 
/// Метод который выводит информацию о количестве рассчитанных дней; 
/// Метод который рассчитывает сумму, которая будет на счете через определенное 
/// количество лет (количество лет – параметр метода); 
/// Метод который выводит информацию о сумме. 
/// Также продумать над конструктором класса. 
/// В методе Main() создайте экземпляр класса «Банковский Счет», присвойте всем 
/// полям значение через свойства доступа, а также на экземпляр класса вызовите 
/// методы для отображения количества дней и суммы.
/// </summary>

namespace Task_3
{
    class Program
    {
        public const string ex = "Введенное значение не целочисленное.";

        static void Main(string[] args)
        {
            GetValue(out int numberOfYears);
            GetValue(out DateTime date);
            BankAccount bankAccount = new BankAccount();
            //Дата открытия счета
            bankAccount.AccountOpeningDate = date;
            //Процентная ставка по счету
            bankAccount.AccountInterestRate = 3.5;
            //Сумма счета
            bankAccount.InvoiceAmount = 9500;

            bankAccount.ShowNumberOfDays(bankAccount.GetNumberOfDays());
            bankAccount.CalculationOfIncome(numberOfYears);
            Console.ReadKey();
        }

        /// <summary>
        /// Считать значение
        /// </summary>
        /// <param name="numberOfYears">Количество лет</param>
        public static void GetValue(out int numberOfYears)
        {
            Console.Write("Введите количество лет: ");
            if (!int.TryParse(Console.ReadLine(), out numberOfYears))
            {
                Console.WriteLine(ex);
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
        /// <summary>
        /// Считать дату
        /// </summary>
        /// <param name="date">Дата</param>
        public static void GetValue(out DateTime date)
        {
            Console.Write("Введите дату: ");
            if (!DateTime.TryParse(Console.ReadLine(), out date))
            {
                Console.WriteLine(ex);
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
