using System;
using System.Collections.Generic;
/// <summary>
/// В теле класса создайте четыре метода для арифметических действий: 
/// (Add – сложение, Sub – вычитание, Mul – умножение, Div – деление). 
/// Метод деления должен делать проверку деления на ноль, если проверка не проходит, 
/// сгенерировать исключение. 
/// </summary>
namespace Task_1
{
    public class Calculator
    {
        private List<string> _mathOperations = new List<string> { "+", "-", "*", "/" };

        /// <summary>
        /// Сложение
        /// </summary>
        private void Add(double val1, double val2)
        {
            Console.WriteLine($"{val1} + {val2} = {val1 + val2}");
        }
        /// <summary>
        /// Вычитание
        /// </summary>
        private void Sub(double val1, double val2)
        {
            Console.WriteLine($"{val1} - {val2} = {val1 - val2}");
        }
        /// <summary>
        /// Умножение
        /// </summary>
        private void Mul(double val1, double val2)
        {
            Console.WriteLine($"{val1} * {val2} = {val1 * val2}");
        }
        /// <summary>
        /// Деление
        /// </summary>
        private void Div(double val1, double val2)
        {         
            try
            {
                if (val2 == 0)
                {
                    throw new DivideByZeroException();
                }
                Console.WriteLine($"{val1} / {val2} = {val1 / val2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            
        }

        /// <summary>
        /// Реализация мат. операций
        /// </summary>
        public void Calculate()
        {
            GetValues(out double val1, out double val2);
            DoMath(val1, val2);
        }

        /// <summary>
        /// Определение мат.операыии над числами
        /// </summary>
        /// <param name="val1">Число1</param>
        /// <param name="val2">Число2</param>
        private void DoMath(double val1, double val2)
        {
            // Индекс знака мат.операции
            int indexOfMathVal = _mathOperations.IndexOf(GetMathVal());
            switch (indexOfMathVal)
            {
                case 0:
                    Add(val1, val2);
                    break;
                case 1:
                    Sub(val1, val2);
                    break;
                case 2:
                    Mul(val1, val2);
                    break;
                case 3:
                    Div(val1, val2);
                    break;
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Получить пару чисел для мат. операции
        /// </summary>
        /// <param name="val1">Число1</param>
        /// <param name="val2">Число2</param>
        private void GetValues(out double val1, out double val2)
        {
            GetVal(out val1);
            GetVal(out val2);
        }

        /// <summary>
        ///  Считать чиловое значение из консоли
        /// </summary>
        /// <param name="val"> Чиловое значение</param>
        private void GetVal(out double val)
        {
            Console.Write("Введите значение числа: ");
            if (!double.TryParse(Console.ReadLine(),out val))
            {
                Console.WriteLine("Введенное значение не числовое.\n");
                GetVal(out val);
            }
        }

        /// <summary>
        /// Считать знак мат.операции из консоли
        /// </summary>
        /// <param name="val">Знак мат.операции</param>
        public string GetMathVal()
        {
            Console.Write("Введите знк мат.операции: ");
            string val = Console.ReadLine();
            if (!_mathOperations.Contains(val))
            {
                Console.WriteLine("Введенное значение не знак мат.операции.\n");
                val = GetMathVal();
            }
 
            return val;
        }
    }
}
