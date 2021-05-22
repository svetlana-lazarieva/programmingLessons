
using System;

namespace Task_1
{
    public class Calculator<T>
    {
        /// <summary>
        /// Сумма 
        /// </summary>
        /// <param name="val1">Значение 1</param>
        /// <param name="val2">Значение 2</param>
        public dynamic Sum(T val1, T val2)
        {
            try
            {
                dynamic res = (dynamic)val1 + (dynamic)val2;
                return res;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        /// <summary>
        /// Разница 
        /// </summary>
        /// <param name="val1">Значение 1</param>
        /// <param name="val2">Значение 2</param>
        public dynamic Difference(T val1, T val2)
        {
            try
            {
                dynamic res = (dynamic)val1 - (dynamic)val2;
                return res;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        /// <summary>
        /// Умножение
        /// </summary>
        /// <param name="val1">Значение 1</param>
        /// <param name="val2">Значение 2</param>
        public dynamic Multiplication(T val1, T val2)
        {
            try
            {
                dynamic res = (dynamic)val1 * (dynamic)val2;
                return res;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        /// <summary>
        /// Деление
        /// </summary>
        /// <param name="val1">Значение 1</param>
        /// <param name="val2">Значение 2</param>
        public dynamic Division(T val1, T val2)
        {
            try
            {
                if ((dynamic)val2 == 0)
                {
                    Exception ex = new DivideByZeroException();
                    throw ex;
                }
                else
                {
                    dynamic res = (dynamic)val1 / (dynamic)val2;
                    return res;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return default;
            }
        }
    }
}
