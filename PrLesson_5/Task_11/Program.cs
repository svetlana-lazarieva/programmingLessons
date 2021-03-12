using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.
/// Представьте, что вы реализуете программу для банка, которая помогает 
/// определить, погасил ли клиент кредит или нет. Допустим, ежемесячная сумма 
/// платежа должна составлять 100 грн. Клиент должен выполнить 7 платежей, 
/// но может платить реже большими суммами. Т.е., может двумя платежами по 
/// 300 и 400 грн. Закрыть весь долг. Создайте метод, который будет в качестве 
/// аргумента принимать сумму платежа, введенную экономистом банка. Метод выводит 
/// на экран информацию о состоянии кредита (сумма задолженности, сумма переплаты, 
/// сообщение об отсутствии долга). 

/// </summary>
namespace Task_11
{
    class Program
    {
        // Сумма кредита
        public const double allSum = 700;       
        // Минимальная сумма выплаты
        public const double minSum = 100;
        // Максимальный срок выплаты
        public const int maxTerm = 7;
        // Cумма задолженности
        public static double amountOwed = allSum;

        static void Main(string[] args)
        {
            for (int term = 1; term <= maxTerm; term++)
            {
                if (term <= maxTerm && amountOwed > 0)
                {
                    ProcessDebt(term);
                }
                else
                {
                    Console.WriteLine("Кредит был погашен в срок.");
                    Console.ReadKey();
                    return;
                }
            }
            Console.ReadKey();
        }

        private static void ProcessDebt(int term)
        {
            Console.Write("Введите сумму платежа: ");
            if (double.TryParse(Console.ReadLine(), out double amountOfPayment))
            {
                amountOwed = GetInfo(amountOfPayment);
                Console.WriteLine("Осталось до истечения срока погашения кредита: " +
                                                      $"{maxTerm - term}");
                if (term == maxTerm && amountOwed > 0)
                {
                    Console.WriteLine("Кредит не был погашен в срок.");
                }
            }
            else
            {
                Console.WriteLine("Введенное значение не числовое");
            }
        }

        /// <summary>
        /// Выводит на экран информацию о состоянии кредита
        /// </summary>
        /// <param name="amountOfPayment">Внесенная сумма</param>
        /// <returns>Cумма задолженности</returns>
        public static double GetInfo(double amountOfPayment)
        {
            // Cумма задолженности
            amountOwed -= amountOfPayment;
            // Cумма переплаты
            double overpaymentAmount = amountOfPayment - minSum;
            Console.WriteLine($"Cумма задолженности: {amountOwed}");
            Console.WriteLine($"Cумма переплаты: {overpaymentAmount}");
            return amountOwed;
        }

    }
}
