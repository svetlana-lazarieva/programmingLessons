using System;
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

namespace Task_3
{
    public class BankAccount
    {
        //Дата открытия счета
        private DateTime _accountOpeningDate;
        //Процентная ставка по счету
        private double _accountInterestRate;
        //Сумма счета
        private double _invoiceAmount;

        public DateTime AccountOpeningDate 
        {
            get { return _accountOpeningDate; }
            set { _accountOpeningDate = value; }
        }
        public double AccountInterestRate
        {
            get { return _accountInterestRate; }
            set { _accountInterestRate = value; }
        }
        public double InvoiceAmount
        {
            get { return _invoiceAmount; }
            set { _invoiceAmount = value; }
        }



        /// <summary>
        /// Я честно думала над конструктором, но так и не поняла,
        /// зачем он мне здесь :)
        /// </summary>
        public BankAccount()
        {

        }

        /// <summary>
        /// Метод, который рассчитывает количество дней, начиная с даты открытия счета
        /// </summary>
        /// <param name="accountOpeningDate">Даты открытия счета</param>
        /// <returns></returns>
        public int GetNumberOfDays()
        {
            int numberOfDays = (DateTime.Now - AccountOpeningDate.Date).Days;
            return numberOfDays;
        }
        /// <summary>
        /// Метод который выводит информацию о количестве рассчитанных дней
        /// </summary>
        /// <param name="numberOfDays"Kоличестве рассчитанных дней</param>
        public void ShowNumberOfDays(int numberOfDays)
        {
            Console.WriteLine($"Kоличестве рассчитанных дней: {numberOfDays}");
        }

        /// <summary>
        /// Метод который рассчитывает сумму, которая будет на счете 
        /// через определенное количество лет
        /// </summary>
        /// <param name="numberOfYears">Kоличество лет</param>
        public void CalculationOfIncome(int numberOfYears)
        {
            double income = InvoiceAmount;
            for (int i = 0; i < numberOfYears; i++)
            {
                income += income * numberOfYears / 100d;
            }
            string mess = string.Format("Сумма на счету через {0} лет: {1:F2}", numberOfYears, income);
            Console.WriteLine(mess);
            
        }
    }
}
