using System;

/// <summary>
/// Используя Visual Studio, создайте проект по шаблону ConsoleApplication. 
/// Напишите программу расчета начисления премий сотрудникам. Премии 
/// рассчитываются согласно выслуге лет. Если выслуга до 5 лет, премия 
/// составляет 10% от заработной платы. Если выслуга от 5 лет (включительно) 
/// до 10 лет, премия составляет 15% от заработной платы. Если выслуга от 
/// 10 лет (включительно) до 15 лет, премия составляет 25% от заработной платы. 
/// Если выслуга от 15 лет (включительно) до 20 лет, премия составляет 35% 
/// от заработной платы. Если выслуга от 20 лет (включительно) до 25 лет, 
/// премия составляет 45% от заработной платы. Если выслуга от 25 лет 
/// (включительно) и более, премия составляет 50% от заработной платы. 
/// Результаты расчета, выведите на экран.
/// </summary>

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите з.п. сотрудника(грн): ");
            if (double.TryParse(Console.ReadLine(), out var salary))
            {
                Console.Write("Введите выслугу лет сотрудника: ");
                if (double.TryParse(Console.ReadLine(), out var seniority))
                {
                    // Определяем премию в процентах
                    int prizePercent = (seniority > 0   && seniority < 5) ? 10 :
                                       (seniority >= 5  && seniority < 10) ? 15 :
                                       (seniority >= 10 && seniority < 15) ? 25 :
                                       (seniority >= 15 && seniority < 20) ? 35 :
                                       (seniority >= 20 && seniority < 25) ? 45 : 50;
                    // Определяем премию в грн
                    double prize = salary * prizePercent / 100d;
                    // Выводим
                    Console.WriteLine(string.Empty);
                    Console.WriteLine($"По скольку сотрудник проработал {seniority} лет в компании, " +
                                      $"а его зарплата - {salary}грн, \nто премия этого сотрудника " +
                                      $"составляет {prizePercent}% ({prize}грн)");
                }
                else
                {
                    Console.WriteLine("Выслуга должна быть числовым значением.");
                }
            }
            else
            {
                Console.WriteLine("Зарплата должна быть числовым значением.");
            }

            

            Console.WriteLine("");
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
